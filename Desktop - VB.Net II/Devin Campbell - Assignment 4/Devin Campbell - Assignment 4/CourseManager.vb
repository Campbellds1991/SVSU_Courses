Imports System.ComponentModel
'------------------------------------------------------------
'-                File Name : CourseManager.vb              - 
'-                Part of Project: Assignment #4            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 02/04/2017		          -
'------------------------------------------------------------
'- File Purpose:                      (Startup Form)        -
'- Handles events and procedures of the CourseManager form  -
'------------------------------------------------------------
Public Class CourseManager

#Region "Automation Handles"
	'------------------------------------------------------------
	'-                Subprogram Name: CourseManager_Load       -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Resets lists based on sender object					-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub CourseManager_Load(sender As Object, Optional e As EventArgs = Nothing) Handles MyBase.Load

		If sender.Equals(Me) Or IsNothing(sender) Then
			lstDegrees.Items.Clear()
			lstCourses.Items.Clear()
			For Each degree In DegreeInfo.Degrees
				lstDegrees.Items.Add(degree.Key + " - " + degree.Value.Details)
			Next
			For Each course In DegreeInfo.Courses
				lstCourses.Items.Add(course.Key + " - " + course.Value)
			Next
		ElseIf sender.Equals(lstDegrees) Then
			lstDegrees.Items.Clear()
			For Each degree In DegreeInfo.Degrees
				lstDegrees.Items.Add(degree.Key + " - " + degree.Value.Details)
			Next
		ElseIf sender.Equals(lstCourses) Then
			lstCourses.Items.Clear()
			For Each course In DegreeInfo.Courses
				lstCourses.Items.Add(course.Key + " - " + course.Value)
			Next
		End If
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: Controller_KeyPress      -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Key watcher for txt fields							-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub Controller_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCoursePrefix.KeyPress, txtCourseDetail.KeyPress, txtDegreePrefix.KeyPress, txtDegreeDetail.KeyPress
		If e.KeyChar = ChrW(Keys.Enter) Then
			If Me.ActiveControl.Equals(txtDegreeDetail) OrElse Me.ActiveControl.Equals(txtDegreePrefix) Then
				cmdDegreeAdd_Click(cmdDegreeAdd, New EventArgs)
			ElseIf Me.ActiveControl.Equals(txtCourseDetail) OrElse Me.ActiveControl.Equals(txtCoursePrefix) Then
				cmdCourseAdd_Click(cmdCourseAdd, New EventArgs)
			End If
		End If
	End Sub
#End Region

	'------------------------------------------------------------
	'-                Subprogram Name: cmdDegreeAdd_Click       -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Adds new degree record							-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
#Region "Standard Event Handlers"
	Private Sub cmdDegreeAdd_Click(sender As Object, e As EventArgs) Handles cmdDegreeAdd.Click
		If txtDegreeDetail.Text.Trim() = "" Or txtDegreePrefix.Text.Trim() = "" Then
			errDisplay.SetIconAlignment(sender, ErrorIconAlignment.MiddleRight)
			errDisplay.SetError(sender, "Neither text field may be blank, Enter Data and try again")
			Exit Sub
		End If
		errDisplay.Clear()
		Try
			DegreeInfo.Degrees.Add(txtDegreePrefix.Text.ToUpper(), New DegreeType.DegreeClass(txtDegreeDetail.Text))
		Catch ex As ArgumentException
			MsgBox("Designator already exists")
		End Try
		txtDegreePrefix.Clear()
		txtDegreeDetail.Clear()
		CourseManager_Load(lstDegrees)
		txtDegreePrefix.Select()
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: cmdDegreeRemove_Click    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Removes selected degree record(s)					-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub cmdDegreeRemove_Click(sender As Object, e As EventArgs) Handles cmdDegreeRemove.Click
		If lstDegrees.SelectedIndex = -1 Then
			errDisplay.SetIconAlignment(sender, ErrorIconAlignment.MiddleLeft)
			errDisplay.SetError(sender, "Must select a degree to remove")
			Exit Sub
		End If
		errDisplay.Clear()
		For Each item In lstDegrees.SelectedItems
			DegreeInfo.Degrees.Remove(item.ToString.Split("-")(0).Trim)
		Next
		CourseManager_Load(lstDegrees)
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: cmdCourseAdd_Click       -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Adds course from text fields to Course records			-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub cmdCourseAdd_Click(sender As Object, e As EventArgs) Handles cmdCourseAdd.Click
		If txtCourseDetail.Text.Trim() = "" Or txtCoursePrefix.Text.Trim() = "" Then
			errDisplay.SetIconAlignment(sender, ErrorIconAlignment.MiddleRight)
			errDisplay.SetError(sender, "Neither text field may be blank, Enter Data and try again")
			Exit Sub
		End If
		errDisplay.Clear()
		Try
			DegreeInfo.Courses.Add(txtCoursePrefix.Text.ToUpper(), txtCourseDetail.Text)
		Catch ex As ArgumentException
			MsgBox("Designator already exists")
		End Try
		txtCourseDetail.Clear()
		txtCoursePrefix.Clear()
		CourseManager_Load(lstCourses)
		txtCoursePrefix.Select()
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: cmdCourseRemove_Click       -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Removes selected course(s) from record				-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub cmdCourseRemove_Click(sender As Object, e As EventArgs) Handles cmdCourseRemove.Click
		If lstCourses.SelectedIndex = -1 Then
			errDisplay.SetIconAlignment(sender, ErrorIconAlignment.MiddleLeft)
			errDisplay.SetError(sender, "Must select a class to remove")
			Exit Sub
		End If
		errDisplay.Clear()
		For Each item In lstCourses.SelectedItems
			DegreeInfo.Courses.Remove(item.ToString.Split("-")(0).Trim)
		Next
		CourseManager_Load(lstCourses)
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: cmdBuildDegrees_Click    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Builds CourseBuilder items, shows the new form, then	- 
	'-	closes current form								-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub cmdBuildDegrees_Click(sender As Object, e As EventArgs) Handles cmdBuildDegrees.Click
		CourseBuilder.CourseBuilder_Load(cmdBuildDegrees, Nothing)
		CourseBuilder.Show()
		Me.Hide()
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: CourseManager_Closing       -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Makes sure user wants to close, then saves data to file	-
	'-	 and closes all forms							-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Public Sub CourseManager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If Not MsgBox("Are you sure you want to Quit?", Title:="Program Exiting", Buttons:=MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
			e.Cancel = True
		End If
		DegreeType.SaveToFile()
		CourseBuilder = Nothing

	End Sub


#End Region

End Class
