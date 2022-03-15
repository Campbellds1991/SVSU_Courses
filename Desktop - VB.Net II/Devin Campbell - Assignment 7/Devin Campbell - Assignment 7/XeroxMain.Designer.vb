<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XeroxMain
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
        Me.txtSourceDir = New System.Windows.Forms.TextBox()
        Me.cmdSetSource = New System.Windows.Forms.Button()
        Me.cmdSetDest = New System.Windows.Forms.Button()
        Me.lstDestContent = New System.Windows.Forms.ListBox()
        Me.txtDestDir = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbSource = New System.Windows.Forms.GroupBox()
        Me.lstSourceContent = New System.Windows.Forms.ListBox()
        Me.trbOverwrite = New System.Windows.Forms.TrackBar()
        Me.txtTrackLabel0 = New System.Windows.Forms.TextBox()
        Me.txtTrackLabel1 = New System.Windows.Forms.TextBox()
        Me.FolderSelectDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.gbSource.SuspendLayout()
        CType(Me.trbOverwrite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSourceDir
        '
        Me.txtSourceDir.Location = New System.Drawing.Point(7, 26)
        Me.txtSourceDir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSourceDir.Name = "txtSourceDir"
        Me.txtSourceDir.ReadOnly = True
        Me.txtSourceDir.Size = New System.Drawing.Size(854, 26)
        Me.txtSourceDir.TabIndex = 0
        '
        'cmdSetSource
        '
        Me.cmdSetSource.Location = New System.Drawing.Point(868, 22)
        Me.cmdSetSource.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSetSource.Name = "cmdSetSource"
        Me.cmdSetSource.Size = New System.Drawing.Size(172, 35)
        Me.cmdSetSource.TabIndex = 2
        Me.cmdSetSource.Text = "Set Source"
        Me.cmdSetSource.UseVisualStyleBackColor = True
        '
        'cmdSetDest
        '
        Me.cmdSetDest.Location = New System.Drawing.Point(868, 22)
        Me.cmdSetDest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSetDest.Name = "cmdSetDest"
        Me.cmdSetDest.Size = New System.Drawing.Size(172, 35)
        Me.cmdSetDest.TabIndex = 5
        Me.cmdSetDest.Text = "Set Destination"
        Me.cmdSetDest.UseVisualStyleBackColor = True
        '
        'lstDestContent
        '
        Me.lstDestContent.AllowDrop = True
        Me.lstDestContent.FormattingEnabled = True
        Me.lstDestContent.ItemHeight = 20
        Me.lstDestContent.Location = New System.Drawing.Point(7, 89)
        Me.lstDestContent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstDestContent.Name = "lstDestContent"
        Me.lstDestContent.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstDestContent.Size = New System.Drawing.Size(1033, 124)
        Me.lstDestContent.TabIndex = 4
        '
        'txtDestDir
        '
        Me.txtDestDir.Location = New System.Drawing.Point(7, 26)
        Me.txtDestDir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDestDir.Name = "txtDestDir"
        Me.txtDestDir.ReadOnly = True
        Me.txtDestDir.Size = New System.Drawing.Size(854, 26)
        Me.txtDestDir.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSetDest)
        Me.GroupBox1.Controls.Add(Me.lstDestContent)
        Me.GroupBox1.Controls.Add(Me.txtDestDir)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 305)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1063, 249)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destination Directory and Files"
        '
        'gbSource
        '
        Me.gbSource.Controls.Add(Me.lstSourceContent)
        Me.gbSource.Controls.Add(Me.cmdSetSource)
        Me.gbSource.Controls.Add(Me.txtSourceDir)
        Me.gbSource.Location = New System.Drawing.Point(22, 22)
        Me.gbSource.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbSource.Name = "gbSource"
        Me.gbSource.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbSource.Size = New System.Drawing.Size(1062, 249)
        Me.gbSource.TabIndex = 7
        Me.gbSource.TabStop = False
        Me.gbSource.Text = "Source Directory and Files"
        '
        'lstSourceContent
        '
        Me.lstSourceContent.AllowDrop = True
        Me.lstSourceContent.FormattingEnabled = True
        Me.lstSourceContent.ItemHeight = 20
        Me.lstSourceContent.Location = New System.Drawing.Point(7, 84)
        Me.lstSourceContent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSourceContent.Name = "lstSourceContent"
        Me.lstSourceContent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSourceContent.Size = New System.Drawing.Size(1033, 144)
        Me.lstSourceContent.TabIndex = 5
        '
        'trbOverwrite
        '
        Me.trbOverwrite.LargeChange = 1
        Me.trbOverwrite.Location = New System.Drawing.Point(310, 614)
        Me.trbOverwrite.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.trbOverwrite.Maximum = 1
        Me.trbOverwrite.Name = "trbOverwrite"
        Me.trbOverwrite.Size = New System.Drawing.Size(480, 69)
        Me.trbOverwrite.TabIndex = 8
        '
        'txtTrackLabel0
        '
        Me.txtTrackLabel0.BackColor = System.Drawing.SystemColors.Control
        Me.txtTrackLabel0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTrackLabel0.Location = New System.Drawing.Point(287, 668)
        Me.txtTrackLabel0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTrackLabel0.Multiline = True
        Me.txtTrackLabel0.Name = "txtTrackLabel0"
        Me.txtTrackLabel0.ReadOnly = True
        Me.txtTrackLabel0.Size = New System.Drawing.Size(79, 112)
        Me.txtTrackLabel0.TabIndex = 9
        Me.txtTrackLabel0.Text = "Do Not Copy if Filename Already Exists"
        Me.txtTrackLabel0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTrackLabel1
        '
        Me.txtTrackLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.txtTrackLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTrackLabel1.Location = New System.Drawing.Point(720, 668)
        Me.txtTrackLabel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTrackLabel1.Multiline = True
        Me.txtTrackLabel1.Name = "txtTrackLabel1"
        Me.txtTrackLabel1.ReadOnly = True
        Me.txtTrackLabel1.Size = New System.Drawing.Size(97, 84)
        Me.txtTrackLabel1.TabIndex = 10
        Me.txtTrackLabel1.Text = "Overwrite Existing Copy if Filename Exists"
        Me.txtTrackLabel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'XeroxMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 795)
        Me.Controls.Add(Me.txtTrackLabel1)
        Me.Controls.Add(Me.txtTrackLabel0)
        Me.Controls.Add(Me.trbOverwrite)
        Me.Controls.Add(Me.gbSource)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "XeroxMain"
        Me.Text = "Ye Ole File Xeroxer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbSource.ResumeLayout(False)
        Me.gbSource.PerformLayout()
        CType(Me.trbOverwrite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSourceDir As TextBox
    Friend WithEvents cmdSetSource As Button
    Friend WithEvents cmdSetDest As Button
    Friend WithEvents txtDestDir As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbSource As GroupBox
    Friend WithEvents trbOverwrite As TrackBar
    Friend WithEvents txtTrackLabel0 As TextBox
    Friend WithEvents txtTrackLabel1 As TextBox
    Friend WithEvents FolderSelectDialog As FolderBrowserDialog
    Private WithEvents lstDestContent As ListBox
    Private WithEvents lstSourceContent As ListBox
End Class
