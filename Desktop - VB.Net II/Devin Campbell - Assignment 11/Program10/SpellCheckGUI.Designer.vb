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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpellCheckGUI))
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.cmdCheckWord = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWord
        '
        resources.ApplyResources(Me.lblWord, "lblWord")
        Me.lblWord.Name = "lblWord"
        '
        'txtWord
        '
        resources.ApplyResources(Me.txtWord, "txtWord")
        Me.txtWord.Name = "txtWord"
        '
        'cmdCheckWord
        '
        resources.ApplyResources(Me.cmdCheckWord, "cmdCheckWord")
        Me.cmdCheckWord.Name = "cmdCheckWord"
        Me.cmdCheckWord.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        resources.ApplyResources(Me.lblResult, "lblResult")
        Me.lblResult.Name = "lblResult"
        '
        'SpellCheckGUI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.cmdCheckWord)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.Name = "SpellCheckGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents cmdCheckWord As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
