Imports System.ComponentModel
'------------------------------------------------------------
'-                File Name : Payroll.vb                    - 
'-                Part of Project: Assingment #1            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Created On: 1/11/2016                     -
'                 Finished On: 1/18/2016                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains all segments which this program       -
'- will use to operate on.                                  -
'------------------------------------------------------------
'- Program Purpose:                                         -
'- Create a persistant storage program in order to see the  -
'- people on the payroll, their respective information, And -
'- to add additional people onto the payroll.               -
'------------------------------------------------------------
'- Global Variable Dictionary:						-
'- arrPayrollListings - master list of all elements stored  -
'-	in PayrollFile.								-
'- intNumRecords - Tracks current place in database		-
'- intCurrentRecord - NonConstant that tracks quantity of	-
'-	records held									-
'- VisibilityState (Line 450) - enumerated variable for	-
'-		 defined form states						-
'------------------------------------------------------------

Public Class frmPayroll

	<Serializable()>
	Class Payroll
		Sub New()
		End Sub
		Sub New(Name As String, ID As Integer, Hours As Double, Wage As Double, isSalary As Boolean)
			Me.strName = Name
			Me.intID = ID
			Me.dblHours = Hours
			Me.dblWage = Wage
			Me.isSalary = isSalary
		End Sub

		Public strName As String
		Public intID As Integer
		Public dblHours As Double
		Public dblWage As Double
		Public isSalary As Boolean
	End Class

	Public arrPayroll = New ArrayList()
	Public intNumRecords As Integer
	Public intCurrentRecord As Integer

	'------------------------------------------------------------
	'-                Subprogram Name: frmPayroll_load          -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/18/2016                     -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Initailizes elements to their default settings and loads -
	'- XML file into memory to be utilized by program           –
	'-                                                          -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -

	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- reader - Deserializes XML file for persistant storage    -
	'- file - StreamReader object pointing to storage file      -
	'------------------------------------------------------------
	Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
		'Load File
		'   convert csv to arraylist(of Payroll)
		If (System.IO.File.Exists("Payroll.xml")) Then
			Dim reader As New Xml.Serialization.XmlSerializer(GetType(ArrayList), extraTypes:={GetType(Payroll)})
			Dim file As New IO.StreamReader("Payroll.xml")
			arrPayroll = CType(reader.Deserialize(file), ArrayList)
			intNumRecords = arrPayroll.Count
			file.Close()
		End If
		'Set Visibilities
		ButtonVisibilityState(VisibilityState.Blank)
		'Lock Cells
		SetReadOnly(True)
		chkIsSalary.Enabled = False
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: cmdCalcWagesDue_Click    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Calculate Wages due based on given information or display-
	'- error									          –
	'-                                                          -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- dblHours - Holds a adjusted equivenlancy of hours worked -
	'-		including overtime					          -
	'- dblWage - Holds type casted value of txtWage textbox	-
	'------------------------------------------------------------
	Private Sub cmdCalcWagesDue_Click(sender As Object, e As EventArgs) Handles cmdCalcWagesDue.Click
		'if wage and hours "" and current record = 0  ? skip
		If txtWage.Text = "" Or txtHours.Text = "" Or intCurrentRecord = 0 Then
			MsgBox("Cannot Calculate: Please enter Wage/Hours and/or declare salary", Title:="Calculation Error")
			Exit Sub
		End If
		'check for salary
		Dim dblHours As Double
		Dim dblWage As Double

		If chkIsSalary.Checked Then
			dblHours = 40
		ElseIf Not Double.TryParse(txtHours.Text, dblHours) Then
			MsgBox("Cannot Calculate: Please enter valid Hours", Title:="Calculation Error")
			Exit Sub
		End If

		If Not Double.TryParse(txtWage.Text, dblWage) Then
			MsgBox("Cannot Calculate: Please enter valid Wage", Title:="Calculation Error")
			Exit Sub
		End If

		If dblHours > 40 Then
			dblHours = 40 + ((dblHours - 40) * 1.5)
		End If

		'calculate wages due
		'change label
		lblWagesDue.Text = String.Format("Employee Wages Due: {0:C}", (dblHours * dblWage))
		'display label
		lblWagesDue.Visible = True
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: cmdPrevListing_Click    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Iterate view to previous record						-
	'-                                                          -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -

	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>									          -
	'------------------------------------------------------------
	Private Sub cmdPrevListing_Click(sender As Object, e As EventArgs) Handles cmdPrevListing.Click
		'decrement current
		intCurrentRecord -= 1
		'error check
		If intCurrentRecord < 1 Then
			lblWagesDue.Text = ""
			MsgBox("Cannot move before first element", Title:="Index out of Range")
			ClearTxtCells()
			Exit Sub
		End If
		'check visibilities
		ButtonVisibilityState(VisibilityState.ViewingRecord)
		'populate cells
		ViewListing()
		'lock cells
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: cmdNextListing_Click    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Iterate view to next record						-
	'-                                                          -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -

	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>									          -
	'------------------------------------------------------------
	Private Sub cmdNextListing_Click(sender As Object, e As EventArgs) Handles cmdNextListing.Click
		intCurrentRecord += 1
		'error check
		If intCurrentRecord > intNumRecords Then
			lblWagesDue.Text = ""
			MsgBox("Already accessing last element", Title:="Index out of Range")
			ClearTxtCells()
			Exit Sub
		End If
		'check visibilities
		ButtonVisibilityState(VisibilityState.ViewingRecord)
		'populate cells
		ViewListing()
		'lock cells
		SetReadOnly(True)
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: ViewListing			-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Sets view of data on form to current record			-
	'-                                                          -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>									          -
	'------------------------------------------------------------
	Private Sub ViewListing()
		txtName.Text = arrPayroll(intCurrentRecord - 1).strName
		txtID.Text = arrPayroll(intCurrentRecord - 1).intID
		txtHours.Text = arrPayroll(intCurrentRecord - 1).dblHours
		txtWage.Text = arrPayroll(intCurrentRecord - 1).dblWage
		chkIsSalary.Checked = arrPayroll(intCurrentRecord - 1).isSalary
		lblWagesDue.Visible = False
		Me.Text = String.Format("Payroll System - Employee {0}/{1}", intCurrentRecord, intNumRecords)
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: cmdAddListing_Click		-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Sets view of data on form for data entry				-
	'-                                                          -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>									          -
	'------------------------------------------------------------
	Private Sub cmdAddListing_Click(sender As Object, e As EventArgs) Handles cmdAddListing.Click
		'clear txtcells Text fields
		ClearTxtCells()
		'set current index to -1
		intCurrentRecord = -1
		'unlock txt cells
		SetReadOnly(False)

		'Set Visibility of cmd buttons
		ButtonVisibilityState(VisibilityState.AddingRecord)


	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: cmdSave_Click			-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Tests type conversions, displays any errors found, then  -
	'-	records saved person in memory                         -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- a,b,c - Tempory values in order to test type conversions	-
	'------------------------------------------------------------
	Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
		intCurrentRecord = 0
		'Validate Data
		'    displayed and break sub if error
		Try
			Dim a = CInt(txtID.Text)
		Catch ex As InvalidCastException
			MsgBox("Invalid ID - Please use whole numbers only", Title:="Invalid Cast Exception")
			Exit Sub
		End Try
		Try
			Dim b = CDbl(txtHours.Text)
		Catch ex As InvalidCastException
			MsgBox("Invalid Hours Entry - Please use decimal numbers only", Title:="Invalid Cast Exception")
			Exit Sub
		End Try
		Try
			Dim c = CDbl(txtWage.Text)
		Catch ex As InvalidCastException
			MsgBox("Invalid Wage Entry - Please use decimal numbers only", Title:="Invalid Cast Exception")
			Exit Sub
		End Try
		'add item to array

		arrPayroll.Add(New Payroll(txtName.Text, txtID.Text, txtHours.Text, txtWage.Text, chkIsSalary.Checked))
		'increment num of records
		intNumRecords += 1

		'clear
		ClearTxtCells()
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: cmdCancel_Click		-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Cancels data imput and clears data for viewing			-
	'-                                                          -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>									          -
	'------------------------------------------------------------
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		ClearTxtCells()
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: SetReadOnly			-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- toggles read only property of all textbox's 			-
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- blnState – declares state of readOnly attribute for		–
	'-          textbox's	                                   - 
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>									          -
	'------------------------------------------------------------
	Private Sub SetReadOnly(blnState As Boolean)
		'toggle read only state for txt cells
		txtHours.ReadOnly = blnState
		txtID.ReadOnly = blnState
		txtName.ReadOnly = blnState
		txtWage.ReadOnly = blnState
		'---------------------------------------------------------
		'salary cannot be locked but cannot be altered in memory

	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: ClearTxtCells			-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Sets Text of all textbox's, sets visibilty state		-
	'-	resets viewed record number and title block			-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>									          -
	'------------------------------------------------------------
	Private Sub ClearTxtCells()
		'clear calc label
		lblWagesDue.Visible = False
		'clear txt cells
		txtHours.Text = ""
		txtID.Text = ""
		txtName.Text = ""
		txtWage.Text = ""
		chkIsSalary.Checked = False
		'reset visibility
		ButtonVisibilityState(VisibilityState.Blank)
		'set current to 0
		intCurrentRecord = 0
		Me.Text = "Payroll System"
	End Sub

