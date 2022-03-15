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
		Me.cmdSave = New System.Windows.Forms.Button()
		Me.cmdCancel = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(28, 18)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(49, 17)
		Me.lblName.TabIndex = 0
		Me.lblName.Text = "Name:"
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(28, 53)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(25, 17)
		Me.lblID.TabIndex = 1
		Me.lblID.Text = "ID:"
		'
		'lblHours
		'
		Me.lblHours.AutoSize = True
		Me.lblHours.Location = New System.Drawing.Point(28, 87)
		Me.lblHours.Name = "lblHours"
		Me.lblHours.Size = New System.Drawing.Size(50, 17)
		Me.lblHours.TabIndex = 2
		Me.lblHours.Text = "Hours:"
		'
		'lblWage
		'
		Me.lblWage.AutoSize = True
		Me.lblWage.Location = New System.Drawing.Point(28, 122)
		Me.lblWage.Name = "lblWage"
		Me.lblWage.Size = New System.Drawing.Size(49, 17)
		Me.lblWage.TabIndex = 3
		Me.lblWage.Text = "Wage:"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(87, 16)
		Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(346, 22)
		Me.txtName.TabIndex = 4
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(87, 50)
		Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(346, 22)
		Me.txtID.TabIndex = 5
		'
		'txtHours
		'
		Me.txtHours.Location = New System.Drawing.Point(87, 85)
		Me.txtHours.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtHours.Name = "txtHours"
		Me.txtHours.Size = New System.Drawing.Size(346, 22)
		Me.txtHours.TabIndex = 6
		'
		'txtWage
		'
		Me.txtWage.Location = New System.Drawing.Point(87, 119)
		Me.txtWage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtWage.Name = "txtWage"
		Me.txtWage.Size = New System.Drawing.Size(346, 22)
		Me.txtWage.TabIndex = 7
		'
		'chkIsSalary
		'
		Me.chkIsSalary.AutoSize = True
		Me.chkIsSalary.Location = New System.Drawing.Point(32, 162)
		Me.chkIsSalary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.chkIsSalary.Name = "chkIsSalary"
		Me.chkIsSalary.Size = New System.Drawing.Size(144, 21)
		Me.chkIsSalary.TabIndex = 8
		Me.chkIsSalary.Text = "Salaried Position?"
		Me.chkIsSalary.UseVisualStyleBackColor = True
		'
		'lblWagesDue
		'
		Me.lblWagesDue.AutoSize = True
		Me.lblWagesDue.Location = New System.Drawing.Point(208, 163)
		Me.lblWagesDue.Name = "lblWagesDue"
		Me.lblWagesDue.Size = New System.Drawing.Size(156, 17)
		Me.lblWagesDue.TabIndex = 9
		Me.lblWagesDue.Text = "Employee Wages Due: "
		'
		'cmdCalcWagesDue
		'
		Me.cmdCalcWagesDue.Location = New System.Drawing.Point(32, 206)
		Me.cmdCalcWagesDue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cmdCalcWagesDue.Name = "cmdCalcWagesDue"
		Me.cmdCalcWagesDue.Size = New System.Drawing.Size(402, 55)
		Me.cmdCalcWagesDue.TabIndex = 10
		Me.cmdCalcWagesDue.Text = "Calculate Wage"
		Me.cmdCalcWagesDue.UseVisualStyleBackColor = True
		'
		'cmdPrevListing
		'
		Me.cmdPrevListing.Location = New System.Drawing.Point(32, 282)
		Me.cmdPrevListing.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cmdPrevListing.Name = "cmdPrevListing"
		Me.cmdPrevListing.Size = New System.Drawing.Size(81, 55)
		Me.cmdPrevListing.TabIndex = 11
		Me.cmdPrevListing.Text = "<<"
		Me.cmdPrevListing.UseVisualStyleBackColor = True
		'
		'cmdAddListing
		'
		Me.cmdAddListing.Location = New System.Drawing.Point(132, 282)
		Me.cmdAddListing.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cmdAddListing.Name = "cmdAddListing"
		Me.cmdAddListing.Size = New System.Drawing.Size(202, 55)
		Me.cmdAddListing.TabIndex = 12
		Me.cmdAddListing.Text = "Add New Employee"
		Me.cmdAddListing.UseVisualStyleBackColor = True
		'
		'cmdNextListing
		'
		Me.cmdNextListing.Location = New System.Drawing.Point(352, 282)
		Me.cmdNextListing.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cmdNextListing.Name = "cmdNextListing"
		Me.cmdNextListing.Size = New System.Drawing.Size(81, 55)
		Me.cmdNextListing.TabIndex = 13
		Me.cmdNextListing.Text = ">>"
		Me.cmdNextListing.UseVisualStyleBackColor = True
		'
		'cmdSave
		'
		Me.cmdSave.Location = New System.Drawing.Point(32, 358)
		Me.cmdSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cmdSave.Name = "cmdSave"
		Me.cmdSave.Size = New System.Drawing.Size(173, 55)
		Me.cmdSave.TabIndex = 14
		Me.cmdSave.Text = "Save"
		Me.cmdSave.UseVisualStyleBackColor = True
		'
		'cmdCancel
		'
		Me.cmdCancel.Location = New System.Drawing.Point(260, 358)
		Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(173, 55)
		Me.cmdCancel.TabIndex = 15
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.UseVisualStyleBackColor = True
		'
		'frmPayroll
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(459, 433)
		Me.Controls.Add(Me.cmdCancel)
		Me.Controls.Add(Me.cmdSave)
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
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.Name = "frmPayroll"
		Me.Text = "Payroll System"
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
	Friend WithEvents cmdSave As Button
	Friend WithEvents cmdCancel As Button
End Class
