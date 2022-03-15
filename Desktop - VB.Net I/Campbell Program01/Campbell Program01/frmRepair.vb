Public Class FrmCampbellProject01
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim FmtStr As String = "{0,-12}{1,-12}"
        Dim Customer As String = TxtName.Text
        Const Tax As Double = 0.05
        Const HourlyRate As Double = 35
        Dim Labor = CDbl((TxtLabor.Text) * HourlyRate)
        Dim Parts = CDbl(TxtParts.Text)
        Dim Total = FormatCurrency((Labor + Parts) * (1 + Tax))
        With LstBill.Items
            .Clear()
            .Add(String.Format(FmtStr, "Customer", Customer))
            .Add(String.Format(FmtStr, "Labor:", FormatCurrency(Labor)))
            .Add(String.Format(FmtStr, "Parts:", FormatCurrency(Parts)))
            .Add(String.Format(FmtStr, "", "------------"))
            .Add(String.Format(FmtStr, "Total: ", FormatCurrency(Total)))
        End With
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

End Class
