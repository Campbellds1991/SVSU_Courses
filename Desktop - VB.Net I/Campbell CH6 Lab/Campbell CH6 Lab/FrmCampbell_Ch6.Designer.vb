<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCampbell_Ch6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Ex3_3_GbGrades = New System.Windows.Forms.GroupBox()
        Me.Ex3_3_LstGrades = New System.Windows.Forms.ListBox()
        Me.Ex3_3_TxtHighest = New System.Windows.Forms.TextBox()
        Me.Ex3_3_LblHighest = New System.Windows.Forms.Label()
        Me.Ex3_3_TxtAverage = New System.Windows.Forms.TextBox()
        Me.Ex3_3_LblAverage = New System.Windows.Forms.Label()
        Me.Ex3_3_BtnCalculate = New System.Windows.Forms.Button()
        Me.Ex3_3_BtnRecord = New System.Windows.Forms.Button()
        Me.Ex3_3_TxtGrade = New System.Windows.Forms.TextBox()
        Me.Ex3_3_LblGrade = New System.Windows.Forms.Label()
        Me.Ex3_2_GbFirstTwoLetters = New System.Windows.Forms.GroupBox()
        Me.Ex3_2_MtbFirstTwoLetters = New System.Windows.Forms.MaskedTextBox()
        Me.Ex3_2_TxtOutput = New System.Windows.Forms.TextBox()
        Me.Ex3_2_BtnSearch = New System.Windows.Forms.Button()
        Me.Ex3_2_LblFirstTwoLetters = New System.Windows.Forms.Label()
        Me.Ex3_2_LblStates = New System.Windows.Forms.Label()
        Me.Ex3_2_LstStates = New System.Windows.Forms.ListBox()
        Me.Ex3_1_GbStates = New System.Windows.Forms.GroupBox()
        Me.Ex3_1_LstLast10 = New System.Windows.Forms.ListBox()
        Me.Ex3_1_BtnLast10 = New System.Windows.Forms.Button()
        Me.Ex3_1_LblStates = New System.Windows.Forms.Label()
        Me.Ex3_1_LstStates = New System.Windows.Forms.ListBox()
        Me.Ex2_4_GbTable = New System.Windows.Forms.GroupBox()
        Me.Ex2_4_LstTable = New System.Windows.Forms.ListBox()
        Me.Ex2_4_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex2_3_GbBackwards = New System.Windows.Forms.GroupBox()
        Me.Ex2_3_TxtBackwards = New System.Windows.Forms.TextBox()
        Me.Ex2_3_BtnReverse = New System.Windows.Forms.Button()
        Me.Ex2_3_TxtWord = New System.Windows.Forms.TextBox()
        Me.Ex2_3_LblWord = New System.Windows.Forms.Label()
        Me.Ex2_2_GbIndexValues = New System.Windows.Forms.GroupBox()
        Me.Ex2_2_TxtStep = New System.Windows.Forms.TextBox()
        Me.Ex2_2_LstValues = New System.Windows.Forms.ListBox()
        Me.Ex2_2_TxtEnd = New System.Windows.Forms.TextBox()
        Me.Ex2_2_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex2_2_LblN = New System.Windows.Forms.Label()
        Me.Ex2_2_LblS = New System.Windows.Forms.Label()
        Me.Ex1_4_GbMovieQuotes = New System.Windows.Forms.GroupBox()
        Me.Ex1_2_TxtOutput = New System.Windows.Forms.TextBox()
        Me.Ex1_2_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex1_1_GbNumbers = New System.Windows.Forms.GroupBox()
        Me.Ex1_1_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex1_1_LstOutput = New System.Windows.Forms.ListBox()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Ex3_3_GbGrades.SuspendLayout()
        Me.Ex3_2_GbFirstTwoLetters.SuspendLayout()
        Me.Ex3_1_GbStates.SuspendLayout()
        Me.Ex2_4_GbTable.SuspendLayout()
        Me.Ex2_3_GbBackwards.SuspendLayout()
        Me.Ex2_2_GbIndexValues.SuspendLayout()
        Me.Ex1_4_GbMovieQuotes.SuspendLayout()
        Me.Ex1_1_GbNumbers.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ex3_3_GbGrades
        '
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_LstGrades)
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_TxtHighest)
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_LblHighest)
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_TxtAverage)
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_LblAverage)
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_BtnCalculate)
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_BtnRecord)
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_TxtGrade)
        Me.Ex3_3_GbGrades.Controls.Add(Me.Ex3_3_LblGrade)
        Me.Ex3_3_GbGrades.Location = New System.Drawing.Point(720, 174)
        Me.Ex3_3_GbGrades.Name = "Ex3_3_GbGrades"
        Me.Ex3_3_GbGrades.Size = New System.Drawing.Size(298, 219)
        Me.Ex3_3_GbGrades.TabIndex = 16
        Me.Ex3_3_GbGrades.TabStop = False
        Me.Ex3_3_GbGrades.Text = "Analyze Grades"
        '
        'Ex3_3_LstGrades
        '
        Me.Ex3_3_LstGrades.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex3_3_LstGrades.FormattingEnabled = True
        Me.Ex3_3_LstGrades.ItemHeight = 14
        Me.Ex3_3_LstGrades.Location = New System.Drawing.Point(175, 26)
        Me.Ex3_3_LstGrades.Name = "Ex3_3_LstGrades"
        Me.Ex3_3_LstGrades.Size = New System.Drawing.Size(105, 186)
        Me.Ex3_3_LstGrades.TabIndex = 8
        '
        'Ex3_3_TxtHighest
        '
        Me.Ex3_3_TxtHighest.Location = New System.Drawing.Point(92, 187)
        Me.Ex3_3_TxtHighest.Name = "Ex3_3_TxtHighest"
        Me.Ex3_3_TxtHighest.Size = New System.Drawing.Size(56, 20)
        Me.Ex3_3_TxtHighest.TabIndex = 7
        '
        'Ex3_3_LblHighest
        '
        Me.Ex3_3_LblHighest.AutoSize = True
        Me.Ex3_3_LblHighest.Location = New System.Drawing.Point(10, 190)
        Me.Ex3_3_LblHighest.Name = "Ex3_3_LblHighest"
        Me.Ex3_3_LblHighest.Size = New System.Drawing.Size(79, 13)
        Me.Ex3_3_LblHighest.TabIndex = 6
        Me.Ex3_3_LblHighest.Text = "Highest grade: "
        '
        'Ex3_3_TxtAverage
        '
        Me.Ex3_3_TxtAverage.Location = New System.Drawing.Point(92, 158)
        Me.Ex3_3_TxtAverage.Name = "Ex3_3_TxtAverage"
        Me.Ex3_3_TxtAverage.Size = New System.Drawing.Size(56, 20)
        Me.Ex3_3_TxtAverage.TabIndex = 5
        '
        'Ex3_3_LblAverage
        '
        Me.Ex3_3_LblAverage.AutoSize = True
        Me.Ex3_3_LblAverage.Location = New System.Drawing.Point(6, 161)
        Me.Ex3_3_LblAverage.Name = "Ex3_3_LblAverage"
        Me.Ex3_3_LblAverage.Size = New System.Drawing.Size(83, 13)
        Me.Ex3_3_LblAverage.TabIndex = 4
        Me.Ex3_3_LblAverage.Text = "Average grade: "
        '
        'Ex3_3_BtnCalculate
        '
        Me.Ex3_3_BtnCalculate.Location = New System.Drawing.Point(10, 101)
        Me.Ex3_3_BtnCalculate.Name = "Ex3_3_BtnCalculate"
        Me.Ex3_3_BtnCalculate.Size = New System.Drawing.Size(150, 40)
        Me.Ex3_3_BtnCalculate.TabIndex = 3
        Me.Ex3_3_BtnCalculate.Text = "Calculate Average anbd Highest Grade"
        Me.Ex3_3_BtnCalculate.UseVisualStyleBackColor = True
        '
        'Ex3_3_BtnRecord
        '
        Me.Ex3_3_BtnRecord.Location = New System.Drawing.Point(10, 57)
        Me.Ex3_3_BtnRecord.Name = "Ex3_3_BtnRecord"
        Me.Ex3_3_BtnRecord.Size = New System.Drawing.Size(150, 38)
        Me.Ex3_3_BtnRecord.TabIndex = 2
        Me.Ex3_3_BtnRecord.Text = "Record Grade"
        Me.Ex3_3_BtnRecord.UseVisualStyleBackColor = True
        '
        'Ex3_3_TxtGrade
        '
        Me.Ex3_3_TxtGrade.Location = New System.Drawing.Point(63, 23)
        Me.Ex3_3_TxtGrade.Name = "Ex3_3_TxtGrade"
        Me.Ex3_3_TxtGrade.Size = New System.Drawing.Size(81, 20)
        Me.Ex3_3_TxtGrade.TabIndex = 1
        '
        'Ex3_3_LblGrade
        '
        Me.Ex3_3_LblGrade.AutoSize = True
        Me.Ex3_3_LblGrade.Location = New System.Drawing.Point(18, 26)
        Me.Ex3_3_LblGrade.Name = "Ex3_3_LblGrade"
        Me.Ex3_3_LblGrade.Size = New System.Drawing.Size(39, 13)
        Me.Ex3_3_LblGrade.TabIndex = 0
        Me.Ex3_3_LblGrade.Text = "Grade:"
        '
        'Ex3_2_GbFirstTwoLetters
        '
        Me.Ex3_2_GbFirstTwoLetters.Controls.Add(Me.Ex3_2_MtbFirstTwoLetters)
        Me.Ex3_2_GbFirstTwoLetters.Controls.Add(Me.Ex3_2_TxtOutput)
        Me.Ex3_2_GbFirstTwoLetters.Controls.Add(Me.Ex3_2_BtnSearch)
        Me.Ex3_2_GbFirstTwoLetters.Controls.Add(Me.Ex3_2_LblFirstTwoLetters)
        Me.Ex3_2_GbFirstTwoLetters.Controls.Add(Me.Ex3_2_LblStates)
        Me.Ex3_2_GbFirstTwoLetters.Controls.Add(Me.Ex3_2_LstStates)
        Me.Ex3_2_GbFirstTwoLetters.Location = New System.Drawing.Point(344, 222)
        Me.Ex3_2_GbFirstTwoLetters.Name = "Ex3_2_GbFirstTwoLetters"
        Me.Ex3_2_GbFirstTwoLetters.Size = New System.Drawing.Size(365, 289)
        Me.Ex3_2_GbFirstTwoLetters.TabIndex = 15
        Me.Ex3_2_GbFirstTwoLetters.TabStop = False
        Me.Ex3_2_GbFirstTwoLetters.Text = "U.S. States"
        '
        'Ex3_2_MtbFirstTwoLetters
        '
        Me.Ex3_2_MtbFirstTwoLetters.Location = New System.Drawing.Point(268, 56)
        Me.Ex3_2_MtbFirstTwoLetters.Mask = "LL"
        Me.Ex3_2_MtbFirstTwoLetters.Name = "Ex3_2_MtbFirstTwoLetters"
        Me.Ex3_2_MtbFirstTwoLetters.Size = New System.Drawing.Size(36, 20)
        Me.Ex3_2_MtbFirstTwoLetters.TabIndex = 8
        '
        'Ex3_2_TxtOutput
        '
        Me.Ex3_2_TxtOutput.Location = New System.Drawing.Point(177, 164)
        Me.Ex3_2_TxtOutput.Name = "Ex3_2_TxtOutput"
        Me.Ex3_2_TxtOutput.ReadOnly = True
        Me.Ex3_2_TxtOutput.Size = New System.Drawing.Size(156, 20)
        Me.Ex3_2_TxtOutput.TabIndex = 7
        '
        'Ex3_2_BtnSearch
        '
        Me.Ex3_2_BtnSearch.Location = New System.Drawing.Point(193, 98)
        Me.Ex3_2_BtnSearch.Name = "Ex3_2_BtnSearch"
        Me.Ex3_2_BtnSearch.Size = New System.Drawing.Size(112, 45)
        Me.Ex3_2_BtnSearch.TabIndex = 6
        Me.Ex3_2_BtnSearch.Text = "Search for State"
        Me.Ex3_2_BtnSearch.UseVisualStyleBackColor = True
        '
        'Ex3_2_LblFirstTwoLetters
        '
        Me.Ex3_2_LblFirstTwoLetters.Location = New System.Drawing.Point(174, 59)
        Me.Ex3_2_LblFirstTwoLetters.Name = "Ex3_2_LblFirstTwoLetters"
        Me.Ex3_2_LblFirstTwoLetters.Size = New System.Drawing.Size(88, 33)
        Me.Ex3_2_LblFirstTwoLetters.TabIndex = 4
        Me.Ex3_2_LblFirstTwoLetters.Text = "First Two Letters of State:"
        '
        'Ex3_2_LblStates
        '
        Me.Ex3_2_LblStates.AutoSize = True
        Me.Ex3_2_LblStates.Location = New System.Drawing.Point(43, 20)
        Me.Ex3_2_LblStates.Name = "Ex3_2_LblStates"
        Me.Ex3_2_LblStates.Size = New System.Drawing.Size(40, 13)
        Me.Ex3_2_LblStates.TabIndex = 3
        Me.Ex3_2_LblStates.Text = "States:"
        '
        'Ex3_2_LstStates
        '
        Me.Ex3_2_LstStates.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex3_2_LstStates.FormattingEnabled = True
        Me.Ex3_2_LstStates.ItemHeight = 14
        Me.Ex3_2_LstStates.Items.AddRange(New Object() {"Delaware", "Pennsylvania", "New Jersey", "Georgia", "Connecticut", "Massachusetts", "Maryland", "South Carolina", "New Hampshire", "Virginia", "New York,NY", "North Carolina", "Rhode Island", "Vermont", "Kentucky", "Tennessee", "Ohio", "Louisiana", "Indiana", "Mississippi", "Illinois", "Alabama", "Maine", "Missouri", "Arkansas", "Michigan", "Florida", "Texas", "Iowa", "Wisconsin", "California", "Minnesota", "Oregon", "Kansas", "West Virginia", "Nevada", "Nebraska", "Colorado", "North Dakota", "South Dakota", "Montana", "Washington", "Idaho", "Wyoming", "Utah", "Oklahoma", "New Mexico", "Arizona", "Alaska", "Hawaii"})
        Me.Ex3_2_LstStates.Location = New System.Drawing.Point(14, 36)
        Me.Ex3_2_LstStates.Name = "Ex3_2_LstStates"
        Me.Ex3_2_LstStates.Size = New System.Drawing.Size(138, 228)
        Me.Ex3_2_LstStates.TabIndex = 2
        '
        'Ex3_1_GbStates
        '
        Me.Ex3_1_GbStates.Controls.Add(Me.Ex3_1_LstLast10)
        Me.Ex3_1_GbStates.Controls.Add(Me.Ex3_1_BtnLast10)
        Me.Ex3_1_GbStates.Controls.Add(Me.Ex3_1_LblStates)
        Me.Ex3_1_GbStates.Controls.Add(Me.Ex3_1_LstStates)
        Me.Ex3_1_GbStates.Location = New System.Drawing.Point(12, 217)
        Me.Ex3_1_GbStates.Name = "Ex3_1_GbStates"
        Me.Ex3_1_GbStates.Size = New System.Drawing.Size(326, 289)
        Me.Ex3_1_GbStates.TabIndex = 14
        Me.Ex3_1_GbStates.TabStop = False
        Me.Ex3_1_GbStates.Text = "U.S. States"
        '
        'Ex3_1_LstLast10
        '
        Me.Ex3_1_LstLast10.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex3_1_LstLast10.FormattingEnabled = True
        Me.Ex3_1_LstLast10.ItemHeight = 14
        Me.Ex3_1_LstLast10.Location = New System.Drawing.Point(147, 75)
        Me.Ex3_1_LstLast10.Name = "Ex3_1_LstLast10"
        Me.Ex3_1_LstLast10.Size = New System.Drawing.Size(157, 186)
        Me.Ex3_1_LstLast10.TabIndex = 3
        '
        'Ex3_1_BtnLast10
        '
        Me.Ex3_1_BtnLast10.Location = New System.Drawing.Point(147, 19)
        Me.Ex3_1_BtnLast10.Name = "Ex3_1_BtnLast10"
        Me.Ex3_1_BtnLast10.Size = New System.Drawing.Size(157, 49)
        Me.Ex3_1_BtnLast10.TabIndex = 2
        Me.Ex3_1_BtnLast10.Text = "Display Last Ten States"
        Me.Ex3_1_BtnLast10.UseVisualStyleBackColor = True
        '
        'Ex3_1_LblStates
        '
        Me.Ex3_1_LblStates.AutoSize = True
        Me.Ex3_1_LblStates.Location = New System.Drawing.Point(35, 20)
        Me.Ex3_1_LblStates.Name = "Ex3_1_LblStates"
        Me.Ex3_1_LblStates.Size = New System.Drawing.Size(40, 13)
        Me.Ex3_1_LblStates.TabIndex = 1
        Me.Ex3_1_LblStates.Text = "States:"
        '
        'Ex3_1_LstStates
        '
        Me.Ex3_1_LstStates.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex3_1_LstStates.FormattingEnabled = True
        Me.Ex3_1_LstStates.ItemHeight = 14
        Me.Ex3_1_LstStates.Items.AddRange(New Object() {"Delaware", "Pennsylvania", "New Jersey", "Georgia", "Connecticut", "Massachusetts", "Maryland", "South Carolina", "New Hampshire", "Virginia", "New York,NY", "North Carolina", "Rhode Island", "Vermont", "Kentucky", "Tennessee", "Ohio", "Louisiana", "Indiana", "Mississippi", "Illinois", "Alabama", "Maine", "Missouri", "Arkansas", "Michigan", "Florida", "Texas", "Iowa", "Wisconsin", "California", "Minnesota", "Oregon", "Kansas", "West Virginia", "Nevada", "Nebraska", "Colorado", "North Dakota", "South Dakota", "Montana", "Washington", "Idaho", "Wyoming", "Utah", "Oklahoma", "New Mexico", "Arizona", "Alaska", "Hawaii"})
        Me.Ex3_1_LstStates.Location = New System.Drawing.Point(6, 36)
        Me.Ex3_1_LstStates.Name = "Ex3_1_LstStates"
        Me.Ex3_1_LstStates.Size = New System.Drawing.Size(135, 228)
        Me.Ex3_1_LstStates.TabIndex = 0
        '
        'Ex2_4_GbTable
        '
        Me.Ex2_4_GbTable.Controls.Add(Me.Ex2_4_LstTable)
        Me.Ex2_4_GbTable.Controls.Add(Me.Ex2_4_BtnDisplay)
        Me.Ex2_4_GbTable.Location = New System.Drawing.Point(835, 13)
        Me.Ex2_4_GbTable.Name = "Ex2_4_GbTable"
        Me.Ex2_4_GbTable.Size = New System.Drawing.Size(257, 155)
        Me.Ex2_4_GbTable.TabIndex = 13
        Me.Ex2_4_GbTable.TabStop = False
        Me.Ex2_4_GbTable.Text = "Multiplication Table"
        '
        'Ex2_4_LstTable
        '
        Me.Ex2_4_LstTable.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex2_4_LstTable.FormattingEnabled = True
        Me.Ex2_4_LstTable.ItemHeight = 14
        Me.Ex2_4_LstTable.Location = New System.Drawing.Point(6, 50)
        Me.Ex2_4_LstTable.Name = "Ex2_4_LstTable"
        Me.Ex2_4_LstTable.Size = New System.Drawing.Size(245, 74)
        Me.Ex2_4_LstTable.TabIndex = 1
        '
        'Ex2_4_BtnDisplay
        '
        Me.Ex2_4_BtnDisplay.Location = New System.Drawing.Point(54, 20)
        Me.Ex2_4_BtnDisplay.Name = "Ex2_4_BtnDisplay"
        Me.Ex2_4_BtnDisplay.Size = New System.Drawing.Size(129, 23)
        Me.Ex2_4_BtnDisplay.TabIndex = 0
        Me.Ex2_4_BtnDisplay.Text = "Display Table"
        Me.Ex2_4_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex2_3_GbBackwards
        '
        Me.Ex2_3_GbBackwards.Controls.Add(Me.Ex2_3_TxtBackwards)
        Me.Ex2_3_GbBackwards.Controls.Add(Me.Ex2_3_BtnReverse)
        Me.Ex2_3_GbBackwards.Controls.Add(Me.Ex2_3_TxtWord)
        Me.Ex2_3_GbBackwards.Controls.Add(Me.Ex2_3_LblWord)
        Me.Ex2_3_GbBackwards.Location = New System.Drawing.Point(578, 13)
        Me.Ex2_3_GbBackwards.Name = "Ex2_3_GbBackwards"
        Me.Ex2_3_GbBackwards.Size = New System.Drawing.Size(251, 107)
        Me.Ex2_3_GbBackwards.TabIndex = 12
        Me.Ex2_3_GbBackwards.TabStop = False
        Me.Ex2_3_GbBackwards.Text = "Write Backwards"
        '
        'Ex2_3_TxtBackwards
        '
        Me.Ex2_3_TxtBackwards.Location = New System.Drawing.Point(24, 73)
        Me.Ex2_3_TxtBackwards.Name = "Ex2_3_TxtBackwards"
        Me.Ex2_3_TxtBackwards.ReadOnly = True
        Me.Ex2_3_TxtBackwards.Size = New System.Drawing.Size(199, 20)
        Me.Ex2_3_TxtBackwards.TabIndex = 3
        '
        'Ex2_3_BtnReverse
        '
        Me.Ex2_3_BtnReverse.Location = New System.Drawing.Point(6, 44)
        Me.Ex2_3_BtnReverse.Name = "Ex2_3_BtnReverse"
        Me.Ex2_3_BtnReverse.Size = New System.Drawing.Size(225, 23)
        Me.Ex2_3_BtnReverse.TabIndex = 2
        Me.Ex2_3_BtnReverse.Text = "Reverse Letters"
        Me.Ex2_3_BtnReverse.UseVisualStyleBackColor = True
        '
        'Ex2_3_TxtWord
        '
        Me.Ex2_3_TxtWord.Location = New System.Drawing.Point(75, 19)
        Me.Ex2_3_TxtWord.Name = "Ex2_3_TxtWord"
        Me.Ex2_3_TxtWord.Size = New System.Drawing.Size(156, 20)
        Me.Ex2_3_TxtWord.TabIndex = 1
        '
        'Ex2_3_LblWord
        '
        Me.Ex2_3_LblWord.AutoSize = True
        Me.Ex2_3_LblWord.Location = New System.Drawing.Point(7, 22)
        Me.Ex2_3_LblWord.Name = "Ex2_3_LblWord"
        Me.Ex2_3_LblWord.Size = New System.Drawing.Size(64, 13)
        Me.Ex2_3_LblWord.TabIndex = 0
        Me.Ex2_3_LblWord.Text = "Enter Word:"
        '
        'Ex2_2_GbIndexValues
        '
        Me.Ex2_2_GbIndexValues.Controls.Add(Me.Ex2_2_TxtStep)
        Me.Ex2_2_GbIndexValues.Controls.Add(Me.Ex2_2_LstValues)
        Me.Ex2_2_GbIndexValues.Controls.Add(Me.Ex2_2_TxtEnd)
        Me.Ex2_2_GbIndexValues.Controls.Add(Me.Ex2_2_BtnDisplay)
        Me.Ex2_2_GbIndexValues.Controls.Add(Me.Ex2_2_LblN)
        Me.Ex2_2_GbIndexValues.Controls.Add(Me.Ex2_2_LblS)
        Me.Ex2_2_GbIndexValues.Location = New System.Drawing.Point(279, 13)
        Me.Ex2_2_GbIndexValues.Name = "Ex2_2_GbIndexValues"
        Me.Ex2_2_GbIndexValues.Size = New System.Drawing.Size(283, 198)
        Me.Ex2_2_GbIndexValues.TabIndex = 11
        Me.Ex2_2_GbIndexValues.TabStop = False
        Me.Ex2_2_GbIndexValues.Text = "Index Values"
        '
        'Ex2_2_TxtStep
        '
        Me.Ex2_2_TxtStep.Location = New System.Drawing.Point(170, 19)
        Me.Ex2_2_TxtStep.Name = "Ex2_2_TxtStep"
        Me.Ex2_2_TxtStep.Size = New System.Drawing.Size(63, 20)
        Me.Ex2_2_TxtStep.TabIndex = 18
        '
        'Ex2_2_LstValues
        '
        Me.Ex2_2_LstValues.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex2_2_LstValues.FormattingEnabled = True
        Me.Ex2_2_LstValues.ItemHeight = 14
        Me.Ex2_2_LstValues.Location = New System.Drawing.Point(24, 72)
        Me.Ex2_2_LstValues.Name = "Ex2_2_LstValues"
        Me.Ex2_2_LstValues.Size = New System.Drawing.Size(225, 102)
        Me.Ex2_2_LstValues.TabIndex = 5
        '
        'Ex2_2_TxtEnd
        '
        Me.Ex2_2_TxtEnd.Location = New System.Drawing.Point(43, 19)
        Me.Ex2_2_TxtEnd.Name = "Ex2_2_TxtEnd"
        Me.Ex2_2_TxtEnd.Size = New System.Drawing.Size(70, 20)
        Me.Ex2_2_TxtEnd.TabIndex = 17
        '
        'Ex2_2_BtnDisplay
        '
        Me.Ex2_2_BtnDisplay.Location = New System.Drawing.Point(6, 45)
        Me.Ex2_2_BtnDisplay.Name = "Ex2_2_BtnDisplay"
        Me.Ex2_2_BtnDisplay.Size = New System.Drawing.Size(259, 23)
        Me.Ex2_2_BtnDisplay.TabIndex = 4
        Me.Ex2_2_BtnDisplay.Text = "Display Values of Index"
        Me.Ex2_2_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex2_2_LblN
        '
        Me.Ex2_2_LblN.AutoSize = True
        Me.Ex2_2_LblN.Location = New System.Drawing.Point(19, 22)
        Me.Ex2_2_LblN.Name = "Ex2_2_LblN"
        Me.Ex2_2_LblN.Size = New System.Drawing.Size(18, 13)
        Me.Ex2_2_LblN.TabIndex = 0
        Me.Ex2_2_LblN.Text = "N:"
        '
        'Ex2_2_LblS
        '
        Me.Ex2_2_LblS.AutoSize = True
        Me.Ex2_2_LblS.Location = New System.Drawing.Point(147, 22)
        Me.Ex2_2_LblS.Name = "Ex2_2_LblS"
        Me.Ex2_2_LblS.Size = New System.Drawing.Size(17, 13)
        Me.Ex2_2_LblS.TabIndex = 1
        Me.Ex2_2_LblS.Text = "S:"
        '
        'Ex1_4_GbMovieQuotes
        '
        Me.Ex1_4_GbMovieQuotes.Controls.Add(Me.Ex1_2_TxtOutput)
        Me.Ex1_4_GbMovieQuotes.Controls.Add(Me.Ex1_2_BtnDisplay)
        Me.Ex1_4_GbMovieQuotes.Location = New System.Drawing.Point(147, 12)
        Me.Ex1_4_GbMovieQuotes.Name = "Ex1_4_GbMovieQuotes"
        Me.Ex1_4_GbMovieQuotes.Size = New System.Drawing.Size(129, 112)
        Me.Ex1_4_GbMovieQuotes.TabIndex = 10
        Me.Ex1_4_GbMovieQuotes.TabStop = False
        Me.Ex1_4_GbMovieQuotes.Text = "Movie Quotations"
        '
        'Ex1_2_TxtOutput
        '
        Me.Ex1_2_TxtOutput.Location = New System.Drawing.Point(7, 72)
        Me.Ex1_2_TxtOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.Ex1_2_TxtOutput.Name = "Ex1_2_TxtOutput"
        Me.Ex1_2_TxtOutput.ReadOnly = True
        Me.Ex1_2_TxtOutput.Size = New System.Drawing.Size(114, 20)
        Me.Ex1_2_TxtOutput.TabIndex = 2
        '
        'Ex1_2_BtnDisplay
        '
        Me.Ex1_2_BtnDisplay.Location = New System.Drawing.Point(7, 20)
        Me.Ex1_2_BtnDisplay.Name = "Ex1_2_BtnDisplay"
        Me.Ex1_2_BtnDisplay.Size = New System.Drawing.Size(116, 23)
        Me.Ex1_2_BtnDisplay.TabIndex = 1
        Me.Ex1_2_BtnDisplay.Text = "Display Quote"
        Me.Ex1_2_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex1_1_GbNumbers
        '
        Me.Ex1_1_GbNumbers.Controls.Add(Me.Ex1_1_BtnDisplay)
        Me.Ex1_1_GbNumbers.Controls.Add(Me.Ex1_1_LstOutput)
        Me.Ex1_1_GbNumbers.Location = New System.Drawing.Point(12, 12)
        Me.Ex1_1_GbNumbers.Name = "Ex1_1_GbNumbers"
        Me.Ex1_1_GbNumbers.Size = New System.Drawing.Size(129, 199)
        Me.Ex1_1_GbNumbers.TabIndex = 9
        Me.Ex1_1_GbNumbers.TabStop = False
        Me.Ex1_1_GbNumbers.Text = "Numbers"
        '
        'Ex1_1_BtnDisplay
        '
        Me.Ex1_1_BtnDisplay.Location = New System.Drawing.Point(7, 20)
        Me.Ex1_1_BtnDisplay.Name = "Ex1_1_BtnDisplay"
        Me.Ex1_1_BtnDisplay.Size = New System.Drawing.Size(116, 23)
        Me.Ex1_1_BtnDisplay.TabIndex = 1
        Me.Ex1_1_BtnDisplay.Text = "Display Numbers"
        Me.Ex1_1_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex1_1_LstOutput
        '
        Me.Ex1_1_LstOutput.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex1_1_LstOutput.FormattingEnabled = True
        Me.Ex1_1_LstOutput.ItemHeight = 14
        Me.Ex1_1_LstOutput.Location = New System.Drawing.Point(7, 46)
        Me.Ex1_1_LstOutput.Name = "Ex1_1_LstOutput"
        Me.Ex1_1_LstOutput.Size = New System.Drawing.Size(116, 130)
        Me.Ex1_1_LstOutput.TabIndex = 0
        '
        'FrmCampbell_Ch6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 552)
        Me.Controls.Add(Me.Ex3_3_GbGrades)
        Me.Controls.Add(Me.Ex3_2_GbFirstTwoLetters)
        Me.Controls.Add(Me.Ex3_1_GbStates)
        Me.Controls.Add(Me.Ex2_4_GbTable)
        Me.Controls.Add(Me.Ex2_3_GbBackwards)
        Me.Controls.Add(Me.Ex2_2_GbIndexValues)
        Me.Controls.Add(Me.Ex1_4_GbMovieQuotes)
        Me.Controls.Add(Me.Ex1_1_GbNumbers)
        Me.Name = "FrmCampbell_Ch6"
        Me.Text = "Campbell CH6 Lab"
        Me.Ex3_3_GbGrades.ResumeLayout(False)
        Me.Ex3_3_GbGrades.PerformLayout()
        Me.Ex3_2_GbFirstTwoLetters.ResumeLayout(False)
        Me.Ex3_2_GbFirstTwoLetters.PerformLayout()
        Me.Ex3_1_GbStates.ResumeLayout(False)
        Me.Ex3_1_GbStates.PerformLayout()
        Me.Ex2_4_GbTable.ResumeLayout(False)
        Me.Ex2_3_GbBackwards.ResumeLayout(False)
        Me.Ex2_3_GbBackwards.PerformLayout()
        Me.Ex2_2_GbIndexValues.ResumeLayout(False)
        Me.Ex2_2_GbIndexValues.PerformLayout()
        Me.Ex1_4_GbMovieQuotes.ResumeLayout(False)
        Me.Ex1_4_GbMovieQuotes.PerformLayout()
        Me.Ex1_1_GbNumbers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ex3_3_GbGrades As GroupBox
    Friend WithEvents Ex3_3_LstGrades As ListBox
    Friend WithEvents Ex3_3_TxtHighest As TextBox
    Friend WithEvents Ex3_3_LblHighest As Label
    Friend WithEvents Ex3_3_TxtAverage As TextBox
    Friend WithEvents Ex3_3_LblAverage As Label
    Friend WithEvents Ex3_3_BtnCalculate As Button
    Friend WithEvents Ex3_3_BtnRecord As Button
    Friend WithEvents Ex3_3_TxtGrade As TextBox
    Friend WithEvents Ex3_3_LblGrade As Label
    Friend WithEvents Ex3_2_GbFirstTwoLetters As GroupBox
    Friend WithEvents Ex3_2_TxtOutput As TextBox
    Friend WithEvents Ex3_2_BtnSearch As Button
    Friend WithEvents Ex3_2_LblFirstTwoLetters As Label
    Friend WithEvents Ex3_2_LblStates As Label
    Friend WithEvents Ex3_2_LstStates As ListBox
    Friend WithEvents Ex3_1_GbStates As GroupBox
    Friend WithEvents Ex3_1_LstLast10 As ListBox
    Friend WithEvents Ex3_1_BtnLast10 As Button
    Friend WithEvents Ex3_1_LblStates As Label
    Friend WithEvents Ex3_1_LstStates As ListBox
    Friend WithEvents Ex2_4_GbTable As GroupBox
    Friend WithEvents Ex2_4_LstTable As ListBox
    Friend WithEvents Ex2_4_BtnDisplay As Button
    Friend WithEvents Ex2_3_GbBackwards As GroupBox
    Friend WithEvents Ex2_3_TxtBackwards As TextBox
    Friend WithEvents Ex2_3_BtnReverse As Button
    Friend WithEvents Ex2_3_TxtWord As TextBox
    Friend WithEvents Ex2_3_LblWord As Label
    Friend WithEvents Ex2_2_GbIndexValues As GroupBox
    Friend WithEvents Ex2_2_LstValues As ListBox
    Friend WithEvents Ex2_2_BtnDisplay As Button
    Friend WithEvents Ex2_2_LblS As Label
    Friend WithEvents Ex2_2_LblN As Label
    Friend WithEvents Ex1_4_GbMovieQuotes As GroupBox
    Friend WithEvents Ex1_2_BtnDisplay As Button
    Friend WithEvents Ex1_1_GbNumbers As GroupBox
    Friend WithEvents Ex1_1_BtnDisplay As Button
    Friend WithEvents Ex1_1_LstOutput As ListBox
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents Ex1_2_TxtOutput As TextBox
    Friend WithEvents Ex2_2_TxtStep As TextBox
    Friend WithEvents Ex2_2_TxtEnd As TextBox
    Friend WithEvents Ex3_2_MtbFirstTwoLetters As MaskedTextBox
End Class
