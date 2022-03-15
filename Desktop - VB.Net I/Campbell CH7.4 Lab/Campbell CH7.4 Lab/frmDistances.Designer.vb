<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistance
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
        Me.LblCh = New System.Windows.Forms.Label()
        Me.LbLA = New System.Windows.Forms.Label()
        Me.LblNY = New System.Windows.Forms.Label()
        Me.LblPh = New System.Windows.Forms.Label()
        Me.LblDestination = New System.Windows.Forms.Label()
        Me.LblOrigin = New System.Windows.Forms.Label()
        Me.MtbOrigin = New System.Windows.Forms.MaskedTextBox()
        Me.MtbDest = New System.Windows.Forms.MaskedTextBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.LblMiles = New System.Windows.Forms.Label()
        Me.TxtMiles = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblCh
        '
        Me.LblCh.AutoSize = True
        Me.LblCh.Location = New System.Drawing.Point(42, 27)
        Me.LblCh.Name = "LblCh"
        Me.LblCh.Size = New System.Drawing.Size(84, 20)
        Me.LblCh.TabIndex = 0
        Me.LblCh.Text = "1. Chicago"
        '
        'LbLA
        '
        Me.LbLA.AutoSize = True
        Me.LbLA.Location = New System.Drawing.Point(42, 61)
        Me.LbLA.Name = "LbLA"
        Me.LbLA.Size = New System.Drawing.Size(114, 20)
        Me.LbLA.TabIndex = 1
        Me.LbLA.Text = "2. Los Angeles"
        '
        'LblNY
        '
        Me.LblNY.AutoSize = True
        Me.LblNY.Location = New System.Drawing.Point(42, 95)
        Me.LblNY.Name = "LblNY"
        Me.LblNY.Size = New System.Drawing.Size(94, 20)
        Me.LblNY.TabIndex = 2
        Me.LblNY.Text = "3. New York"
        '
        'LblPh
        '
        Me.LblPh.AutoSize = True
        Me.LblPh.Location = New System.Drawing.Point(42, 129)
        Me.LblPh.Name = "LblPh"
        Me.LblPh.Size = New System.Drawing.Size(111, 20)
        Me.LblPh.TabIndex = 3
        Me.LblPh.Text = "4. Philadelphia"
        '
        'LblDestination
        '
        Me.LblDestination.AutoSize = True
        Me.LblDestination.Location = New System.Drawing.Point(220, 95)
        Me.LblDestination.Name = "LblDestination"
        Me.LblDestination.Size = New System.Drawing.Size(94, 20)
        Me.LblDestination.TabIndex = 4
        Me.LblDestination.Text = "Destination:"
        '
        'LblOrigin
        '
        Me.LblOrigin.AutoSize = True
        Me.LblOrigin.Location = New System.Drawing.Point(256, 61)
        Me.LblOrigin.Name = "LblOrigin"
        Me.LblOrigin.Size = New System.Drawing.Size(58, 20)
        Me.LblOrigin.TabIndex = 5
        Me.LblOrigin.Text = "Origin: "
        '
        'MtbOrigin
        '
        Me.MtbOrigin.Location = New System.Drawing.Point(320, 58)
        Me.MtbOrigin.Mask = "0"
        Me.MtbOrigin.Name = "MtbOrigin"
        Me.MtbOrigin.Size = New System.Drawing.Size(55, 26)
        Me.MtbOrigin.TabIndex = 6
        '
        'MtbDest
        '
        Me.MtbDest.Location = New System.Drawing.Point(320, 92)
        Me.MtbDest.Mask = "0"
        Me.MtbDest.Name = "MtbDest"
        Me.MtbDest.Size = New System.Drawing.Size(55, 26)
        Me.MtbDest.TabIndex = 7
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(60, 162)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(279, 54)
        Me.BtnShow.TabIndex = 8
        Me.BtnShow.Text = "Show Mileage Betwen Origin and Destination"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'LblMiles
        '
        Me.LblMiles.AutoSize = True
        Me.LblMiles.Location = New System.Drawing.Point(85, 237)
        Me.LblMiles.Name = "LblMiles"
        Me.LblMiles.Size = New System.Drawing.Size(68, 20)
        Me.LblMiles.TabIndex = 9
        Me.LblMiles.Text = "Mileage:"
        '
        'TxtMiles
        '
        Me.TxtMiles.Location = New System.Drawing.Point(159, 234)
        Me.TxtMiles.Name = "TxtMiles"
        Me.TxtMiles.ReadOnly = True
        Me.TxtMiles.Size = New System.Drawing.Size(154, 26)
        Me.TxtMiles.TabIndex = 10
        '
        'frmDistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 301)
        Me.Controls.Add(Me.TxtMiles)
        Me.Controls.Add(Me.LblMiles)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.MtbDest)
        Me.Controls.Add(Me.MtbOrigin)
        Me.Controls.Add(Me.LblOrigin)
        Me.Controls.Add(Me.LblDestination)
        Me.Controls.Add(Me.LblPh)
        Me.Controls.Add(Me.LblNY)
        Me.Controls.Add(Me.LbLA)
        Me.Controls.Add(Me.LblCh)
        Me.Name = "frmDistance"
        Me.Text = "Intercity Distances"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCh As Label
    Friend WithEvents LbLA As Label
    Friend WithEvents LblNY As Label
    Friend WithEvents LblPh As Label
    Friend WithEvents LblDestination As Label
    Friend WithEvents LblOrigin As Label
    Friend WithEvents MtbOrigin As MaskedTextBox
    Friend WithEvents MtbDest As MaskedTextBox
    Friend WithEvents BtnShow As Button
    Friend WithEvents LblMiles As Label
    Friend WithEvents TxtMiles As TextBox
End Class
