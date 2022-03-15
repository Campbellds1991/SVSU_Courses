Imports System.ComponentModel
'------------------------------------------------------------
'-                File Name : frmInvoice.vb                 -
'-                Part of Project: Assignment #2            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Created On: 01/18/2017                    -
'-                Modified On: 01/24/2017                   -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file controls the invoice form, which displays the	-
'- information passed from the order form, places orders,	-
'- takes you back To the order form, Or closes the		-
'- application										-
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program asks the user for input their Name and		-
'-	purchase order, then returns a reciept in a new window -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- blnClosing - flag set to allow the closing of the		-
'- application in full								-
'------------------------------------------------------------
Public Class frmInvoice
	Public blnClosing As Boolean = False

	'------------------------------------------------------------
	'-                Subprogram Name: cmdChangeOrder_Click     -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Created On: 01/18/2017                    -
	'-                Modified On: 01/18/2017                   -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Returns user to the order form						-
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     -
	'- e – Holds the EventArgs object sent to the routine		-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub cmdChangeOrder_Click(sender As Object, e As EventArgs) Handles cmdChangeOrder.Click
		frmOrder.Show()
		Me.Hide()
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: cmdSendOrder_Click		-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Created On: 01/18/2017                    -
	'-                Modified On: 01/18/2017                   -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Displays a thank you message (production version to send -
	'- reciept to user and order to kitchen), then clears the	-
	'- order form For a new customer						-
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     -
	'- e – Holds the EventArgs object sent to the routine		-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub cmdSendOrder_Click(sender As Object, e As EventArgs) Handles cmdSendOrder.Click
		MsgBox(Title:="Thank you", Prompt:="The Claw is our master, It chooses who must stay and who must go!")
		With frmOrder
			.txtName.Text = ""
			.radCrustPlain.Checked = True
			.nudQuantity.Value = 1
			.nudSize.Value = 12
		End With
		For Each control In frmOrder.gbToppings.Controls
			If TypeName(control) = "CheckBox" Then
				control.Checked = False
			End If
		Next

		cmdChangeOrder_Click(Nothing, Nothing)
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: cmdExit_Click			-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Created On: 01/18/2017                    -
	'-                Modified On: 01/18/2017                   -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Closes program and triggers the closing event			-
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     -
	'- e – Holds the EventArgs object sent to the routine		-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
		Me.Close()
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: frmInvoice_Closing		-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Created On: 01/18/2017                    -
	'-                Modified On: 01/18/2017                   -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Presents a message box asking user if they want to exit. -
	'- Based on response, the program will either cancel the	-
	'- closing or close the application entirely 			-
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     -
	'- e – Holds the CancelEventArgs object sent to the routine -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub frmInvoice_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNo, "Quit?") = MsgBoxResult.No Then
			e.Cancel = True
			Exit Sub
		End If
		blnClosing = True
		frmOrder.Close()
	End Sub
End Class