<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCampbellProject01
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
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblLabor = New System.Windows.Forms.Label()
        Me.LblParts = New System.Windows.Forms.Label()
        Me.TxtLabor = New System.Windows.Forms.TextBox()
        Me.TxtParts = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstBill = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(582, 54)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(265, 47)
        Me.BtnCalculate.TabIndex = 0
        Me.BtnCalculate.Text = "Calculate Bill"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(582, 178)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(265, 43)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(227, 72)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(281, 29)
        Me.TxtName.TabIndex = 2
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(61, 75)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(160, 25)
        Me.LblName.TabIndex = 3
        Me.LblName.Text = "Customer Name:"
        '
        'LblLabor
        '
        Me.LblLabor.AutoSize = True
        Me.LblLabor.Location = New System.Drawing.Point(75, 128)
        Me.LblLabor.Name = "LblLabor"
        Me.LblLabor.Size = New System.Drawing.Size(146, 25)
        Me.LblLabor.TabIndex = 4
        Me.LblLabor.Text = "Hours of Labor:"
        '
        'LblParts
        '
        Me.LblParts.AutoSize = True
        Me.LblParts.Location = New System.Drawing.Point(75, 187)
        Me.LblParts.Name = "LblParts"
        Me.LblParts.Size = New System.Drawing.Size(122, 25)
        Me.LblParts.TabIndex = 5
        Me.LblParts.Text = "Cost of parts"
        '
        'TxtLabor
        '
        Me.TxtLabor.Location = New System.Drawing.Point(227, 125)
        Me.TxtLabor.Name = "TxtLabor"
        Me.TxtLabor.Size = New System.Drawing.Size(162, 29)
        Me.TxtLabor.TabIndex = 6
        '
        'TxtParts
        '
        Me.TxtParts.Location = New System.Drawing.Point(227, 183)
        Me.TxtParts.Name = "TxtParts"
        Me.TxtParts.Size = New System.Drawing.Size(162, 29)
        Me.TxtParts.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "and supplies:"
        '
        'LstBill
        '
        Me.LstBill.Font = New System.Drawing.Font("Courier New", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBill.FormattingEnabled = True
        Me.LstBill.ItemHeight = 21
        Me.LstBill.Location = New System.Drawing.Point(66, 299)
        Me.LstBill.Name = "LstBill"
        Me.LstBill.Size = New System.Drawing.Size(519, 235)
        Me.LstBill.TabIndex = 9
        '
        'FrmCampbellProject01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 676)
        Me.Controls.Add(Me.LstBill)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtParts)
        Me.Controls.Add(Me.TxtLabor)
        Me.Controls.Add(Me.LblParts)
        Me.Controls.Add(Me.LblLabor)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Name = "FrmCampbellProject01"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents LblLabor As Label
    Friend WithEvents LblParts As Label
    Friend WithEvents TxtLabor As TextBox
    Friend WithEvents TxtParts As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LstBill As ListBox
End Class
