Public Class FrmPhone

    '   Program: CH7-PP-10
    '   Name: Devin Campbell
    '   Date: 4/18/16
    '   Class: CS146 - WM - Sec 2

    Structure Employee
        Dim FirstName As String
        Dim LastName As String
        Dim Extention As String
        Dim PushCode As String
    End Structure

    Dim Employees() As Employee
#Region "Form_OnLoad"
    Private Sub FrmPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' reads the directory from a text file
        Dim Directory() As String = IO.File.ReadAllLines("Directory.txt")
        ReDim Employees(Directory.Length - 1)
        Dim data(2) As String
        ' feeds data into the array line by line
        For i As Integer = 0 To Directory.Length - 1
            Dim Line = Directory(i)
            data = Line.Split(","c)
            Employees(i).PushCode = GetPushCode(data(1), data(0))
            Employees(i).FirstName = data(1)
            Employees(i).LastName = data(0)
            Employees(i).Extention = data(2)

        Next i
    End Sub
#End Region
    ' Using the first and last names of users in the directory, 
    '   assign each employee a code used to search them using pushtone keys
#Region "GetPushCode"
    Private Function GetPushCode(First As String, Last As String) As String
        Dim PushCode As String = ""
        Dim temp As String
        temp = Last.Substring(0, 3)
        temp += First.Substring(0, 1)
        ' tests letters indiviually to assign a numerical value to each
        For i As Integer = 0 To 3
            Select Case (temp.Substring(i, 1).ToLower)
                Case "a", "b", "c"
                    PushCode += "2"
                Case "d", "e", "f"
                    PushCode += "3"
                Case "g", "h", "i"
                    PushCode += "4"
                Case "j", "k", "l"
                    PushCode += "5"
                Case "m", "n", "o"
                    PushCode += "6"
                Case "p", "q", "r", "s"
                    PushCode += "7"
                Case "t", "u", "v"
                    PushCode += "8"
                Case "w", "x", "y", "z"
                    PushCode += "9"
            End Select
        Next
        Return PushCode
    End Function
#End Region
    ' locates users in the directory matching the search
#Region "Locate"
    Private Sub Locate()
        ' defined to limit parameter
        Dim n As Integer = TxtPushCode.Text.Length
        ' Structured list
        Dim Query = From emp In Employees
                    Where emp.PushCode.Substring(0, n) = TxtPushCode.Text
                    Order By emp.LastName Ascending
                    Select emp.LastName, emp.FirstName, emp.Extention

        ' checks if any records were found
        If Query.Count = 0 Then
            MessageBox.Show("No Records were found", caption:="No records found error")
        Else
            ' otherwise displays contents of structured list to data grid
            DgvListing.DataSource = Query.ToList
            DgvListing.CurrentCell = Nothing
            DgvListing.Columns("LastName").HeaderText = "Last Name"
            DgvListing.Columns("FirstName").HeaderText = "First Name"
        End If

    End Sub
#End Region
    ' Displays to the user basic instructions on how system is used
#Region "BtnGetInstructions_Click"
    Private Sub BtnGetInstructions_Click(sender As Object, e As EventArgs) Handles BtnGetInstructions.Click
        MessageBox.Show("Enter the first three letteres of the person's last name follwed by
the first letter of the person's first name", caption:="Instructions")
    End Sub
#End Region
    ' closes application
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    ' used to locate users in directory if numbers entered manually or have less then 4 numbers 
    Private Sub BtnDisplayDirectory_Click(sender As Object, e As EventArgs) Handles BtnDisplayDirectory.Click
        Locate()
    End Sub
    ' clears the Table (DataGridView) and textbox
    Private Sub BtnLookup_Click(sender As Object, e As EventArgs) Handles BtnLookup.Click
        DgvListing.DataSource = Nothing
        TxtPushCode.Text = ""
    End Sub

    ' This Region is dedicated to the Number Buttons located on the GUI
#Region "Buttons"
    ' Each button is the same excluding the number that is entered into the textbox
    Private Sub BtnNum1_Click(sender As Object, e As EventArgs) Handles BtnNum1.Click
        ' only adds numbers if you have less then 4 numbers already
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "1"
            ' when you push a button and its the 4th digit, automaticly locate users in directory
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub

    Private Sub BtnNum2_Click(sender As Object, e As EventArgs) Handles BtnNum2.Click
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "2"
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub

    Private Sub BtnNum3_Click(sender As Object, e As EventArgs) Handles BtnNum3.Click
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "3"
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub

    Private Sub BtnNum4_Click(sender As Object, e As EventArgs) Handles BtnNum4.Click
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "4"
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub

    Private Sub BtnNum5_Click(sender As Object, e As EventArgs) Handles BtnNum5.Click
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "5"
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub

    Private Sub BtnNum6_Click(sender As Object, e As EventArgs) Handles BtnNum6.Click
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "6"
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub

    Private Sub BtnNum7_Click(sender As Object, e As EventArgs) Handles BtnNum7.Click
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "7"
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub

    Private Sub BtnNum8_Click(sender As Object, e As EventArgs) Handles BtnNum8.Click
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "8"
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub

    Private Sub BtnNum9_Click(sender As Object, e As EventArgs) Handles BtnNum9.Click
        If TxtPushCode.TextLength < 4 Then
            TxtPushCode.Text += "9"
            If TxtPushCode.TextLength = 4 Then
                Locate()
            End If
        End If
    End Sub
#End Region

End Class
