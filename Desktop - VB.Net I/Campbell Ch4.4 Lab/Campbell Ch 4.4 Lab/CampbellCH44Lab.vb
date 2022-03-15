''' <summary>
''' Devin Campbell
''' CS146
''' 02/29/16
''' CH 4.4 Lab
''' </summary>



Public Class FrmCampbellCh44Lab
    Private Sub BtnEx1Process_Click(sender As Object, e As EventArgs) Handles BtnEx1Process.Click
        Dim DaysInMonth As String
        Select Case LstEx1Month.Text
            Case "September", "April", "June", "November"
                DaysInMonth = "30"
            Case "February"
                DaysInMonth = "28 or 29"
            Case Else
                DaysInMonth = "31"
        End Select
        TxtEx1Days.Text = DaysInMonth
    End Sub

    Private Sub BtnEx3Determine_Click(sender As Object, e As EventArgs) Handles BtnEx3Determine.Click
        If RadEx3Child.Checked Then
            TxtEx3Fee.Text = (0).ToString("C")
        ElseIf RadEx3Minor.Checked Then
            TxtEx3Fee.Text = (5).ToString("C")
        ElseIf RadEx3Adult.Checked Then
            TxtEx3Fee.Text = (10).ToString("C")
        ElseIf RadEx3Senior.Checked Then
            TxtEx3Fee.Text = (7.5).ToString("C")
        Else
            MessageBox.Show("You must make a selection")
        End If
    End Sub

    Private Sub BtnEx4Determine_Click(sender As Object, e As EventArgs) Handles BtnEx4Determine.Click
        Dim Sum As Double = 0
        If ChkEx4Drug.Checked Then
            Sum += 39.15
        End If
        If ChkEx4Dental.Checked Then
            Sum += 10.81
        End If
        If ChkEx4Vision.Checked Then
            Sum += 2.25
        End If
        If ChkEx4Medical.Checked Then
            Sum += 55.52
        End If
        TxtEx4Total.Text = Sum.ToString("C")
    End Sub
End Class
