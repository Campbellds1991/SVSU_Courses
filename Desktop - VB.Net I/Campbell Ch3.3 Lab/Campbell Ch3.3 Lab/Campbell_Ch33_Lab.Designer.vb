<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Campbell_Ch33_Lab
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
        Me.Ex1GbAge = New System.Windows.Forms.GroupBox()
        Me.Ex1MtbDayOfBirth = New System.Windows.Forms.MaskedTextBox()
        Me.Ex1LblAgeInDays = New System.Windows.Forms.Label()
        Me.Ex1LblToday = New System.Windows.Forms.Label()
        Me.Ex1LblFullDateOfBirth = New System.Windows.Forms.Label()
        Me.Ex1TxtAgeInDays = New System.Windows.Forms.TextBox()
        Me.Ex1TxtToday = New System.Windows.Forms.TextBox()
        Me.Ex1BtnComputeBirth = New System.Windows.Forms.Button()
        Me.Ex1LblDayOfBirth = New System.Windows.Forms.Label()
        Me.Ex2GbNameAge = New System.Windows.Forms.GroupBox()
        Me.Ex3GbMessageExit = New System.Windows.Forms.GroupBox()
        Me.Ex4GbColleges = New System.Windows.Forms.GroupBox()
        Me.Ex1TxtFullDateOfBirth = New System.Windows.Forms.TextBox()
        Me.Ex2BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex2LblToday = New System.Windows.Forms.Label()
        Me.Ex2TxtToday = New System.Windows.Forms.TextBox()
        Me.Ex2TxtOutput = New System.Windows.Forms.TextBox()
        Me.Ex3BtnClickMe = New System.Windows.Forms.Button()
        Me.Ex3BtnExit = New System.Windows.Forms.Button()
        Me.Ex4LstColleges = New System.Windows.Forms.ListBox()
        Me.Ex4BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex1GbAge.SuspendLayout()
        Me.Ex2GbNameAge.SuspendLayout()
        Me.Ex3GbMessageExit.SuspendLayout()
        Me.Ex4GbColleges.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ex1GbAge
        '
        Me.Ex1GbAge.Controls.Add(Me.Ex1MtbDayOfBirth)
        Me.Ex1GbAge.Controls.Add(Me.Ex1LblAgeInDays)
        Me.Ex1GbAge.Controls.Add(Me.Ex1LblToday)
        Me.Ex1GbAge.Controls.Add(Me.Ex1LblFullDateOfBirth)
        Me.Ex1GbAge.Controls.Add(Me.Ex1TxtAgeInDays)
        Me.Ex1GbAge.Controls.Add(Me.Ex1TxtToday)
        Me.Ex1GbAge.Controls.Add(Me.Ex1TxtFullDateOfBirth)
        Me.Ex1GbAge.Controls.Add(Me.Ex1BtnComputeBirth)
        Me.Ex1GbAge.Controls.Add(Me.Ex1LblDayOfBirth)
        Me.Ex1GbAge.Location = New System.Drawing.Point(35, 21)
        Me.Ex1GbAge.Margin = New System.Windows.Forms.Padding(2)
        Me.Ex1GbAge.Name = "Ex1GbAge"
        Me.Ex1GbAge.Padding = New System.Windows.Forms.Padding(2)
        Me.Ex1GbAge.Size = New System.Drawing.Size(591, 503)
        Me.Ex1GbAge.TabIndex = 12
        Me.Ex1GbAge.TabStop = False
        Me.Ex1GbAge.Text = "Ex 3.1 Age in Days"
        '
        'Ex1MtbDayOfBirth
        '
        Me.Ex1MtbDayOfBirth.Location = New System.Drawing.Point(180, 41)
        Me.Ex1MtbDayOfBirth.Mask = "00/00/0000"
        Me.Ex1MtbDayOfBirth.Name = "Ex1MtbDayOfBirth"
        Me.Ex1MtbDayOfBirth.Size = New System.Drawing.Size(362, 26)
        Me.Ex1MtbDayOfBirth.TabIndex = 21
        Me.Ex1MtbDayOfBirth.ValidatingType = GetType(Date)
        '
        'Ex1LblAgeInDays
        '
        Me.Ex1LblAgeInDays.AutoSize = True
        Me.Ex1LblAgeInDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex1LblAgeInDays.Location = New System.Drawing.Point(35, 362)
        Me.Ex1LblAgeInDays.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Ex1LblAgeInDays.Name = "Ex1LblAgeInDays"
        Me.Ex1LblAgeInDays.Size = New System.Drawing.Size(143, 29)
        Me.Ex1LblAgeInDays.TabIndex = 20
        Me.Ex1LblAgeInDays.Text = "Age in days:"
        '
        'Ex1LblToday
        '
        Me.Ex1LblToday.AutoSize = True
        Me.Ex1LblToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex1LblToday.Location = New System.Drawing.Point(21, 281)
        Me.Ex1LblToday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Ex1LblToday.Name = "Ex1LblToday"
        Me.Ex1LblToday.Size = New System.Drawing.Size(159, 29)
        Me.Ex1LblToday.TabIndex = 19
        Me.Ex1LblToday.Text = "Today's Date:"
        '
        'Ex1LblFullDateOfBirth
        '
        Me.Ex1LblFullDateOfBirth.AutoSize = True
        Me.Ex1LblFullDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex1LblFullDateOfBirth.Location = New System.Drawing.Point(15, 203)
        Me.Ex1LblFullDateOfBirth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Ex1LblFullDateOfBirth.Name = "Ex1LblFullDateOfBirth"
        Me.Ex1LblFullDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Ex1LblFullDateOfBirth.Size = New System.Drawing.Size(165, 29)
        Me.Ex1LblFullDateOfBirth.TabIndex = 18
        Me.Ex1LblFullDateOfBirth.Text = "Full birth date:"
        '
        'Ex1TxtAgeInDays
        '
        Me.Ex1TxtAgeInDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex1TxtAgeInDays.Location = New System.Drawing.Point(180, 359)
        Me.Ex1TxtAgeInDays.Margin = New System.Windows.Forms.Padding(2)
        Me.Ex1TxtAgeInDays.Name = "Ex1TxtAgeInDays"
        Me.Ex1TxtAgeInDays.ReadOnly = True
        Me.Ex1TxtAgeInDays.Size = New System.Drawing.Size(362, 35)
        Me.Ex1TxtAgeInDays.TabIndex = 17
        '
        'Ex1TxtToday
        '
        Me.Ex1TxtToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex1TxtToday.Location = New System.Drawing.Point(180, 278)
        Me.Ex1TxtToday.Margin = New System.Windows.Forms.Padding(2)
        Me.Ex1TxtToday.Name = "Ex1TxtToday"
        Me.Ex1TxtToday.ReadOnly = True
        Me.Ex1TxtToday.Size = New System.Drawing.Size(362, 35)
        Me.Ex1TxtToday.TabIndex = 16
        '
        'Ex1BtnComputeBirth
        '
        Me.Ex1BtnComputeBirth.Location = New System.Drawing.Point(205, 106)
        Me.Ex1BtnComputeBirth.Margin = New System.Windows.Forms.Padding(2)
        Me.Ex1BtnComputeBirth.Name = "Ex1BtnComputeBirth"
        Me.Ex1BtnComputeBirth.Size = New System.Drawing.Size(320, 55)
        Me.Ex1BtnComputeBirth.TabIndex = 13
        Me.Ex1BtnComputeBirth.Text = "Compute Data"
        Me.Ex1BtnComputeBirth.UseVisualStyleBackColor = True
        '
        'Ex1LblDayOfBirth
        '
        Me.Ex1LblDayOfBirth.AutoSize = True
        Me.Ex1LblDayOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex1LblDayOfBirth.Location = New System.Drawing.Point(25, 37)
        Me.Ex1LblDayOfBirth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Ex1LblDayOfBirth.Name = "Ex1LblDayOfBirth"
        Me.Ex1LblDayOfBirth.Size = New System.Drawing.Size(150, 29)
        Me.Ex1LblDayOfBirth.TabIndex = 12
        Me.Ex1LblDayOfBirth.Text = "Date of Birth:"
        '
        'Ex2GbNameAge
        '
        Me.Ex2GbNameAge.Controls.Add(Me.Ex2TxtOutput)
        Me.Ex2GbNameAge.Controls.Add(Me.Ex2TxtToday)
        Me.Ex2GbNameAge.Controls.Add(Me.Ex2LblToday)
        Me.Ex2GbNameAge.Controls.Add(Me.Ex2BtnDisplay)
        Me.Ex2GbNameAge.Location = New System.Drawing.Point(669, 21)
        Me.Ex2GbNameAge.Name = "Ex2GbNameAge"
        Me.Ex2GbNameAge.Size = New System.Drawing.Size(559, 211)
        Me.Ex2GbNameAge.TabIndex = 13
        Me.Ex2GbNameAge.TabStop = False
        Me.Ex2GbNameAge.Text = "Ex 3.2 Name and Age"
        '
        'Ex3GbMessageExit
        '
        Me.Ex3GbMessageExit.Controls.Add(Me.Ex3BtnExit)
        Me.Ex3GbMessageExit.Controls.Add(Me.Ex3BtnClickMe)
        Me.Ex3GbMessageExit.Location = New System.Drawing.Point(35, 556)
        Me.Ex3GbMessageExit.Name = "Ex3GbMessageExit"
        Me.Ex3GbMessageExit.Size = New System.Drawing.Size(591, 285)
        Me.Ex3GbMessageExit.TabIndex = 14
        Me.Ex3GbMessageExit.TabStop = False
        Me.Ex3GbMessageExit.Text = "Ex 3 Message Box and Exit "
        '
        'Ex4GbColleges
        '
        Me.Ex4GbColleges.Controls.Add(Me.Ex4BtnDisplay)
        Me.Ex4GbColleges.Controls.Add(Me.Ex4LstColleges)
        Me.Ex4GbColleges.Location = New System.Drawing.Point(669, 556)
        Me.Ex4GbColleges.Name = "Ex4GbColleges"
        Me.Ex4GbColleges.Size = New System.Drawing.Size(559, 531)
        Me.Ex4GbColleges.TabIndex = 15
        Me.Ex4GbColleges.TabStop = False
        Me.Ex4GbColleges.Text = "Ex 4 College Data"
        '
        'Ex1TxtFullDateOfBirth
        '
        Me.Ex1TxtFullDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex1TxtFullDateOfBirth.Location = New System.Drawing.Point(180, 201)
        Me.Ex1TxtFullDateOfBirth.Margin = New System.Windows.Forms.Padding(2)
        Me.Ex1TxtFullDateOfBirth.Name = "Ex1TxtFullDateOfBirth"
        Me.Ex1TxtFullDateOfBirth.ReadOnly = True
        Me.Ex1TxtFullDateOfBirth.Size = New System.Drawing.Size(362, 35)
        Me.Ex1TxtFullDateOfBirth.TabIndex = 15
        '
        'Ex2BtnDisplay
        '
        Me.Ex2BtnDisplay.Location = New System.Drawing.Point(143, 50)
        Me.Ex2BtnDisplay.Name = "Ex2BtnDisplay"
        Me.Ex2BtnDisplay.Size = New System.Drawing.Size(278, 33)
        Me.Ex2BtnDisplay.TabIndex = 0
        Me.Ex2BtnDisplay.Text = "Display First Name and Age"
        Me.Ex2BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex2LblToday
        '
        Me.Ex2LblToday.AutoSize = True
        Me.Ex2LblToday.Location = New System.Drawing.Point(72, 106)
        Me.Ex2LblToday.Name = "Ex2LblToday"
        Me.Ex2LblToday.Size = New System.Drawing.Size(106, 20)
        Me.Ex2LblToday.TabIndex = 1
        Me.Ex2LblToday.Text = "Today's Date:"
        '
        'Ex2TxtToday
        '
        Me.Ex2TxtToday.Location = New System.Drawing.Point(184, 103)
        Me.Ex2TxtToday.Name = "Ex2TxtToday"
        Me.Ex2TxtToday.ReadOnly = True
        Me.Ex2TxtToday.Size = New System.Drawing.Size(251, 26)
        Me.Ex2TxtToday.TabIndex = 2
        '
        'Ex2TxtOutput
        '
        Me.Ex2TxtOutput.Location = New System.Drawing.Point(64, 152)
        Me.Ex2TxtOutput.Name = "Ex2TxtOutput"
        Me.Ex2TxtOutput.ReadOnly = True
        Me.Ex2TxtOutput.Size = New System.Drawing.Size(387, 26)
        Me.Ex2TxtOutput.TabIndex = 3
        '
        'Ex3BtnClickMe
        '
        Me.Ex3BtnClickMe.Location = New System.Drawing.Point(112, 67)
        Me.Ex3BtnClickMe.Name = "Ex3BtnClickMe"
        Me.Ex3BtnClickMe.Size = New System.Drawing.Size(329, 42)
        Me.Ex3BtnClickMe.TabIndex = 0
        Me.Ex3BtnClickMe.Text = "Click Me!!!!"
        Me.Ex3BtnClickMe.UseVisualStyleBackColor = True
        '
        'Ex3BtnExit
        '
        Me.Ex3BtnExit.Location = New System.Drawing.Point(140, 168)
        Me.Ex3BtnExit.Name = "Ex3BtnExit"
        Me.Ex3BtnExit.Size = New System.Drawing.Size(275, 48)
        Me.Ex3BtnExit.TabIndex = 1
        Me.Ex3BtnExit.Text = "Exit"
        Me.Ex3BtnExit.UseVisualStyleBackColor = True
        '
        'Ex4LstColleges
        '
        Me.Ex4LstColleges.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex4LstColleges.FormattingEnabled = True
        Me.Ex4LstColleges.ItemHeight = 18
        Me.Ex4LstColleges.Location = New System.Drawing.Point(48, 53)
        Me.Ex4LstColleges.Name = "Ex4LstColleges"
        Me.Ex4LstColleges.Size = New System.Drawing.Size(452, 148)
        Me.Ex4LstColleges.TabIndex = 0
        '
        'Ex4BtnDisplay
        '
        Me.Ex4BtnDisplay.Location = New System.Drawing.Point(195, 261)
        Me.Ex4BtnDisplay.Name = "Ex4BtnDisplay"
        Me.Ex4BtnDisplay.Size = New System.Drawing.Size(188, 46)
        Me.Ex4BtnDisplay.TabIndex = 1
        Me.Ex4BtnDisplay.Text = "Display Table"
        Me.Ex4BtnDisplay.UseVisualStyleBackColor = True
        '
        'Campbell_Ch33_Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 1151)
        Me.Controls.Add(Me.Ex4GbColleges)
        Me.Controls.Add(Me.Ex3GbMessageExit)
        Me.Controls.Add(Me.Ex2GbNameAge)
        Me.Controls.Add(Me.Ex1GbAge)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Campbell_Ch33_Lab"
        Me.Text = "Campbell_Ch3.3_Lab"
        Me.Ex1GbAge.ResumeLayout(False)
        Me.Ex1GbAge.PerformLayout()
        Me.Ex2GbNameAge.ResumeLayout(False)
        Me.Ex2GbNameAge.PerformLayout()
        Me.Ex3GbMessageExit.ResumeLayout(False)
        Me.Ex4GbColleges.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ex1GbAge As GroupBox
    Friend WithEvents Ex1LblAgeInDays As Label
    Friend WithEvents Ex1LblToday As Label
    Friend WithEvents Ex1LblFullDateOfBirth As Label
    Friend WithEvents Ex1TxtAgeInDays As TextBox
    Friend WithEvents Ex1TxtToday As TextBox
    Friend WithEvents Ex1BtnComputeBirth As Button
    Friend WithEvents Ex1LblDayOfBirth As Label
    Friend WithEvents Ex1MtbDayOfBirth As MaskedTextBox
    Friend WithEvents Ex2GbNameAge As GroupBox
    Friend WithEvents Ex3GbMessageExit As GroupBox
    Friend WithEvents Ex4GbColleges As GroupBox
    Friend WithEvents Ex1TxtFullDateOfBirth As TextBox
    Friend WithEvents Ex2TxtOutput As TextBox
    Friend WithEvents Ex2TxtToday As TextBox
    Friend WithEvents Ex2LblToday As Label
    Friend WithEvents Ex2BtnDisplay As Button
    Friend WithEvents Ex3BtnExit As Button
    Friend WithEvents Ex3BtnClickMe As Button
    Friend WithEvents Ex4BtnDisplay As Button
    Friend WithEvents Ex4LstColleges As ListBox
End Class
