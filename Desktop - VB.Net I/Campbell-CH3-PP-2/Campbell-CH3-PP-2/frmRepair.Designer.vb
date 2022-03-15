<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepair
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
        Me.LstBill = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtParts = New System.Windows.Forms.TextBox()
        Me.TxtLabor = New System.Windows.Forms.TextBox()
        Me.LblParts = New System.Windows.Forms.Label()
        Me.LblLabor = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnNewCustomer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstBill
        '
        Me.LstBill.Font = New System.Drawing.Font("Courier New", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBill.FormattingEnabled = True
        Me.LstBill.ItemHeight = 21
        Me.LstBill.Location = New System.Drawing.Point(74, 293)
        Me.LstBill.Name = "LstBill"
        Me.LstBill.Size = New System.Drawing.Size(519, 235)
        Me.LstBill.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "and supplies:"
        '
        'TxtParts
        '
        Me.TxtParts.Location = New System.Drawing.Point(235, 177)
        Me.TxtParts.Name = "TxtParts"
        Me.TxtParts.Size = New System.Drawing.Size(162, 29)
        Me.TxtParts.TabIndex = 2
        '
        'TxtLabor
        '
        Me.TxtLabor.Location = New System.Drawing.Point(235, 119)
        Me.TxtLabor.Name = "TxtLabor"
        Me.TxtLabor.Size = New System.Drawing.Size(162, 29)
        Me.TxtLabor.TabIndex = 1
        '
        'LblParts
        '
        Me.LblParts.AutoSize = True
        Me.LblParts.Location = New System.Drawing.Point(83, 181)
        Me.LblParts.Name = "LblParts"
        Me.LblParts.Size = New System.Drawing.Size(122, 25)
        Me.LblParts.TabIndex = 8
        Me.LblParts.Text = "Cost of parts"
        '
        'LblLabor
        '
        Me.LblLabor.AutoSize = True
        Me.LblLabor.Location = New System.Drawing.Point(83, 122)
        Me.LblLabor.Name = "LblLabor"
        Me.LblLabor.Size = New System.Drawing.Size(146, 25)
        Me.LblLabor.TabIndex = 7
        Me.LblLabor.Text = "Hours of Labor:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(69, 69)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(160, 25)
        Me.LblName.TabIndex = 6
        Me.LblName.Text = "Customer Name:"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(235, 66)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(281, 29)
        Me.TxtName.TabIndex = 0
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(590, 206)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(265, 43)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(590, 58)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(265, 47)
        Me.BtnCalculate.TabIndex = 3
        Me.BtnCalculate.Text = "Calculate Bill"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnNewCustomer
        '
        Me.BtnNewCustomer.Location = New System.Drawing.Point(590, 135)
        Me.BtnNewCustomer.Name = "BtnNewCustomer"
        Me.BtnNewCustomer.Size = New System.Drawing.Size(265, 43)
        Me.BtnNewCustomer.TabIndex = 4
        Me.BtnNewCustomer.Text = "New Customer"
        Me.BtnNewCustomer.UseVisualStyleBackColor = True
        '
        'frmRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 631)
        Me.Controls.Add(Me.BtnNewCustomer)
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
        Me.Name = "frmRepair"
        Me.Text = "Campbell's A-1 Auto Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstBill As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtParts As TextBox
    Friend WithEvents TxtLabor As TextBox
    Friend WithEvents LblParts As Label
    Friend WithEvents LblLabor As Label
    Friend WithEvents LblName As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnNewCustomer As Button
End Class
