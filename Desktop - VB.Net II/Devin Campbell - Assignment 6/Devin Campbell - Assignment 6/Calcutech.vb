Imports System.ComponentModel
Imports System.Linq.Expressions
'------------------------------------------------------------
'-                File Name : Calcutech.vb                  - 
'-                Part of Project: Assignment #6            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 2/24/2016                     -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file controls the functionality of each calculator  -
'-      instance                                            -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- mem – Tracks a string segmentation commands issued       –
'- Preview – Tells the program that the current display is  -
'-  only a preview Of results And will be cleared On Next   - 
'-  key press                                               –
'- vbScript - passes vbscript access to the program for     -
'-  String based math formulation - (easily made into       -
'-  algebraic calculation)                                  -        
'------------------------------------------------------------

Public Class Calcutech
    Private Preview As Boolean
    Public mem As String
    Public vbScript As New MSScriptControl.ScriptControl With {.Language = "VBSCRIPT"}

    Private Enum DisplayState
        Float = True
        Int = False
    End Enum
	'------------------------------------------------------------
	'-                Subprogram Name: DisplayViewState         -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/24/2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Changes button use state based on enumerated input.	    –
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- state – enumerated boolean for which display type to be	-
	'-	used													- 
	'------------------------------------------------------------

	Private Sub DisplayViewState(state As DisplayState)
        cmdSin.Enabled = state
        cmdSqrt.Enabled = state
        cmdCos.Enabled = state
        cmdTan.Enabled = state
        cmdModulus.Enabled = Not state
        cmdInsertDecimal.Enabled = state
    End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: CmdNumber_Click          -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/24/2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- This subroutine handles the numeric inputs on the form	-
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------

	Private Sub CmdNumber_Click(sender As Object, e As EventArgs) Handles cmd0.Click, cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click,
																		cmd5.Click, cmd6.Click, cmd7.Click, cmd8.Click, cmd9.Click, cmdInsertDecimal.Click
		If Preview Then
			txtDisplay.Clear()
			Preview = False
		End If
		Select Case sender.Name
			Case cmd0.Name
				txtDisplay.Text &= "0"
			Case cmd1.Name
				txtDisplay.Text &= "1"
			Case cmd2.Name
				txtDisplay.Text &= "2"
			Case cmd3.Name
				txtDisplay.Text &= "3"
			Case cmd4.Name
				txtDisplay.Text &= "4"
			Case cmd5.Name
				txtDisplay.Text &= "5"
			Case cmd6.Name
				txtDisplay.Text &= "6"
			Case cmd7.Name
				txtDisplay.Text &= "7"
			Case cmd8.Name
				txtDisplay.Text &= "8"
			Case cmd9.Name
				txtDisplay.Text &= "9"
			Case cmdInsertDecimal.Name
				If Not txtDisplay.Text.Contains(".") Then
					If txtDisplay.Text = "" Then
						txtDisplay.Text = "0."
					Else
						txtDisplay.Text &= "."
					End If
				Else
					Beep()
				End If
		End Select

	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: Evaluate					-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/24/2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Using vbScript control, this sub passes a built string	-
	'-    to the scripting controller to parse the string and	-
	'-    calculate any Function passed To it.					–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------

	Private Sub Evaluate(Operand As String, Optional isTrigometric As Boolean = False)
        If isTrigometric Then
            mem &= $"{Operand}({txtDisplay.Text}) "
        Else
            mem &= $"{txtDisplay.Text}"
        End If
        If radFloat.Checked Then
            Try
                txtDisplay.Text = vbScript.Eval(mem).ToString
                mem = txtDisplay.Text
                Preview = True
            Catch ex As Exception
                txtDisplay.Text = ex.Message
                mem = ""
                Preview = True
            End Try
        Else
            Try
                txtDisplay.Text = vbScript.Eval($"Int({mem})").ToString
                mem = txtDisplay.Text
                Preview = True
            Catch ex As Exception
                txtDisplay.Text = ex.Message
                mem = ""
                Preview = True
            End Try
        End If
        If isTrigometric Then
            mem = ""
        Else
            mem &= $" {Operand} "
        End If
    End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: Operand_Click            -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/24/2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Handles operand function operation calls                 –
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------


	Private Sub Operand_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click, cmdClear.Click, cmdClearEntry.Click,
    cmdCos.Click, cmdDivide.Click, cmdEquals.Click, cmdExp.Click,
    cmdFlipSign.Click, cmdModulus.Click, cmdProduct.Click,
    cmdSin.Click, cmdSqrt.Click, cmdSubtract.Click, cmdTan.Click

        Select Case sender.Name
            Case cmdAdd.Name
                Evaluate("+")
            Case cmdClear.Name
                mem = String.Empty
                txtDisplay.Clear()
            Case cmdClearEntry.Name
                txtDisplay.Clear()
            Case cmdCos.Name
                Evaluate("Cos", True)
            Case cmdDivide.Name
                Evaluate("/")
            Case cmdEquals.Name
                Evaluate("")
                mem = ""
                Preview = True
            Case cmdExp.Name
                Evaluate("^")
            Case cmdFlipSign.Name
                If txtDisplay.Text.Substring(0, 1) = "-" Then
                    txtDisplay.Text = txtDisplay.Text.Substring(1)
                Else
                    txtDisplay.Text = $"-{txtDisplay.Text}"
                End If
            Case cmdModulus.Name
                Evaluate("Mod")
            Case cmdProduct.Name
                Evaluate("*")
            Case cmdSin.Name
                Evaluate("Sin", isTrigometric:=True)
            Case cmdSqrt.Name
                Evaluate("Sqr", isTrigometric:=True)
            Case cmdSubtract.Name
                Evaluate("-")
            Case cmdTan.Name
                Evaluate("Tan", isTrigometric:=True)
        End Select

    End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: Event_KeyPress           -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/24/2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Handles Keypress arguments from the user to simulate		-
	'-		the buttons											–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------


	Private Sub Event_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "0"c : CmdNumber_Click(cmd0, New EventArgs)
            Case "1"c : CmdNumber_Click(cmd1, New EventArgs)
            Case "2"c : CmdNumber_Click(cmd2, New EventArgs)
            Case "3"c : CmdNumber_Click(cmd3, New EventArgs)
            Case "4"c : CmdNumber_Click(cmd4, New EventArgs)
            Case "5"c : CmdNumber_Click(cmd5, New EventArgs)
            Case "6"c : CmdNumber_Click(cmd6, New EventArgs)
            Case "7"c : CmdNumber_Click(cmd7, New EventArgs)
            Case "8"c : CmdNumber_Click(cmd8, New EventArgs)
            Case "9"c : CmdNumber_Click(cmd9, New EventArgs)
            Case "."c : CmdNumber_Click(cmdInsertDecimal, New EventArgs)
            Case "/"c : Operand_Click(cmdDivide, New EventArgs)
            Case "*"c : Operand_Click(cmdProduct, New EventArgs)
            Case "-"c : Operand_Click(cmdSubtract, New EventArgs)
            Case "+"c : Operand_Click(cmdAdd, New EventArgs)
            Case "^"c : Operand_Click(cmdExp, New EventArgs)
            Case "%"c : Operand_Click(cmdModulus, New EventArgs)

        End Select

    End Sub

	'------------------------------------------------------------
	'-                Subprogram Name:							-
	'-					RadioButtons_CheckedChanged				-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/24/2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Calls to change the button states based on selection     –
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub RadioButtons_CheckedChanged(sender As RadioButton, e As EventArgs) Handles radFloat.CheckedChanged, RadInt.CheckedChanged
        If sender.Checked Then
            Select Case sender.Name
                Case radFloat.Name
                    mem = ""
                    txtDisplay.Clear()
                    DisplayViewState(DisplayState.Float)
                Case RadInt.Name
                    mem = ""
                    txtDisplay.Clear()
                    DisplayViewState(DisplayState.Int)
                Case Else
                    MsgBox("Fatal Error, Display Mode is declared as neither Float or Int.  Window must close.")
                    Close()
            End Select
        End If
    End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: Calcutech_Closing        -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/24/2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Form closing event, verify with user if form is dirty    –
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub Calcutech_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If Not txtDisplay.Text = "0" And Not txtDisplay.Text = "" Then
			If Not MsgBox($"Are you sure you want to close ""{Me.Text}""", Title:="Form Closing", Buttons:=MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
				e.Cancel = True
			Else

			End If
		End If

	End Sub
End Class