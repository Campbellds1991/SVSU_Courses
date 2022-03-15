'------------------------------------------------------------
'-                File Name : GradeReporter.vb              - 
'-                Part of Project: Assignment #5            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 02/11/2017		          -
'------------------------------------------------------------
'- File Purpose:                      (Startup Form)        -
'- Delegates all tasks needed to generate Report			-
'------------------------------------------------------------
'- Global Variable Dictionary:						-
'- StudentData - Holds all records associated with students	-
'-	and their grades								-
'------------------------------------------------------------
Module GradeReporter
	Public StudentData As New List(Of StuInfo)
	Structure StuInfo
		Public Initials As String
		Public LastName As String
		Public Homework1 As Single
		Public Homework2 As Single
		Public Homework3 As Single
		Public Homework4 As Single
		Public ExamScore As Single
		Public NumericGrade As Single
		Public LetterGrade As String
	End Structure
	'------------------------------------------------------------
	'-                Subprogram Name: Main				     -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/11/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Main method, all code starts and ends here.			-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- None											-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- FileLocation - user defined location of space delimited  -
	'-	text file used To read In user data                    -
	'- Reader - Data Stream object used to read student info	-
	'------------------------------------------------------------
	Sub Main()
		Console.Title = "Ye Old Country School - Grade Report"
		Console.WriteLine("Designate File Location:")

		' Revert to Console.Readline after testing
		Dim FileLocation As String = Console.ReadLine()
		Dim Reader As IO.StreamReader
		Try
			Reader = New IO.StreamReader(FileLocation)
		Catch ex As Exception
			Console.WriteLine()
			Console.WriteLine(ex.Message)
			Console.WriteLine()
			Console.WriteLine("Program will Exit, Press esc to continue.......")
			While Not Console.ReadKey.Key = ConsoleKey.Escape
			End While
			Environment.Exit(-1)
		End Try
		'------------------------------------------------------------
		'- Local Variable Dictionary (alphabetically):              -
		'- ln - Temp variable used in splitting lines read from file-
		'------------------------------------------------------------
		'- Constant Variable Dictionary (alphabetically):           -
		'- EXAM_WEIGHT - Relative grade weight of Exam scores		-
		'- HW_WEIGHT - Relative grade weight of Homework scores	-
		'------------------------------------------------------------
		While Not Reader.EndOfStream()
			Dim ln As String() = Reader.ReadLine().Split(" ")
			Const EXAM_WEIGHT = 0.5
			Const HW_WEIGHT = 0.5
			Try
				StudentData.Add(New StuInfo With {
					.Initials = ln(0),
					.LastName = ln(1),
					.Homework1 = ln(2),
					.Homework2 = ln(3),
					.Homework3 = ln(4),
					.Homework4 = ln(5),
					.ExamScore = ln(6),
					.NumericGrade = ((.Homework1 + .Homework2 + .Homework3 + .Homework4) * HW_WEIGHT) + (.ExamScore * EXAM_WEIGHT),
					.LetterGrade = NumGradeToLetterGrade(.NumericGrade)})
			Catch
				Console.WriteLine()
				Console.WriteLine("Error with data, program will exit, Press esc to continue")
				While Not Console.ReadKey.Key = ConsoleKey.Escape
				End While
				Environment.Exit(-1)
			End Try
		End While

		BaseReport()
		DistributionStats()
		GradeRangeReport()
		overallGradeStatistics()
		Console.WriteLine(vbCrLf & "Press enter to exit.")
		Console.Read()
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: NumGradeToLetterGrade    -
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/11/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Converts a numeric grade into a letter grade			-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- num - numeric representation of a students grade		-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- None											-
	'------------------------------------------------------------
	Public Function NumGradeToLetterGrade(num As Integer) As String
		Select Case num
			Case Is >= 95 : Return "A"
			Case Is >= 90 : Return "A-"
			Case Is >= 87 : Return "B+"
			Case Is >= 84 : Return "B"
			Case Is >= 80 : Return "B-"
			Case Is >= 77 : Return "C+"
			Case Is >= 74 : Return "C"
			Case Is >= 70 : Return "C-"
			Case Is >= 67 : Return "D+"
			Case Is >= 64 : Return "D"
			Case Is >= 60 : Return "D-"
			Case Else : Return "F"
		End Select
	End Function

	'------------------------------------------------------------
	'-                Subprogram Name: BaseReport			-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/11/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Shows a generic listing of all students grades listed	-
	'-	in alphabetic order								-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- None											-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- header - Format String for headings displayed to console -
	'- report- Format String for results posted to console		-
	'------------------------------------------------------------
	Sub BaseReport()
		Console.WriteLine()
		Console.WriteLine(StrDup(14, " ") & "Ye Old Country School")
		Console.WriteLine(StrDup(10, " ") & "*** Semester Grade Report ***")
		Console.WriteLine(StrDup(10, " ") & "-----------------------------")
		Console.WriteLine()
		Dim header As String = "{0,-20} {1,-6} {2,-6} {3,-6} {4,-6} {5,-6} {6,-7} {7,-6}"
		Dim report As String = "{0,-20} {1,6:N2} {2,6:N2} {3,6:N2} {4,6:N2} {5,6:N2} {6,7:N2}   {7,-2}"
		Console.WriteLine(String.Format("{0,-20}{1,-29}{2,-6} {3,-6} {4,-6}", "", "     Homework Scores", " Exam", "Numeric", "Letter"))
		Console.WriteLine(String.Format(header, "     Name", "  1", "  2", "  3", "  4", " Score", " Grade", "Grade"))
		Console.WriteLine(String.Format(header, StrDup(20, "-"), StrDup(6, "-"), StrDup(6, "-"), StrDup(6, "-"), StrDup(6, "-"), StrDup(6, "-"), StrDup(7, "-"), StrDup(6, "-")))
		For Each Stu In From student In StudentData
					 Order By student.LastName
					 Select student
			Console.WriteLine(String.Format(report, Stu.Initials & " " & Stu.LastName, Stu.Homework1, Stu.Homework2, Stu.Homework3, Stu.Homework4, Stu.ExamScore, Stu.NumericGrade, Stu.LetterGrade))
		Next
	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: DistributionStats		-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/11/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Writes to the console a listing of students grouped by	-
	'-	letter grade recieved							-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- None											-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- gradeset - holds the current itteration of the letter	-
	'-	grade being check against.						-
	'------------------------------------------------------------
	Sub DistributionStats()
		Console.WriteLine()
		Console.WriteLine(StrDup(60, "-"))
		Console.WriteLine(StrDup(10, " ") & "Grade Distribution Statistics")
		Console.WriteLine(StrDup(60, "-"))
		Dim gradeSet As Char = ""
		For Each student In (From stu In StudentData
						 Order By stu.LetterGrade, stu.LastName, stu.Initials
						 Select stu)
			' Breaks the itteration of students based on the Letter portion of a grade
			' Grades will be seperated using the gradeset variable to test against.
			' ***  When the first A arrives, gradeset will be set to A and given a header.  Once a B arrives, this code
			'	will itterate a new header and continue to itterate grades present in the listing. ***
			If Not gradeSet = student.LetterGrade.Chars(0) Then
				Console.WriteLine()
				gradeSet = student.LetterGrade.Chars(0)
				Console.WriteLine(String.Format("Those Students earning a {0} grade are", student.LetterGrade.Chars(0)))
			End If
			Console.WriteLine(String.Format("   {0,4} {1,-15} ---> {2}", student.Initials, student.LastName, student.LetterGrade))
		Next

	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: GradeRangeReport		-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/11/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Writes to the console a listing of statistics per each	-
	'-	type of grading.								-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- None											-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- report- Format String for results posted to console		-
	'- Stats - Holds all statistic data pertinant to homeworks	-
	'-	and exams										-
	'------------------------------------------------------------
	'- Constant Variable Dictionary (alphabetically):           -
	'- HW_SCORE_TO_PERCENT - Relative weight of HW to percentage-
	'------------------------------------------------------------
	Sub GradeRangeReport()
		Console.WriteLine()
		Console.WriteLine(StrDup(60, "-"))
		Console.WriteLine(StrDup(12, " ") & "Homework/Exam Grade Range Statistics")
		Console.WriteLine(StrDup(60, "-"))
		Dim report As String = "{0,-10} : {1,6:N2}%" & StrDup(12, ".") & "{2,6:N2}%" & StrDup(12, ".") & "{3,6:N2}%"
		Console.WriteLine(String.Format("{0,-10} : {1,6}%" & StrDup(12, ".") & "{2,6}%" & StrDup(12, ".") & "{3,6}%", "", " Low", " Avg", " High"))

		Dim Stats = New With {
			Key .hw1 = (Aggregate grade In StudentData Into Min(grade.Homework1), Average(grade.Homework1), Max(grade.Homework1)),
			Key .hw2 = (Aggregate grade In StudentData Into Min(grade.Homework2), Average(grade.Homework2), Max(grade.Homework2)),
			Key .hw3 = (Aggregate grade In StudentData Into Min(grade.Homework3), Average(grade.Homework3), Max(grade.Homework3)),
			Key .hw4 = (Aggregate grade In StudentData Into Min(grade.Homework4), Average(grade.Homework4), Max(grade.Homework4)),
			Key .exam = (Aggregate grade In StudentData Into Min(grade.ExamScore), Average(grade.ExamScore), Max(grade.ExamScore))
		}
		Const HW_SCORE_TO_PERCENT = 100 / 25
		Console.WriteLine(String.Format(report, "Homework 1", Stats.hw1.Min * HW_SCORE_TO_PERCENT, Stats.hw1.Average * HW_SCORE_TO_PERCENT, Stats.hw1.Max * HW_SCORE_TO_PERCENT))
		Console.WriteLine(String.Format(report, "Homework 2", Stats.hw2.Min * HW_SCORE_TO_PERCENT, Stats.hw2.Average * HW_SCORE_TO_PERCENT, Stats.hw2.Max * HW_SCORE_TO_PERCENT))
		Console.WriteLine(String.Format(report, "Homework 3", Stats.hw3.Min * HW_SCORE_TO_PERCENT, Stats.hw3.Average * HW_SCORE_TO_PERCENT, Stats.hw3.Max * HW_SCORE_TO_PERCENT))
		Console.WriteLine(String.Format(report, "Homework 4", Stats.hw4.Min * HW_SCORE_TO_PERCENT, Stats.hw4.Average * HW_SCORE_TO_PERCENT, Stats.hw4.Max * HW_SCORE_TO_PERCENT))
		Console.WriteLine(String.Format(report, "Exam", Stats.exam.Min, Stats.exam.Average, Stats.exam.Max))


	End Sub
	'------------------------------------------------------------
	'-                Subprogram Name: overallGradeStatistics	-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/11/2017		          -
	'------------------------------------------------------------
	'- Subprogram Purpose:                                      -
	'-                                                          -
	'- Writes to the console a listing of students grouped by	-
	'-	letter grade recieved							-
	'-												–
	'------------------------------------------------------------
	'- Parameter Dictionary (in parameter order):               -
	'- None											-
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- stats - Holds all statistic data of student grades		-
	'- overall - Same as stats but uses information from stats	-
	'-	to determine students included in certain stats		-
	'------------------------------------------------------------
	Sub overallGradeStatistics()
		Console.WriteLine()
		Console.WriteLine(StrDup(60, "-"))
		Console.WriteLine(StrDup(10, " ") & "Overall Grade Course Statistics")
		Console.WriteLine(StrDup(60, "-"))
		Dim stats = Aggregate grade In StudentData Into Min(grade.NumericGrade), Average(grade.NumericGrade), Max(grade.NumericGrade)

		Dim overall = New With {Key .High = (From stu In StudentData Where stu.NumericGrade = stats.Max Select stu), Key .Low = (From stu In StudentData Where stu.NumericGrade = stats.Min Select stu)}


		Console.WriteLine(String.Format("The Highest course grade of {0} was earned by:", stats.Max))
		For Each student In overall.High
			Console.WriteLine(String.Format("   {0,-4} {1,-15} ---> {2,-3:N0}", student.Initials, student.LastName, student.NumericGrade))
		Next
		Console.WriteLine()
		Console.WriteLine(String.Format("The Lowest course grade of {0} was earned by:", stats.Min))
		For Each student In overall.Low
			Console.WriteLine(String.Format("   {0,-4} {1,-15} ---> {2,-3:N0}", student.Initials, student.LastName, student.NumericGrade))
		Next
		Console.WriteLine()
		Console.WriteLine(String.Format("The Average Course Grade was {0:N4}", stats.Average))
	End Sub
End Module
