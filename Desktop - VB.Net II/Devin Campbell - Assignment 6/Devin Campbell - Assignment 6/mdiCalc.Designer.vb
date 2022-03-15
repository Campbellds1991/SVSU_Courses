<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiCalc))
        Me.mnuBase = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileNewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowTileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowCascadeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBase.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuBase
        '
        Me.mnuBase.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuBase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpMenuItem})
        Me.mnuBase.Location = New System.Drawing.Point(0, 0)
        Me.mnuBase.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.mnuBase.Name = "mnuBase"
        Me.mnuBase.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuBase.Size = New System.Drawing.Size(807, 28)
        Me.mnuBase.TabIndex = 1
        Me.mnuBase.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileNewMenuItem, Me.FileExitMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'FileNewMenuItem
        '
        Me.FileNewMenuItem.Name = "FileNewMenuItem"
        Me.FileNewMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.FileNewMenuItem.Text = "&New"
        '
        'FileExitMenuItem
        '
        Me.FileExitMenuItem.Name = "FileExitMenuItem"
        Me.FileExitMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.FileExitMenuItem.Text = "E&xit"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowTileMenuItem, Me.WindowCascadeMenuItem, Me.ToolStripMenuItem1})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'WindowTileMenuItem
        '
        Me.WindowTileMenuItem.Name = "WindowTileMenuItem"
        Me.WindowTileMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.WindowTileMenuItem.Text = "Tile"
        '
        'WindowCascadeMenuItem
        '
        Me.WindowCascadeMenuItem.Name = "WindowCascadeMenuItem"
        Me.WindowCascadeMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.WindowCascadeMenuItem.Text = "Cascade"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'HelpMenuItem
        '
        Me.HelpMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpAboutMenuItem})
        Me.HelpMenuItem.Name = "HelpMenuItem"
        Me.HelpMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpMenuItem.Text = "&Help"
        '
        'HelpAboutMenuItem
        '
        Me.HelpAboutMenuItem.Name = "HelpAboutMenuItem"
        Me.HelpAboutMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.HelpAboutMenuItem.Text = "&About"
        '
        'mdiCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 654)
        Me.Controls.Add(Me.mnuBase)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuBase
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mdiCalc"
        Me.Text = "1970 Calcutech"
        Me.mnuBase.ResumeLayout(False)
        Me.mnuBase.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuBase As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileNewMenuItem As ToolStripMenuItem
    Friend WithEvents FileExitMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowTileMenuItem As ToolStripMenuItem
    Friend WithEvents WindowCascadeMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents HelpMenuItem As ToolStripMenuItem
    Friend WithEvents HelpAboutMenuItem As ToolStripMenuItem
End Class
