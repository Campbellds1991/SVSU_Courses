<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Campbell_Ch73_Lab
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
        Me.Ex4_LblState = New System.Windows.Forms.Label()
        Me.Ex4_GbColleges = New System.Windows.Forms.GroupBox()
        Me.Ex4_LstColleges = New System.Windows.Forms.ListBox()
        Me.Ex4_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex4_MtbState = New System.Windows.Forms.MaskedTextBox()
        Me.Ex4B_GbColleges = New System.Windows.Forms.GroupBox()
        Me.Ex4B_DgvColleges = New System.Windows.Forms.DataGridView()
        Me.Ex4B_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex4B_MtbState = New System.Windows.Forms.MaskedTextBox()
        Me.Ex4B_LblState = New System.Windows.Forms.Label()
        Me.Ex5_GbColleges = New System.Windows.Forms.GroupBox()
        Me.Ex5_LblColleges = New System.Windows.Forms.Label()
        Me.Ex5_TxtYearFounded = New System.Windows.Forms.TextBox()
        Me.Ex5_TxtState = New System.Windows.Forms.TextBox()
        Me.Ex5_LblYearFounded = New System.Windows.Forms.Label()
        Me.Ex5_LblState = New System.Windows.Forms.Label()
        Me.Ex5_LstColleges = New System.Windows.Forms.ListBox()
        Me.Ex4_GbColleges.SuspendLayout()
        Me.Ex4B_GbColleges.SuspendLayout()
        CType(Me.Ex4B_DgvColleges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ex5_GbColleges.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ex4_LblState
        '
        Me.Ex4_LblState.AutoSize = True
        Me.Ex4_LblState.Location = New System.Drawing.Point(146, 25)
        Me.Ex4_LblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ex4_LblState.Name = "Ex4_LblState"
        Me.Ex4_LblState.Size = New System.Drawing.Size(52, 20)
        Me.Ex4_LblState.TabIndex = 0
        Me.Ex4_LblState.Text = "State:"
        '
        'Ex4_GbColleges
        '
        Me.Ex4_GbColleges.Controls.Add(Me.Ex4_LstColleges)
        Me.Ex4_GbColleges.Controls.Add(Me.Ex4_BtnDisplay)
        Me.Ex4_GbColleges.Controls.Add(Me.Ex4_MtbState)
        Me.Ex4_GbColleges.Controls.Add(Me.Ex4_LblState)
        Me.Ex4_GbColleges.Location = New System.Drawing.Point(18, 18)
        Me.Ex4_GbColleges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4_GbColleges.Name = "Ex4_GbColleges"
        Me.Ex4_GbColleges.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4_GbColleges.Size = New System.Drawing.Size(417, 323)
        Me.Ex4_GbColleges.TabIndex = 1
        Me.Ex4_GbColleges.TabStop = False
        Me.Ex4_GbColleges.Text = "Earliest Colleges"
        '
        'Ex4_LstColleges
        '
        Me.Ex4_LstColleges.FormattingEnabled = True
        Me.Ex4_LstColleges.ItemHeight = 20
        Me.Ex4_LstColleges.Location = New System.Drawing.Point(40, 122)
        Me.Ex4_LstColleges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4_LstColleges.Name = "Ex4_LstColleges"
        Me.Ex4_LstColleges.Size = New System.Drawing.Size(342, 184)
        Me.Ex4_LstColleges.TabIndex = 3
        '
        'Ex4_BtnDisplay
        '
        Me.Ex4_BtnDisplay.Location = New System.Drawing.Point(93, 65)
        Me.Ex4_BtnDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4_BtnDisplay.Name = "Ex4_BtnDisplay"
        Me.Ex4_BtnDisplay.Size = New System.Drawing.Size(230, 48)
        Me.Ex4_BtnDisplay.TabIndex = 2
        Me.Ex4_BtnDisplay.Text = "Display Colleges"
        Me.Ex4_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex4_MtbState
        '
        Me.Ex4_MtbState.Location = New System.Drawing.Point(207, 25)
        Me.Ex4_MtbState.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4_MtbState.Mask = "LL"
        Me.Ex4_MtbState.Name = "Ex4_MtbState"
        Me.Ex4_MtbState.Size = New System.Drawing.Size(58, 26)
        Me.Ex4_MtbState.TabIndex = 1
        '
        'Ex4B_GbColleges
        '
        Me.Ex4B_GbColleges.Controls.Add(Me.Ex4B_DgvColleges)
        Me.Ex4B_GbColleges.Controls.Add(Me.Ex4B_BtnDisplay)
        Me.Ex4B_GbColleges.Controls.Add(Me.Ex4B_MtbState)
        Me.Ex4B_GbColleges.Controls.Add(Me.Ex4B_LblState)
        Me.Ex4B_GbColleges.Location = New System.Drawing.Point(444, 18)
        Me.Ex4B_GbColleges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4B_GbColleges.Name = "Ex4B_GbColleges"
        Me.Ex4B_GbColleges.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4B_GbColleges.Size = New System.Drawing.Size(417, 323)
        Me.Ex4B_GbColleges.TabIndex = 4
        Me.Ex4B_GbColleges.TabStop = False
        Me.Ex4B_GbColleges.Text = "Earliest Colleges"
        '
        'Ex4B_DgvColleges
        '
        Me.Ex4B_DgvColleges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ex4B_DgvColleges.Location = New System.Drawing.Point(32, 122)
        Me.Ex4B_DgvColleges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4B_DgvColleges.Name = "Ex4B_DgvColleges"
        Me.Ex4B_DgvColleges.RowHeadersVisible = False
        Me.Ex4B_DgvColleges.Size = New System.Drawing.Size(360, 186)
        Me.Ex4B_DgvColleges.TabIndex = 3
        '
        'Ex4B_BtnDisplay
        '
        Me.Ex4B_BtnDisplay.Location = New System.Drawing.Point(93, 65)
        Me.Ex4B_BtnDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4B_BtnDisplay.Name = "Ex4B_BtnDisplay"
        Me.Ex4B_BtnDisplay.Size = New System.Drawing.Size(230, 48)
        Me.Ex4B_BtnDisplay.TabIndex = 2
        Me.Ex4B_BtnDisplay.Text = "Display Colleges"
        Me.Ex4B_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex4B_MtbState
        '
        Me.Ex4B_MtbState.Location = New System.Drawing.Point(207, 25)
        Me.Ex4B_MtbState.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex4B_MtbState.Mask = "LL"
        Me.Ex4B_MtbState.Name = "Ex4B_MtbState"
        Me.Ex4B_MtbState.Size = New System.Drawing.Size(58, 26)
        Me.Ex4B_MtbState.TabIndex = 1
        '
        'Ex4B_LblState
        '
        Me.Ex4B_LblState.AutoSize = True
        Me.Ex4B_LblState.Location = New System.Drawing.Point(146, 25)
        Me.Ex4B_LblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ex4B_LblState.Name = "Ex4B_LblState"
        Me.Ex4B_LblState.Size = New System.Drawing.Size(52, 20)
        Me.Ex4B_LblState.TabIndex = 0
        Me.Ex4B_LblState.Text = "State:"
        '
        'Ex5_GbColleges
        '
        Me.Ex5_GbColleges.Controls.Add(Me.Ex5_LblColleges)
        Me.Ex5_GbColleges.Controls.Add(Me.Ex5_TxtYearFounded)
        Me.Ex5_GbColleges.Controls.Add(Me.Ex5_TxtState)
        Me.Ex5_GbColleges.Controls.Add(Me.Ex5_LblYearFounded)
        Me.Ex5_GbColleges.Controls.Add(Me.Ex5_LblState)
        Me.Ex5_GbColleges.Controls.Add(Me.Ex5_LstColleges)
        Me.Ex5_GbColleges.Location = New System.Drawing.Point(18, 351)
        Me.Ex5_GbColleges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex5_GbColleges.Name = "Ex5_GbColleges"
        Me.Ex5_GbColleges.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex5_GbColleges.Size = New System.Drawing.Size(540, 323)
        Me.Ex5_GbColleges.TabIndex = 4
        Me.Ex5_GbColleges.TabStop = False
        Me.Ex5_GbColleges.Text = "Earliest Colleges"
        '
        'Ex5_LblColleges
        '
        Me.Ex5_LblColleges.AutoSize = True
        Me.Ex5_LblColleges.Location = New System.Drawing.Point(9, 25)
        Me.Ex5_LblColleges.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ex5_LblColleges.Name = "Ex5_LblColleges"
        Me.Ex5_LblColleges.Size = New System.Drawing.Size(224, 20)
        Me.Ex5_LblColleges.TabIndex = 8
        Me.Ex5_LblColleges.Text = "Click on the name of a college."
        '
        'Ex5_TxtYearFounded
        '
        Me.Ex5_TxtYearFounded.Location = New System.Drawing.Point(370, 125)
        Me.Ex5_TxtYearFounded.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex5_TxtYearFounded.Name = "Ex5_TxtYearFounded"
        Me.Ex5_TxtYearFounded.ReadOnly = True
        Me.Ex5_TxtYearFounded.Size = New System.Drawing.Size(121, 26)
        Me.Ex5_TxtYearFounded.TabIndex = 7
        '
        'Ex5_TxtState
        '
        Me.Ex5_TxtState.Location = New System.Drawing.Point(370, 83)
        Me.Ex5_TxtState.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex5_TxtState.Name = "Ex5_TxtState"
        Me.Ex5_TxtState.ReadOnly = True
        Me.Ex5_TxtState.Size = New System.Drawing.Size(85, 26)
        Me.Ex5_TxtState.TabIndex = 6
        '
        'Ex5_LblYearFounded
        '
        Me.Ex5_LblYearFounded.AutoSize = True
        Me.Ex5_LblYearFounded.Location = New System.Drawing.Point(247, 128)
        Me.Ex5_LblYearFounded.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ex5_LblYearFounded.Name = "Ex5_LblYearFounded"
        Me.Ex5_LblYearFounded.Size = New System.Drawing.Size(115, 20)
        Me.Ex5_LblYearFounded.TabIndex = 5
        Me.Ex5_LblYearFounded.Text = "Year Founded:"
        '
        'Ex5_LblState
        '
        Me.Ex5_LblState.AutoSize = True
        Me.Ex5_LblState.Location = New System.Drawing.Point(310, 86)
        Me.Ex5_LblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ex5_LblState.Name = "Ex5_LblState"
        Me.Ex5_LblState.Size = New System.Drawing.Size(52, 20)
        Me.Ex5_LblState.TabIndex = 4
        Me.Ex5_LblState.Text = "State:"
        '
        'Ex5_LstColleges
        '
        Me.Ex5_LstColleges.FormattingEnabled = True
        Me.Ex5_LstColleges.ItemHeight = 20
        Me.Ex5_LstColleges.Location = New System.Drawing.Point(9, 49)
        Me.Ex5_LstColleges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ex5_LstColleges.Name = "Ex5_LstColleges"
        Me.Ex5_LstColleges.Size = New System.Drawing.Size(230, 244)
        Me.Ex5_LstColleges.TabIndex = 3
        '
        'Campbell_Ch73_Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 751)
        Me.Controls.Add(Me.Ex5_GbColleges)
        Me.Controls.Add(Me.Ex4B_GbColleges)
        Me.Controls.Add(Me.Ex4_GbColleges)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Campbell_Ch73_Lab"
        Me.Text = "Campbell Ch7.3 Lab"
        Me.Ex4_GbColleges.ResumeLayout(False)
        Me.Ex4_GbColleges.PerformLayout()
        Me.Ex4B_GbColleges.ResumeLayout(False)
        Me.Ex4B_GbColleges.PerformLayout()
        CType(Me.Ex4B_DgvColleges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ex5_GbColleges.ResumeLayout(False)
        Me.Ex5_GbColleges.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ex4_LblState As Label
    Friend WithEvents Ex4_GbColleges As GroupBox
    Friend WithEvents Ex4_LstColleges As ListBox
    Friend WithEvents Ex4_BtnDisplay As Button
    Friend WithEvents Ex4_MtbState As MaskedTextBox
    Friend WithEvents Ex4B_GbColleges As GroupBox
    Friend WithEvents Ex4B_BtnDisplay As Button
    Friend WithEvents Ex4B_MtbState As MaskedTextBox
    Friend WithEvents Ex4B_LblState As Label
    Friend WithEvents Ex4B_DgvColleges As DataGridView
    Friend WithEvents Ex5_GbColleges As GroupBox
    Friend WithEvents Ex5_LblColleges As Label
    Friend WithEvents Ex5_TxtYearFounded As TextBox
    Friend WithEvents Ex5_TxtState As TextBox
    Friend WithEvents Ex5_LblYearFounded As Label
    Friend WithEvents Ex5_LblState As Label
    Friend WithEvents Ex5_LstColleges As ListBox
End Class
