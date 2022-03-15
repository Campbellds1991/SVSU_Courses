<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class XeroxProgressBar
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblBtyeCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(700, 120)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(120, 30)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblBtyeCount
        '
        Me.lblBtyeCount.AutoSize = True
        Me.lblBtyeCount.Location = New System.Drawing.Point(75, 120)
        Me.lblBtyeCount.Name = "lblBtyeCount"
        Me.lblBtyeCount.Size = New System.Drawing.Size(0, 20)
        Me.lblBtyeCount.TabIndex = 3
        '
        'XeroxProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 154)
        Me.Controls.Add(Me.lblBtyeCount)
        Me.Controls.Add(Me.cmdClose)
        Me.Name = "XeroxProgressBar"
        Me.Text = "XeroxProgressBar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblBtyeCount As Label
End Class
