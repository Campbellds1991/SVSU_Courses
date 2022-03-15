<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CampbellCh71Lab
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
        Me.Ex7_1_GbBowl = New System.Windows.Forms.GroupBox()
        Me.Ex7_1_LblWinner = New System.Windows.Forms.Label()
        Me.Ex7_1_TxtWinner = New System.Windows.Forms.TextBox()
        Me.Ex7_1_BtnWhoWon = New System.Windows.Forms.Button()
        Me.Ex7_1_MtbNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Ex7_1_LblNumber = New System.Windows.Forms.Label()
        Me.Ex7_2_GbBowl = New System.Windows.Forms.GroupBox()
        Me.Ex7_2_LblWinner = New System.Windows.Forms.Label()
        Me.Ex7_2_TxtWinner = New System.Windows.Forms.TextBox()
        Me.Ex7_2_BtnWhoWon = New System.Windows.Forms.Button()
        Me.Ex7_2_MtbNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Ex7_2_LblNumber = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ex7_3_LstValues = New System.Windows.Forms.ListBox()
        Me.Ex7_3_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex7_7_GbStates = New System.Windows.Forms.GroupBox()
        Me.Ex7_7_TxtOutput = New System.Windows.Forms.TextBox()
        Me.Ex7_7_TxtState = New System.Windows.Forms.TextBox()
        Me.Ex7_7_BtnDetermine = New System.Windows.Forms.Button()
        Me.Ex7_7_LblState = New System.Windows.Forms.Label()
        Me.Ex7_8_GbName = New System.Windows.Forms.GroupBox()
        Me.Ex7_8_BtnExtract = New System.Windows.Forms.Button()
        Me.Ex7_8_TxtLast = New System.Windows.Forms.TextBox()
        Me.Ex7_8_TxtFirst = New System.Windows.Forms.TextBox()
        Me.Ex7_8_LblLast = New System.Windows.Forms.Label()
        Me.Ex7_8_LblFirst = New System.Windows.Forms.Label()
        Me.Ex7_8_TxtFull = New System.Windows.Forms.TextBox()
        Me.Ex7_8_LblFull = New System.Windows.Forms.Label()
        Me.Ex7_1_GbBowl.SuspendLayout()
        Me.Ex7_2_GbBowl.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Ex7_7_GbStates.SuspendLayout()
        Me.Ex7_8_GbName.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ex7_1_GbBowl
        '
        Me.Ex7_1_GbBowl.Controls.Add(Me.Ex7_1_LblWinner)
        Me.Ex7_1_GbBowl.Controls.Add(Me.Ex7_1_TxtWinner)
        Me.Ex7_1_GbBowl.Controls.Add(Me.Ex7_1_BtnWhoWon)
        Me.Ex7_1_GbBowl.Controls.Add(Me.Ex7_1_MtbNumber)
        Me.Ex7_1_GbBowl.Controls.Add(Me.Ex7_1_LblNumber)
        Me.Ex7_1_GbBowl.Location = New System.Drawing.Point(12, 12)
        Me.Ex7_1_GbBowl.Name = "Ex7_1_GbBowl"
        Me.Ex7_1_GbBowl.Size = New System.Drawing.Size(358, 145)
        Me.Ex7_1_GbBowl.TabIndex = 0
        Me.Ex7_1_GbBowl.TabStop = False
        Me.Ex7_1_GbBowl.Text = "Early Super Bowls"
        '
        'Ex7_1_LblWinner
        '
        Me.Ex7_1_LblWinner.AutoSize = True
        Me.Ex7_1_LblWinner.Location = New System.Drawing.Point(28, 96)
        Me.Ex7_1_LblWinner.Name = "Ex7_1_LblWinner"
        Me.Ex7_1_LblWinner.Size = New System.Drawing.Size(114, 20)
        Me.Ex7_1_LblWinner.TabIndex = 4
        Me.Ex7_1_LblWinner.Text = "Winning Team:"
        '
        'Ex7_1_TxtWinner
        '
        Me.Ex7_1_TxtWinner.Location = New System.Drawing.Point(148, 93)
        Me.Ex7_1_TxtWinner.Name = "Ex7_1_TxtWinner"
        Me.Ex7_1_TxtWinner.ReadOnly = True
        Me.Ex7_1_TxtWinner.Size = New System.Drawing.Size(175, 26)
        Me.Ex7_1_TxtWinner.TabIndex = 3
        '
        'Ex7_1_BtnWhoWon
        '
        Me.Ex7_1_BtnWhoWon.Location = New System.Drawing.Point(225, 38)
        Me.Ex7_1_BtnWhoWon.Name = "Ex7_1_BtnWhoWon"
        Me.Ex7_1_BtnWhoWon.Size = New System.Drawing.Size(116, 34)
        Me.Ex7_1_BtnWhoWon.TabIndex = 2
        Me.Ex7_1_BtnWhoWon.Text = "Who Won?"
        Me.Ex7_1_BtnWhoWon.UseVisualStyleBackColor = True
        '
        'Ex7_1_MtbNumber
        '
        Me.Ex7_1_MtbNumber.Location = New System.Drawing.Point(168, 42)
        Me.Ex7_1_MtbNumber.Mask = "0"
        Me.Ex7_1_MtbNumber.Name = "Ex7_1_MtbNumber"
        Me.Ex7_1_MtbNumber.Size = New System.Drawing.Size(42, 26)
        Me.Ex7_1_MtbNumber.TabIndex = 1
        '
        'Ex7_1_LblNumber
        '
        Me.Ex7_1_LblNumber.AutoSize = True
        Me.Ex7_1_LblNumber.Location = New System.Drawing.Point(13, 45)
        Me.Ex7_1_LblNumber.Name = "Ex7_1_LblNumber"
        Me.Ex7_1_LblNumber.Size = New System.Drawing.Size(149, 20)
        Me.Ex7_1_LblNumber.TabIndex = 0
        Me.Ex7_1_LblNumber.Text = "Number from 1 to 4:"
        '
        'Ex7_2_GbBowl
        '
        Me.Ex7_2_GbBowl.Controls.Add(Me.Ex7_2_LblWinner)
        Me.Ex7_2_GbBowl.Controls.Add(Me.Ex7_2_TxtWinner)
        Me.Ex7_2_GbBowl.Controls.Add(Me.Ex7_2_BtnWhoWon)
        Me.Ex7_2_GbBowl.Controls.Add(Me.Ex7_2_MtbNumber)
        Me.Ex7_2_GbBowl.Controls.Add(Me.Ex7_2_LblNumber)
        Me.Ex7_2_GbBowl.Location = New System.Drawing.Point(393, 12)
        Me.Ex7_2_GbBowl.Name = "Ex7_2_GbBowl"
        Me.Ex7_2_GbBowl.Size = New System.Drawing.Size(358, 145)
        Me.Ex7_2_GbBowl.TabIndex = 5
        Me.Ex7_2_GbBowl.TabStop = False
        Me.Ex7_2_GbBowl.Text = "Early Super Bowls"
        '
        'Ex7_2_LblWinner
        '
        Me.Ex7_2_LblWinner.AutoSize = True
        Me.Ex7_2_LblWinner.Location = New System.Drawing.Point(28, 96)
        Me.Ex7_2_LblWinner.Name = "Ex7_2_LblWinner"
        Me.Ex7_2_LblWinner.Size = New System.Drawing.Size(114, 20)
        Me.Ex7_2_LblWinner.TabIndex = 4
        Me.Ex7_2_LblWinner.Text = "Winning Team:"
        '
        'Ex7_2_TxtWinner
        '
        Me.Ex7_2_TxtWinner.Location = New System.Drawing.Point(148, 93)
        Me.Ex7_2_TxtWinner.Name = "Ex7_2_TxtWinner"
        Me.Ex7_2_TxtWinner.ReadOnly = True
        Me.Ex7_2_TxtWinner.Size = New System.Drawing.Size(175, 26)
        Me.Ex7_2_TxtWinner.TabIndex = 3
        '
        'Ex7_2_BtnWhoWon
        '
        Me.Ex7_2_BtnWhoWon.Location = New System.Drawing.Point(225, 38)
        Me.Ex7_2_BtnWhoWon.Name = "Ex7_2_BtnWhoWon"
        Me.Ex7_2_BtnWhoWon.Size = New System.Drawing.Size(116, 34)
        Me.Ex7_2_BtnWhoWon.TabIndex = 2
        Me.Ex7_2_BtnWhoWon.Text = "Who Won?"
        Me.Ex7_2_BtnWhoWon.UseVisualStyleBackColor = True
        '
        'Ex7_2_MtbNumber
        '
        Me.Ex7_2_MtbNumber.Location = New System.Drawing.Point(168, 42)
        Me.Ex7_2_MtbNumber.Mask = "0"
        Me.Ex7_2_MtbNumber.Name = "Ex7_2_MtbNumber"
        Me.Ex7_2_MtbNumber.Size = New System.Drawing.Size(42, 26)
        Me.Ex7_2_MtbNumber.TabIndex = 1
        '
        'Ex7_2_LblNumber
        '
        Me.Ex7_2_LblNumber.AutoSize = True
        Me.Ex7_2_LblNumber.Location = New System.Drawing.Point(13, 45)
        Me.Ex7_2_LblNumber.Name = "Ex7_2_LblNumber"
        Me.Ex7_2_LblNumber.Size = New System.Drawing.Size(149, 20)
        Me.Ex7_2_LblNumber.TabIndex = 0
        Me.Ex7_2_LblNumber.Text = "Number from 1 to 4:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ex7_3_LstValues)
        Me.GroupBox1.Controls.Add(Me.Ex7_3_BtnDisplay)
        Me.GroupBox1.Location = New System.Drawing.Point(758, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 266)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Presidential Ages at Inauguration"
        '
        'Ex7_3_LstValues
        '
        Me.Ex7_3_LstValues.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex7_3_LstValues.FormattingEnabled = True
        Me.Ex7_3_LstValues.ItemHeight = 18
        Me.Ex7_3_LstValues.Location = New System.Drawing.Point(6, 73)
        Me.Ex7_3_LstValues.Name = "Ex7_3_LstValues"
        Me.Ex7_3_LstValues.Size = New System.Drawing.Size(270, 184)
        Me.Ex7_3_LstValues.TabIndex = 1
        '
        'Ex7_3_BtnDisplay
        '
        Me.Ex7_3_BtnDisplay.Location = New System.Drawing.Point(6, 28)
        Me.Ex7_3_BtnDisplay.Name = "Ex7_3_BtnDisplay"
        Me.Ex7_3_BtnDisplay.Size = New System.Drawing.Size(270, 39)
        Me.Ex7_3_BtnDisplay.TabIndex = 0
        Me.Ex7_3_BtnDisplay.Text = "Display Values"
        Me.Ex7_3_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex7_7_GbStates
        '
        Me.Ex7_7_GbStates.Controls.Add(Me.Ex7_7_TxtOutput)
        Me.Ex7_7_GbStates.Controls.Add(Me.Ex7_7_TxtState)
        Me.Ex7_7_GbStates.Controls.Add(Me.Ex7_7_BtnDetermine)
        Me.Ex7_7_GbStates.Controls.Add(Me.Ex7_7_LblState)
        Me.Ex7_7_GbStates.Location = New System.Drawing.Point(12, 163)
        Me.Ex7_7_GbStates.Name = "Ex7_7_GbStates"
        Me.Ex7_7_GbStates.Size = New System.Drawing.Size(358, 167)
        Me.Ex7_7_GbStates.TabIndex = 7
        Me.Ex7_7_GbStates.TabStop = False
        Me.Ex7_7_GbStates.Text = "U.S. States"
        '
        'Ex7_7_TxtOutput
        '
        Me.Ex7_7_TxtOutput.Location = New System.Drawing.Point(32, 113)
        Me.Ex7_7_TxtOutput.Name = "Ex7_7_TxtOutput"
        Me.Ex7_7_TxtOutput.ReadOnly = True
        Me.Ex7_7_TxtOutput.Size = New System.Drawing.Size(291, 26)
        Me.Ex7_7_TxtOutput.TabIndex = 3
        '
        'Ex7_7_TxtState
        '
        Me.Ex7_7_TxtState.Location = New System.Drawing.Point(130, 33)
        Me.Ex7_7_TxtState.Name = "Ex7_7_TxtState"
        Me.Ex7_7_TxtState.Size = New System.Drawing.Size(193, 26)
        Me.Ex7_7_TxtState.TabIndex = 2
        '
        'Ex7_7_BtnDetermine
        '
        Me.Ex7_7_BtnDetermine.Location = New System.Drawing.Point(32, 73)
        Me.Ex7_7_BtnDetermine.Name = "Ex7_7_BtnDetermine"
        Me.Ex7_7_BtnDetermine.Size = New System.Drawing.Size(292, 34)
        Me.Ex7_7_BtnDetermine.TabIndex = 1
        Me.Ex7_7_BtnDetermine.Text = "Determine Order"
        Me.Ex7_7_BtnDetermine.UseVisualStyleBackColor = True
        '
        'Ex7_7_LblState
        '
        Me.Ex7_7_LblState.AutoSize = True
        Me.Ex7_7_LblState.Location = New System.Drawing.Point(26, 39)
        Me.Ex7_7_LblState.Name = "Ex7_7_LblState"
        Me.Ex7_7_LblState.Size = New System.Drawing.Size(98, 20)
        Me.Ex7_7_LblState.TabIndex = 0
        Me.Ex7_7_LblState.Text = "State Name:"
        '
        'Ex7_8_GbName
        '
        Me.Ex7_8_GbName.Controls.Add(Me.Ex7_8_BtnExtract)
        Me.Ex7_8_GbName.Controls.Add(Me.Ex7_8_TxtLast)
        Me.Ex7_8_GbName.Controls.Add(Me.Ex7_8_TxtFirst)
        Me.Ex7_8_GbName.Controls.Add(Me.Ex7_8_LblLast)
        Me.Ex7_8_GbName.Controls.Add(Me.Ex7_8_LblFirst)
        Me.Ex7_8_GbName.Controls.Add(Me.Ex7_8_TxtFull)
        Me.Ex7_8_GbName.Controls.Add(Me.Ex7_8_LblFull)
        Me.Ex7_8_GbName.Location = New System.Drawing.Point(377, 164)
        Me.Ex7_8_GbName.Name = "Ex7_8_GbName"
        Me.Ex7_8_GbName.Size = New System.Drawing.Size(375, 231)
        Me.Ex7_8_GbName.TabIndex = 8
        Me.Ex7_8_GbName.TabStop = False
        Me.Ex7_8_GbName.Text = "Parse a Name"
        '
        'Ex7_8_BtnExtract
        '
        Me.Ex7_8_BtnExtract.Location = New System.Drawing.Point(33, 82)
        Me.Ex7_8_BtnExtract.Name = "Ex7_8_BtnExtract"
        Me.Ex7_8_BtnExtract.Size = New System.Drawing.Size(324, 33)
        Me.Ex7_8_BtnExtract.TabIndex = 6
        Me.Ex7_8_BtnExtract.Text = "Extract First and Last Names"
        Me.Ex7_8_BtnExtract.UseVisualStyleBackColor = True
        '
        'Ex7_8_TxtLast
        '
        Me.Ex7_8_TxtLast.Location = New System.Drawing.Point(164, 175)
        Me.Ex7_8_TxtLast.Name = "Ex7_8_TxtLast"
        Me.Ex7_8_TxtLast.ReadOnly = True
        Me.Ex7_8_TxtLast.Size = New System.Drawing.Size(148, 26)
        Me.Ex7_8_TxtLast.TabIndex = 5
        '
        'Ex7_8_TxtFirst
        '
        Me.Ex7_8_TxtFirst.Location = New System.Drawing.Point(164, 127)
        Me.Ex7_8_TxtFirst.Name = "Ex7_8_TxtFirst"
        Me.Ex7_8_TxtFirst.ReadOnly = True
        Me.Ex7_8_TxtFirst.Size = New System.Drawing.Size(148, 26)
        Me.Ex7_8_TxtFirst.TabIndex = 4
        '
        'Ex7_8_LblLast
        '
        Me.Ex7_8_LblLast.AutoSize = True
        Me.Ex7_8_LblLast.Location = New System.Drawing.Point(68, 178)
        Me.Ex7_8_LblLast.Name = "Ex7_8_LblLast"
        Me.Ex7_8_LblLast.Size = New System.Drawing.Size(90, 20)
        Me.Ex7_8_LblLast.TabIndex = 3
        Me.Ex7_8_LblLast.Text = "Last Name:"
        '
        'Ex7_8_LblFirst
        '
        Me.Ex7_8_LblFirst.AutoSize = True
        Me.Ex7_8_LblFirst.Location = New System.Drawing.Point(68, 130)
        Me.Ex7_8_LblFirst.Name = "Ex7_8_LblFirst"
        Me.Ex7_8_LblFirst.Size = New System.Drawing.Size(90, 20)
        Me.Ex7_8_LblFirst.TabIndex = 2
        Me.Ex7_8_LblFirst.Text = "First Name:"
        '
        'Ex7_8_TxtFull
        '
        Me.Ex7_8_TxtFull.Location = New System.Drawing.Point(125, 35)
        Me.Ex7_8_TxtFull.Name = "Ex7_8_TxtFull"
        Me.Ex7_8_TxtFull.Size = New System.Drawing.Size(232, 26)
        Me.Ex7_8_TxtFull.TabIndex = 1
        '
        'Ex7_8_LblFull
        '
        Me.Ex7_8_LblFull.AutoSize = True
        Me.Ex7_8_LblFull.Location = New System.Drawing.Point(29, 38)
        Me.Ex7_8_LblFull.Name = "Ex7_8_LblFull"
        Me.Ex7_8_LblFull.Size = New System.Drawing.Size(82, 20)
        Me.Ex7_8_LblFull.TabIndex = 0
        Me.Ex7_8_LblFull.Text = "Full name:"
        '
        'CampbellCh71Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 450)
        Me.Controls.Add(Me.Ex7_8_GbName)
        Me.Controls.Add(Me.Ex7_7_GbStates)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Ex7_2_GbBowl)
        Me.Controls.Add(Me.Ex7_1_GbBowl)
        Me.Name = "CampbellCh71Lab"
        Me.Text = "Campbell Ch7.1 Lab"
        Me.Ex7_1_GbBowl.ResumeLayout(False)
        Me.Ex7_1_GbBowl.PerformLayout()
        Me.Ex7_2_GbBowl.ResumeLayout(False)
        Me.Ex7_2_GbBowl.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Ex7_7_GbStates.ResumeLayout(False)
        Me.Ex7_7_GbStates.PerformLayout()
        Me.Ex7_8_GbName.ResumeLayout(False)
        Me.Ex7_8_GbName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ex7_1_GbBowl As GroupBox
    Friend WithEvents Ex7_1_LblWinner As Label
    Friend WithEvents Ex7_1_TxtWinner As TextBox
    Friend WithEvents Ex7_1_BtnWhoWon As Button
    Friend WithEvents Ex7_1_MtbNumber As MaskedTextBox
    Friend WithEvents Ex7_1_LblNumber As Label
    Friend WithEvents Ex7_2_GbBowl As GroupBox
    Friend WithEvents Ex7_2_LblWinner As Label
    Friend WithEvents Ex7_2_TxtWinner As TextBox
    Friend WithEvents Ex7_2_BtnWhoWon As Button
    Friend WithEvents Ex7_2_MtbNumber As MaskedTextBox
    Friend WithEvents Ex7_2_LblNumber As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Ex7_3_LstValues As ListBox
    Friend WithEvents Ex7_3_BtnDisplay As Button
    Friend WithEvents Ex7_7_GbStates As GroupBox
    Friend WithEvents Ex7_7_TxtOutput As TextBox
    Friend WithEvents Ex7_7_TxtState As TextBox
    Friend WithEvents Ex7_7_BtnDetermine As Button
    Friend WithEvents Ex7_7_LblState As Label
    Friend WithEvents Ex7_8_GbName As GroupBox
    Friend WithEvents Ex7_8_BtnExtract As Button
    Friend WithEvents Ex7_8_TxtLast As TextBox
    Friend WithEvents Ex7_8_TxtFirst As TextBox
    Friend WithEvents Ex7_8_LblLast As Label
    Friend WithEvents Ex7_8_LblFirst As Label
    Friend WithEvents Ex7_8_TxtFull As TextBox
    Friend WithEvents Ex7_8_LblFull As Label
End Class
