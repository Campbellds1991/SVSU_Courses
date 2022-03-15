'------------------------------------------------------------
'-                File Name : XeroxProgressBar.vb           - 
'-                Part of Project: Assign07                 -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 3/14/2017                     -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file generates the UI and updates data as called    - 
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- final – marks form as able to close                      -
'- Labels – array of generated labels                       –   
'- progBars - array of generated progress bars              -
'------------------------------------------------------------

Public Class XeroxProgressBar
    Public progBars() As ProgressBar
    Public Labels() As Label
    Public final As Boolean
    '------------------------------------------------------------
    '-                Subprogram Name: BuildForm                -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Builds form to have respective ammount of progress bars  -
    '- as there are files                                       –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- files – list of files to be copied                       - 
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- ClientOffset - Calculates distance to bottom of the form -
    '------------------------------------------------------------
    Public Sub BuildForm(files As String())
        ReDim progBars(files.Count - 1)
        ReDim Labels(files.Count - 1)
        Dim ClientOffset As Integer = 150 + (60 * files.Count)
        Me.ClientSize = New Size(922, ClientOffset)
        Me.cmdClose.Location = New Point(700, ClientOffset - 90)
        lblBtyeCount.Location = New Point(75, ClientOffset - 90)
        For i = 0 To files.Count - 1
            progBars(i) = New ProgressBar With {
                .ForeColor = System.Drawing.SystemColors.HotTrack,
                .Location = New System.Drawing.Point(75, 30 + 65 * i),
                .MarqueeAnimationSpeed = 0,
                .Name = $"ProgressBar{i}",
                .Size = New Size(750, 25),
                .Step = 1,
                .Style = ProgressBarStyle.Continuous,
                .TabIndex = 0}
            Labels(i) = New Label With {
                .AutoSize = True,
                .Location = New System.Drawing.Point(75, 15 + 65 * i),
                .Name = $"ProgLabel{i}",
                .Size = New System.Drawing.Size(57, 20),
                .TabIndex = 2,
                .Text = files(i)}
        Next

        Me.Controls.AddRange(progBars)
        Me.Controls.AddRange(Labels)

        PerformLayout()
        Me.Show()
        Application.DoEvents()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: statusUpdate       -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Updates data on form                                     –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- status - percentage of data transfered per file          -
    '- dataWritten - bytes written to file                      -
    '- totalData - bytes to be written to file                  -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub statusUpdate(status() As Double, dataWritten As Long, totalData As Long)
        For i = 0 To status.Count() - 1
            progBars(i).Value = status(i) * 100
        Next
        lblBtyeCount.Text = $"Bytes Processed: {dataWritten} / {totalData}"
        Application.DoEvents()

    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: cmd_Close                -
    '------------------------------------------------------------
    '-                Written By: Devin Campbell                -
    '-                Written On: 3/14/2017                     -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- initiates closing                                        –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       - 
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub cmd_Close(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    '--------------------------------------------------------------------
    '-                Subprogram Name: Me_Closing                       -
    '--------------------------------------------------------------------
    '-                Written By: Devin Campbell                        -
    '-                Written On: 3/14/2017                             -
    '--------------------------------------------------------------------
    '- Subprogram Purpose:                                              -
    '-                                                                  -
    '- handles closing before disposal                                  -
    '--------------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):                       -
    '- sender – Identifies which particular control raised the          -
    '-          click event                                             -
    '- e – Holds the FormClosingEventArgs object sent to the routine    -
    '--------------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):                      -
    '- (None)                                                           -
    '--------------------------------------------------------------------
    Public Sub Me_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not final Then
            MsgBox("Cannot exit, Transfer still in progress")
            e.Cancel = True
        Else
            Erase progBars
        End If
    End Sub

End Class