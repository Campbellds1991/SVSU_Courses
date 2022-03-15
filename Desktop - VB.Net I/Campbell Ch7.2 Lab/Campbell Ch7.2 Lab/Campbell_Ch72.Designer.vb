<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Campbell_Ch72
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
        Me.Ex1_GbStates = New System.Windows.Forms.GroupBox()
        Me.Ex1_LstOutput = New System.Windows.Forms.ListBox()
        Me.Ex1_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex2_GbNumbers = New System.Windows.Forms.GroupBox()
        Me.Ex2_LstOutput = New System.Windows.Forms.ListBox()
        Me.Ex2_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex4_GbSort = New System.Windows.Forms.GroupBox()
        Me.Ex4_LstOutput = New System.Windows.Forms.ListBox()
        Me.Ex4_BtnSort = New System.Windows.Forms.Button()
        Me.Ex5_GbStates = New System.Windows.Forms.GroupBox()
        Me.Ex5_LstStates = New System.Windows.Forms.ListBox()
        Me.Ex5_BtnDisplay = New System.Windows.Forms.Button()
        Me.Ex1_GbStates.SuspendLayout()
        Me.Ex2_GbNumbers.SuspendLayout()
        Me.Ex4_GbSort.SuspendLayout()
        Me.Ex5_GbStates.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ex1_GbStates
        '
        Me.Ex1_GbStates.Controls.Add(Me.Ex1_LstOutput)
        Me.Ex1_GbStates.Controls.Add(Me.Ex1_BtnDisplay)
        Me.Ex1_GbStates.Location = New System.Drawing.Point(13, 13)
        Me.Ex1_GbStates.Name = "Ex1_GbStates"
        Me.Ex1_GbStates.Size = New System.Drawing.Size(188, 168)
        Me.Ex1_GbStates.TabIndex = 0
        Me.Ex1_GbStates.TabStop = False
        Me.Ex1_GbStates.Text = "U.S. States"
        '
        'Ex1_LstOutput
        '
        Me.Ex1_LstOutput.FormattingEnabled = True
        Me.Ex1_LstOutput.Location = New System.Drawing.Point(30, 49)
        Me.Ex1_LstOutput.Name = "Ex1_LstOutput"
        Me.Ex1_LstOutput.Size = New System.Drawing.Size(120, 108)
        Me.Ex1_LstOutput.TabIndex = 1
        '
        'Ex1_BtnDisplay
        '
        Me.Ex1_BtnDisplay.Location = New System.Drawing.Point(30, 19)
        Me.Ex1_BtnDisplay.Name = "Ex1_BtnDisplay"
        Me.Ex1_BtnDisplay.Size = New System.Drawing.Size(118, 23)
        Me.Ex1_BtnDisplay.TabIndex = 0
        Me.Ex1_BtnDisplay.Text = "Display States"
        Me.Ex1_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex2_GbNumbers
        '
        Me.Ex2_GbNumbers.Controls.Add(Me.Ex2_LstOutput)
        Me.Ex2_GbNumbers.Controls.Add(Me.Ex2_BtnDisplay)
        Me.Ex2_GbNumbers.Location = New System.Drawing.Point(207, 13)
        Me.Ex2_GbNumbers.Name = "Ex2_GbNumbers"
        Me.Ex2_GbNumbers.Size = New System.Drawing.Size(188, 168)
        Me.Ex2_GbNumbers.TabIndex = 2
        Me.Ex2_GbNumbers.TabStop = False
        Me.Ex2_GbNumbers.Text = "Numbers"
        '
        'Ex2_LstOutput
        '
        Me.Ex2_LstOutput.FormattingEnabled = True
        Me.Ex2_LstOutput.Location = New System.Drawing.Point(30, 49)
        Me.Ex2_LstOutput.Name = "Ex2_LstOutput"
        Me.Ex2_LstOutput.Size = New System.Drawing.Size(120, 108)
        Me.Ex2_LstOutput.TabIndex = 1
        '
        'Ex2_BtnDisplay
        '
        Me.Ex2_BtnDisplay.Location = New System.Drawing.Point(30, 19)
        Me.Ex2_BtnDisplay.Name = "Ex2_BtnDisplay"
        Me.Ex2_BtnDisplay.Size = New System.Drawing.Size(118, 23)
        Me.Ex2_BtnDisplay.TabIndex = 0
        Me.Ex2_BtnDisplay.Text = "Display Numbers"
        Me.Ex2_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Ex4_GbSort
        '
        Me.Ex4_GbSort.Controls.Add(Me.Ex4_LstOutput)
        Me.Ex4_GbSort.Controls.Add(Me.Ex4_BtnSort)
        Me.Ex4_GbSort.Location = New System.Drawing.Point(13, 187)
        Me.Ex4_GbSort.Name = "Ex4_GbSort"
        Me.Ex4_GbSort.Size = New System.Drawing.Size(188, 168)
        Me.Ex4_GbSort.TabIndex = 3
        Me.Ex4_GbSort.TabStop = False
        Me.Ex4_GbSort.Text = "Sorting with LINQ"
        '
        'Ex4_LstOutput
        '
        Me.Ex4_LstOutput.FormattingEnabled = True
        Me.Ex4_LstOutput.Location = New System.Drawing.Point(30, 49)
        Me.Ex4_LstOutput.Name = "Ex4_LstOutput"
        Me.Ex4_LstOutput.Size = New System.Drawing.Size(120, 108)
        Me.Ex4_LstOutput.TabIndex = 1
        '
        'Ex4_BtnSort
        '
        Me.Ex4_BtnSort.Location = New System.Drawing.Point(30, 19)
        Me.Ex4_BtnSort.Name = "Ex4_BtnSort"
        Me.Ex4_BtnSort.Size = New System.Drawing.Size(118, 23)
        Me.Ex4_BtnSort.TabIndex = 0
        Me.Ex4_BtnSort.Text = "Sort Numbers"
        Me.Ex4_BtnSort.UseVisualStyleBackColor = True
        '
        'Ex5_GbStates
        '
        Me.Ex5_GbStates.Controls.Add(Me.Ex5_LstStates)
        Me.Ex5_GbStates.Controls.Add(Me.Ex5_BtnDisplay)
        Me.Ex5_GbStates.Location = New System.Drawing.Point(207, 187)
        Me.Ex5_GbStates.Name = "Ex5_GbStates"
        Me.Ex5_GbStates.Size = New System.Drawing.Size(188, 168)
        Me.Ex5_GbStates.TabIndex = 2
        Me.Ex5_GbStates.TabStop = False
        Me.Ex5_GbStates.Text = "U.S. States"
        '
        'Ex5_LstStates
        '
        Me.Ex5_LstStates.FormattingEnabled = True
        Me.Ex5_LstStates.Location = New System.Drawing.Point(30, 49)
        Me.Ex5_LstStates.Name = "Ex5_LstStates"
        Me.Ex5_LstStates.Size = New System.Drawing.Size(120, 108)
        Me.Ex5_LstStates.TabIndex = 1
        '
        'Ex5_BtnDisplay
        '
        Me.Ex5_BtnDisplay.Location = New System.Drawing.Point(30, 19)
        Me.Ex5_BtnDisplay.Name = "Ex5_BtnDisplay"
        Me.Ex5_BtnDisplay.Size = New System.Drawing.Size(118, 23)
        Me.Ex5_BtnDisplay.TabIndex = 0
        Me.Ex5_BtnDisplay.Text = "Display States"
        Me.Ex5_BtnDisplay.UseVisualStyleBackColor = True
        '
        'Campbell_Ch72
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 402)
        Me.Controls.Add(Me.Ex5_GbStates)
        Me.Controls.Add(Me.Ex4_GbSort)
        Me.Controls.Add(Me.Ex2_GbNumbers)
        Me.Controls.Add(Me.Ex1_GbStates)
        Me.Name = "Campbell_Ch72"
        Me.Text = "Campbell Ch 7.2 Lab"
        Me.Ex1_GbStates.ResumeLayout(False)
        Me.Ex2_GbNumbers.ResumeLayout(False)
        Me.Ex4_GbSort.ResumeLayout(False)
        Me.Ex5_GbStates.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ex1_GbStates As GroupBox
    Friend WithEvents Ex1_LstOutput As ListBox
    Friend WithEvents Ex1_BtnDisplay As Button
    Friend WithEvents Ex2_GbNumbers As GroupBox
    Friend WithEvents Ex2_LstOutput As ListBox
    Friend WithEvents Ex2_BtnDisplay As Button
    Friend WithEvents Ex4_GbSort As GroupBox
    Friend WithEvents Ex4_LstOutput As ListBox
    Friend WithEvents Ex4_BtnSort As Button
    Friend WithEvents Ex5_GbStates As GroupBox
    Friend WithEvents Ex5_LstStates As ListBox
    Friend WithEvents Ex5_BtnDisplay As Button
End Class
