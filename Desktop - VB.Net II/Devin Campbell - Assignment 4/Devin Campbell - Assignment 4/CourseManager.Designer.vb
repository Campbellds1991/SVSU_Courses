<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseManager
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseManager))
		Me.gbDegreeMaintenance = New System.Windows.Forms.GroupBox()
		Me.cmdDegreeRemove = New System.Windows.Forms.Button()
		Me.cmdDegreeAdd = New System.Windows.Forms.Button()
		Me.txtDegreeDetail = New System.Windows.Forms.TextBox()
		Me.txtDegreePrefix = New System.Windows.Forms.TextBox()
		Me.lblCourseDesignator = New System.Windows.Forms.Label()
		Me.lstDegrees = New System.Windows.Forms.ListBox()
		Me.gbClassMaintenance = New System.Windows.Forms.GroupBox()
		Me.cmdCourseRemove = New System.Windows.Forms.Button()
		Me.cmdCourseAdd = New System.Windows.Forms.Button()
		Me.txtCourseDetail = New System.Windows.Forms.TextBox()
		Me.txtCoursePrefix = New System.Windows.Forms.TextBox()
		Me.lblClassDesignator = New System.Windows.Forms.Label()
		Me.lstCourses = New System.Windows.Forms.ListBox()
		Me.cmdBuildDegrees = New System.Windows.Forms.Button()
		Me.errDisplay = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.gbDegreeMaintenance.SuspendLayout()
		Me.gbClassMaintenance.SuspendLayout()
		CType(Me.errDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'gbDegreeMaintenance
		'
		Me.gbDegreeMaintenance.Controls.Add(Me.cmdDegreeRemove)
		Me.gbDegreeMaintenance.Controls.Add(Me.cmdDegreeAdd)
		Me.gbDegreeMaintenance.Controls.Add(Me.txtDegreeDetail)
		Me.gbDegreeMaintenance.Controls.Add(Me.txtDegreePrefix)
		Me.gbDegreeMaintenance.Controls.Add(Me.lblCourseDesignator)
		Me.gbDegreeMaintenance.Controls.Add(Me.lstDegrees)
		Me.gbDegreeMaintenance.Location = New System.Drawing.Point(13, 13)
		Me.gbDegreeMaintenance.Name = "gbDegreeMaintenance"
		Me.gbDegreeMaintenance.Size = New System.Drawing.Size(1049, 334)
		Me.gbDegreeMaintenance.TabIndex = 0
		Me.gbDegreeMaintenance.TabStop = False
		Me.gbDegreeMaintenance.Text = "Degree Maintenance"
		'
		'cmdDegreeRemove
		'
		Me.cmdDegreeRemove.Location = New System.Drawing.Point(610, 279)
		Me.cmdDegreeRemove.Name = "cmdDegreeRemove"
		Me.cmdDegreeRemove.Size = New System.Drawing.Size(433, 48)
		Me.cmdDegreeRemove.TabIndex = 5
		Me.cmdDegreeRemove.Text = "Delete Degree(s)"
		Me.cmdDegreeRemove.UseVisualStyleBackColor = True
		'
		'cmdDegreeAdd
		'
		Me.cmdDegreeAdd.Location = New System.Drawing.Point(9, 280)
		Me.cmdDegreeAdd.Name = "cmdDegreeAdd"
		Me.cmdDegreeAdd.Size = New System.Drawing.Size(433, 48)
		Me.cmdDegreeAdd.TabIndex = 4
		Me.cmdDegreeAdd.Text = "Add Degree"
		Me.cmdDegreeAdd.UseVisualStyleBackColor = True
		'
		'txtDegreeDetail
		'
		Me.txtDegreeDetail.Location = New System.Drawing.Point(265, 251)
		Me.txtDegreeDetail.Name = "txtDegreeDetail"
		Me.txtDegreeDetail.Size = New System.Drawing.Size(778, 22)
		Me.txtDegreeDetail.TabIndex = 3
		'
		'txtDegreePrefix
		'
		Me.txtDegreePrefix.Location = New System.Drawing.Point(9, 251)
		Me.txtDegreePrefix.Name = "txtDegreePrefix"
		Me.txtDegreePrefix.Size = New System.Drawing.Size(162, 22)
		Me.txtDegreePrefix.TabIndex = 2
		'
		'lblCourseDesignator
		'
		Me.lblCourseDesignator.AutoSize = True
		Me.lblCourseDesignator.Location = New System.Drawing.Point(6, 231)
		Me.lblCourseDesignator.Name = "lblCourseDesignator"
		Me.lblCourseDesignator.Size = New System.Drawing.Size(542, 17)
		Me.lblCourseDesignator.TabIndex = 1
		Me.lblCourseDesignator.Text = "Enter New Degree Designator and Name in Textboxes and Press Add Degree Button"
		'
		'lstDegrees
		'
		Me.lstDegrees.FormattingEnabled = True
		Me.lstDegrees.ItemHeight = 16
		Me.lstDegrees.Location = New System.Drawing.Point(7, 21)
		Me.lstDegrees.Name = "lstDegrees"
		Me.lstDegrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
		Me.lstDegrees.Size = New System.Drawing.Size(1036, 180)
		Me.lstDegrees.TabIndex = 0
		'
		'gbClassMaintenance
		'
		Me.gbClassMaintenance.Controls.Add(Me.cmdCourseRemove)
		Me.gbClassMaintenance.Controls.Add(Me.cmdCourseAdd)
		Me.gbClassMaintenance.Controls.Add(Me.txtCourseDetail)
		Me.gbClassMaintenance.Controls.Add(Me.txtCoursePrefix)
		Me.gbClassMaintenance.Controls.Add(Me.lblClassDesignator)
		Me.gbClassMaintenance.Controls.Add(Me.lstCourses)
		Me.gbClassMaintenance.Location = New System.Drawing.Point(13, 353)
		Me.gbClassMaintenance.Name = "gbClassMaintenance"
		Me.gbClassMaintenance.Size = New System.Drawing.Size(1049, 334)
		Me.gbClassMaintenance.TabIndex = 1
		Me.gbClassMaintenance.TabStop = False
		Me.gbClassMaintenance.Text = "Class Maintenance"
		'
		'cmdCourseRemove
		'
		Me.cmdCourseRemove.Location = New System.Drawing.Point(610, 279)
		Me.cmdCourseRemove.Name = "cmdCourseRemove"
		Me.cmdCourseRemove.Size = New System.Drawing.Size(433, 48)
		Me.cmdCourseRemove.TabIndex = 5
		Me.cmdCourseRemove.Text = "Delete Class(es)"
		Me.cmdCourseRemove.UseVisualStyleBackColor = True
		'
		'cmdCourseAdd
		'
		Me.cmdCourseAdd.Location = New System.Drawing.Point(9, 280)
		Me.cmdCourseAdd.Name = "cmdCourseAdd"
		Me.cmdCourseAdd.Size = New System.Drawing.Size(433, 48)
		Me.cmdCourseAdd.TabIndex = 4
		Me.cmdCourseAdd.Text = "Add Class"
		Me.cmdCourseAdd.UseVisualStyleBackColor = True
		'
		'txtCourseDetail
		'
		Me.txtCourseDetail.Location = New System.Drawing.Point(265, 251)
		Me.txtCourseDetail.Name = "txtCourseDetail"
		Me.txtCourseDetail.Size = New System.Drawing.Size(778, 22)
		Me.txtCourseDetail.TabIndex = 3
		'
		'txtCoursePrefix
		'
		Me.txtCoursePrefix.Location = New System.Drawing.Point(9, 251)
		Me.txtCoursePrefix.Name = "txtCoursePrefix"
		Me.txtCoursePrefix.Size = New System.Drawing.Size(162, 22)
		Me.txtCoursePrefix.TabIndex = 2
		'
		'lblClassDesignator
		'
		Me.lblClassDesignator.AutoSize = True
		Me.lblClassDesignator.Location = New System.Drawing.Point(6, 231)
		Me.lblClassDesignator.Name = "lblClassDesignator"
		Me.lblClassDesignator.Size = New System.Drawing.Size(539, 17)
		Me.lblClassDesignator.TabIndex = 1
		Me.lblClassDesignator.Text = "Enter New Course Designator and Name in TextBoxes and Press Add Course Button"
		'
		'lstCourses
		'
		Me.lstCourses.FormattingEnabled = True
		Me.lstCourses.ItemHeight = 16
		Me.lstCourses.Location = New System.Drawing.Point(13, 21)
		Me.lstCourses.Name = "lstCourses"
		Me.lstCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
		Me.lstCourses.Size = New System.Drawing.Size(1036, 180)
		Me.lstCourses.TabIndex = 0
		'
		'cmdBuildDegrees
		'
		Me.cmdBuildDegrees.Location = New System.Drawing.Point(324, 707)
		Me.cmdBuildDegrees.Name = "cmdBuildDegrees"
		Me.cmdBuildDegrees.Size = New System.Drawing.Size(433, 48)
		Me.cmdBuildDegrees.TabIndex = 6
		Me.cmdBuildDegrees.Text = "Build Degrees"
		Me.cmdBuildDegrees.UseVisualStyleBackColor = True
		'
		'errDisplay
		'
		Me.errDisplay.BlinkRate = 500
		Me.errDisplay.ContainerControl = Me
		'
		'CourseManager
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1074, 788)
		Me.Controls.Add(Me.cmdBuildDegrees)
		Me.Controls.Add(Me.gbClassMaintenance)
		Me.Controls.Add(Me.gbDegreeMaintenance)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "CourseManager"
		Me.Text = "Degree and Course Manager"
		Me.gbDegreeMaintenance.ResumeLayout(False)
		Me.gbDegreeMaintenance.PerformLayout()
		Me.gbClassMaintenance.ResumeLayout(False)
		Me.gbClassMaintenance.PerformLayout()
		CType(Me.errDisplay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents gbDegreeMaintenance As GroupBox
	Friend WithEvents cmdDegreeRemove As Button
	Friend WithEvents cmdDegreeAdd As Button
	Friend WithEvents txtDegreeDetail As TextBox
	Friend WithEvents txtDegreePrefix As TextBox
	Friend WithEvents lblCourseDesignator As Label
	Friend WithEvents lstDegrees As ListBox
	Friend WithEvents gbClassMaintenance As GroupBox
	Friend WithEvents cmdCourseRemove As Button
	Friend WithEvents cmdCourseAdd As Button
	Friend WithEvents txtCourseDetail As TextBox
	Friend WithEvents txtCoursePrefix As TextBox
	Friend WithEvents lblClassDesignator As Label
	Friend WithEvents lstCourses As ListBox
	Friend WithEvents cmdBuildDegrees As Button
	Friend WithEvents errDisplay As ErrorProvider
End Class
