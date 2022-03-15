Imports Microsoft.Office.Interop
'------------------------------------------------------
'-			Name: Devin Campbell
'-			Date: 03-29-2017
'------------------------------------------------------
'- File Name: PayrollReport.vb
'- Module Name: Main
'------------------------------------------------------
'- File Purpose:
'- Contains the test data and report writer
'------------------------------------------------------
'- Program Purpose:
'- Program builds an excel file showing employee time
'-	and statistics relevant to its respective column
'------------------------------------------------------
'- Global Variable Dictionary (alphabetically):              
'- (None)                                                   
'------------------------------------------------------

Public Module Main
	'------------------------------------------------------------
	'-                Subprogram Name: Main						-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 03-29-2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Startup point for the application                        –
	'- Builds a list of employees then runs the report generator-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- myEmps - arraylist containing the array of employees 	-
	'- to pass to the report generator                          - 
	'------------------------------------------------------------
	Public Sub Main()
		Dim myEmps As New ArrayList
		Try
			myEmps.Add(New clsEmployee("Sue", 103, 15.25, {8, 8, 8, 8, 8, 0, 0}))
			myEmps.Add(New clsEmployee("Scott", 105, 15, {10, 10, 0, 10, 10, 10, 0}))
			myEmps.Add(New clsEmployee("Bill", 106, 12, {8, 8, 8, 8, 9, 0, 0}))
			myEmps.Add(New clsEmployee("Tina", 107, 16, {8, 8, 8, 8, 8, 0, 0}))
			myEmps.Add(New clsEmployee("Ron", 109, 15.5, {0, 0, 9, 9, 9, 9, 9}))
			myEmps.Add(New clsEmployee("Barb", 110, 13, {0, 10, 0, 10, 10, 10, 0}))
			myEmps.Add(New clsEmployee("Cathy", 111, 14.5, {8, 8, 8, 8, 8, 0, 0}))
			myEmps.Add(New clsEmployee("AL", 112, 15, {10, 10, 10, 10, 8, 0, 0}))
			myEmps.Add(New clsEmployee("Dave", 133, 15.5, {0, 0, 8, 8, 8, 8, 8}))
			myEmps.Add(New clsEmployee("Haley", 134, 16.5, {8, 8, 8, 8, 8, 0, 0}))
			myEmps.Add(New clsEmployee("Drew", 136, 12.25, {10, 10, 0, 0, 10, 10, 0}))
			myEmps.Add(New clsEmployee("John", 137, 13, {8, 8, 8, 8, 8, 0, 0}))
			myEmps.Add(New clsEmployee("Mary", 138, 14, {8, 8, 8, 8, 8, 0, 0}))
			myEmps.Add(New clsEmployee("Ann", 139, 15, {0, 0, 0, 10, 10, 10, 10}))
			myEmps.Add(New clsEmployee("Chuck", 140, 15, {0, 8, 8, 8, 8, 8, 0}))

		Catch ex As InvalidOperationException
			MsgBox(ex.Message, Title:="Invalid Employee Record")
		End Try
		GenerateReport(myEmps)
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: GenerateReport			-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 03-29-2017					-
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Generates a excel document with headers, all employee's	-
	'-	data, and calculated statistics							-
	'------------------------------------------------------------
	'- Parameter Dictionary:									-
	'-	myEmployees - list of employees populated by user		-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- ExcelDoc - reference to excel.exe						-
	'- ExcelSheet - Sheet held within a excel workbook			-
	'- openWorkbook - container for finding any excel 			-
	'- applications already availiable							-
	'- WorkBook - the current workbook to be used in excel.exe	-
	'------------------------------------------------------------
	Public Sub GenerateReport(myEmployees As ArrayList)
		Dim openWorkbook As Object = Nothing
		Dim ExcelDoc As Excel.Application
		Try
			openWorkbook = GetObject(, "Excel.Application")
		Catch ex As Exception
			'ignored if no object exists
		End Try
		If openWorkbook Is Nothing Then
			ExcelDoc = New Excel.Application
		Else
			ExcelDoc = openWorkbook
		End If

		Dim WorkBook = ExcelDoc.Workbooks.Add()
		Dim ExcelSheet = ExcelDoc.ActiveSheet
		ExcelSheet.Cells(1, 1).Value = "Name"
		ExcelSheet.Cells(1, 2).Value = "ID"
		ExcelSheet.Cells(1, 3).Value = "Payrate"
		ExcelSheet.Cells(1, 4).Value = "Hours"
		ExcelSheet.Cells(1, 5).Value = "Total"

		For i = 0 To myEmployees.Count - 1
			ExcelSheet.Cells(i + 2, 1).Value = myEmployees(i).strName
			ExcelSheet.Cells(i + 2, 2).Value = myEmployees(i).intID
			ExcelSheet.Cells(i + 2, 3).Value = myEmployees(i).dblPayRate
			ExcelSheet.Cells(i + 2, 4).Value = myEmployees(i).dblHours
		Next
		ExcelSheet.Range("E2", $"E{1 + myEmployees.Count}").Formula = "=(MIN(40,D2)*C2)+(MAX(0,D2-40)*C2*1.5)"

		ExcelSheet.Cells(3 + myEmployees.Count, 2).Value = "Aver:"
		ExcelSheet.Cells(4 + myEmployees.Count, 2).Value = "Min:"
		ExcelSheet.Cells(5 + myEmployees.Count, 2).Value = "Max:"
		ExcelSheet.Cells(6 + myEmployees.Count, 2).Value = "Total:"

		ExcelSheet.Range($"C{3 + myEmployees.Count}: E{3 + myEmployees.Count}").Formula = $"=AVERAGE(C2:C{1 + myEmployees.Count})"
		ExcelSheet.Range($"C{4 + myEmployees.Count}: E{4 + myEmployees.Count}").Formula = $"=MIN(C2:C{1 + myEmployees.Count})"
		ExcelSheet.Range($"C{5 + myEmployees.Count}: E{5 + myEmployees.Count}").Formula = $"=MAX(C2:C{1 + myEmployees.Count})"
		ExcelSheet.Range($"C{6 + myEmployees.Count}: E{6 + myEmployees.Count}").Formula = $"=SUM(C2:C{1 + myEmployees.Count})"

		ExcelDoc.Visible = True
	End Sub
End Module
'------------------------------------------------------------
'-                Class Name: clsEmployee					-
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 03-29-2017					-
'------------------------------------------------------------
'- Class Variable Dictionary (alphabetically):				-
'- dblHours - total hours worked
'- dblPayRate - Rate of pay per hour
'- intID - employee id number
'- strName - name of the employee
'------------------------------------------------------------
Public Class clsEmployee
    Public strName As String
    Public intID As Integer
    Public dblPayRate As Double
    Public dblHours As Double

	Public Sub New(Name As String, ID As Integer, HourlyRate As Double, ParamArray HoursWorked As Double())
		Me.strName = Name
		Me.intID = ID
		Me.dblPayRate = HourlyRate
		If (HoursWorked.Count > 7) Then
			Throw New InvalidOperationException($"Employee {ID} shows more then 7 days worked this week, please revise and resubmit")
		End If
		Me.dblHours = (Aggregate H In HoursWorked Into Sum(H))
	End Sub
End Class
