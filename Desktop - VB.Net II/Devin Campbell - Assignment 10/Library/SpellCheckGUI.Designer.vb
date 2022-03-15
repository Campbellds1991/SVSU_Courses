<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpellCheckGUI
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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.cmdCheckWord = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(9, 19)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(36, 13)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "Word:"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(54, 16)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(362, 20)
        Me.txtWord.TabIndex = 1
        '
        'cmdCheckWord
        '
        Me.cmdCheckWord.Location = New System.Drawing.Point(433, 14)
        Me.cmdCheckWord.Name = "cmdCheckWord"
        Me.cmdCheckWord.Size = New System.Drawing.Size(122, 23)
        Me.cmdCheckWord.TabIndex = 2
        Me.cmdCheckWord.Text = "Check Spelling"
        Me.cmdCheckWord.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(9, 54)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 3
        '
        'SpellCheckGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 104)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.cmdCheckWord)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.Name = "SpellCheckGUI"
        Me.Text = "SpellCheckGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents cmdCheckWord As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
