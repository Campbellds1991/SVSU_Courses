Imports System.IO
Imports Campbell_Ch8_PP_4.frmPhone

Public Class frmPhone
    '
    ' Program: CH8-PP-4
    ' Name: Devin Campbell
    ' Date: 4/18/2016
    ' Class: CS146
    ' Program Def:
    '   Program is responisible to:
    '       - read and delete users directory files
    '       - edit users directory


    ' Structure used to divide records
    Structure Contact
        Dim Name As String
        Dim PhoneNumber As String
    End Structure

    ' Global Variables
    Public Contacts() As Contact
    Dim Index As String = "Campbell_Index.Txt"
    ' used to stop events from occuring when manipulating data in GUI
    Dim DisableEvent As Boolean
    ' On Load Event
    Private Sub frmPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Application As Object
        Application = CreateObject("Shell.Application")
        Application.MinimizeAll
        Me.WindowState = FormWindowState.Normal
        Initiate_Index()
    End Sub

    ' Initiates the index file used to reference the directory contact files
    Sub Initiate_Index()
        Dim Writer As New Writer
        Dim Reader As New Reader
        Dim result As DialogResult
        ' Creates Index file if it doesnt exist
        If Not File.Exists(Index) Then
            result = MessageBox.Show("Index File Created. Press OK to identify directories to be imported, " &
                        "Otherwise press Cancel to End Program",
                            buttons:=MessageBoxButtons.OKCancel, caption:="Import Directory Files")
            ' When user accepts, import Files one at a time from the open file dialog.
            If result = DialogResult.OK Then
                OpenFileDialog1.ShowDialog()
                Dim FileName = OpenFileDialog1.FileName.Split("\").Last
                Writer.Write(Index, FileName)
                Writer.Write(FileName, Reader.ReadAllLines(OpenFileDialog1.FileName))
                result = MessageBox.Show("Is there any more directories you wish to import",
                                                             buttons:=MessageBoxButtons.YesNo, caption:="Import Directory Files")
                ' continues to import files until the user says to stop importing
                While result = DialogResult.Yes
                    OpenFileDialog1.ShowDialog()
                    FileName = OpenFileDialog1.FileName.Split("\").Last
                    Writer.Write(FileName, Reader.ReadAllLines(OpenFileDialog1.FileName))
                    Writer.Append(Index, FileName)
                    Writer.SortedReWrite(Index)
                    result = MessageBox.Show("Is there any more directories you wish to import",
                                             buttons:=MessageBoxButtons.YesNo, caption:="Import Directory Files")
                End While
            Else
                ' Closes the executable.  me.close only closes the form, allowing code to continue to process.
                Environment.Exit(0)
            End If
        End If
        UpdateDirectories()
    End Sub
    ' Method used to update the listbox with files containing contacts
    Sub UpdateDirectories()
        Dim i As String = LstDirectories.Text
        LstDirectories.Items.Clear()
        Dim Reader As New Reader
        Dim data() As String = Reader.ReadAllLines(Index)
        data.ToList.Sort()
        For Each line In data
            LstDirectories.Items.Add(line)
        Next
        LstDirectories.Text = i
    End Sub

    Private Sub LstDirectories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstDirectories.SelectedIndexChanged
        TxtWorkingDirectory.Text = LstDirectories.Text
        Dim read As New Reader
        ' check if selected directory exists
        If read.FileExists(TxtWorkingDirectory.Text) Then
            ' if it exists, change data to reference the correct file
            If Not LstDirectories.SelectedIndex = -1 Then
                Dim directory() As String = read.ReadAllLines(LstDirectories.Text)
                ReDim Contacts(directory.Length - 1)
                Dim data(1) As String
                ' Reads file into memory
                For i As Integer = 0 To directory.Length - 1
                    Dim Line = directory(i)
                    If Line.IndexOf(",") = -1 Then
                        Line &= ","
                    End If
                    data = Line.Split(","c)
                    Contacts(i).Name = data(0)
                    Contacts(i).PhoneNumber = data(1)
                Next
                Query()
            End If
            ' when file doesnt exist, directory is removed from the index
        Else
            Dim writer As New Writer
            MessageBox.Show("File does not Exist. Directory removed from Listings", "File Not Found")
            Dim IndexContent() As String = read.ReadAllLines(Index).Where(Function(s) s <> TxtWorkingDirectory.Text).ToArray
            writer.Write(Index, IndexContent)
            writer.SortedReWrite(Index)
            UpdateDirectories()

        End If

        ' clear the text boxes of information
        TxtName.Text = ""
        MtbPhone.Text = ""
        TxtName.Focus()
    End Sub

    Private Sub BtnCreateDirectory_Click(sender As Object, e As EventArgs) Handles BtnCreateDirectory.Click
        Dim writer As New Writer
        Dim reader As New Reader
        ' ask user if they want to import an existing directory
        Dim result As DialogResult = MessageBox.Show("Do you wish to import an existing directory." &
                                                     " ''Yes'' to import, ''No'' to create",
                                                     buttons:=MessageBoxButtons.YesNo, caption:="Import Directory Files?")
        ' on "Yes" Result
        If result = DialogResult.Yes Then
            OpenFileDialog1.ShowDialog()
            Dim FileName = OpenFileDialog1.FileName.Split("\").Last
            writer.Write(FileName, reader.ReadAllLines(OpenFileDialog1.FileName))
            writer.Append(Index, FileName)
            ' on "No" Result
        Else
            Dim response As String = InputBox("Please enter a Name for your new directory without the .txt",
                                              "Create Directory File")
            ' check for blank Field, do not create files with blank name headings
            If Not response = "" Then
                response &= ".txt"
                writer.CreateFile(response)
                If notFound(Index, response) Then
                    writer.Append(Index, response)
                End If
            End If
        End If
        writer.SortedReWrite(Index)
        UpdateDirectories()
    End Sub

    ' removes file from directory
    Private Sub BtnRemoveDirectory_Click(sender As Object, e As EventArgs) Handles BtnRemoveDirectory.Click
        Dim writer As New Writer
        Dim read As New Reader
        ' rewrites the index to not include selected directory
        Dim IndexContent() As String = read.ReadAllLines(Index).Where(Function(s) s <> TxtWorkingDirectory.Text).ToArray
        writer.Write(Index, IndexContent)
        writer.SortedReWrite(Index)

        DisableEvent = True
        UpdateDirectories()
        TxtWorkingDirectory.Text = ""
        DgvContacts.DataSource = Nothing
        DisableEvent = False
    End Sub

    Sub Query()
        ' populates the Data Grid with information relavant to the file, and
        '       tests it against text in the Textboxes.
        Dim Query = From c In Contacts
                    Where (c.Name.ToLower.Contains(TxtName.Text.ToLower)) Or
                       c.PhoneNumber.Contains(MtbPhone.Text) Or
                        (TxtName.Text = "" And MtbPhone.Text = "(   )    -")
                    Order By c.Name Ascending
                    Select c.Name, c.PhoneNumber
        DisableEvent = True
        DgvContacts.DataSource = Query.ToList
        DgvContacts.CurrentCell = Nothing
        DgvContacts.Columns("PhoneNumber").HeaderText = "Phone Number"
        DisableEvent = False
    End Sub
    ' gets selected information from data grid then populates that data to the textboxes
    Private Sub DgvContacts_SelectionChanged(sender As Object, e As EventArgs) Handles DgvContacts.SelectionChanged
        If Not DisableEvent Then
            DisableEvent = True
            TxtName.Text = CStr(DgvContacts.CurrentRow.Cells(0).Value)
            ' removes non-numeric values so it can be transfered to Masked text box
            Dim strTemp As String = CStr(DgvContacts.CurrentRow.Cells(1).Value)
            Dim strTemp2 As String = ""
            For i As Integer = 0 To strTemp.Length - 1
                If IsNumeric(strTemp.Substring(i, 1)) Then
                    strTemp2 &= strTemp.Substring(i, 1)
                End If
            Next
            MtbPhone.Text = strTemp2
            DisableEvent = False
        End If
    End Sub
    ' reads a file for a string of text and returns if it exists
    Function notFound(file As String, text As String)
        Dim reader As New Reader
        Dim data() = reader.ReadAllLines(file)
        For Each d In data
            If d = text Then
                Return False
            End If
        Next
        Return True
    End Function


#Region "Add and Remove Listings"
    ' appends text to a file then updates GUI
    Private Sub BtnAddListing_Click(sender As Object, e As EventArgs) Handles BtnAddListing.Click
        Dim write As New Writer
        Dim Line As String
        Line = TxtName.Text & "," & MtbPhone.Text
        write.Append(LstDirectories.Text, Line)
        DisableEvent = True
        TxtName.Text = ""
        MtbPhone.Text = ""
        DisableEvent = False
        Query()
        UpdateDirectories()
    End Sub
    ' uses file in memory, tests data, then rewrites file without the requested entry
    Private Sub BtnRemoveListing_Click(sender As Object, e As EventArgs) Handles BtnRemoveListing.Click
        Dim writer As New Writer
        Contacts = Contacts.Where(Function(s) s.Name <> TxtName.Text Or s.PhoneNumber <> MtbPhone.Text).ToArray
        writer.WriteCSV(LstDirectories.Text, Contacts)
        DisableEvent = True
        TxtName.Text = ""
        MtbPhone.Text = ""
        DisableEvent = False
        ' updates GUI
        Query()
        UpdateDirectories()
    End Sub
#End Region
End Class

' Classes used to streamline opening and closing of StreamWriter and StreamReader Classes
Public Class Writer
    ' Writes a file with array of text
    Sub Write(destination As String, text() As String)
        Dim sw As New StreamWriter(destination)
        For Each line In text
            sw.WriteLine(line)
        Next
        sw.Close()
    End Sub
    ' Writes a file with line of text
    Sub Write(destination As String, text As String)
        Dim sw As New StreamWriter(destination)
        sw.WriteLine(text)
        sw.Close()
    End Sub
    ' Writes data in CSV format used for contact files
    Sub WriteCSV(destination As String, text() As Contact)
        Dim sw As New StreamWriter(destination)
        Dim read As New Reader
        Dim Line As String
        For Each i In text
            Line = i.Name & "," & i.PhoneNumber
            sw.WriteLine(Line)
        Next
        sw.Close()
    End Sub
    ' Adds Array of data to a file
    Sub Append(destination As String, text() As String)
        Dim sw As StreamWriter = File.AppendText(destination)
        For Each line In text
            sw.WriteLine(line)
        Next
        sw.Close()
    End Sub
    ' Adds data to a file
    Sub Append(destination As String, text As String)
        Dim sw As StreamWriter = File.AppendText(destination)
        sw.WriteLine(text)
        sw.Close()
    End Sub
    ' Reads a file, sorts it, then rewrites the file
    Sub SortedReWrite(Destination As String)
        Dim read As New Reader()
        Dim data() As String = read.ReadAllLines(Destination)
        data = data.Distinct().ToArray()
        Array.Sort(data)
        Write(Destination, data)
    End Sub
    ' Creates a Blank File with called filename
    Sub CreateFile(Destination As String)
        Dim sw As StreamWriter = File.CreateText(Destination)
        sw.Close()
    End Sub
    ' deletes file at called filename
    Sub DeleteFile(Destination As String)
        File.Delete(Destination)
    End Sub

End Class
Public Class Reader
    Dim file As String
    Dim data As String()
    ' Reads data from a file into an array
    Sub GetData(Directory As String)
        data = ReadAllLines(Directory)
        data.ToList.Sort()
        data.ToArray
    End Sub
    ' reads all lines in a file into an array
    Function ReadAllLines(Directory As String) As String()
        Dim srIndex = New StreamReader(Directory)
        Dim text As New List(Of String)
        While Not srIndex.EndOfStream
            text.Add(srIndex.ReadLine())
        End While
        srIndex.Close()
        Return text.ToArray()
    End Function
    ' returns the number of lines in a file
    Function CountLines(Directory As String) As Integer
        Dim count As Integer
        count = IO.File.ReadAllLines(Directory).Length
        Return count
    End Function
    ' Tests if a file exists, then returns a boolean
    Function FileExists(Directory As String) As Boolean
        Return IO.File.Exists(Directory)
    End Function
End Class


