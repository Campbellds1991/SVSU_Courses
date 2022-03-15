Imports System.ComponentModel
'------------------------------------------------------------
'-                File Name : mdiCalc.vb					- 
'-                Part of Project: Assignment #6            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 2/24/2016                     -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file controls the functionality of the mdi			-
'-	controller instance                                     -
'------------------------------------------------------------
Public Class mdiCalc
	'------------------------------------------------------------
	'-                Subprogram Name: menuHandler				-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 2/24/2016                     -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- handles all the functions of the menu strip              –
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub menuHandler(sender As Object, e As EventArgs) Handles HelpAboutMenuItem.Click, FileExitMenuItem.Click, WindowTileMenuItem.Click, WindowCascadeMenuItem.Click, FileNewMenuItem.Click
        Select Case sender.name
            Case HelpAboutMenuItem.Name : About.ShowDialog()
            Case FileExitMenuItem.Name : Me.Close()
            Case WindowTileMenuItem.Name : Me.LayoutMdi(MdiLayout.TileVertical)
            Case WindowCascadeMenuItem.Name : Me.LayoutMdi(MdiLayout.Cascade)
            Case FileNewMenuItem.Name
                Static intWindowCount = intWindowCount + 1
                Dim newCalc As New Calcutech With {.MdiParent = Me, .Name = $"{ .Name} {CStr(intWindowCount)}", .Text = $"1970 { .Name}"}
                newCalc.Show()
        End Select

    End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: mdiCalc_Closing          -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 2/24/2016                     -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- form closing event initiate a closing event for all		-
	'-		child forms											–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub mdiCalc_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For Each item In MdiChildren
            item.Close()
        Next
        If MdiChildren.Length <> 0 Then
            e.Cancel = True
        End If
    End Sub


End Class
