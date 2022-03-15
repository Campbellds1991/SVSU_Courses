Imports System.ComponentModel

'------------------------------------------------------------
'-                File Name : frmOrder.vb                 - 
'-                Part of Project: Assignment #2            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Created On: 01/18/2017                    -
'-                Modified On: 01/24/2017                   -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file controls the order form which allows the user	-
'- to edit order information then pass that information to	-
'- the invoice form. this file also prevents the user from	-
'- exiting via the order form.						- 
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program asks the user for input their Name and		-
'-	purchase order, then returns a reciept in a new window -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- <None>											–
'------------------------------------------------------------


Public Class frmOrder
	'------------------------------------------------------------
	'-                Function Name: CrustStuffing              -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Created On: 01/18/2017                    -
	'-                Modified On: 01/18/2017                   -
	'------------------------------------------------------------
	'- Function Purpose:                                      -
	'-                                                          -
	'- This function is called to display the type of crust	-
	'- a customer would like to order						–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- <None>											–
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>											–
	'------------------------------------------------------------
	'- Returns:                                                 -
	'- String – Returns the crust selection as a displayable	-
	'-	text											-
	'------------------------------------------------------------
	Private Function CrustStuffing() As String
		If radCrustPlain.Checked Then
			Return "Plain Crust"
		ElseIf radCrustCheese.Checked Then
			Return "Cheese Stuffed Crust"
		ElseIf radCrustGarlic.Checked Then
			Return "Garlic Stuffed Crust"
		ElseIf radCrustHam.Checked Then
			Return "Ham Stuffed Crust"
		ElseIf radCrustPepperoni.Checked Then
			Return "Pepperoni Stuffed Crust"
		Else
			Throw New InvalidOperationException
		End If
	End Function
	'------------------------------------------------------------
	'-                Subprogram Name: cmdPlaceOrder_Click      -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Created On: 01/18/2017                    -
	'-                Modified On: 01/24/2017                   -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- This function is called to display the type of crust	-
	'- a customer would like to order						–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- dblAreaCost - Cost of the pizza based on its size		-
	'- dblCOST_PER_SQ_IN - cost of pizza per Sq. inch			-
	'- dblGrandTotal - total cost based on price per pizza		-
	'-		including toppings and crust times the quantity	-
	'- intNumToppings - Counts the number of toppings included	-
	'- dblPRICE_FOR_STUFFED_CRUST - price of non-plain crust	-
	'- dblPRICE_PER_TOPPING - price of each topping added		-
	'- refInvoiceItems	- Reference variable to invoice listbox	-
	'-		items									-
	'------------------------------------------------------------
	Private Sub cmdPlaceOrder_Click(sender As Object, e As EventArgs) Handles cmdPlaceOrder.Click
		frmInvoice.lstInvoice.Items.Clear()
		If txtName.Text = "" Then
			MsgBox("Must provide a name for the order.", Title:="Who's Order?")
			Exit Sub
		End If
		Dim refInvoiceItems = frmInvoice.lstInvoice.Items
		With refInvoiceItems
			.Add("==================================================")
			.Add("                  Pizza Planet Order              ")
			.Add("==================================================")
			.Add("")
			.Add(String.Format("Baking up some pizza goodness for {0}", txtName.Text.Trim))
			.Add("")
			.Add(String.Format("There will be {0} {1}"" pizza(s) created by the little alien dudes!", nudQuantity.Value, nudSize.Value))
			.Add("")
			Try
				.Add(String.Format("Each pizza will have {0}", CrustStuffing()))
			Catch ex As InvalidOperationException
				MsgBox("Atleast one type of crust must be selected", Title:="Error!")
				Exit Sub
			End Try
			.Add("")
			.Add(String.Format("These are the Toppings that your requested:"))
			.Add(String.Format("    Cheese (automatic at no cost!)"))
		End With
		Dim intNumToppings As Integer = 0
		For Each control In gbToppings.Controls
			If TypeName(control) = "CheckBox" Then
				If control.Checked Then
					refInvoiceItems.Add(String.Format("    {0}", control.Text))
					intNumToppings += 1
				End If
			End If
		Next
		Const dblCOST_PER_SQ_IN As Double = 0.07
		Const dblPRICE_PER_TOPPING As Double = 1.5
		Const dblPRICE_FOR_STUFFED_CRUST As Double = 2.25
		Dim dblRadius As Double = CInt(nudSize.Text) / 2
		'surface area formula for a circular object is PI * r^2
		Dim dblAreaCost = Math.Round(dblCOST_PER_SQ_IN * Math.PI * (dblRadius ^ 2), 2, MidpointRounding.AwayFromZero)
		Dim dblGrandTotal = (dblAreaCost + If(Not radCrustPlain.Checked, dblPRICE_FOR_STUFFED_CRUST, 0) + (dblPRICE_PER_TOPPING * intNumToppings)) * CInt(nudQuantity.Text)
		With refInvoiceItems
			.Add("")
			.Add("Cost Per Pizza Summary:")
			.Add(String.Format("{0,-25}{1:C}", "Area Cost:", dblAreaCost))
			.Add(String.Format("{0,-25}{1:C}", "Crust Cost:", If(Not radCrustPlain.Checked, 2.25, 0)))
			.Add(String.Format("{0,-25}{1:C}", "Toppings Cost:", dblPRICE_PER_TOPPING * intNumToppings))
			.Add("==================================================")
			.Add(String.Format("{0,-25}{1}", "Quantity Ordered:", nudQuantity.Text))
			.Add("==================================================")
			.Add(String.Format("{0,-25}{1:C}", "Grand Total:", dblGrandTotal))
		End With
		frmInvoice.Show()
		Me.Hide()
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: frmOrder_Closing         -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Created On: 01/18/2017                    -
	'-                Modified On: 01/18/2017                   -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Prevents user from closing the form if not initiated	-
	'- from the invoice screen							–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     -
	'- e – Holds the CancelEventArgs object sent to the routine -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub frmOrder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If Not frmInvoice.blnClosing Then
			MsgBox("Sorry, but the application can only be closed on the invoice screen. Please press 'Place Order' to go to that screen...", Title:="Sorry, Not Sorry")
			e.Cancel = True
		End If
	End Sub
End Class
