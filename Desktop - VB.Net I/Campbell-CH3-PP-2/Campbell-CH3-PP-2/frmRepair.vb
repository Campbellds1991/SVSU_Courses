Public Class frmRepair
    '
    ' Program:CH3-PP-2
    ' Name: Devin Campbell  
    ' Date: 02/16/2016
    ' Class: CS146
    ' Program Desc: take costs involved in repair and display an itemized bill in a list box
    '
    '   Input: 
    '       Customer Name, Hours Of Labor, Cost Of Material
    '       Declare Constants
    '   Process:  
    '       1) Set Labor cost using hourly rate and hours of labor
    '       2) Set Total bill using sum of costs, labor, and taxes
    '   Output: 
    '       Display in ListBox with left side headers: Customer Name on top, Labor cost 2nd,
    '       Parts cost 3rd, spacing Using dashes 4th, Finally With total 5th
    '
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim FmtStr As String = "{0,-12}{1,-12}"
        '   ******* Input *********
        Dim Customer As String = TxtName.Text
        Const TAX As Double = 0.05
        Const HOURLY_RATE As Double = 35
        '   ******* Process ********
        '   1)
        Dim Labor = CDbl((TxtLabor.Text) * HOURLY_RATE)
        Dim Parts = CDbl(TxtParts.Text)
        '   2)
        Dim Total As Double = (Labor + (Parts * (1 + TAX)))
        '  ****** Output ******
        With LstBill.Items
            .Clear()
            .Add(String.Format(FmtStr, "Customer", Customer))
            .Add(String.Format(FmtStr, "Labor:", FormatCurrency(Labor)))
            .Add(String.Format(FmtStr, "Parts:", FormatCurrency(Parts)))
            .Add(String.Format(FmtStr, "", "------------"))
            .Add(String.Format(FmtStr, "Total: ", FormatCurrency(Total)))
        End With
    End Sub
    '   *******  Exit Buttton  **********
    '   Secondary option to close program
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
    '   ******* New Customer *********
    '   Clear list then set Name box as Selected box
    Private Sub BtnNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnNewCustomer.Click
        LstBill.Items.Clear()
        TxtName.Focus()
    End Sub
End Class
