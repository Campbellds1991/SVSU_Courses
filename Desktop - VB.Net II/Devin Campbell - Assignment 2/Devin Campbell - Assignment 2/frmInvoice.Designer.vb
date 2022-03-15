<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
		Me.lstInvoice = New System.Windows.Forms.ListBox()
		Me.cmdChangeOrder = New System.Windows.Forms.Button()
		Me.cmdSendOrder = New System.Windows.Forms.Button()
		Me.cmdExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lstInvoice
		'
		Me.lstInvoice.Font = New System.Drawing.Font("Courier New", 8.0!)
		Me.lstInvoice.FormattingEnabled = True
		Me.lstInvoice.ItemHeight = 21
		Me.lstInvoice.Location = New System.Drawing.Point(13, 13)
		Me.lstInvoice.Name = "lstInvoice"
		Me.lstInvoice.Size = New System.Drawing.Size(939, 718)
		Me.lstInvoice.TabIndex = 0
		'
		'cmdChangeOrder
		'
		Me.cmdChangeOrder.Location = New System.Drawing.Point(13, 757)
		Me.cmdChangeOrder.Name = "cmdChangeOrder"
		Me.cmdChangeOrder.Size = New System.Drawing.Size(248, 69)
		Me.cmdChangeOrder.TabIndex = 1
		Me.cmdChangeOrder.Text = "Change Order"
		Me.cmdChangeOrder.UseVisualStyleBackColor = True
		'
		'cmdSendOrder
		'
		Me.cmdSendOrder.Location = New System.Drawing.Point(358, 757)
		Me.cmdSendOrder.Name = "cmdSendOrder"
		Me.cmdSendOrder.Size = New System.Drawing.Size(248, 69)
		Me.cmdSendOrder.TabIndex = 2
		Me.cmdSendOrder.Text = "Send Order To Kitchen"
		Me.cmdSendOrder.UseVisualStyleBackColor = True
		'
		'cmdExit
		'
		Me.cmdExit.Location = New System.Drawing.Point(703, 757)
		Me.cmdExit.Name = "cmdExit"
		Me.cmdExit.Size = New System.Drawing.Size(248, 69)
		Me.cmdExit.TabIndex = 3
		Me.cmdExit.Text = "Exit"
		Me.cmdExit.UseVisualStyleBackColor = True
		'
		'frmInvoice
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(971, 854)
		Me.Controls.Add(Me.cmdExit)
		Me.Controls.Add(Me.cmdSendOrder)
		Me.Controls.Add(Me.cmdChangeOrder)
		Me.Controls.Add(Me.lstInvoice)
		Me.Name = "frmInvoice"
		Me.Text = "Pizza Planet Invoice"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lstInvoice As ListBox
	Friend WithEvents cmdChangeOrder As Button
	Friend WithEvents cmdSendOrder As Button
	Friend WithEvents cmdExit As Button
End Class
