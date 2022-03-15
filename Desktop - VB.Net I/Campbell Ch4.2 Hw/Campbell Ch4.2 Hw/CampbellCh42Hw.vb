Public Class CampbellCh42Hw
    ''' <summary>
    ''' 
    ''' Devin Campbell
    ''' CS145-02-MW
    ''' 2/24/16
    ''' Chapter 4.2 Homework
    ''' 
    ''' </summary>


    Private Sub BtnEx1FindLarger_Click(sender As Object, e As EventArgs) Handles BtnEx1FindLarger.Click
        Dim Num1, Num2 As Double
        Num1 = CDbl(TxtEx1First.Text)
        Num2 = CDbl(TxtEx1Second.Text)
        If Num1 > Num2 Then
            TxtEx1Result.Text = "The Larger Number is " & Num1 & "."
        ElseIf Num2 > Num1 Then
            TxtEx1Result.Text = "The Larger Number is " & Num2 & "."
        Else
            TxtEx1Result.Text = "Both Numbers are equal to each other"
        End If
    End Sub
    Private Sub BtnEx2Interpret_Click(sender As Object, e As EventArgs) Handles BtnEx2Interpret.Click
        Dim Color, Mode As String
        Color = MtbEx2Color.Text.ToUpper()
        Mode = MtbEx2Mode.Text.ToUpper()
        If Color = "B" Then
            If Mode = "S" Then
                TxtEx2Forecast.Text = "Clear View"
            Else 'mode = "F"
                TxtEx2Forecast.Text = "Clounds Due"
            End If
        Else 'color = "R"
            If Mode = "S" Then
                TxtEx2Forecast.Text = "Rain Ahead"
            Else 'mode = "F"
                TxtEx2Forecast.Text = "Snow Ahead"
            End If
        End If
    End Sub

    Private Sub BtnEx3FindLarger_Click(sender As Object, e As EventArgs) Handles BtnEx3FindLarger.Click
        Dim Num1, Num2 As Double
        Num1 = CDbl(TxtEx3First.Text)
        Num2 = CDbl(TxtEx3Second.Text)
        If Num1 > Num2 Then
            TxtEx3Result.Text = "The Larger Number is " & Num1 & "."
        ElseIf Num2 > Num1 Then
            TxtEx3Result.Text = "The Larger Number is " & Num2 & "."
        Else
            TxtEx3Result.Text = "Both Numbers are equal to each other"
        End If
    End Sub

    Private Sub BtnEx4Add_Click(sender As Object, e As EventArgs) Handles BtnEx4Add.Click
        If IsNumeric(TxtEx4First.Text) And IsNumeric(TxtEx4Second.Text) Then
            TxtEx4Sum.Text = CStr(CDbl(TxtEx4First.Text) + CDbl(TxtEx4Second.Text))
        ElseIf Not IsNumeric(TxtEx4First.Text) Then
            If Not IsNumeric(TxtEx4Second.Text) Then
                MessageBox.Show("Each text box is empty or has an improper entry.")
            Else
                MessageBox.Show("the first textbox is empty or has an improper entry.")
            End If
        Else
            MessageBox.Show("the second text box is empty or has an imporper entry.")
        End If
    End Sub
End Class
