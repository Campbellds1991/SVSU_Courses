<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Campbell_Ch5_Lab
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
        Me.Ex5_21_GbSums = New System.Windows.Forms.GroupBox()
        Me.Ex5_21_LstOutput = New System.Windows.Forms.ListBox()
        Me.Ex5_21_BtnAddNumbers = New System.Windows.Forms.Button()
        Me.Ex5_22_GbDensity = New System.Windows.Forms.GroupBox()
        Me.Ex5_22_LstDensity = New System.Windows.Forms.ListBox()
        Me.Ex5_22_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex5_24_GbCallSub = New System.Windows.Forms.GroupBox()
        Me.Ex5_24_LstOutput = New System.Windows.Forms.ListBox()
        Me.Ex5_24_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex5_31_GbPassByValue = New System.Windows.Forms.GroupBox()
        Me.Ex5_31_LstOutput = New System.Windows.Forms.ListBox()
        Me.Ex5_31_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex5_32_GbAdd = New System.Windows.Forms.GroupBox()
        Me.Ex5_32_TxtResult = New System.Windows.Forms.TextBox()
        Me.Ex5_32_TxtSecondNum = New System.Windows.Forms.TextBox()
        Me.Ex5_32_TxtFirstNum = New System.Windows.Forms.TextBox()
        Me.Ex5_32_BtnCompute = New System.Windows.Forms.Button()
        Me.Ex5_32_LblSecondNum = New System.Windows.Forms.Label()
        Me.Ex5_32_LblFirstNum = New System.Windows.Forms.Label()
        Me.Ex5_33_GbWords = New System.Windows.Forms.GroupBox()
        Me.Ex5_33_TxtOutput = New System.Windows.Forms.TextBox()
        Me.Ex5_33_TxtSecond = New System.Windows.Forms.TextBox()
        Me.Ex5_33_TxtFirst = New System.Windows.Forms.TextBox()
        Me.Ex5_33_BtnSort = New System.Windows.Forms.Button()
        Me.Ex5_33_LblSecond = New System.Windows.Forms.Label()
        Me.Ex5_33_LblFirst = New System.Windows.Forms.Label()
        Me.Ex5_21_GbSums.SuspendLayout()
        Me.Ex5_22_GbDensity.SuspendLayout()
        Me.Ex5_24_GbCallSub.SuspendLayout()
        Me.Ex5_31_GbPassByValue.SuspendLayout()
        Me.Ex5_32_GbAdd.SuspendLayout()
        Me.Ex5_33_GbWords.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ex5_21_GbSums
        '
        Me.Ex5_21_GbSums.Controls.Add(Me.Ex5_21_LstOutput)
        Me.Ex5_21_GbSums.Controls.Add(Me.Ex5_21_BtnAddNumbers)
        Me.Ex5_21_GbSums.Location = New System.Drawing.Point(30, 34)
        Me.Ex5_21_GbSums.Name = "Ex5_21_GbSums"
        Me.Ex5_21_GbSums.Size = New System.Drawing.Size(318, 256)
        Me.Ex5_21_GbSums.TabIndex = 0
        Me.Ex5_21_GbSums.TabStop = False
        Me.Ex5_21_GbSums.Text = "Sums"
        '
        'Ex5_21_LstOutput
        '
        Me.Ex5_21_LstOutput.FormattingEnabled = True
        Me.Ex5_21_LstOutput.ItemHeight = 20
        Me.Ex5_21_LstOutput.Location = New System.Drawing.Point(13, 107)
        Me.Ex5_21_LstOutput.Name = "Ex5_21_LstOutput"
        Me.Ex5_21_LstOutput.Size = New System.Drawing.Size(276, 124)
        Me.Ex5_21_LstOutput.TabIndex = 1
        '
        'Ex5_21_BtnAddNumbers
        '
        Me.Ex5_21_BtnAddNumbers.Location = New System.Drawing.Point(13, 36)
        Me.Ex5_21_BtnAddNumbers.Name = "Ex5_21_BtnAddNumbers"
        Me.Ex5_21_BtnAddNumbers.Size = New System.Drawing.Size(276, 51)
        Me.Ex5_21_BtnAddNumbers.TabIndex = 0
        Me.Ex5_21_BtnAddNumbers.Text = "Display Three Sums"
        Me.Ex5_21_BtnAddNumbers.UseVisualStyleBackColor = True
        '
        'Ex5_22_GbDensity
        '
        Me.Ex5_22_GbDensity.Controls.Add(Me.Ex5_22_LstDensity)
        Me.Ex5_22_GbDensity.Controls.Add(Me.Ex5_22_BtnDisplay)
        Me.Ex5_22_GbDensity.Location = New System.Drawing.Point(378, 45)
        Me.Ex5_22_GbDensity.Name = "Ex5_22_GbDensity"
        Me.Ex5_22_GbDensity.Size = New System.Drawing.Size(318, 245)
        Me.Ex5_22_GbDensity.TabIndex = 1
        Me.Ex5_22_GbDensity.TabStop = False
        Me.Ex5_22_GbDensity.Text = "Density"
        '
        'Ex5_22_LstDensity
        '
        Me.Ex5_22_LstDensity.FormattingEnabled = True
        Me.Ex5_22_LstDensity.ItemHeight = 20
        Me.Ex5_22_LstDensity.Location = New System.Drawing.Point(31, 96)
        Me.Ex5_22_LstDensity.Name = "Ex5_22_LstDensity"
        Me.Ex5_22_LstDensity.Size = New System.Drawing.Size(258, 124)
        Me.Ex5_22_LstDensity.TabIndex = 1
        '
        'Ex5_22_BtnDisplay
        '
        Me.Ex5_22_BtnDisplay.Location = New System.Drawing.Point(31, 25)
        Me.Ex5_22_BtnDisplay.Name = "Ex5_22_BtnDisplay"
        Me.Ex5_22_BtnDisplay.Size = New System.Drawing.Size(258, 51)
        Me.Ex5_22_BtnDisplay.TabIndex = 0
        Me.Ex5_22_BtnDisplay.Text = "Display Demographics"
        Me.Ex5_22_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex5_24_GbCallSub
        '
        Me.Ex5_24_GbCallSub.Controls.Add(Me.Ex5_24_LstOutput)
        Me.Ex5_24_GbCallSub.Controls.Add(Me.Ex5_24_BtnDisplay)
        Me.Ex5_24_GbCallSub.Location = New System.Drawing.Point(731, 45)
        Me.Ex5_24_GbCallSub.Name = "Ex5_24_GbCallSub"
        Me.Ex5_24_GbCallSub.Size = New System.Drawing.Size(318, 245)
        Me.Ex5_24_GbCallSub.TabIndex = 2
        Me.Ex5_24_GbCallSub.TabStop = False
        Me.Ex5_24_GbCallSub.Text = "Call Sub Procedures"
        '
        'Ex5_24_LstOutput
        '
        Me.Ex5_24_LstOutput.FormattingEnabled = True
        Me.Ex5_24_LstOutput.ItemHeight = 20
        Me.Ex5_24_LstOutput.Location = New System.Drawing.Point(31, 96)
        Me.Ex5_24_LstOutput.Name = "Ex5_24_LstOutput"
        Me.Ex5_24_LstOutput.Size = New System.Drawing.Size(258, 124)
        Me.Ex5_24_LstOutput.TabIndex = 1
        '
        'Ex5_24_BtnDisplay
        '
        Me.Ex5_24_BtnDisplay.Location = New System.Drawing.Point(31, 25)
        Me.Ex5_24_BtnDisplay.Name = "Ex5_24_BtnDisplay"
        Me.Ex5_24_BtnDisplay.Size = New System.Drawing.Size(258, 51)
        Me.Ex5_24_BtnDisplay.TabIndex = 0
        Me.Ex5_24_BtnDisplay.Text = "Display Output"
        Me.Ex5_24_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex5_31_GbPassByValue
        '
        Me.Ex5_31_GbPassByValue.Controls.Add(Me.Ex5_31_LstOutput)
        Me.Ex5_31_GbPassByValue.Controls.Add(Me.Ex5_31_BtnDisplay)
        Me.Ex5_31_GbPassByValue.Location = New System.Drawing.Point(30, 324)
        Me.Ex5_31_GbPassByValue.Name = "Ex5_31_GbPassByValue"
        Me.Ex5_31_GbPassByValue.Size = New System.Drawing.Size(318, 245)
        Me.Ex5_31_GbPassByValue.TabIndex = 2
        Me.Ex5_31_GbPassByValue.TabStop = False
        Me.Ex5_31_GbPassByValue.Text = "Pass By Val"
        '
        'Ex5_31_LstOutput
        '
        Me.Ex5_31_LstOutput.FormattingEnabled = True
        Me.Ex5_31_LstOutput.ItemHeight = 20
        Me.Ex5_31_LstOutput.Location = New System.Drawing.Point(31, 96)
        Me.Ex5_31_LstOutput.Name = "Ex5_31_LstOutput"
        Me.Ex5_31_LstOutput.Size = New System.Drawing.Size(258, 124)
        Me.Ex5_31_LstOutput.TabIndex = 1
        '
        'Ex5_31_BtnDisplay
        '
        Me.Ex5_31_BtnDisplay.Location = New System.Drawing.Point(31, 25)
        Me.Ex5_31_BtnDisplay.Name = "Ex5_31_BtnDisplay"
        Me.Ex5_31_BtnDisplay.Size = New System.Drawing.Size(258, 51)
        Me.Ex5_31_BtnDisplay.TabIndex = 0
        Me.Ex5_31_BtnDisplay.Text = "Display Output"
        Me.Ex5_31_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex5_32_GbAdd
        '
        Me.Ex5_32_GbAdd.Controls.Add(Me.Ex5_32_TxtResult)
        Me.Ex5_32_GbAdd.Controls.Add(Me.Ex5_32_TxtSecondNum)
        Me.Ex5_32_GbAdd.Controls.Add(Me.Ex5_32_TxtFirstNum)
        Me.Ex5_32_GbAdd.Controls.Add(Me.Ex5_32_BtnCompute)
        Me.Ex5_32_GbAdd.Controls.Add(Me.Ex5_32_LblSecondNum)
        Me.Ex5_32_GbAdd.Controls.Add(Me.Ex5_32_LblFirstNum)
        Me.Ex5_32_GbAdd.Location = New System.Drawing.Point(378, 324)
        Me.Ex5_32_GbAdd.Name = "Ex5_32_GbAdd"
        Me.Ex5_32_GbAdd.Size = New System.Drawing.Size(318, 245)
        Me.Ex5_32_GbAdd.TabIndex = 2
        Me.Ex5_32_GbAdd.TabStop = False
        Me.Ex5_32_GbAdd.Text = "Density"
        '
        'Ex5_32_TxtResult
        '
        Me.Ex5_32_TxtResult.Location = New System.Drawing.Point(25, 166)
        Me.Ex5_32_TxtResult.Name = "Ex5_32_TxtResult"
        Me.Ex5_32_TxtResult.ReadOnly = True
        Me.Ex5_32_TxtResult.Size = New System.Drawing.Size(248, 26)
        Me.Ex5_32_TxtResult.TabIndex = 5
        '
        'Ex5_32_TxtSecondNum
        '
        Me.Ex5_32_TxtSecondNum.Location = New System.Drawing.Point(160, 75)
        Me.Ex5_32_TxtSecondNum.Name = "Ex5_32_TxtSecondNum"
        Me.Ex5_32_TxtSecondNum.Size = New System.Drawing.Size(100, 26)
        Me.Ex5_32_TxtSecondNum.TabIndex = 4
        '
        'Ex5_32_TxtFirstNum
        '
        Me.Ex5_32_TxtFirstNum.Location = New System.Drawing.Point(160, 37)
        Me.Ex5_32_TxtFirstNum.Name = "Ex5_32_TxtFirstNum"
        Me.Ex5_32_TxtFirstNum.Size = New System.Drawing.Size(100, 26)
        Me.Ex5_32_TxtFirstNum.TabIndex = 3
        '
        'Ex5_32_BtnCompute
        '
        Me.Ex5_32_BtnCompute.Location = New System.Drawing.Point(62, 121)
        Me.Ex5_32_BtnCompute.Name = "Ex5_32_BtnCompute"
        Me.Ex5_32_BtnCompute.Size = New System.Drawing.Size(176, 29)
        Me.Ex5_32_BtnCompute.TabIndex = 2
        Me.Ex5_32_BtnCompute.Text = "Compute Sum"
        Me.Ex5_32_BtnCompute.UseVisualStyleBackColor = True
        '
        'Ex5_32_LblSecondNum
        '
        Me.Ex5_32_LblSecondNum.AutoSize = True
        Me.Ex5_32_LblSecondNum.Location = New System.Drawing.Point(26, 78)
        Me.Ex5_32_LblSecondNum.Name = "Ex5_32_LblSecondNum"
        Me.Ex5_32_LblSecondNum.Size = New System.Drawing.Size(128, 20)
        Me.Ex5_32_LblSecondNum.TabIndex = 1
        Me.Ex5_32_LblSecondNum.Text = "Second Number:"
        '
        'Ex5_32_LblFirstNum
        '
        Me.Ex5_32_LblFirstNum.AutoSize = True
        Me.Ex5_32_LblFirstNum.Location = New System.Drawing.Point(50, 40)
        Me.Ex5_32_LblFirstNum.Name = "Ex5_32_LblFirstNum"
        Me.Ex5_32_LblFirstNum.Size = New System.Drawing.Size(104, 20)
        Me.Ex5_32_LblFirstNum.TabIndex = 0
        Me.Ex5_32_LblFirstNum.Text = "First Number:"
        '
        'Ex5_33_GbWords
        '
        Me.Ex5_33_GbWords.Controls.Add(Me.Ex5_33_TxtOutput)
        Me.Ex5_33_GbWords.Controls.Add(Me.Ex5_33_TxtSecond)
        Me.Ex5_33_GbWords.Controls.Add(Me.Ex5_33_TxtFirst)
        Me.Ex5_33_GbWords.Controls.Add(Me.Ex5_33_BtnSort)
        Me.Ex5_33_GbWords.Controls.Add(Me.Ex5_33_LblSecond)
        Me.Ex5_33_GbWords.Controls.Add(Me.Ex5_33_LblFirst)
        Me.Ex5_33_GbWords.Location = New System.Drawing.Point(731, 324)
        Me.Ex5_33_GbWords.Name = "Ex5_33_GbWords"
        Me.Ex5_33_GbWords.Size = New System.Drawing.Size(318, 245)
        Me.Ex5_33_GbWords.TabIndex = 2
        Me.Ex5_33_GbWords.TabStop = False
        Me.Ex5_33_GbWords.Text = "Alphabetize"
        '
        'Ex5_33_TxtOutput
        '
        Me.Ex5_33_TxtOutput.Location = New System.Drawing.Point(35, 163)
        Me.Ex5_33_TxtOutput.Name = "Ex5_33_TxtOutput"
        Me.Ex5_33_TxtOutput.ReadOnly = True
        Me.Ex5_33_TxtOutput.Size = New System.Drawing.Size(248, 26)
        Me.Ex5_33_TxtOutput.TabIndex = 11
        '
        'Ex5_33_TxtSecond
        '
        Me.Ex5_33_TxtSecond.Location = New System.Drawing.Point(123, 72)
        Me.Ex5_33_TxtSecond.Name = "Ex5_33_TxtSecond"
        Me.Ex5_33_TxtSecond.Size = New System.Drawing.Size(147, 26)
        Me.Ex5_33_TxtSecond.TabIndex = 10
        '
        'Ex5_33_TxtFirst
        '
        Me.Ex5_33_TxtFirst.Location = New System.Drawing.Point(123, 34)
        Me.Ex5_33_TxtFirst.Name = "Ex5_33_TxtFirst"
        Me.Ex5_33_TxtFirst.Size = New System.Drawing.Size(147, 26)
        Me.Ex5_33_TxtFirst.TabIndex = 9
        '
        'Ex5_33_BtnSort
        '
        Me.Ex5_33_BtnSort.Location = New System.Drawing.Point(72, 118)
        Me.Ex5_33_BtnSort.Name = "Ex5_33_BtnSort"
        Me.Ex5_33_BtnSort.Size = New System.Drawing.Size(176, 29)
        Me.Ex5_33_BtnSort.TabIndex = 8
        Me.Ex5_33_BtnSort.Text = "Sort and Display Words"
        Me.Ex5_33_BtnSort.UseVisualStyleBackColor = True
        '
        'Ex5_33_LblSecond
        '
        Me.Ex5_33_LblSecond.AutoSize = True
        Me.Ex5_33_LblSecond.Location = New System.Drawing.Point(7, 78)
        Me.Ex5_33_LblSecond.Name = "Ex5_33_LblSecond"
        Me.Ex5_33_LblSecond.Size = New System.Drawing.Size(110, 20)
        Me.Ex5_33_LblSecond.TabIndex = 7
        Me.Ex5_33_LblSecond.Text = "Second Word:"
        '
        'Ex5_33_LblFirst
        '
        Me.Ex5_33_LblFirst.AutoSize = True
        Me.Ex5_33_LblFirst.Location = New System.Drawing.Point(31, 37)
        Me.Ex5_33_LblFirst.Name = "Ex5_33_LblFirst"
        Me.Ex5_33_LblFirst.Size = New System.Drawing.Size(86, 20)
        Me.Ex5_33_LblFirst.TabIndex = 6
        Me.Ex5_33_LblFirst.Text = "First Word:"
        '
        'Campbell_Ch5_Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 647)
        Me.Controls.Add(Me.Ex5_33_GbWords)
        Me.Controls.Add(Me.Ex5_32_GbAdd)
        Me.Controls.Add(Me.Ex5_31_GbPassByValue)
        Me.Controls.Add(Me.Ex5_24_GbCallSub)
        Me.Controls.Add(Me.Ex5_22_GbDensity)
        Me.Controls.Add(Me.Ex5_21_GbSums)
        Me.Name = "Campbell_Ch5_Lab"
        Me.Text = "Campbell Ch5 Section 2 & 3 "
        Me.Ex5_21_GbSums.ResumeLayout(False)
        Me.Ex5_22_GbDensity.ResumeLayout(False)
        Me.Ex5_24_GbCallSub.ResumeLayout(False)
        Me.Ex5_31_GbPassByValue.ResumeLayout(False)
        Me.Ex5_32_GbAdd.ResumeLayout(False)
        Me.Ex5_32_GbAdd.PerformLayout()
        Me.Ex5_33_GbWords.ResumeLayout(False)
        Me.Ex5_33_GbWords.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ex5_21_GbSums As GroupBox
    Friend WithEvents Ex5_21_LstOutput As ListBox
    Friend WithEvents Ex5_21_BtnAddNumbers As Button
    Friend WithEvents Ex5_22_GbDensity As GroupBox
    Friend WithEvents Ex5_22_BtnDisplay As Button
    Friend WithEvents Ex5_22_LstDensity As ListBox
    Friend WithEvents Ex5_24_GbCallSub As GroupBox
    Friend WithEvents Ex5_24_LstOutput As ListBox
    Friend WithEvents Ex5_24_BtnDisplay As Button
    Friend WithEvents Ex5_31_GbPassByValue As GroupBox
    Friend WithEvents Ex5_31_LstOutput As ListBox
    Friend WithEvents Ex5_31_BtnDisplay As Button
    Friend WithEvents Ex5_32_GbAdd As GroupBox
    Friend WithEvents Ex5_33_GbWords As GroupBox
    Friend WithEvents Ex5_32_TxtResult As TextBox
    Friend WithEvents Ex5_32_TxtSecondNum As TextBox
    Friend WithEvents Ex5_32_TxtFirstNum As TextBox
    Friend WithEvents Ex5_32_BtnCompute As Button
    Friend WithEvents Ex5_32_LblSecondNum As Label
    Friend WithEvents Ex5_32_LblFirstNum As Label
    Friend WithEvents Ex5_33_TxtOutput As TextBox
    Friend WithEvents Ex5_33_TxtSecond As TextBox
    Friend WithEvents Ex5_33_TxtFirst As TextBox
    Friend WithEvents Ex5_33_BtnSort As Button
    Friend WithEvents Ex5_33_LblSecond As Label
    Friend WithEvents Ex5_33_LblFirst As Label
End Class
