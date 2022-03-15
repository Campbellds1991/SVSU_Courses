<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CampbellCh43Hw
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
        Me.GbEx1Olympics = New System.Windows.Forms.GroupBox()
        Me.TxtEx1Outcome = New System.Windows.Forms.TextBox()
        Me.BtnEx1Evaluate = New System.Windows.Forms.Button()
        Me.TxtEx1Position = New System.Windows.Forms.TextBox()
        Me.LblEx1Position = New System.Windows.Forms.Label()
        Me.GbEx3Days = New System.Windows.Forms.GroupBox()
        Me.TxtEx3Output = New System.Windows.Forms.TextBox()
        Me.MtbEx3Year = New System.Windows.Forms.MaskedTextBox()
        Me.MtbEx3Month = New System.Windows.Forms.MaskedTextBox()
        Me.BtnEx3Determine = New System.Windows.Forms.Button()
        Me.LblEx3Year = New System.Windows.Forms.Label()
        Me.LblEx3Month = New System.Windows.Forms.Label()
        Me.GbEx3Quiz = New System.Windows.Forms.GroupBox()
        Me.TxtEx4Reply = New System.Windows.Forms.TextBox()
        Me.TxtEx4Name = New System.Windows.Forms.TextBox()
        Me.LblEx4Question = New System.Windows.Forms.Label()
        Me.BtnEx4Interpret = New System.Windows.Forms.Button()
        Me.GbEx1Olympics.SuspendLayout()
        Me.GbEx3Days.SuspendLayout()
        Me.GbEx3Quiz.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbEx1Olympics
        '
        Me.GbEx1Olympics.Controls.Add(Me.TxtEx1Outcome)
        Me.GbEx1Olympics.Controls.Add(Me.BtnEx1Evaluate)
        Me.GbEx1Olympics.Controls.Add(Me.TxtEx1Position)
        Me.GbEx1Olympics.Controls.Add(Me.LblEx1Position)
        Me.GbEx1Olympics.Location = New System.Drawing.Point(72, 67)
        Me.GbEx1Olympics.Name = "GbEx1Olympics"
        Me.GbEx1Olympics.Size = New System.Drawing.Size(443, 277)
        Me.GbEx1Olympics.TabIndex = 0
        Me.GbEx1Olympics.TabStop = False
        Me.GbEx1Olympics.Text = "Olympics"
        '
        'TxtEx1Outcome
        '
        Me.TxtEx1Outcome.Location = New System.Drawing.Point(54, 212)
        Me.TxtEx1Outcome.Name = "TxtEx1Outcome"
        Me.TxtEx1Outcome.ReadOnly = True
        Me.TxtEx1Outcome.Size = New System.Drawing.Size(323, 29)
        Me.TxtEx1Outcome.TabIndex = 3
        '
        'BtnEx1Evaluate
        '
        Me.BtnEx1Evaluate.Location = New System.Drawing.Point(54, 138)
        Me.BtnEx1Evaluate.Name = "BtnEx1Evaluate"
        Me.BtnEx1Evaluate.Size = New System.Drawing.Size(323, 43)
        Me.BtnEx1Evaluate.TabIndex = 2
        Me.BtnEx1Evaluate.Text = "Evalute Position"
        Me.BtnEx1Evaluate.UseVisualStyleBackColor = True
        '
        'TxtEx1Position
        '
        Me.TxtEx1Position.Location = New System.Drawing.Point(236, 62)
        Me.TxtEx1Position.Name = "TxtEx1Position"
        Me.TxtEx1Position.Size = New System.Drawing.Size(141, 29)
        Me.TxtEx1Position.TabIndex = 1
        '
        'LblEx1Position
        '
        Me.LblEx1Position.Location = New System.Drawing.Point(49, 44)
        Me.LblEx1Position.Name = "LblEx1Position"
        Me.LblEx1Position.Size = New System.Drawing.Size(169, 57)
        Me.LblEx1Position.TabIndex = 0
        Me.LblEx1Position.Text = "Finishing position (1, 2, 3, ...):"
        '
        'GbEx3Days
        '
        Me.GbEx3Days.Controls.Add(Me.TxtEx3Output)
        Me.GbEx3Days.Controls.Add(Me.MtbEx3Year)
        Me.GbEx3Days.Controls.Add(Me.MtbEx3Month)
        Me.GbEx3Days.Controls.Add(Me.BtnEx3Determine)
        Me.GbEx3Days.Controls.Add(Me.LblEx3Year)
        Me.GbEx3Days.Controls.Add(Me.LblEx3Month)
        Me.GbEx3Days.Location = New System.Drawing.Point(640, 67)
        Me.GbEx3Days.Name = "GbEx3Days"
        Me.GbEx3Days.Size = New System.Drawing.Size(284, 313)
        Me.GbEx3Days.TabIndex = 1
        Me.GbEx3Days.TabStop = False
        Me.GbEx3Days.Text = "Count Days"
        '
        'TxtEx3Output
        '
        Me.TxtEx3Output.Location = New System.Drawing.Point(21, 247)
        Me.TxtEx3Output.Name = "TxtEx3Output"
        Me.TxtEx3Output.ReadOnly = True
        Me.TxtEx3Output.Size = New System.Drawing.Size(219, 29)
        Me.TxtEx3Output.TabIndex = 7
        '
        'MtbEx3Year
        '
        Me.MtbEx3Year.Location = New System.Drawing.Point(176, 90)
        Me.MtbEx3Year.Mask = "0000"
        Me.MtbEx3Year.Name = "MtbEx3Year"
        Me.MtbEx3Year.Size = New System.Drawing.Size(64, 29)
        Me.MtbEx3Year.TabIndex = 6
        '
        'MtbEx3Month
        '
        Me.MtbEx3Month.Location = New System.Drawing.Point(176, 41)
        Me.MtbEx3Month.Mask = "00"
        Me.MtbEx3Month.Name = "MtbEx3Month"
        Me.MtbEx3Month.Size = New System.Drawing.Size(42, 29)
        Me.MtbEx3Month.TabIndex = 5
        '
        'BtnEx3Determine
        '
        Me.BtnEx3Determine.Location = New System.Drawing.Point(44, 138)
        Me.BtnEx3Determine.Name = "BtnEx3Determine"
        Me.BtnEx3Determine.Size = New System.Drawing.Size(196, 74)
        Me.BtnEx3Determine.TabIndex = 4
        Me.BtnEx3Determine.Text = "Determin Number of Days in Month"
        Me.BtnEx3Determine.UseVisualStyleBackColor = True
        '
        'LblEx3Year
        '
        Me.LblEx3Year.AutoSize = True
        Me.LblEx3Year.Location = New System.Drawing.Point(121, 93)
        Me.LblEx3Year.Name = "LblEx3Year"
        Me.LblEx3Year.Size = New System.Drawing.Size(59, 25)
        Me.LblEx3Year.TabIndex = 1
        Me.LblEx3Year.Text = "Year:"
        '
        'LblEx3Month
        '
        Me.LblEx3Month.AutoSize = True
        Me.LblEx3Month.Location = New System.Drawing.Point(38, 44)
        Me.LblEx3Month.Name = "LblEx3Month"
        Me.LblEx3Month.Size = New System.Drawing.Size(142, 25)
        Me.LblEx3Month.TabIndex = 0
        Me.LblEx3Month.Text = "Month (1 - 12):"
        '
        'GbEx3Quiz
        '
        Me.GbEx3Quiz.Controls.Add(Me.TxtEx4Reply)
        Me.GbEx3Quiz.Controls.Add(Me.TxtEx4Name)
        Me.GbEx3Quiz.Controls.Add(Me.LblEx4Question)
        Me.GbEx3Quiz.Controls.Add(Me.BtnEx4Interpret)
        Me.GbEx3Quiz.Location = New System.Drawing.Point(164, 414)
        Me.GbEx3Quiz.Name = "GbEx3Quiz"
        Me.GbEx3Quiz.Size = New System.Drawing.Size(656, 341)
        Me.GbEx3Quiz.TabIndex = 2
        Me.GbEx3Quiz.TabStop = False
        Me.GbEx3Quiz.Text = "Quiz"
        '
        'TxtEx4Reply
        '
        Me.TxtEx4Reply.Location = New System.Drawing.Point(77, 222)
        Me.TxtEx4Reply.Name = "TxtEx4Reply"
        Me.TxtEx4Reply.ReadOnly = True
        Me.TxtEx4Reply.Size = New System.Drawing.Size(439, 29)
        Me.TxtEx4Reply.TabIndex = 3
        '
        'TxtEx4Name
        '
        Me.TxtEx4Name.Location = New System.Drawing.Point(270, 62)
        Me.TxtEx4Name.Name = "TxtEx4Name"
        Me.TxtEx4Name.Size = New System.Drawing.Size(292, 29)
        Me.TxtEx4Name.TabIndex = 2
        '
        'LblEx4Question
        '
        Me.LblEx4Question.Location = New System.Drawing.Point(63, 53)
        Me.LblEx4Question.Name = "LblEx4Question"
        Me.LblEx4Question.Size = New System.Drawing.Size(200, 58)
        Me.LblEx4Question.TabIndex = 1
        Me.LblEx4Question.Text = "What was President Wilson's first name?"
        '
        'BtnEx4Interpret
        '
        Me.BtnEx4Interpret.Location = New System.Drawing.Point(68, 129)
        Me.BtnEx4Interpret.Name = "BtnEx4Interpret"
        Me.BtnEx4Interpret.Size = New System.Drawing.Size(427, 56)
        Me.BtnEx4Interpret.TabIndex = 0
        Me.BtnEx4Interpret.Text = "Interpret Answer"
        Me.BtnEx4Interpret.UseVisualStyleBackColor = True
        '
        'CampbellCh43Hw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 794)
        Me.Controls.Add(Me.GbEx3Quiz)
        Me.Controls.Add(Me.GbEx3Days)
        Me.Controls.Add(Me.GbEx1Olympics)
        Me.Name = "CampbellCh43Hw"
        Me.Text = "Campbell CH4.3 HW"
        Me.GbEx1Olympics.ResumeLayout(False)
        Me.GbEx1Olympics.PerformLayout()
        Me.GbEx3Days.ResumeLayout(False)
        Me.GbEx3Days.PerformLayout()
        Me.GbEx3Quiz.ResumeLayout(False)
        Me.GbEx3Quiz.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbEx1Olympics As GroupBox
    Friend WithEvents LblEx1Position As Label
    Friend WithEvents TxtEx1Outcome As TextBox
    Friend WithEvents BtnEx1Evaluate As Button
    Friend WithEvents TxtEx1Position As TextBox
    Friend WithEvents GbEx3Days As GroupBox
    Friend WithEvents BtnEx3Determine As Button
    Friend WithEvents LblEx3Year As Label
    Friend WithEvents LblEx3Month As Label
    Friend WithEvents MtbEx3Year As MaskedTextBox
    Friend WithEvents MtbEx3Month As MaskedTextBox
    Friend WithEvents TxtEx3Output As TextBox
    Friend WithEvents GbEx3Quiz As GroupBox
    Friend WithEvents TxtEx4Reply As TextBox
    Friend WithEvents TxtEx4Name As TextBox
    Friend WithEvents LblEx4Question As Label
    Friend WithEvents BtnEx4Interpret As Button
End Class
