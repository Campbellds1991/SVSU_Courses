<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCH22Lab
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
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtCSZ = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblCSZ = New System.Windows.Forms.Label()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.LstResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(351, 68)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(200, 29)
        Me.TxtName.TabIndex = 0
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(351, 133)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(200, 29)
        Me.TxtAddress.TabIndex = 1
        '
        'TxtCSZ
        '
        Me.TxtCSZ.Location = New System.Drawing.Point(351, 199)
        Me.TxtCSZ.Name = "TxtCSZ"
        Me.TxtCSZ.Size = New System.Drawing.Size(200, 29)
        Me.TxtCSZ.TabIndex = 2
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(275, 71)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(70, 25)
        Me.LblName.TabIndex = 3
        Me.LblName.Text = "Name:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(254, 136)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(91, 25)
        Me.LblAddress.TabIndex = 4
        Me.LblAddress.Text = "Address:"
        '
        'LblCSZ
        '
        Me.LblCSZ.AutoSize = True
        Me.LblCSZ.Location = New System.Drawing.Point(205, 202)
        Me.LblCSZ.Name = "LblCSZ"
        Me.LblCSZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCSZ.Size = New System.Drawing.Size(140, 25)
        Me.LblCSZ.TabIndex = 5
        Me.LblCSZ.Text = "City, State Zip:"
        '
        'BtnProcess
        '
        Me.BtnProcess.Location = New System.Drawing.Point(210, 290)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(200, 40)
        Me.BtnProcess.TabIndex = 6
        Me.BtnProcess.Text = "&Process"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(557, 284)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(200, 40)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtResult
        '
        Me.TxtResult.Location = New System.Drawing.Point(210, 469)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.ReadOnly = True
        Me.TxtResult.Size = New System.Drawing.Size(500, 29)
        Me.TxtResult.TabIndex = 8
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Location = New System.Drawing.Point(127, 472)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(77, 25)
        Me.LblResult.TabIndex = 9
        Me.LblResult.Text = "Result: "
        '
        'LstResult
        '
        Me.LstResult.FormattingEnabled = True
        Me.LstResult.ItemHeight = 24
        Me.LstResult.Location = New System.Drawing.Point(210, 514)
        Me.LstResult.Name = "LstResult"
        Me.LstResult.Size = New System.Drawing.Size(500, 172)
        Me.LstResult.TabIndex = 10
        '
        'FrmCH22Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 703)
        Me.Controls.Add(Me.LstResult)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.LblCSZ)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtCSZ)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "FrmCH22Lab"
        Me.Text = "Campbell CH2.2 LAb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtCSZ As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblCSZ As Label
    Friend WithEvents BtnProcess As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtResult As TextBox
    Friend WithEvents LblResult As Label
    Friend WithEvents LstResult As ListBox
End Class
