''' <summary>
'''  Devin Campbell
'''  CS146
'''  02/28/2016
'''  Ch 4.3 HW
''' </summary>


Public Class CampbellCh43Hw
    Private Sub BtnEx1Evaluate_Click(sender As Object, e As EventArgs) Handles BtnEx1Evaluate.Click
        Dim Position As Integer 'Selector
        Position = CInt(TxtEx1Position.Text)
        Select Case Position
            Case 1
                TxtEx1Outcome.Text = "Gold medalist"
            Case 2
                TxtEx1Outcome.Text = "Silver medalist"
            Case 3
                TxtEx1Outcome.Text = "Bronze medalist"
            Case 4, 5
                TxtEx1Outcome.Text = "You almost won a medal"
            Case Else
                TxtEx1Outcome.Text = "Nice Try"
        End Select
    End Sub

    Private Sub BtnEx2Determine_Click(sender As Object, e As EventArgs) Handles BtnEx3Determine.Click
        Dim Month As Integer = CInt(MtbEx3Month.Text)
        Dim Yr As Integer = CInt(MtbEx3Year.Text)
        Dim Dt1, Dt2 As Date
        Dim NumberOfDays As Integer
        Select Case Month 'September, April, June, and November
            Case 9, 4, 6, 11
                NumberOfDays = 30
            Case 2 'February
                Dt1 = CDate("1/1/" & Yr)
                Dt2 = Dt1.AddYears(1)
                If DateDiff(DateInterval.Day, Dt1, Dt2) = 366 Then
                    NumberOfDays = 29
                Else
                    NumberOfDays = 28
                End If
            Case Else
                NumberOfDays = 31
        End Select
        TxtEx3Output.Text = Month & "/" & Yr & " has " & NumberOfDays & " days."
    End Sub

    Private Sub BtnEx4Interpret_Click(sender As Object, e As EventArgs) Handles BtnEx4Interpret.Click
        Dim FirstName As String
        FirstName = TxtEx4Name.Text.ToUpper
        Select Case FirstName
            Case "THOMAS"
                TxtEx4Reply.Text = "Correct."
            Case "WOODROW"
                TxtEx4Reply.Text = "Sorry, his full name was " &
                                    "Thomas Woodrow Wilson."
            Case "PRESIDENT"
                TxtEx4Reply.Text = "Are you for real?"
            Case Else
                TxtEx4Reply.Text = "Nice try, but no cigar."
        End Select
    End Sub
End Class
