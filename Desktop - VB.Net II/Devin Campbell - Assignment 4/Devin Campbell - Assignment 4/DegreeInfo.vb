'------------------------------------------------------------
'-                File Name : DataContainers.vb             - 
'-                Part of Project: Assignment #4            -
'------------------------------------------------------------
'-                Written By: Devin Campbell                -
'-                Written On: 02/04/2017		          -
'------------------------------------------------------------
'- File Purpose:                      (Data Format)         -
'- Handles events and procedures of the CourseManager form  -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- DegreeInfo - DegreeType | Universal data set, Required   -
'-	to Serialize and Deserialize at Load and Save		-
'------------------------------------------------------------
Public Module DataContainers
	Public DegreeInfo As DegreeType = DegreeType.LoadFromFile()
	'------------------------------------------------------------
	'-                Class Name: DegreeType				-
	'------------------------------------------------------------
	'-                Written By: Devin Campbell                -
	'-                Written On: 02/04/2017		          -
	'------------------------------------------------------------
	'- Local Variable Dictionary (alphabetically):              -
	'- Courses - SortedDictionary | List of available classes	-
	'- Degrees - SortedDictionary | List of degrees and related -
	'-	classes										-
	'------------------------------------------------------------
	<Serializable>
	Public Class DegreeType
		Public Courses As SortedDictionary(Of String, String)
		Public Degrees As SortedDictionary(Of String, DegreeClass)

		'------------------------------------------------------------
		'-                Class Name: DegreeClass				-
		'------------------------------------------------------------
		'-                Written By: Devin Campbell                -
		'-                Written On: 02/04/2017		          -
		'------------------------------------------------------------
		'- Local Variable Dictionary (alphabetically):              -
		'- Details - SortedDictionary | Description of class		-
		'- Requirements - SortedDictionary | List of req Classes	-
		'------------------------------------------------------------
		<Serializable>
		Class DegreeClass
			Public Details As String
			Public Requirements As SortedDictionary(Of String, String)
			Sub New(Detail As String)
				Me.Details = Detail
				Me.Requirements = New SortedDictionary(Of String, String)
			End Sub
		End Class

		'- Default Constructor (No Args - No Declarations)
		Sub New()
			Degrees = New SortedDictionary(Of String, DegreeClass)
			Courses = New SortedDictionary(Of String, String)
		End Sub
		'------------------------------------------------------------
		'-                Subprogram Name: LoadFromFile		     -
		'------------------------------------------------------------
		'-                Written By: Devin Campbell                -
		'-                Written On: 02/04/2017		          -
		'------------------------------------------------------------
		'- Subprogram Purpose:                                      -
		'-                                                          -
		'- Loads Global object into memory from File				–
		'------------------------------------------------------------
		'- Parameter Dictionary (in parameter order):               -
		'- FileLocation – Files location in relation to Program	–
		'------------------------------------------------------------
		'- Local Variable Dictionary (alphabetically):              -
		'- BinaryFormat - Binary Formatter (serializer)             -
		'- output - Returns DegreeType object to variable	          -
		'- stream - FileStream object used for file access		-
		'------------------------------------------------------------
		Shared Function LoadFromFile(Optional FileLocation As String = "DegreeData.data") As DegreeType
			Dim output As New DegreeType()
			If IO.File.Exists(FileLocation) Then
				Dim BinaryFormat As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
				Dim stream As New IO.FileStream(FileLocation, IO.FileMode.OpenOrCreate)

				Try
					output = DirectCast(BinaryFormat.Deserialize(stream), DegreeType)
				Catch ex As Runtime.Serialization.SerializationException
					MsgBox("Data file corrupted. Please delete file or replace with backup.")
					Environment.Exit(-1)
				Finally
					stream.Close()
				End Try

				Return output
			Else
				Return New DegreeType()
			End If
		End Function
		'------------------------------------------------------------
		'-                Subprogram Name: SaveToFile		     -
		'------------------------------------------------------------
		'-                Written By: Devin Campbell                -
		'-                Written On: 02/04/2017		          -
		'------------------------------------------------------------
		'- Subprogram Purpose:                                      -
		'-                                                          -
		'- Saves data object into file from memory				–
		'------------------------------------------------------------
		'- Parameter Dictionary (in parameter order):               -
		'- Degree - DegreeType object passed to Writer			-
		'- FileLocation – Files location in relation to Program	–
		'------------------------------------------------------------
		'- Local Variable Dictionary (alphabetically):              -
		'- BinaryFormat - Binary Formatter (serializer)             -
		'- stream - FileStream object used for file access		-
		'------------------------------------------------------------
		Shared Sub SaveToFile(Degree As DegreeType, Optional ByVal FileLocation As String = "DegreeData.data")
			Dim stream As New IO.FileStream(FileLocation, IO.FileMode.OpenOrCreate)
			Try
				Dim BinaryFormat As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
				BinaryFormat.Serialize(stream, DegreeInfo)
			Catch ex As Runtime.Serialization.SerializationException
				MsgBox("Error saving File" + ex.Message)
				Throw
			Finally
				stream.Close()
			End Try

		End Sub
		'------------------------------------------------------------
		'-                Subprogram Name: SaveToFile		     -
		'------------------------------------------------------------
		'-                Written By: Devin Campbell                -
		'-                Written On: 02/04/2017		          -
		'------------------------------------------------------------
		'- Subprogram Purpose:                                      -
		'-                                                          -
		'- Saves data object into file from memory (overload)		–
		'------------------------------------------------------------
		'- Parameter Dictionary (in parameter order):               -
		'- FileLocation – Files location in relation to Program	–
		'------------------------------------------------------------
		'- Local Variable Dictionary (alphabetically):              -
		'- BinaryFormat - Binary Formatter (serializer)             -
		'- stream - FileStream object used for file access		-
		'------------------------------------------------------------
		Shared Sub SaveToFile(Optional FileLocation As String = "DegreeData.data")
			SaveToFile(DegreeInfo, FileLocation)
		End Sub
	End Class

End Module