<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseBuilder
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseBuilder))
		Me.cmdBack = New System.Windows.Forms.Button()
		Me.lstDegrees = New System.Windows.Forms.ListBox()
		Me.lstIncludedCourses = New System.Windows.Forms.ListBox()
		Me.lstAvailable = New System.Windows.Forms.ListBox()
		Me.cmdAddCourse = New System.Windows.Forms.Button()
		Me.cmdRemoveCourse = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'cmdBack
		'
		Me.cmdBack.Location = New System.Drawing.Point(12, 12)
		Me.cmdBack.Name = "cmdBack"
		Me.cmdBack.Size = New System.Drawing.Size(1147, 49)
		Me.cmdBack.TabIndex = 0
		Me.cmdBack.Text = "Back to Degree and Course Maintenance"
		Me.cmdBack.UseVisualStyleBackColor = True
		'
		'lstDegrees
		'
		Me.lstDegrees.FormattingEnabled = True
		Me.lstDegrees.ItemHeight = 16
		Me.lstDegrees.Location = New System.Drawing.Point(13, 67)
		Me.lstDegrees.Name = "lstDegrees"
		Me.lstDegrees.Size = New System.Drawing.Size(1146, 212)
		Me.lstDegrees.TabIndex = 1
		'
		'lstIncludedCourses
		'
		Me.lstIncludedCourses.FormattingEnabled = True
		Me.lstIncludedCourses.ItemHeight = 16
		Me.lstIncludedCourses.Location = New System.Drawing.Point(16, 327)
		Me.lstIncludedCourses.Name = "lstIncludedCourses"
		Me.lstIncludedCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
		Me.lstIncludedCourses.Size = New System.Drawing.Size(452, 292)
		Me.lstIncludedCourses.TabIndex = 2
		'
		'lstAvailable
		'
		Me.lstAvailable.FormattingEnabled = True
		Me.lstAvailable.ItemHeight = 16
		Me.lstAvailable.Location = New System.Drawing.Point(707, 327)
		Me.lstAvailable.Name = "lstAvailable"
		Me.lstAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
		Me.lstAvailable.Size = New System.Drawing.Size(452, 292)
		Me.lstAvailable.TabIndex = 3
		'
		'cmdAddCourse
		'
		Me.cmdAddCourse.Image = Global.Devin_Campbell___Assignment_4.My.Resources.Resources._1486007370_DoubleChevronLeft
		Me.cmdAddCourse.Location = New System.Drawing.Point(497, 355)
		Me.cmdAddCourse.Name = "cmdAddCourse"
		Me.cmdAddCourse.Size = New System.Drawing.Size(181, 91)
		Me.cmdAddCourse.TabIndex = 4
		Me.cmdAddCourse.UseVisualStyleBackColor = True
		'
		'cmdRemoveCourse
		'
		Me.cmdRemoveCourse.Image = Global.Devin_Campbell___Assignment_4.My.Resources.Resources._1486007352_DoubleChevronRight
		Me.cmdRemoveCourse.Location = New System.Drawing.Point(497, 501)
		Me.cmdRemoveCourse.Name = "cmdRemoveCourse"
		Me.cmdRemoveCourse.Size = New System.Drawing.Size(181, 91)
		Me.cmdRemoveCourse.TabIndex = 5
		Me.cmdRemoveCourse.UseVisualStyleBackColor = True
		'
		'CourseBuilder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1171, 685)
		Me.Controls.Add(Me.cmdRemoveCourse)
		Me.Controls.Add(Me.cmdAddCourse)
		Me.Controls.Add(Me.lstAvailable)
		Me.Controls.Add(Me.lstIncludedCourses)
		Me.Controls.Add(Me.lstDegrees)
		Me.Controls.Add(Me.cmdBack)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "CourseBuilder"
		Me.Text = "Course Builder"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents cmdBack As Button
	Friend WithEvents lstDegrees As ListBox
	Friend WithEvents lstIncludedCourses As ListBox
	Friend WithEvents lstAvailable As ListBox
	Friend WithEvents cmdAddCourse As Button
	Friend WithEvents cmdRemoveCourse As Button
End Class
