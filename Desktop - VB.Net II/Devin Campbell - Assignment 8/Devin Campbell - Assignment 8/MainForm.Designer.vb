<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbCustInfo = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New Devin_Campbell___Assignment_8.DBSet()
        Me.cmdNextRecord = New System.Windows.Forms.Button()
        Me.cmdLastRecord = New System.Windows.Forms.Button()
        Me.cmdUpdateRecord = New System.Windows.Forms.Button()
        Me.cmdDeleteRecord = New System.Windows.Forms.Button()
        Me.cmdAddRecord = New System.Windows.Forms.Button()
        Me.cmdPrevRecord = New System.Windows.Forms.Button()
        Me.cmdFirstRecord = New System.Windows.Forms.Button()
        Me.txtAddrZip = New System.Windows.Forms.TextBox()
        Me.txtAddrState = New System.Windows.Forms.TextBox()
        Me.txtAddrCity = New System.Windows.Forms.TextBox()
        Me.txtAddrSt = New System.Windows.Forms.TextBox()
        Me.txtNameLast = New System.Windows.Forms.TextBox()
        Me.txtNameFirst = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.bsOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbCustInfo.SuspendLayout()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCustInfo
        '
        Me.gbCustInfo.Controls.Add(Me.Label1)
        Me.gbCustInfo.Controls.Add(Me.txtID)
        Me.gbCustInfo.Controls.Add(Me.cmdNextRecord)
        Me.gbCustInfo.Controls.Add(Me.cmdLastRecord)
        Me.gbCustInfo.Controls.Add(Me.cmdUpdateRecord)
        Me.gbCustInfo.Controls.Add(Me.cmdDeleteRecord)
        Me.gbCustInfo.Controls.Add(Me.cmdAddRecord)
        Me.gbCustInfo.Controls.Add(Me.cmdPrevRecord)
        Me.gbCustInfo.Controls.Add(Me.cmdFirstRecord)
        Me.gbCustInfo.Controls.Add(Me.txtAddrZip)
        Me.gbCustInfo.Controls.Add(Me.txtAddrState)
        Me.gbCustInfo.Controls.Add(Me.txtAddrCity)
        Me.gbCustInfo.Controls.Add(Me.txtAddrSt)
        Me.gbCustInfo.Controls.Add(Me.txtNameLast)
        Me.gbCustInfo.Controls.Add(Me.txtNameFirst)
        Me.gbCustInfo.Controls.Add(Me.lblAddress)
        Me.gbCustInfo.Controls.Add(Me.lblName)
        Me.gbCustInfo.Location = New System.Drawing.Point(12, 12)
        Me.gbCustInfo.Name = "gbCustInfo"
        Me.gbCustInfo.Size = New System.Drawing.Size(531, 177)
        Me.gbCustInfo.TabIndex = 0
        Me.gbCustInfo.TabStop = False
        Me.gbCustInfo.Text = "Customer Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCustomers, "CustomerID", True))
        Me.txtID.Location = New System.Drawing.Point(455, 27)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(56, 20)
        Me.txtID.TabIndex = 15
        '
        'bsCustomers
        '
        Me.bsCustomers.DataMember = "Customers"
        Me.bsCustomers.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "DBSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdNextRecord
        '
        Me.cmdNextRecord.Location = New System.Drawing.Point(455, 134)
        Me.cmdNextRecord.Name = "cmdNextRecord"
        Me.cmdNextRecord.Size = New System.Drawing.Size(18, 23)
        Me.cmdNextRecord.TabIndex = 14
        Me.cmdNextRecord.Text = ">"
        Me.cmdNextRecord.UseVisualStyleBackColor = True
        '
        'cmdLastRecord
        '
        Me.cmdLastRecord.Location = New System.Drawing.Point(479, 134)
        Me.cmdLastRecord.Name = "cmdLastRecord"
        Me.cmdLastRecord.Size = New System.Drawing.Size(32, 23)
        Me.cmdLastRecord.TabIndex = 13
        Me.cmdLastRecord.Text = ">>"
        Me.cmdLastRecord.UseVisualStyleBackColor = True
        '
        'cmdUpdateRecord
        '
        Me.cmdUpdateRecord.Location = New System.Drawing.Point(231, 134)
        Me.cmdUpdateRecord.Name = "cmdUpdateRecord"
        Me.cmdUpdateRecord.Size = New System.Drawing.Size(58, 23)
        Me.cmdUpdateRecord.TabIndex = 12
        Me.cmdUpdateRecord.Text = "Update"
        Me.cmdUpdateRecord.UseVisualStyleBackColor = True
        '
        'cmdDeleteRecord
        '
        Me.cmdDeleteRecord.Location = New System.Drawing.Point(322, 134)
        Me.cmdDeleteRecord.Name = "cmdDeleteRecord"
        Me.cmdDeleteRecord.Size = New System.Drawing.Size(58, 23)
        Me.cmdDeleteRecord.TabIndex = 11
        Me.cmdDeleteRecord.Text = "Delete"
        Me.cmdDeleteRecord.UseVisualStyleBackColor = True
        '
        'cmdAddRecord
        '
        Me.cmdAddRecord.Location = New System.Drawing.Point(136, 134)
        Me.cmdAddRecord.Name = "cmdAddRecord"
        Me.cmdAddRecord.Size = New System.Drawing.Size(58, 23)
        Me.cmdAddRecord.TabIndex = 10
        Me.cmdAddRecord.Text = "Add"
        Me.cmdAddRecord.UseVisualStyleBackColor = True
        '
        'cmdPrevRecord
        '
        Me.cmdPrevRecord.Location = New System.Drawing.Point(46, 134)
        Me.cmdPrevRecord.Name = "cmdPrevRecord"
        Me.cmdPrevRecord.Size = New System.Drawing.Size(18, 23)
        Me.cmdPrevRecord.TabIndex = 9
        Me.cmdPrevRecord.Text = "<"
        Me.cmdPrevRecord.UseVisualStyleBackColor = True
        '
        'cmdFirstRecord
        '
        Me.cmdFirstRecord.Location = New System.Drawing.Point(8, 134)
        Me.cmdFirstRecord.Name = "cmdFirstRecord"
        Me.cmdFirstRecord.Size = New System.Drawing.Size(32, 23)
        Me.cmdFirstRecord.TabIndex = 8
        Me.cmdFirstRecord.Text = "<<"
        Me.cmdFirstRecord.UseVisualStyleBackColor = True
        '
        'txtAddrZip
        '
        Me.txtAddrZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCustomers, "ZipCode", True))
        Me.txtAddrZip.Location = New System.Drawing.Point(293, 79)
        Me.txtAddrZip.Name = "txtAddrZip"
        Me.txtAddrZip.Size = New System.Drawing.Size(112, 20)
        Me.txtAddrZip.TabIndex = 7
        '
        'txtAddrState
        '
        Me.txtAddrState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCustomers, "State", True))
        Me.txtAddrState.Location = New System.Drawing.Point(231, 79)
        Me.txtAddrState.Name = "txtAddrState"
        Me.txtAddrState.Size = New System.Drawing.Size(56, 20)
        Me.txtAddrState.TabIndex = 6
        '
        'txtAddrCity
        '
        Me.txtAddrCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCustomers, "City", True))
        Me.txtAddrCity.Location = New System.Drawing.Point(60, 79)
        Me.txtAddrCity.Name = "txtAddrCity"
        Me.txtAddrCity.Size = New System.Drawing.Size(165, 20)
        Me.txtAddrCity.TabIndex = 5
        '
        'txtAddrSt
        '
        Me.txtAddrSt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCustomers, "StreetAddress", True))
        Me.txtAddrSt.Location = New System.Drawing.Point(60, 53)
        Me.txtAddrSt.Name = "txtAddrSt"
        Me.txtAddrSt.Size = New System.Drawing.Size(345, 20)
        Me.txtAddrSt.TabIndex = 4
        '
        'txtNameLast
        '
        Me.txtNameLast.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCustomers, "LastName", True))
        Me.txtNameLast.Location = New System.Drawing.Point(231, 27)
        Me.txtNameLast.Name = "txtNameLast"
        Me.txtNameLast.Size = New System.Drawing.Size(174, 20)
        Me.txtNameLast.TabIndex = 3
        '
        'txtNameFirst
        '
        Me.txtNameFirst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCustomers, "FirstName", True))
        Me.txtNameFirst.Location = New System.Drawing.Point(60, 27)
        Me.txtNameFirst.Name = "txtNameFirst"
        Me.txtNameFirst.Size = New System.Drawing.Size(165, 20)
        Me.txtNameFirst.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 56)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'dgvOrders
        '
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Location = New System.Drawing.Point(12, 195)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.RowHeadersVisible = False
        Me.dgvOrders.Size = New System.Drawing.Size(531, 341)
        Me.dgvOrders.TabIndex = 1
        '
        'bsOrders
        '
        Me.bsOrders.DataMember = "Orders"
        Me.bsOrders.DataSource = Me.CustomerDataSet
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 548)
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.gbCustInfo)
        Me.Name = "MainForm"
        Me.Text = "Customer Order System"
        Me.gbCustInfo.ResumeLayout(False)
        Me.gbCustInfo.PerformLayout()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCustInfo As GroupBox
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents txtAddrZip As TextBox
    Friend WithEvents txtAddrState As TextBox
    Friend WithEvents txtAddrCity As TextBox
    Friend WithEvents txtAddrSt As TextBox
    Friend WithEvents txtNameLast As TextBox
    Friend WithEvents txtNameFirst As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents cmdNextRecord As Button
    Friend WithEvents cmdLastRecord As Button
    Friend WithEvents cmdUpdateRecord As Button
    Friend WithEvents cmdDeleteRecord As Button
    Friend WithEvents cmdAddRecord As Button
    Friend WithEvents cmdPrevRecord As Button
    Friend WithEvents cmdFirstRecord As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents CustomerDataSet As DBSet
    Friend WithEvents bsCustomers As BindingSource
    Friend WithEvents bsOrders As BindingSource
End Class
