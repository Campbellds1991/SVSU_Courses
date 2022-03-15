<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrder
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
        Me.GbCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.LblCustFineprint = New System.Windows.Forms.Label()
        Me.TxtCustName_Tip = New System.Windows.Forms.Label()
        Me.LblCustCSZ = New System.Windows.Forms.Label()
        Me.LblCustAddress = New System.Windows.Forms.Label()
        Me.LblCustName = New System.Windows.Forms.Label()
        Me.TxtCustCSZ = New System.Windows.Forms.TextBox()
        Me.TxtCustAddress = New System.Windows.Forms.TextBox()
        Me.TxtCustName = New System.Windows.Forms.TextBox()
        Me.GbOrderInfo = New System.Windows.Forms.GroupBox()
        Me.TxtOrder_Dishwasher = New System.Windows.Forms.MaskedTextBox()
        Me.TxtOrder_Refridg = New System.Windows.Forms.MaskedTextBox()
        Me.TxtOrder_Stove = New System.Windows.Forms.MaskedTextBox()
        Me.LblOrderHeadQuantity = New System.Windows.Forms.Label()
        Me.LblOrder_Dishwasher = New System.Windows.Forms.Label()
        Me.LblOrder_Refr = New System.Windows.Forms.Label()
        Me.LblOrder_Stoves = New System.Windows.Forms.Label()
        Me.LblOrderHeadItem = New System.Windows.Forms.Label()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.LstOut_Invoice = New System.Windows.Forms.ListBox()
        Me.GbCustomerInfo.SuspendLayout()
        Me.GbOrderInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbCustomerInfo
        '
        Me.GbCustomerInfo.BackColor = System.Drawing.Color.Gray
        Me.GbCustomerInfo.Controls.Add(Me.LblCustFineprint)
        Me.GbCustomerInfo.Controls.Add(Me.TxtCustName_Tip)
        Me.GbCustomerInfo.Controls.Add(Me.LblCustCSZ)
        Me.GbCustomerInfo.Controls.Add(Me.LblCustAddress)
        Me.GbCustomerInfo.Controls.Add(Me.LblCustName)
        Me.GbCustomerInfo.Controls.Add(Me.TxtCustCSZ)
        Me.GbCustomerInfo.Controls.Add(Me.TxtCustAddress)
        Me.GbCustomerInfo.Controls.Add(Me.TxtCustName)
        Me.GbCustomerInfo.ForeColor = System.Drawing.Color.Black
        Me.GbCustomerInfo.Location = New System.Drawing.Point(12, 12)
        Me.GbCustomerInfo.Name = "GbCustomerInfo"
        Me.GbCustomerInfo.Size = New System.Drawing.Size(623, 228)
        Me.GbCustomerInfo.TabIndex = 1
        Me.GbCustomerInfo.TabStop = False
        Me.GbCustomerInfo.Text = "Customer Information"
        '
        'LblCustFineprint
        '
        Me.LblCustFineprint.AutoSize = True
        Me.LblCustFineprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustFineprint.Location = New System.Drawing.Point(146, 187)
        Me.LblCustFineprint.Name = "LblCustFineprint"
        Me.LblCustFineprint.Size = New System.Drawing.Size(263, 15)
        Me.LblCustFineprint.TabIndex = 10
        Me.LblCustFineprint.Text = "***All Forms are Required to be filled***"
        '
        'TxtCustName_Tip
        '
        Me.TxtCustName_Tip.AutoSize = True
        Me.TxtCustName_Tip.Location = New System.Drawing.Point(183, 69)
        Me.TxtCustName_Tip.Name = "TxtCustName_Tip"
        Me.TxtCustName_Tip.Size = New System.Drawing.Size(132, 20)
        Me.TxtCustName_Tip.TabIndex = 6
        Me.TxtCustName_Tip.Text = "(First space Last)"
        '
        'LblCustCSZ
        '
        Me.LblCustCSZ.AutoSize = True
        Me.LblCustCSZ.Location = New System.Drawing.Point(16, 150)
        Me.LblCustCSZ.Name = "LblCustCSZ"
        Me.LblCustCSZ.Size = New System.Drawing.Size(116, 20)
        Me.LblCustCSZ.TabIndex = 5
        Me.LblCustCSZ.Text = "City, State, Zip:"
        '
        'LblCustAddress
        '
        Me.LblCustAddress.AutoSize = True
        Me.LblCustAddress.Location = New System.Drawing.Point(58, 102)
        Me.LblCustAddress.Name = "LblCustAddress"
        Me.LblCustAddress.Size = New System.Drawing.Size(76, 20)
        Me.LblCustAddress.TabIndex = 4
        Me.LblCustAddress.Text = "Address: "
        '
        'LblCustName
        '
        Me.LblCustName.AutoSize = True
        Me.LblCustName.Location = New System.Drawing.Point(6, 43)
        Me.LblCustName.Name = "LblCustName"
        Me.LblCustName.Size = New System.Drawing.Size(128, 20)
        Me.LblCustName.TabIndex = 3
        Me.LblCustName.Text = "Customer Name:"
        '
        'TxtCustCSZ
        '
        Me.TxtCustCSZ.Location = New System.Drawing.Point(138, 147)
        Me.TxtCustCSZ.Name = "TxtCustCSZ"
        Me.TxtCustCSZ.Size = New System.Drawing.Size(460, 26)
        Me.TxtCustCSZ.TabIndex = 2
        '
        'TxtCustAddress
        '
        Me.TxtCustAddress.Location = New System.Drawing.Point(140, 102)
        Me.TxtCustAddress.Name = "TxtCustAddress"
        Me.TxtCustAddress.Size = New System.Drawing.Size(460, 26)
        Me.TxtCustAddress.TabIndex = 1
        '
        'TxtCustName
        '
        Me.TxtCustName.Location = New System.Drawing.Point(140, 40)
        Me.TxtCustName.Name = "TxtCustName"
        Me.TxtCustName.Size = New System.Drawing.Size(460, 26)
        Me.TxtCustName.TabIndex = 0
        '
        'GbOrderInfo
        '
        Me.GbOrderInfo.BackColor = System.Drawing.Color.Gray
        Me.GbOrderInfo.Controls.Add(Me.TxtOrder_Dishwasher)
        Me.GbOrderInfo.Controls.Add(Me.TxtOrder_Refridg)
        Me.GbOrderInfo.Controls.Add(Me.TxtOrder_Stove)
        Me.GbOrderInfo.Controls.Add(Me.LblOrderHeadQuantity)
        Me.GbOrderInfo.Controls.Add(Me.LblOrder_Dishwasher)
        Me.GbOrderInfo.Controls.Add(Me.LblOrder_Refr)
        Me.GbOrderInfo.Controls.Add(Me.LblOrder_Stoves)
        Me.GbOrderInfo.Controls.Add(Me.LblOrderHeadItem)
        Me.GbOrderInfo.Location = New System.Drawing.Point(12, 257)
        Me.GbOrderInfo.Name = "GbOrderInfo"
        Me.GbOrderInfo.Size = New System.Drawing.Size(276, 214)
        Me.GbOrderInfo.TabIndex = 2
        Me.GbOrderInfo.TabStop = False
        Me.GbOrderInfo.Text = "Order Information"
        '
        'TxtOrder_Dishwasher
        '
        Me.TxtOrder_Dishwasher.Location = New System.Drawing.Point(138, 133)
        Me.TxtOrder_Dishwasher.Mask = "##"
        Me.TxtOrder_Dishwasher.Name = "TxtOrder_Dishwasher"
        Me.TxtOrder_Dishwasher.Size = New System.Drawing.Size(100, 26)
        Me.TxtOrder_Dishwasher.TabIndex = 12
        '
        'TxtOrder_Refridg
        '
        Me.TxtOrder_Refridg.Location = New System.Drawing.Point(138, 101)
        Me.TxtOrder_Refridg.Mask = "##"
        Me.TxtOrder_Refridg.Name = "TxtOrder_Refridg"
        Me.TxtOrder_Refridg.Size = New System.Drawing.Size(100, 26)
        Me.TxtOrder_Refridg.TabIndex = 11
        '
        'TxtOrder_Stove
        '
        Me.TxtOrder_Stove.Location = New System.Drawing.Point(138, 69)
        Me.TxtOrder_Stove.Mask = "##"
        Me.TxtOrder_Stove.Name = "TxtOrder_Stove"
        Me.TxtOrder_Stove.Size = New System.Drawing.Size(100, 26)
        Me.TxtOrder_Stove.TabIndex = 10
        '
        'LblOrderHeadQuantity
        '
        Me.LblOrderHeadQuantity.AutoSize = True
        Me.LblOrderHeadQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrderHeadQuantity.Location = New System.Drawing.Point(156, 39)
        Me.LblOrderHeadQuantity.Name = "LblOrderHeadQuantity"
        Me.LblOrderHeadQuantity.Size = New System.Drawing.Size(68, 20)
        Me.LblOrderHeadQuantity.TabIndex = 4
        Me.LblOrderHeadQuantity.Text = "Quantity"
        '
        'LblOrder_Dishwasher
        '
        Me.LblOrder_Dishwasher.AutoSize = True
        Me.LblOrder_Dishwasher.Location = New System.Drawing.Point(20, 136)
        Me.LblOrder_Dishwasher.Name = "LblOrder_Dishwasher"
        Me.LblOrder_Dishwasher.Size = New System.Drawing.Size(92, 20)
        Me.LblOrder_Dishwasher.TabIndex = 3
        Me.LblOrder_Dishwasher.Text = "Dishwasher"
        '
        'LblOrder_Refr
        '
        Me.LblOrder_Refr.AutoSize = True
        Me.LblOrder_Refr.Location = New System.Drawing.Point(20, 104)
        Me.LblOrder_Refr.Name = "LblOrder_Refr"
        Me.LblOrder_Refr.Size = New System.Drawing.Size(94, 20)
        Me.LblOrder_Refr.TabIndex = 2
        Me.LblOrder_Refr.Text = "Refrigerator"
        '
        'LblOrder_Stoves
        '
        Me.LblOrder_Stoves.AutoSize = True
        Me.LblOrder_Stoves.Location = New System.Drawing.Point(20, 71)
        Me.LblOrder_Stoves.Name = "LblOrder_Stoves"
        Me.LblOrder_Stoves.Size = New System.Drawing.Size(58, 20)
        Me.LblOrder_Stoves.TabIndex = 1
        Me.LblOrder_Stoves.Text = "Stoves"
        '
        'LblOrderHeadItem
        '
        Me.LblOrderHeadItem.AutoSize = True
        Me.LblOrderHeadItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrderHeadItem.Location = New System.Drawing.Point(20, 39)
        Me.LblOrderHeadItem.Name = "LblOrderHeadItem"
        Me.LblOrderHeadItem.Size = New System.Drawing.Size(49, 20)
        Me.LblOrderHeadItem.TabIndex = 0
        Me.LblOrderHeadItem.Text = "Items"
        '
        'BtnProcess
        '
        Me.BtnProcess.Location = New System.Drawing.Point(395, 280)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(202, 36)
        Me.BtnProcess.TabIndex = 3
        Me.BtnProcess.Text = "&Process Order"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(395, 345)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(202, 36)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "&Clear Order Form"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(395, 410)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(202, 36)
        Me.BtnQuit.TabIndex = 5
        Me.BtnQuit.Text = "&Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'LstOut_Invoice
        '
        Me.LstOut_Invoice.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOut_Invoice.FormattingEnabled = True
        Me.LstOut_Invoice.ItemHeight = 18
        Me.LstOut_Invoice.Location = New System.Drawing.Point(12, 477)
        Me.LstOut_Invoice.Name = "LstOut_Invoice"
        Me.LstOut_Invoice.Size = New System.Drawing.Size(624, 616)
        Me.LstOut_Invoice.TabIndex = 6
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(647, 1119)
        Me.Controls.Add(Me.LstOut_Invoice)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.GbOrderInfo)
        Me.Controls.Add(Me.GbCustomerInfo)
        Me.MaximizeBox = False
        Me.Name = "FrmOrder"
        Me.Text = "Campbell Appliance Warehouse"
        Me.GbCustomerInfo.ResumeLayout(False)
        Me.GbCustomerInfo.PerformLayout()
        Me.GbOrderInfo.ResumeLayout(False)
        Me.GbOrderInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbCustomerInfo As GroupBox
    Friend WithEvents TxtCustCSZ As TextBox
    Friend WithEvents TxtCustAddress As TextBox
    Friend WithEvents TxtCustName As TextBox
    Friend WithEvents TxtCustName_Tip As Label
    Friend WithEvents LblCustCSZ As Label
    Friend WithEvents LblCustAddress As Label
    Friend WithEvents LblCustName As Label
    Friend WithEvents GbOrderInfo As GroupBox
    Friend WithEvents LblOrder_Dishwasher As Label
    Friend WithEvents LblOrder_Refr As Label
    Friend WithEvents LblOrder_Stoves As Label
    Friend WithEvents LblOrderHeadItem As Label
    Friend WithEvents LblOrderHeadQuantity As Label
    Friend WithEvents BtnProcess As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents LstOut_Invoice As ListBox
    Friend WithEvents LblCustFineprint As Label
    Friend WithEvents TxtOrder_Dishwasher As MaskedTextBox
    Friend WithEvents TxtOrder_Refridg As MaskedTextBox
    Friend WithEvents TxtOrder_Stove As MaskedTextBox
End Class
