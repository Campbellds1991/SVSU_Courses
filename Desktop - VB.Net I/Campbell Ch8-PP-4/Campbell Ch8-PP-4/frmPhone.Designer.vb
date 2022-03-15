<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhone
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
        Me.LblHowTo = New System.Windows.Forms.Label()
        Me.BtnCreateDirectory = New System.Windows.Forms.Button()
        Me.LblDirectories = New System.Windows.Forms.Label()
        Me.LstDirectories = New System.Windows.Forms.ListBox()
        Me.LblWorkingDirectory = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.TxtWorkingDirectory = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnAddListing = New System.Windows.Forms.Button()
        Me.BtnRemoveListing = New System.Windows.Forms.Button()
        Me.DgvContacts = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.BtnRemoveDirectory = New System.Windows.Forms.Button()
        CType(Me.DgvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHowTo
        '
        Me.LblHowTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblHowTo.Location = New System.Drawing.Point(9, 10)
        Me.LblHowTo.Name = "LblHowTo"
        Me.LblHowTo.Size = New System.Drawing.Size(331, 56)
        Me.LblHowTo.TabIndex = 0
        Me.LblHowTo.Text = "Click on one fo the existing phone directories below to make it the current phone" &
    " directory"
        '
        'BtnCreateDirectory
        '
        Me.BtnCreateDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateDirectory.Location = New System.Drawing.Point(346, 12)
        Me.BtnCreateDirectory.Name = "BtnCreateDirectory"
        Me.BtnCreateDirectory.Size = New System.Drawing.Size(264, 54)
        Me.BtnCreateDirectory.TabIndex = 1
        Me.BtnCreateDirectory.Text = "Find / Create a New Phone Directory"
        Me.BtnCreateDirectory.UseVisualStyleBackColor = True
        '
        'LblDirectories
        '
        Me.LblDirectories.AutoSize = True
        Me.LblDirectories.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDirectories.Location = New System.Drawing.Point(67, 66)
        Me.LblDirectories.Name = "LblDirectories"
        Me.LblDirectories.Size = New System.Drawing.Size(183, 25)
        Me.LblDirectories.TabIndex = 2
        Me.LblDirectories.Text = "Phone Directories"
        '
        'LstDirectories
        '
        Me.LstDirectories.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LstDirectories.FormattingEnabled = True
        Me.LstDirectories.ItemHeight = 20
        Me.LstDirectories.Location = New System.Drawing.Point(12, 94)
        Me.LstDirectories.Name = "LstDirectories"
        Me.LstDirectories.Size = New System.Drawing.Size(298, 324)
        Me.LstDirectories.TabIndex = 3
        '
        'LblWorkingDirectory
        '
        Me.LblWorkingDirectory.AutoSize = True
        Me.LblWorkingDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblWorkingDirectory.Location = New System.Drawing.Point(316, 137)
        Me.LblWorkingDirectory.Name = "LblWorkingDirectory"
        Me.LblWorkingDirectory.Size = New System.Drawing.Size(183, 20)
        Me.LblWorkingDirectory.TabIndex = 9
        Me.LblWorkingDirectory.Text = "Current Phone Directory:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblName.Location = New System.Drawing.Point(312, 177)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(55, 20)
        Me.LblName.TabIndex = 11
        Me.LblName.Text = "Name:"
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblPhone.Location = New System.Drawing.Point(312, 216)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(119, 20)
        Me.LblPhone.TabIndex = 12
        Me.LblPhone.Text = "Phone Number:"
        '
        'TxtWorkingDirectory
        '
        Me.TxtWorkingDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TxtWorkingDirectory.Location = New System.Drawing.Point(501, 134)
        Me.TxtWorkingDirectory.Name = "TxtWorkingDirectory"
        Me.TxtWorkingDirectory.ReadOnly = True
        Me.TxtWorkingDirectory.Size = New System.Drawing.Size(109, 26)
        Me.TxtWorkingDirectory.TabIndex = 10
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TxtName.Location = New System.Drawing.Point(373, 174)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(237, 26)
        Me.TxtName.TabIndex = 4
        '
        'BtnAddListing
        '
        Me.BtnAddListing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BtnAddListing.Location = New System.Drawing.Point(16, 431)
        Me.BtnAddListing.Name = "BtnAddListing"
        Me.BtnAddListing.Size = New System.Drawing.Size(294, 58)
        Me.BtnAddListing.TabIndex = 7
        Me.BtnAddListing.Text = "Add Listing to Current Directory"
        Me.BtnAddListing.UseVisualStyleBackColor = True
        '
        'BtnRemoveListing
        '
        Me.BtnRemoveListing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BtnRemoveListing.Location = New System.Drawing.Point(16, 496)
        Me.BtnRemoveListing.Name = "BtnRemoveListing"
        Me.BtnRemoveListing.Size = New System.Drawing.Size(294, 55)
        Me.BtnRemoveListing.TabIndex = 8
        Me.BtnRemoveListing.Text = "Remove Listing from Current Directory"
        Me.BtnRemoveListing.UseVisualStyleBackColor = True
        '
        'DgvContacts
        '
        Me.DgvContacts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContacts.Location = New System.Drawing.Point(316, 245)
        Me.DgvContacts.Name = "DgvContacts"
        Me.DgvContacts.RowHeadersVisible = False
        Me.DgvContacts.RowTemplate.Height = 28
        Me.DgvContacts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvContacts.Size = New System.Drawing.Size(294, 307)
        Me.DgvContacts.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text Files (*.txt) | *.txt"
        Me.OpenFileDialog1.InitialDirectory = "/"
        '
        'MtbPhone
        '
        Me.MtbPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.MtbPhone.Location = New System.Drawing.Point(437, 213)
        Me.MtbPhone.Mask = "(000) 000-0000"
        Me.MtbPhone.Name = "MtbPhone"
        Me.MtbPhone.Size = New System.Drawing.Size(173, 26)
        Me.MtbPhone.TabIndex = 5
        '
        'BtnRemoveDirectory
        '
        Me.BtnRemoveDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveDirectory.Location = New System.Drawing.Point(347, 72)
        Me.BtnRemoveDirectory.Name = "BtnRemoveDirectory"
        Me.BtnRemoveDirectory.Size = New System.Drawing.Size(264, 54)
        Me.BtnRemoveDirectory.TabIndex = 13
        Me.BtnRemoveDirectory.Text = "Remove Current Phone Directory"
        Me.BtnRemoveDirectory.UseVisualStyleBackColor = True
        '
        'frmPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 559)
        Me.Controls.Add(Me.BtnRemoveDirectory)
        Me.Controls.Add(Me.MtbPhone)
        Me.Controls.Add(Me.DgvContacts)
        Me.Controls.Add(Me.BtnRemoveListing)
        Me.Controls.Add(Me.BtnAddListing)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtWorkingDirectory)
        Me.Controls.Add(Me.LblPhone)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblWorkingDirectory)
        Me.Controls.Add(Me.LstDirectories)
        Me.Controls.Add(Me.LblDirectories)
        Me.Controls.Add(Me.BtnCreateDirectory)
        Me.Controls.Add(Me.LblHowTo)
        Me.Name = "frmPhone"
        Me.Text = "Campbell's Create and Maintain Telephone Directories"
        CType(Me.DgvContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHowTo As Label
    Friend WithEvents BtnCreateDirectory As Button
    Friend WithEvents LblDirectories As Label
    Friend WithEvents LstDirectories As ListBox
    Friend WithEvents LblWorkingDirectory As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents TxtWorkingDirectory As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnAddListing As Button
    Friend WithEvents BtnRemoveListing As Button
    Friend WithEvents DgvContacts As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MtbPhone As MaskedTextBox
    Friend WithEvents BtnRemoveDirectory As Button
End Class