#Region "Changeing Visibility"
	'------------------------------------------------------------
	'-                Subprogram Name: ButtonVisibilityState	-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Sets view of data on form to current record			-
	'-                                                          -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- state  - accepts only enumerated values to set known	-
	'-	form states									-
	'-												-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- <None>									          -
	'------------------------------------------------------------
	Private Sub ButtonVisibilityState(state As VisibilityState)
		'select case statement
		Select Case state
			Case VisibilityState.AddingRecord
				cmdSave.Visible = True
				cmdCancel.Visible = True
				cmdPrevListing.Visible = False
				cmdNextListing.Visible = False
				cmdAddListing.Visible = False
			Case VisibilityState.ViewingRecord, VisibilityState.Blank
				cmdSave.Visible = False
				cmdCancel.Visible = False
				cmdPrevListing.Visible = True
				cmdNextListing.Visible = True
				cmdAddListing.Visible = True
			Case Else
		End Select
	End Sub
	Enum VisibilityState
		AddingRecord
		ViewingRecord
		Blank
	End Enum
#End Region

	'------------------------------------------------------------
	'-                Subprogram Name: frmPayroll_Closing		-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 1/11/2016                     -
	'-                Modified On: 1/18/2016                    -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Writes xml data out to file on successful closing		-
	'-                                                          -
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- writer - serialization object used to interpret data	-
	'-	types								          -
	'- file - StreamWriter object pointing to storage file		-
	'------------------------------------------------------------
	Private Sub frmPayroll_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(ArrayList), extraTypes:={GetType(Payroll)})

		Dim file As New IO.StreamWriter("Payroll.xml")

		writer.Serialize(file, arrPayroll)
		file.Close()

	End Sub



End Class