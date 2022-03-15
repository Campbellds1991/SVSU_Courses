<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CampbellCH4
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
        Me.LstPricing = New System.Windows.Forms.ListBox()
        Me.LblPricing = New System.Windows.Forms.Label()
        Me.LstReciept = New System.Windows.Forms.ListBox()
        Me.CkbTrailerHalf = New System.Windows.Forms.CheckBox()
        Me.CkbDollyHalf = New System.Windows.Forms.CheckBox()
        Me.CkbDollyFull = New System.Windows.Forms.CheckBox()
        Me.CkbTruckFull = New System.Windows.Forms.CheckBox()
        Me.CkbTrailerFull = New System.Windows.Forms.CheckBox()
        Me.CkbTruckHalf = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LstPricing
        '
        Me.LstPricing.BackColor = System.Drawing.SystemColors.Menu
        Me.LstPricing.Font = New System.Drawing.Font("Courier New", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstPricing.FormattingEnabled = True
        Me.LstPricing.ItemHeight = 21
        Me.LstPricing.Location = New System.Drawing.Point(31, 65)
        Me.LstPricing.Name = "LstPricing"
        Me.LstPricing.Size = New System.Drawing.Size(636, 193)
        Me.LstPricing.TabIndex = 0
        '
        'LblPricing
        '
        Me.LblPricing.AutoSize = True
        Me.LblPricing.Location = New System.Drawing.Point(115, 18)
        Me.LblPricing.Name = "LblPricing"
        Me.LblPricing.Size = New System.Drawing.Size(387, 25)
        Me.LblPricing.TabIndex = 1
        Me.LblPricing.Text = "Please select item(s) you wish to purchase:"
        '
        'LstReciept
        '
        Me.LstReciept.Font = New System.Drawing.Font("Courier New", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstReciept.FormattingEnabled = True
        Me.LstReciept.ItemHeight = 21
        Me.LstReciept.Location = New System.Drawing.Point(31, 290)
        Me.LstReciept.Name = "LstReciept"
        Me.LstReciept.Size = New System.Drawing.Size(749, 319)
        Me.LstReciept.TabIndex = 8
        '
        'CkbTrailerHalf
        '
        Me.CkbTrailerHalf.AutoSize = True
        Me.CkbTrailerHalf.Location = New System.Drawing.Point(62, 148)
        Me.CkbTrailerHalf.Name = "CkbTrailerHalf"
        Me.CkbTrailerHalf.Size = New System.Drawing.Size(22, 21)
        Me.CkbTrailerHalf.TabIndex = 4
        Me.CkbTrailerHalf.UseVisualStyleBackColor = True
        '
        'CkbDollyHalf
        '
        Me.CkbDollyHalf.AutoSize = True
        Me.CkbDollyHalf.Location = New System.Drawing.Point(62, 175)
        Me.CkbDollyHalf.Name = "CkbDollyHalf"
        Me.CkbDollyHalf.Size = New System.Drawing.Size(22, 21)
        Me.CkbDollyHalf.TabIndex = 6
        Me.CkbDollyHalf.UseVisualStyleBackColor = True
        '
        'CkbDollyFull
        '
        Me.CkbDollyFull.AutoSize = True
        Me.CkbDollyFull.Location = New System.Drawing.Point(164, 175)
        Me.CkbDollyFull.Name = "CkbDollyFull"
        Me.CkbDollyFull.Size = New System.Drawing.Size(22, 21)
        Me.CkbDollyFull.TabIndex = 7
        Me.CkbDollyFull.UseVisualStyleBackColor = True
        '
        'CkbTruckFull
        '
        Me.CkbTruckFull.AutoSize = True
        Me.CkbTruckFull.Location = New System.Drawing.Point(164, 121)
        Me.CkbTruckFull.Name = "CkbTruckFull"
        Me.CkbTruckFull.Size = New System.Drawing.Size(22, 21)
        Me.CkbTruckFull.TabIndex = 3
        Me.CkbTruckFull.UseVisualStyleBackColor = True
        '
        'CkbTrailerFull
        '
        Me.CkbTrailerFull.AutoSize = True
        Me.CkbTrailerFull.Location = New System.Drawing.Point(164, 148)
        Me.CkbTrailerFull.Name = "CkbTrailerFull"
        Me.CkbTrailerFull.Size = New System.Drawing.Size(22, 21)
        Me.CkbTrailerFull.TabIndex = 5
        Me.CkbTrailerFull.UseVisualStyleBackColor = True
        '
        'CkbTruckHalf
        '
        Me.CkbTruckHalf.AutoSize = True
        Me.CkbTruckHalf.Location = New System.Drawing.Point(62, 121)
        Me.CkbTruckHalf.Name = "CkbTruckHalf"
        Me.CkbTruckHalf.Size = New System.Drawing.Size(22, 21)
        Me.CkbTruckHalf.TabIndex = 9
        Me.CkbTruckHalf.UseVisualStyleBackColor = True
        '
        'CampbellCH4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 631)
        Me.Controls.Add(Me.CkbTruckHalf)
        Me.Controls.Add(Me.CkbDollyFull)
        Me.Controls.Add(Me.CkbTruckFull)
        Me.Controls.Add(Me.CkbTrailerFull)
        Me.Controls.Add(Me.CkbDollyHalf)
        Me.Controls.Add(Me.CkbTrailerHalf)
        Me.Controls.Add(Me.LstReciept)
        Me.Controls.Add(Me.LblPricing)
        Me.Controls.Add(Me.LstPricing)
        Me.Name = "CampbellCH4"
        Me.Text = "Welcome to Campbell's Equipment Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstPricing As ListBox
    Friend WithEvents LblPricing As Label
    Friend WithEvents LstReciept As ListBox
    Friend WithEvents CkbTrailerHalf As CheckBox
    Friend WithEvents CkbDollyHalf As CheckBox
    Friend WithEvents CkbDollyFull As CheckBox
    Friend WithEvents CkbTruckFull As CheckBox
    Friend WithEvents CkbTrailerFull As CheckBox
    Friend WithEvents CkbTruckHalf As CheckBox
End Class
