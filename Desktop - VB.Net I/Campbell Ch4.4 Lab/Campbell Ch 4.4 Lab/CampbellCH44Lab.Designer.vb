<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCampbellCh44Lab
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
        Me.LblEx1Month = New System.Windows.Forms.Label()
        Me.LstEx1Month = New System.Windows.Forms.ListBox()
        Me.GbEx1NumDaysInMonth = New System.Windows.Forms.GroupBox()
        Me.TxtEx1Days = New System.Windows.Forms.TextBox()
        Me.LblEx1Days = New System.Windows.Forms.Label()
        Me.BtnEx1Process = New System.Windows.Forms.Button()
        Me.GbEx3Fee = New System.Windows.Forms.GroupBox()
        Me.GbEx3Age = New System.Windows.Forms.GroupBox()
        Me.RadEx3Child = New System.Windows.Forms.RadioButton()
        Me.RadEx3Minor = New System.Windows.Forms.RadioButton()
        Me.RadEx3Adult = New System.Windows.Forms.RadioButton()
        Me.RadEx3Senior = New System.Windows.Forms.RadioButton()
        Me.BtnEx3Determine = New System.Windows.Forms.Button()
        Me.LblEx3Fee = New System.Windows.Forms.Label()
        Me.TxtEx3Fee = New System.Windows.Forms.TextBox()
        Me.GbEx4Menu = New System.Windows.Forms.GroupBox()
        Me.ChkEx4Drug = New System.Windows.Forms.CheckBox()
        Me.ChkEx4Dental = New System.Windows.Forms.CheckBox()
        Me.ChkEx4Vision = New System.Windows.Forms.CheckBox()
        Me.ChkEx4Medical = New System.Windows.Forms.CheckBox()
        Me.BtnEx4Determine = New System.Windows.Forms.Button()
        Me.TxtEx4Total = New System.Windows.Forms.TextBox()
        Me.LblEx4Total = New System.Windows.Forms.Label()
        Me.GbEx1NumDaysInMonth.SuspendLayout()
        Me.GbEx3Fee.SuspendLayout()
        Me.GbEx3Age.SuspendLayout()
        Me.GbEx4Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblEx1Month
        '
        Me.LblEx1Month.AutoSize = True
        Me.LblEx1Month.Location = New System.Drawing.Point(37, 37)
        Me.LblEx1Month.Name = "LblEx1Month"
        Me.LblEx1Month.Size = New System.Drawing.Size(120, 20)
        Me.LblEx1Month.TabIndex = 0
        Me.LblEx1Month.Text = "Select a Month:"
        '
        'LstEx1Month
        '
        Me.LstEx1Month.FormattingEnabled = True
        Me.LstEx1Month.ItemHeight = 20
        Me.LstEx1Month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.LstEx1Month.Location = New System.Drawing.Point(41, 60)
        Me.LstEx1Month.Name = "LstEx1Month"
        Me.LstEx1Month.Size = New System.Drawing.Size(121, 264)
        Me.LstEx1Month.TabIndex = 1
        '
        'GbEx1NumDaysInMonth
        '
        Me.GbEx1NumDaysInMonth.Controls.Add(Me.TxtEx1Days)
        Me.GbEx1NumDaysInMonth.Controls.Add(Me.LblEx1Days)
        Me.GbEx1NumDaysInMonth.Controls.Add(Me.BtnEx1Process)
        Me.GbEx1NumDaysInMonth.Controls.Add(Me.LblEx1Month)
        Me.GbEx1NumDaysInMonth.Controls.Add(Me.LstEx1Month)
        Me.GbEx1NumDaysInMonth.Location = New System.Drawing.Point(35, 24)
        Me.GbEx1NumDaysInMonth.Name = "GbEx1NumDaysInMonth"
        Me.GbEx1NumDaysInMonth.Size = New System.Drawing.Size(425, 358)
        Me.GbEx1NumDaysInMonth.TabIndex = 2
        Me.GbEx1NumDaysInMonth.TabStop = False
        Me.GbEx1NumDaysInMonth.Text = "Number of Days"
        '
        'TxtEx1Days
        '
        Me.TxtEx1Days.Location = New System.Drawing.Point(308, 162)
        Me.TxtEx1Days.Name = "TxtEx1Days"
        Me.TxtEx1Days.ReadOnly = True
        Me.TxtEx1Days.Size = New System.Drawing.Size(100, 26)
        Me.TxtEx1Days.TabIndex = 4
        '
        'LblEx1Days
        '
        Me.LblEx1Days.AutoSize = True
        Me.LblEx1Days.Location = New System.Drawing.Point(175, 165)
        Me.LblEx1Days.Name = "LblEx1Days"
        Me.LblEx1Days.Size = New System.Drawing.Size(127, 20)
        Me.LblEx1Days.TabIndex = 3
        Me.LblEx1Days.Text = "Number of Days:"
        '
        'BtnEx1Process
        '
        Me.BtnEx1Process.Location = New System.Drawing.Point(179, 106)
        Me.BtnEx1Process.Name = "BtnEx1Process"
        Me.BtnEx1Process.Size = New System.Drawing.Size(236, 38)
        Me.BtnEx1Process.TabIndex = 2
        Me.BtnEx1Process.Text = "Determine Number of Days"
        Me.BtnEx1Process.UseVisualStyleBackColor = True
        '
        'GbEx3Fee
        '
        Me.GbEx3Fee.Controls.Add(Me.TxtEx3Fee)
        Me.GbEx3Fee.Controls.Add(Me.LblEx3Fee)
        Me.GbEx3Fee.Controls.Add(Me.BtnEx3Determine)
        Me.GbEx3Fee.Controls.Add(Me.GbEx3Age)
        Me.GbEx3Fee.Location = New System.Drawing.Point(559, 24)
        Me.GbEx3Fee.Name = "GbEx3Fee"
        Me.GbEx3Fee.Size = New System.Drawing.Size(438, 220)
        Me.GbEx3Fee.TabIndex = 3
        Me.GbEx3Fee.TabStop = False
        Me.GbEx3Fee.Text = "Admission Fee"
        '
        'GbEx3Age
        '
        Me.GbEx3Age.Controls.Add(Me.RadEx3Senior)
        Me.GbEx3Age.Controls.Add(Me.RadEx3Adult)
        Me.GbEx3Age.Controls.Add(Me.RadEx3Minor)
        Me.GbEx3Age.Controls.Add(Me.RadEx3Child)
        Me.GbEx3Age.Location = New System.Drawing.Point(43, 37)
        Me.GbEx3Age.Name = "GbEx3Age"
        Me.GbEx3Age.Size = New System.Drawing.Size(152, 163)
        Me.GbEx3Age.TabIndex = 0
        Me.GbEx3Age.TabStop = False
        Me.GbEx3Age.Text = "Age"
        '
        'RadEx3Child
        '
        Me.RadEx3Child.AutoSize = True
        Me.RadEx3Child.Location = New System.Drawing.Point(7, 26)
        Me.RadEx3Child.Name = "RadEx3Child"
        Me.RadEx3Child.Size = New System.Drawing.Size(113, 24)
        Me.RadEx3Child.TabIndex = 0
        Me.RadEx3Child.TabStop = True
        Me.RadEx3Child.Text = "Child ( < 6 )"
        Me.RadEx3Child.UseVisualStyleBackColor = True
        '
        'RadEx3Minor
        '
        Me.RadEx3Minor.AutoSize = True
        Me.RadEx3Minor.Location = New System.Drawing.Point(6, 56)
        Me.RadEx3Minor.Name = "RadEx3Minor"
        Me.RadEx3Minor.Size = New System.Drawing.Size(131, 24)
        Me.RadEx3Minor.TabIndex = 1
        Me.RadEx3Minor.TabStop = True
        Me.RadEx3Minor.Text = "Minor ( 6 -17 )"
        Me.RadEx3Minor.UseVisualStyleBackColor = True
        '
        'RadEx3Adult
        '
        Me.RadEx3Adult.AutoSize = True
        Me.RadEx3Adult.Location = New System.Drawing.Point(7, 86)
        Me.RadEx3Adult.Name = "RadEx3Adult"
        Me.RadEx3Adult.Size = New System.Drawing.Size(142, 24)
        Me.RadEx3Adult.TabIndex = 2
        Me.RadEx3Adult.TabStop = True
        Me.RadEx3Adult.Text = "Adult ( 18 - 64 )"
        Me.RadEx3Adult.UseVisualStyleBackColor = True
        '
        'RadEx3Senior
        '
        Me.RadEx3Senior.AutoSize = True
        Me.RadEx3Senior.Location = New System.Drawing.Point(7, 116)
        Me.RadEx3Senior.Name = "RadEx3Senior"
        Me.RadEx3Senior.Size = New System.Drawing.Size(129, 24)
        Me.RadEx3Senior.TabIndex = 3
        Me.RadEx3Senior.TabStop = True
        Me.RadEx3Senior.Text = "Senior ( 65+ )"
        Me.RadEx3Senior.UseVisualStyleBackColor = True
        '
        'BtnEx3Determine
        '
        Me.BtnEx3Determine.Location = New System.Drawing.Point(243, 49)
        Me.BtnEx3Determine.Name = "BtnEx3Determine"
        Me.BtnEx3Determine.Size = New System.Drawing.Size(154, 38)
        Me.BtnEx3Determine.TabIndex = 1
        Me.BtnEx3Determine.Text = "Determine Fee"
        Me.BtnEx3Determine.UseVisualStyleBackColor = True
        '
        'LblEx3Fee
        '
        Me.LblEx3Fee.AutoSize = True
        Me.LblEx3Fee.Location = New System.Drawing.Point(243, 123)
        Me.LblEx3Fee.Name = "LblEx3Fee"
        Me.LblEx3Fee.Size = New System.Drawing.Size(41, 20)
        Me.LblEx3Fee.TabIndex = 2
        Me.LblEx3Fee.Text = "Fee:"
        '
        'TxtEx3Fee
        '
        Me.TxtEx3Fee.Location = New System.Drawing.Point(290, 120)
        Me.TxtEx3Fee.Name = "TxtEx3Fee"
        Me.TxtEx3Fee.ReadOnly = True
        Me.TxtEx3Fee.Size = New System.Drawing.Size(117, 26)
        Me.TxtEx3Fee.TabIndex = 3
        '
        'GbEx4Menu
        '
        Me.GbEx4Menu.Controls.Add(Me.LblEx4Total)
        Me.GbEx4Menu.Controls.Add(Me.TxtEx4Total)
        Me.GbEx4Menu.Controls.Add(Me.BtnEx4Determine)
        Me.GbEx4Menu.Controls.Add(Me.ChkEx4Medical)
        Me.GbEx4Menu.Controls.Add(Me.ChkEx4Vision)
        Me.GbEx4Menu.Controls.Add(Me.ChkEx4Dental)
        Me.GbEx4Menu.Controls.Add(Me.ChkEx4Drug)
        Me.GbEx4Menu.Location = New System.Drawing.Point(343, 419)
        Me.GbEx4Menu.Name = "GbEx4Menu"
        Me.GbEx4Menu.Size = New System.Drawing.Size(483, 275)
        Me.GbEx4Menu.TabIndex = 4
        Me.GbEx4Menu.TabStop = False
        Me.GbEx4Menu.Text = "Benefits Menu"
        '
        'ChkEx4Drug
        '
        Me.ChkEx4Drug.AutoSize = True
        Me.ChkEx4Drug.Location = New System.Drawing.Point(20, 36)
        Me.ChkEx4Drug.Name = "ChkEx4Drug"
        Me.ChkEx4Drug.Size = New System.Drawing.Size(255, 24)
        Me.ChkEx4Drug.TabIndex = 0
        Me.ChkEx4Drug.Text = "Prescription Drug Plan ($39.15)"
        Me.ChkEx4Drug.UseVisualStyleBackColor = True
        '
        'ChkEx4Dental
        '
        Me.ChkEx4Dental.AutoSize = True
        Me.ChkEx4Dental.Location = New System.Drawing.Point(20, 66)
        Me.ChkEx4Dental.Name = "ChkEx4Dental"
        Me.ChkEx4Dental.Size = New System.Drawing.Size(180, 24)
        Me.ChkEx4Dental.TabIndex = 1
        Me.ChkEx4Dental.Text = "Dental Plan ($10.81)"
        Me.ChkEx4Dental.UseVisualStyleBackColor = True
        '
        'ChkEx4Vision
        '
        Me.ChkEx4Vision.AutoSize = True
        Me.ChkEx4Vision.Location = New System.Drawing.Point(20, 96)
        Me.ChkEx4Vision.Name = "ChkEx4Vision"
        Me.ChkEx4Vision.Size = New System.Drawing.Size(167, 24)
        Me.ChkEx4Vision.TabIndex = 2
        Me.ChkEx4Vision.Text = "Vision Plan ($2.25)"
        Me.ChkEx4Vision.UseVisualStyleBackColor = True
        '
        'ChkEx4Medical
        '
        Me.ChkEx4Medical.AutoSize = True
        Me.ChkEx4Medical.Location = New System.Drawing.Point(20, 126)
        Me.ChkEx4Medical.Name = "ChkEx4Medical"
        Me.ChkEx4Medical.Size = New System.Drawing.Size(187, 24)
        Me.ChkEx4Medical.TabIndex = 3
        Me.ChkEx4Medical.Text = "Medical Plan ($55.52)"
        Me.ChkEx4Medical.UseVisualStyleBackColor = True
        '
        'BtnEx4Determine
        '
        Me.BtnEx4Determine.Location = New System.Drawing.Point(56, 157)
        Me.BtnEx4Determine.Name = "BtnEx4Determine"
        Me.BtnEx4Determine.Size = New System.Drawing.Size(235, 40)
        Me.BtnEx4Determine.TabIndex = 4
        Me.BtnEx4Determine.Text = "Determine Total Monthly Cost"
        Me.BtnEx4Determine.UseVisualStyleBackColor = True
        '
        'TxtEx4Total
        '
        Me.TxtEx4Total.Location = New System.Drawing.Point(176, 213)
        Me.TxtEx4Total.Name = "TxtEx4Total"
        Me.TxtEx4Total.ReadOnly = True
        Me.TxtEx4Total.Size = New System.Drawing.Size(184, 26)
        Me.TxtEx4Total.TabIndex = 5
        '
        'LblEx4Total
        '
        Me.LblEx4Total.AutoSize = True
        Me.LblEx4Total.Location = New System.Drawing.Point(29, 216)
        Me.LblEx4Total.Name = "LblEx4Total"
        Me.LblEx4Total.Size = New System.Drawing.Size(141, 20)
        Me.LblEx4Total.TabIndex = 6
        Me.LblEx4Total.Text = "Total monthly cost:"
        '
        'FrmCampbellCh44Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 757)
        Me.Controls.Add(Me.GbEx4Menu)
        Me.Controls.Add(Me.GbEx3Fee)
        Me.Controls.Add(Me.GbEx1NumDaysInMonth)
        Me.Name = "FrmCampbellCh44Lab"
        Me.Text = "Campbell CH4.4 Lab"
        Me.GbEx1NumDaysInMonth.ResumeLayout(False)
        Me.GbEx1NumDaysInMonth.PerformLayout()
        Me.GbEx3Fee.ResumeLayout(False)
        Me.GbEx3Fee.PerformLayout()
        Me.GbEx3Age.ResumeLayout(False)
        Me.GbEx3Age.PerformLayout()
        Me.GbEx4Menu.ResumeLayout(False)
        Me.GbEx4Menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblEx1Month As Label
    Friend WithEvents LstEx1Month As ListBox
    Friend WithEvents GbEx1NumDaysInMonth As GroupBox
    Friend WithEvents TxtEx1Days As TextBox
    Friend WithEvents LblEx1Days As Label
    Friend WithEvents BtnEx1Process As Button
    Friend WithEvents GbEx3Fee As GroupBox
    Friend WithEvents TxtEx3Fee As TextBox
    Friend WithEvents LblEx3Fee As Label
    Friend WithEvents BtnEx3Determine As Button
    Friend WithEvents GbEx3Age As GroupBox
    Friend WithEvents RadEx3Senior As RadioButton
    Friend WithEvents RadEx3Adult As RadioButton
    Friend WithEvents RadEx3Minor As RadioButton
    Friend WithEvents RadEx3Child As RadioButton
    Friend WithEvents GbEx4Menu As GroupBox
    Friend WithEvents LblEx4Total As Label
    Friend WithEvents TxtEx4Total As TextBox
    Friend WithEvents BtnEx4Determine As Button
    Friend WithEvents ChkEx4Medical As CheckBox
    Friend WithEvents ChkEx4Vision As CheckBox
    Friend WithEvents ChkEx4Dental As CheckBox
    Friend WithEvents ChkEx4Drug As CheckBox
End Class
