Public Class frmDistance

    'Name: Devin Campbell
    'Class: CS146-02-MW
    'Date: 4/12/16

    Dim rm(,) As Double = {{0, 2054, 802, 738},
                            {2054, 0, 2786, 2706},
                            {802, 2786, 0, 100},
                            {738, 2706, 100, 0}}

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim row, col As Integer
        row = CInt(MtbOrigin.Text)
        col = CInt(MtbDest.Text)
        If (row >= 1 And row <= 4) And (col >= 1 And col <= 4) Then
            TxtMiles.Text = CStr(rm(row - 1, col - 1))
        Else
            MessageBox.Show("Origin and Destination must be numbers from 1 to 4",
                            "Error")
        End If
    End Sub
End Class
