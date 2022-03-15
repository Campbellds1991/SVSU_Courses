Imports System.ComponentModel
'------------------------------------------------------------
'-                File Name : CourseBuilder.vb              - 
'-                Part of Project: Assignment #4            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 02/04/2017		          -
'------------------------------------------------------------
'- File Purpose:                                            -
'- Handles events and procedures of the CourseBuilder form  -
'------------------------------------------------------------

Public Class CourseBuilder
	'------------------------------------------------------------
	'-                Subprogram Name: CourseBuilder_Load       -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Clears all list boxes and populates forms based on		-
	'-	Dictionary									–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------

	Public Sub CourseBuilder_Load(sender As Object, e As EventArgs) Handles Me.Load
		lstDegrees.Items.Clear()
		For Each degree In DegreeInfo.Degrees
			lstDegrees.Items.Add(degree.Key + " - " + degree.Value.Details)
		Next
		lstAvailable.Items.Clear()
		For Each Course In DegreeInfo.Courses
			lstAvailable.Items.Add(Course.Key + " - " + Course.Value)
		Next
		lstIncludedCourses.Items.Clear()
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: CourseBuilder_Closing    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- ensures user intended on closing, then saves Dictionary  -
	'-	and closes out other forms					     –
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub CourseBuilder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If Not MsgBox("Are you sure you want to Quit?", Title:="Program Exiting", Buttons:=MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
			e.Cancel = True
		End If
		DegreeType.SaveToFile()
		CourseManager = Nothing
	End Sub

	'------------------------------------------------------------
	'-      Subprogram Name: lstDegrees_SelectedIndexChanged    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Resets requirements when a new degree set is selected    –
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the CancelEventArgs object sent to the routine -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)                                                   -
	'------------------------------------------------------------
	Private Sub lstDegrees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDegrees.SelectedIndexChanged
		lstIncludedCourses.Items.Clear()
		If lstDegrees.SelectedIndex <> -1 Then
			For Each course In DegreeInfo.Degrees.Item(lstDegrees.SelectedItem.ToString().Split("-")(0).Trim).Requirements
				lstIncludedCourses.Items.Add(course.Key + " - " + course.Value)
			Next
		End If
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: cmdAddCourse_Click       -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Resets requirements when a new degree set is selected    –
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- SelectedDegree - String | selected degree pointer        -
	'- SelectedItem - String() | array thats split from the	-
	'-	selected item To designate key, value pair			-
	'------------------------------------------------------------
	Private Sub cmdAddCourse_Click(sender As Object, e As EventArgs) Handles cmdAddCourse.Click
		If lstDegrees.SelectedIndex <> -1 Then
			Dim SelectedDegree As String = lstDegrees.SelectedItem.ToString().Split("-")(0).Trim
			For Each selected In lstAvailable.SelectedItems
				Dim selectedItem As String() = selected.ToString.Split("-")
				Try
					DegreeInfo.Degrees.Item(SelectedDegree).Requirements.Add(selectedItem(0).Trim, selectedItem(1).Trim)
				Catch ex As ArgumentException
					MsgBox(selected.ToString + " Already exists")
				End Try
			Next
			lstIncludedCourses.Items.Clear()
			For Each course In DegreeInfo.Degrees.Item(SelectedDegree).Requirements
				lstIncludedCourses.Items.Add(course.Key + " - " + course.Value)
			Next
			lstAvailable.SelectedIndex = -1
		Else
			MsgBox("Must Select a Degree")
		End If

	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: cmdRemoveCourse_Click    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Removes all degree required courses selected by user	-
	'-	from degree requirements							–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- SelectedDegree - String | selected degree pointer        -
	'- SelectedItem - String() | array thats split from the	-
	'-	selected item To designate key, value pair			-
	'------------------------------------------------------------
	Private Sub cmdRemoveCourse_Click(sender As Object, e As EventArgs) Handles cmdRemoveCourse.Click
		Dim SelectedDegree As String = lstDegrees.SelectedItem.ToString().Split("-")(0).Trim
		For Each selected In lstIncludedCourses.SelectedItems
			Dim selectedItem As String() = selected.ToString.Split("-")
			DegreeInfo.Degrees.Item(SelectedDegree).Requirements.Remove(selectedItem(0).Trim)
		Next
		lstIncludedCourses.Items.Clear()
		For Each course In DegreeInfo.Degrees.Item(SelectedDegree).Requirements
			lstIncludedCourses.Items.Add(course.Key + " - " + course.Value)
		Next
	End Sub

	'------------------------------------------------------------
	'-                Subprogram Name: cmdBack_Click		     -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Returns user to the Course Manager form				–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- sender – Identifies which particular control raised the  –
	'-          click event                                     - 
	'- e – Holds the EventArgs object sent to the routine       -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- (None)											-
	'------------------------------------------------------------
	Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
		CourseManager.Show()
		Me.Hide()
	End Sub
End Class