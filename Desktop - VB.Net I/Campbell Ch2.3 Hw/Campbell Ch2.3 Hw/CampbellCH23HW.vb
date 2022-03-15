'  Program: CH2.3 HW
'  Name:    Devin Campbell
'  Date:    01/31/16
'  Class:   CS146
Public Class CampbellCH23HW
    Private Sub BtnLeft_Click(sender As Object, e As EventArgs) Handles BtnLeft.Click
        TxtBox.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub BtnMiddle_Click(sender As Object, e As EventArgs) Handles BtnMiddle.Click
        TxtBox.TextAlign = HorizontalAlignment.Center

    End Sub

    Private Sub BtnRight_Click(sender As Object, e As EventArgs) Handles BtnRight.Click
        TxtBox.TextAlign = HorizontalAlignment.Right

    End Sub

    Private Sub BtnSmile_Click(sender As Object, e As EventArgs) Handles BtnSmile.Click
        LblFace.Text = ":-)"

    End Sub

    Private Sub BtnFrown_Click(sender As Object, e As EventArgs) Handles BtnFrown.Click
        LblFace.Text = ":-("
    End Sub

    Private Sub BtnRed_Click(sender As Object, e As EventArgs) Handles BtnRed.Click
        TxtBoxEX35.BackColor = Color.Red

    End Sub

    Private Sub BtnBlue_Click(sender As Object, e As EventArgs) Handles BtnBlue.Click
        TxtBoxEX35.BackColor = Color.Blue

    End Sub

    Private Sub BtnWhite_Click(sender As Object, e As EventArgs) Handles BtnWhite.Click
        TxtBoxEX35.ForeColor = Color.White

    End Sub

    Private Sub BtnYellow_Click(sender As Object, e As EventArgs) Handles BtnYellow.Click
        TxtBoxEX35.ForeColor = Color.Yellow

    End Sub

    Private Sub TxtBox1EX36_GotFocus(sender As Object, e As EventArgs) Handles TxtBox1EX36.GotFocus
        TxtBox1EX36.ForeColor = Color.Red
    End Sub
    Private Sub TxtBox1EX36_LostFocus(sender As Object, e As EventArgs) Handles TxtBox1EX36.LostFocus
        TxtBox1EX36.ForeColor = Color.Black
    End Sub
    Private Sub TxtBox2Ex36_GotFocus(sender As Object, e As EventArgs) Handles TxtBox2Ex36.GotFocus
        TxtBox2Ex36.ForeColor = Color.Red
    End Sub
    Private Sub TxtBox2Ex36_LostFocus(sender As Object, e As EventArgs) Handles TxtBox2Ex36.LostFocus
        TxtBox2Ex36.ForeColor = Color.Black
    End Sub
    Private Sub TxtBox3Ex36_GotFocus(sender As Object, e As EventArgs) Handles TxtBox3Ex36.GotFocus
        TxtBox3Ex36.ForeColor = Color.Red
    End Sub
    Private Sub TxtBox3Ex36_LostFocus(sender As Object, e As EventArgs) Handles TxtBox3Ex36.LostFocus
        TxtBox3Ex36.ForeColor = Color.Black
    End Sub
    Private Sub BtnLeftEx36_Click(sender As Object, e As EventArgs) Handles BtnLeftEx36.Click
        TxtBox1EX36.TextAlign = HorizontalAlignment.Left
        TxtBox2Ex36.TextAlign = HorizontalAlignment.Left
        TxtBox3Ex36.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub BtnRightEx36_Click(sender As Object, e As EventArgs) Handles BtnRightEx36.Click
        TxtBox1EX36.TextAlign = HorizontalAlignment.Right
        TxtBox2Ex36.TextAlign = HorizontalAlignment.Right
        TxtBox3Ex36.TextAlign = HorizontalAlignment.Right
    End Sub
End Class
