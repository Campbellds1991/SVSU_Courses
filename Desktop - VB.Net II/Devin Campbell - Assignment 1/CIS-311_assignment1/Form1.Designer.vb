<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
		Me.lblName = New System.Windows.Forms.Label()
		Me.lblID = New System.Windows.Forms.Label()
		Me.lblHours = New System.Windows.Forms.Label()
		Me.lblWage = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtHours = New System.Windows.Forms.TextBox()
		Me.txtWage = New System.Windows.Forms.TextBox()
		Me.chkIsSalary = New System.Windows.Forms.CheckBox()
		Me.lblWagesDue = New System.Windows.Forms.Label()
		Me.cmdCalcWagesDue = New System.Windows.Forms.Button()
		Me.cmdPrevListing = New System.Windows.Forms.Button()
		Me.cmdAddListing = New System.Windows.Forms.Button()
		Me.cmdNextListing = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(35, 43)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(55, 20)
		Me.lblName.TabIndex = 0
		Me.lblName.Text = "Name:"
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(35, 120)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(30, 20)
		Me.lblID.TabIndex = 1
		Me.lblID.Text = "ID:"
		'
		'lblHours
		'
		Me.lblHours.AutoSize = True
		Me.lblHours.Location = New System.Drawing.Point(35, 197)
		Me.lblHours.Name = "lblHours"
		Me.lblHours.Size = New System.Drawing.Size(56, 20)
		Me.lblHours.TabIndex = 2
		Me.lblHours.Text = "Hours:"
		'
		'lblWage
		'
		Me.lblWage.AutoSize = True
		Me.lblWage.Location = New System.Drawing.Point(35, 274)
		Me.lblWage.Name = "lblWage"
		Me.lblWage.Size = New System.Drawing.Size(55, 20)
		Me.lblWage.TabIndex = 3
		Me.lblWage.Text = "Wage:"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(102, 40)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(389, 26)
		Me.txtName.TabIndex = 4
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(102, 117)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(389, 26)
		Me.txtID.TabIndex = 5
		'
		'txtHours
		'
		Me.txtHours.Location = New System.Drawing.Point(102, 194)
		Me.txtHours.Name = "txtHours"
		Me.txtHours.Size = New System.Drawing.Size(389, 26)
		Me.txtHours.TabIndex = 6
		'
		'txtWage
		'
		Me.txtWage.Location = New System.Drawing.Point(102, 271)
		Me.txtWage.Name = "txtWage"
		Me.txtWage.Size = New System.Drawing.Size(389, 26)
		Me.txtWage.TabIndex = 7
		'
		'chkIsSalary
		'
		Me.chkIsSalary.AutoSize = True
		Me.chkIsSalary.Location = New System.Drawing.Point(39, 344)
		Me.chkIsSalary.Name = "chkIsSalary"
		Me.chkIsSalary.Size = New System.Drawing.Size(162, 24)
		Me.chkIsSalary.TabIndex = 8
		Me.chkIsSalary.Text = "Salaried Position?"
		Me.chkIsSalary.UseVisualStyleBackColor = True
		'
		'lblWagesDue
		'
		Me.lblWagesDue.AutoSize = True
		Me.lblWagesDue.Location = New System.Drawing.Point(276, 345)
		Me.lblWagesDue.Name = "lblWagesDue"
		Me.lblWagesDue.Size = New System.Drawing.Size(57, 20)
		Me.lblWagesDue.TabIndex = 9
		Me.lblWagesDue.Text = "Label5"
		'
		'cmdCalcWagesDue
		'
		Me.cmdCalcWagesDue.Location = New System.Drawing.Point(40, 399)
		Me.cmdCalcWagesDue.Name = "cmdCalcWagesDue"
		Me.cmdCalcWagesDue.Size = New System.Drawing.Size(452, 89)
		Me.cmdCalcWagesDue.TabIndex = 10
		Me.cmdCalcWagesDue.Text = "Button1"
		Me.cmdCalcWagesDue.UseVisualStyleBackColor = True
		'
		'cmdPrevListing
		'
		Me.cmdPrevListing.Location = New System.Drawing.Point(40, 494)
		Me.cmdPrevListing.Name = "cmdPrevListing"
		Me.cmdPrevListing.Size = New System.Drawing.Size(91, 89)
		Me.cmdPrevListing.TabIndex = 11
		Me.cmdPrevListing.Text = "Button1"
		Me.cmdPrevListing.UseVisualStyleBackColor = True
		'
		'cmdAddListing
		'
		Me.cmdAddListing.Location = New System.Drawing.Point(137, 494)
		Me.cmdAddListing.Name = "cmdAddListing"
		Me.cmdAddListing.Size = New System.Drawing.Size(258, 89)
		Me.cmdAddListing.TabIndex = 12
		Me.cmdAddListing.Text = "Button1"
		Me.cmdAddListing.UseVisualStyleBackColor = True
		'
		'cmdNextListing
		'
		Me.cmdNextListing.Location = New System.Drawing.Point(401, 494)
		Me.cmdNextListing.Name = "cmdNextListing"
		Me.cmdNextListing.Size = New System.Drawing.Size(91, 89)
		Me.cmdNextListing.TabIndex = 13
		Me.cmdNextListing.Text = "Button1"
		Me.cmdNextListing.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(40, 589)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(220, 89)
		Me.Button2.TabIndex = 14
		Me.Button2.Text = "Button1"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(271, 589)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(220, 89)
		Me.Button1.TabIndex = 15
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'frmPayroll
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(544, 711)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.cmdNextListing)
		Me.Controls.Add(Me.cmdAddListing)
		Me.Controls.Add(Me.cmdPrevListing)
		Me.Controls.Add(Me.cmdCalcWagesDue)
		Me.Controls.Add(Me.lblWagesDue)
		Me.Controls.Add(Me.chkIsSalary)
		Me.Controls.Add(Me.txtWage)
		Me.Controls.Add(Me.txtHours)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.lblWage)
		Me.Controls.Add(Me.lblHours)
		Me.Controls.Add(Me.lblID)
		Me.Controls.Add(Me.lblName)
		Me.Name = "frmPayroll"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblName As Label
	Friend WithEvents lblID As Label
	Friend WithEvents lblHours As Label
	Friend WithEvents lblWage As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtHours As TextBox
	Friend WithEvents txtWage As TextBox
	Friend WithEvents chkIsSalary As CheckBox
	Friend WithEvents lblWagesDue As Label
	Friend WithEvents cmdCalcWagesDue As Button
	Friend WithEvents cmdPrevListing As Button
	Friend WithEvents cmdAddListing As Button
	Friend WithEvents cmdNextListing As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
End Class
