Imports System.IO
Imports System.Security.Permissions
'------------------------------------------------------------
'-                File Name : XeroxMain.vb                  - 
'-                Part of Project: Assign07                 -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 3/14/2017                     -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application form where the   -
'- user will select a source and destination directory, then-
'- drag a file On the list To the destination To initiate   -
'- a copy                                                   - 
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program copies 1 or more files from a directory to  -
'-  another                                                 -    
'------------------------------------------------------------


Partial Public Class XeroxMain
    '------------------------------------------------------------
    '-                Subprogram Name: cmdSetSource_Click       -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- sets the respective listbox's content and the textbox    -
    '- directory location                                       –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       - 
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- listboxPath - directs the event to its respective list   -
    '- textboxPath - directs the event to proper textbox        -
    '------------------------------------------------------------
    Private Sub cmdSetSource_Click(sender As Button, e As EventArgs) Handles cmdSetSource.Click, cmdSetDest.Click
        FolderSelectDialog.ShowDialog()
        Dim listboxPath As ListBox = If(sender.Name = cmdSetSource.Name, lstSourceContent, lstDestContent)
        Dim textboxPath As TextBox = If(sender.Name = cmdSetSource.Name, txtSourceDir, txtDestDir)
        If IO.Directory.Exists(FolderSelectDialog.SelectedPath) Then
            textboxPath.Text = FolderSelectDialog.SelectedPath
            listboxPath.Items.Clear()
            listboxPath.Items.AddRange((From file In IO.Directory.GetFiles(textboxPath.Text)
                                        Select IO.Path.GetFileName(file)).ToArray())
        End If
        FolderSelectDialog.Reset()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: ResetListBox             -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Resets the desinated listbox's contents.                 –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies the list to reset                    - 
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub ResetListBox(sender As ListBox)
        sender.Items.Clear()
        If sender.Equals(lstDestContent) Then
            sender.Items.AddRange((From file In IO.Directory.GetFiles(txtDestDir.Text)
                                   Select IO.Path.GetFileName(file)).ToArray())
        ElseIf sender.Equals(lstSourceContent) Then
            sender.Items.AddRange((From file In IO.Directory.GetFiles(txtSourceDir.Text)
                                   Select IO.Path.GetFileName(file)).ToArray())
        End If

    End Sub
    '------------------------------------------------------------
    '-          Subprogram Name: lstSourceContent_MouseMove     -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- initiates a dragdrop if mouse is dragged while mouse     -
    '- is down                                                  –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the MouseEventArgs object sent to the routine  -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstSourceContent_MouseMove(sender As Object, e As MouseEventArgs) Handles lstSourceContent.MouseMove

        If e.Button = MouseButtons.Left Then
            If lstSourceContent.SelectedItems.Count > 0 Then
                lstSourceContent.DoDragDrop((From item In lstSourceContent.SelectedItems
                                             Select $"{item}").ToArray(), DragDropEffects.All)
            End If
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: lstDestContent_DragEnter -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- changes the graphic view of the cursor on dragdrop       –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the DragEventArgs object sent to the routine   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstDestContent_DragEnter(sender As Object, e As DragEventArgs) Handles lstDestContent.DragEnter
        If Not IsNothing(e.Data) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: lstDestContent_DragDrop  -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- on drop, validates the input, creates reference          -
    '- variables And threads, then delegates write operations   -
    '- to those threads                                         –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the DragEventArgs object sent to the routine   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- DataTotal - number of bytes to write                     -
    '- files - collection of file names to copy                 -
    '- status - Collection of boolean values to determine       -
    '-      individual transfer status                          -
    '- Streams - collection of thread streams                   -
    '------------------------------------------------------------
    Private Sub lstDestContent_DragDrop(sender As Object, e As DragEventArgs) Handles lstDestContent.DragDrop
        If XeroxProgressBar.Visible Then
            MsgBox("Please close progress bar to continue.")
            Exit Sub
        End If
        Dim files As String() = e.Data.GetData(GetType(String()))
        Dim Streams(files.Length - 1) As Threading.Thread
        Dim status(files.Length - 1) As Double
        Dim DataTotal As Long = 0

        For i = 0 To files.Length - 1
            'used to iterate stream declarations
            'stream subs cannot access loop variable correctly
            Dim x = i
            Try
                'Tests the writability of the stream location before dedicating thread
                Dim temp As New FileStream($"{txtDestDir.Text}\{files(x)}", FileMode.Create)
                temp.Close()
                For Each file In files
                    Dim temp2 As New FileIOPermission(FileIOPermissionAccess.Write, $"{txtDestDir.Text}\{file}")
                    temp2.Demand()
                Next
            Catch ex As Exception
                MsgBox(ex.Message & " Choose a new directory or contact your system administrator.")
                Exit Sub
            End Try

            If trbOverwrite.Value = 1 Then
                Streams(i) = New Threading.Thread(
                    New Threading.ThreadStart(Sub() CopyFile(
                        New BinaryReader(New FileStream($"{txtSourceDir.Text}\{files(x)}", FileMode.Open)),
                        New BinaryWriter(New FileStream($"{txtDestDir.Text}\{files(x)}", FileMode.Create)),
                        DataTotal, status(x))))
                Streams(i).Start()

            Else
                If Not IO.File.Exists($"{txtDestDir.Text}\{files(x)}") Then
                    Streams(i) = New Threading.Thread(
                            New Threading.ThreadStart(Sub() CopyFile(
                                New BinaryReader(New FileStream($"{txtSourceDir.Text}\{files(x)}", FileMode.Open)),
                                New BinaryWriter(New FileStream($"{txtDestDir.Text}\{files(x)}", FileMode.CreateNew)),
                                DataTotal, status(x))))
                    Streams(i).Start()
                Else
                    status(i) = 1
                End If
            End If
        Next

        XeroxProgressBar.BuildForm(files)
        While (From state In status Where state < 1 Select state).Count > 0
            Threading.Thread.Sleep(100)
            XeroxProgressBar.statusUpdate(status, (Aggregate state In status Into Average()) * DataTotal, DataTotal)
        End While

        XeroxProgressBar.statusUpdate(status, (Aggregate state In status Into Average()) * DataTotal, DataTotal)
        XeroxProgressBar.final = True
        ResetListBox(lstDestContent)
        Application.DoEvents()
        Erase Streams
        lstSourceContent.ClearSelected()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: CopyFile                 -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Reads the file and directly writes it to destination     -                                   
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- reader - read stream / binary                            -
    '- writer - write stream / binary                           -
    '- Total - returns total bytes to write byref               -
    '- Status - returns percentage of data written as decimal   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub CopyFile(reader As BinaryReader,
                         writer As BinaryWriter,
                         ByRef Total As Long,
                         ByRef status As Double)
        Total += reader.BaseStream.Length

        While reader.BaseStream.Position < reader.BaseStream.Length
            status = reader.BaseStream.Position / reader.BaseStream.Length
            writer.Write(reader.ReadBytes(10000))
        End While
        status = 1
        writer.Close()
        reader.Close()
        Threading.Thread.CurrentThread.Abort()
    End Sub


End Class
