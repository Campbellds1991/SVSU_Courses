<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepreciation
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
        Me.LblItem = New System.Windows.Forms.Label()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.LblStartYear = New System.Windows.Forms.Label()
        Me.LblStartValue = New System.Windows.Forms.Label()
        Me.LblDuration = New System.Windows.Forms.Label()
        Me.TxtStartYear = New System.Windows.Forms.TextBox()
        Me.TxtStartValue = New System.Windows.Forms.TextBox()
        Me.TxtDuration = New System.Windows.Forms.TextBox()
        Me.BtnStraightMethod = New System.Windows.Forms.Button()
        Me.BtnDblMethod = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.LstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LblItem
        '
        Me.LblItem.AutoSize = True
        Me.LblItem.Location = New System.Drawing.Point(19, 24)
        Me.LblItem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(30, 13)
        Me.LblItem.TabIndex = 0
        Me.LblItem.Text = "Item:"
        '
        'TxtItem
        '
        Me.TxtItem.Location = New System.Drawing.Point(53, 22)
        Me.TxtItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(408, 20)
        Me.TxtItem.TabIndex = 1
        '
        'LblStartYear
        '
        Me.LblStartYear.Location = New System.Drawing.Point(19, 57)
        Me.LblStartYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblStartYear.Name = "LblStartYear"
        Me.LblStartYear.Size = New System.Drawing.Size(67, 29)
        Me.LblStartYear.TabIndex = 2
        Me.LblStartYear.Text = "Year of purchase:"
        '
        'LblStartValue
        '
        Me.LblStartValue.AutoSize = True
        Me.LblStartValue.Location = New System.Drawing.Point(170, 66)
        Me.LblStartValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblStartValue.Name = "LblStartValue"
        Me.LblStartValue.Size = New System.Drawing.Size(31, 13)
        Me.LblStartValue.TabIndex = 3
        Me.LblStartValue.Text = "Cost:"
        '
        'LblDuration
        '
        Me.LblDuration.Location = New System.Drawing.Point(321, 57)
        Me.LblDuration.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(92, 29)
        Me.LblDuration.TabIndex = 4
        Me.LblDuration.Text = "Estimated life of item (Years):"
        '
        'TxtStartYear
        '
        Me.TxtStartYear.Location = New System.Drawing.Point(79, 62)
        Me.TxtStartYear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtStartYear.Name = "TxtStartYear"
        Me.TxtStartYear.Size = New System.Drawing.Size(68, 20)
        Me.TxtStartYear.TabIndex = 5
        '
        'TxtStartValue
        '
        Me.TxtStartValue.Location = New System.Drawing.Point(205, 64)
        Me.TxtStartValue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtStartValue.Name = "TxtStartValue"
        Me.TxtStartValue.Size = New System.Drawing.Size(97, 20)
        Me.TxtStartValue.TabIndex = 6
        '
        'TxtDuration
        '
        Me.TxtDuration.Location = New System.Drawing.Point(417, 64)
        Me.TxtDuration.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(44, 20)
        Me.TxtDuration.TabIndex = 7
        '
        'BtnStraightMethod
        '
        Me.BtnStraightMethod.Location = New System.Drawing.Point(22, 105)
        Me.BtnStraightMethod.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnStraightMethod.Name = "BtnStraightMethod"
        Me.BtnStraightMethod.Size = New System.Drawing.Size(145, 27)
        Me.BtnStraightMethod.TabIndex = 8
        Me.BtnStraightMethod.Text = "Straight-Line Method"
        Me.BtnStraightMethod.UseVisualStyleBackColor = True
        '
        'BtnDblMethod
        '
        Me.BtnDblMethod.Location = New System.Drawing.Point(173, 105)
        Me.BtnDblMethod.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnDblMethod.Name = "BtnDblMethod"
        Me.BtnDblMethod.Size = New System.Drawing.Size(191, 27)
        Me.BtnDblMethod.TabIndex = 9
        Me.BtnDblMethod.Text = "Double-Declining-Balance Method"
        Me.BtnDblMethod.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(368, 105)
        Me.BtnQuit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(92, 27)
        Me.BtnQuit.TabIndex = 10
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'LstOutput
        '
        Me.LstOutput.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOutput.FormattingEnabled = True
        Me.LstOutput.ItemHeight = 14
        Me.LstOutput.Location = New System.Drawing.Point(22, 147)
        Me.LstOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LstOutput.Name = "LstOutput"
        Me.LstOutput.Size = New System.Drawing.Size(439, 298)
        Me.LstOutput.TabIndex = 11
        '
        'FrmDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 482)
        Me.Controls.Add(Me.LstOutput)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnDblMethod)
        Me.Controls.Add(Me.BtnStraightMethod)
        Me.Controls.Add(Me.TxtDuration)
        Me.Controls.Add(Me.TxtStartValue)
        Me.Controls.Add(Me.TxtStartYear)
        Me.Controls.Add(Me.LblDuration)
        Me.Controls.Add(Me.LblStartValue)
        Me.Controls.Add(Me.LblStartYear)
        Me.Controls.Add(Me.TxtItem)
        Me.Controls.Add(Me.LblItem)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmDepreciation"
        Me.Text = "Campbell's Depreciation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblItem As Label
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents LblStartYear As Label
    Friend WithEvents LblStartValue As Label
    Friend WithEvents LblDuration As Label
    Friend WithEvents TxtStartYear As TextBox
    Friend WithEvents TxtStartValue As TextBox
    Friend WithEvents TxtDuration As TextBox
    Friend WithEvents BtnStraightMethod As Button
    Friend WithEvents BtnDblMethod As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents LstOutput As ListBox
End Class
