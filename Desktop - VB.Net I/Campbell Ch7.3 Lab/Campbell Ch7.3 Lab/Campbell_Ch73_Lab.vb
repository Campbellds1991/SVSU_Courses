Public Class Campbell_Ch73_Lab
    Structure College
        Dim name As String
        Dim State As String
        Dim yearFounded As Integer
    End Structure

    Dim Colleges() As College

    Private Sub Campbell_Ch73_Lab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Schools() As String = IO.File.ReadAllLines("Colleges.txt")
        Dim n As Integer = Schools.Count - 1
        ReDim Colleges(n)
        Dim line As String
        Dim Data(2) As String
        For i As Integer = 0 To n
            line = Schools(i)
            Data = line.Split(","c)
            Colleges(i).name = Data(0)
            Colleges(i).State = Data(1)
            Colleges(i).yearFounded = CInt(Data(2))
        Next
        Dim query = From institution In Colleges
                    Order By institution.name
                    Select institution
        For Each institution In query
            Ex5_LstColleges.Items.Add(institution.name)
        Next
    End Sub

    Private Sub Ex4_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex4_BtnDisplay.Click
        Dim query = From col In Colleges
                    Where col.State = Ex4_MtbState.Text.ToUpper
                    Order By col.name Ascending
                    Select col.name, col.yearFounded
        Ex4_LstColleges.Items.Clear()
        For Each institution In query
            Ex4_LstColleges.Items.Add(institution.name & " " & institution.yearFounded)
        Next
    End Sub

    Private Sub Ex4B_BtnDisplay_Click(sender As Object, e As EventArgs) Handles Ex4B_BtnDisplay.Click
        Dim query = From col In Colleges
                    Where col.State = Ex4B_MtbState.Text.ToUpper
                    Order By col.name Ascending
                    Select col.name, col.yearFounded
        Ex4B_DgvColleges.DataSource = query.ToList
        Ex4B_DgvColleges.CurrentCell = Nothing
        Ex4B_DgvColleges.Columns("name").HeaderText = "College"
        Ex4B_DgvColleges.Columns("yearFounded").HeaderText = "Year Founded"
    End Sub

    Private Sub Ex5_LstColleges_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ex5_LstColleges.SelectedIndexChanged
        Dim query = From institution In Colleges
                    Where institution.name = Ex5_LstColleges.Text
                    Select institution
        Ex5_TxtState.Text = query.First.State
        Ex5_TxtYearFounded.Text = CStr(query.First.yearFounded)
    End Sub


End Class
