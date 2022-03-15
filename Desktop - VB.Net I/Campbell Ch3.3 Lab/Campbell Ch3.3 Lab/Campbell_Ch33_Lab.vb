'  Program: CH 3.3 Lab
'  Name:    Devin Campbell
'  Date:    02/15/2016
'  Class:   CS146
Public Class Campbell_Ch33_Lab
    Private Sub Ex1BtnComputeBirth_Click(sender As Object, e As EventArgs) Handles Ex1BtnComputeBirth.Click
        Dim Dob As Date = CDate(Ex1MtbDayOfBirth.Text)
        Ex1TxtFullDateOfBirth.Text = Dob.ToString("D")
        Ex1TxtToday.Text = Today.ToString("D")
        Ex1TxtAgeInDays.Text = DateDiff(DateInterval.Day, Dob, Today).ToString("N0")
    End Sub

    Private Sub Ex2BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex2BtnDisplay.Click
        Dim Prompt, Title, FullName, FirstName As String
        Dim DateOfBirth As Date
        Prompt = "Enter your full Name:"
        Title = "Name"
        FullName = InputBox(Prompt, Title)
        FirstName = FullName.Substring(0, FullName.IndexOf(" "))
        Prompt = "Enter your Date of Birth"
        Title = "Birthday"
        Ex2TxtToday.Text = CStr(Today)
        DateOfBirth = CDate(InputBox(Prompt, Title))
        Ex2TxtOutput.Text = FirstName & ", you are " & DateDiff(DateInterval.Day, DateOfBirth, Today) & " days old."
    End Sub

    Private Sub Ex3BtnClickMe_Click(sender As Object, e As EventArgs) Handles Ex3BtnClickMe.Click
        MessageBox.Show("Nice try, But no cigar", "Consolation")
    End Sub

    Private Sub Ex3BtnExit_Click(sender As Object, e As EventArgs) Handles Ex3BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub Ex4BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex4BtnDisplay.Click
        Dim FmtStr As String = "{0,-10}{1,12}{2,14}{3,12}"
        With Ex4LstColleges.Items
            .Clear()
            .Add(String.Format(FmtStr, "College", "Enrollment", "Endowment", "Public SS"))
            .Add(String.Format(FmtStr, "Harvard", 6660, 19.2, 0.659))
            .Add(String.Format(FmtStr, "Yale", 5278, 10.1, 0.532))
        End With
    End Sub
End Class
