<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Campbell_Ch8_Lab
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
        Me.Gb_8_1 = New System.Windows.Forms.GroupBox()
        Me.Btn_8_1 = New System.Windows.Forms.Button()
        Me.Gb_8_2 = New System.Windows.Forms.GroupBox()
        Me.Dgv_8_2 = New System.Windows.Forms.DataGridView()
        Me.BtnSort = New System.Windows.Forms.Button()
        Me.Gb_8_5 = New System.Windows.Forms.GroupBox()
        Me.Btn_8_5_Remove2From1 = New System.Windows.Forms.Button()
        Me.Btn_8_5_IntersectFiles = New System.Windows.Forms.Button()
        Me.Btn_8_5_ConcatWoRep = New System.Windows.Forms.Button()
        Me.Btn_8_5_ConcatWRep = New System.Windows.Forms.Button()
        Me.GbDisplayFile_8_9 = New System.Windows.Forms.GroupBox()
        Me.LstOutput_8_9 = New System.Windows.Forms.ListBox()
        Me.BtnSelect_8_9 = New System.Windows.Forms.Button()
        Me.GbNames_8_2_3 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete_8_2_3 = New System.Windows.Forms.Button()
        Me.BtnDetermine_8_2_3 = New System.Windows.Forms.Button()
        Me.BtnAdd_8_2_3 = New System.Windows.Forms.Button()
        Me.TxtName_8_2_3 = New System.Windows.Forms.TextBox()
        Me.LblName_8_2_3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Gb_8_1.SuspendLayout()
        Me.Gb_8_2.SuspendLayout()
        CType(Me.Dgv_8_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_8_5.SuspendLayout()
        Me.GbDisplayFile_8_9.SuspendLayout()
        Me.GbNames_8_2_3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_8_1
        '
        Me.Gb_8_1.Controls.Add(Me.Btn_8_1)
        Me.Gb_8_1.Location = New System.Drawing.Point(13, 13)
        Me.Gb_8_1.Name = "Gb_8_1"
        Me.Gb_8_1.Size = New System.Drawing.Size(237, 98)
        Me.Gb_8_1.TabIndex = 0
        Me.Gb_8_1.TabStop = False
        Me.Gb_8_1.Text = "U.S. Presidents"
        '
        'Btn_8_1
        '
        Me.Btn_8_1.Location = New System.Drawing.Point(6, 25)
        Me.Btn_8_1.Name = "Btn_8_1"
        Me.Btn_8_1.Size = New System.Drawing.Size(221, 42)
        Me.Btn_8_1.TabIndex = 0
        Me.Btn_8_1.Text = "Click Me"
        Me.Btn_8_1.UseVisualStyleBackColor = True
        '
        'Gb_8_2
        '
        Me.Gb_8_2.Controls.Add(Me.Dgv_8_2)
        Me.Gb_8_2.Controls.Add(Me.BtnSort)
        Me.Gb_8_2.Location = New System.Drawing.Point(313, 13)
        Me.Gb_8_2.Name = "Gb_8_2"
        Me.Gb_8_2.Size = New System.Drawing.Size(376, 470)
        Me.Gb_8_2.TabIndex = 1
        Me.Gb_8_2.TabStop = False
        Me.Gb_8_2.Text = "U.S. Presidents"
        '
        'Dgv_8_2
        '
        Me.Dgv_8_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_8_2.Location = New System.Drawing.Point(30, 72)
        Me.Dgv_8_2.Name = "Dgv_8_2"
        Me.Dgv_8_2.RowHeadersVisible = False
        Me.Dgv_8_2.RowTemplate.Height = 28
        Me.Dgv_8_2.Size = New System.Drawing.Size(302, 369)
        Me.Dgv_8_2.TabIndex = 1
        '
        'BtnSort
        '
        Me.BtnSort.Location = New System.Drawing.Point(47, 25)
        Me.BtnSort.Name = "BtnSort"
        Me.BtnSort.Size = New System.Drawing.Size(268, 41)
        Me.BtnSort.TabIndex = 0
        Me.BtnSort.Text = "Sort"
        Me.BtnSort.UseVisualStyleBackColor = True
        '
        'Gb_8_5
        '
        Me.Gb_8_5.Controls.Add(Me.Btn_8_5_Remove2From1)
        Me.Gb_8_5.Controls.Add(Me.Btn_8_5_IntersectFiles)
        Me.Gb_8_5.Controls.Add(Me.Btn_8_5_ConcatWoRep)
        Me.Gb_8_5.Controls.Add(Me.Btn_8_5_ConcatWRep)
        Me.Gb_8_5.Location = New System.Drawing.Point(695, 23)
        Me.Gb_8_5.Name = "Gb_8_5"
        Me.Gb_8_5.Size = New System.Drawing.Size(399, 236)
        Me.Gb_8_5.TabIndex = 2
        Me.Gb_8_5.TabStop = False
        Me.Gb_8_5.Text = "Set Operations"
        '
        'Btn_8_5_Remove2From1
        '
        Me.Btn_8_5_Remove2From1.Location = New System.Drawing.Point(7, 164)
        Me.Btn_8_5_Remove2From1.Name = "Btn_8_5_Remove2From1"
        Me.Btn_8_5_Remove2From1.Size = New System.Drawing.Size(369, 58)
        Me.Btn_8_5_Remove2From1.TabIndex = 3
        Me.Btn_8_5_Remove2From1.Text = "Delete the Items in the Second File form the First File"
        Me.Btn_8_5_Remove2From1.UseVisualStyleBackColor = True
        '
        'Btn_8_5_IntersectFiles
        '
        Me.Btn_8_5_IntersectFiles.Location = New System.Drawing.Point(7, 118)
        Me.Btn_8_5_IntersectFiles.Name = "Btn_8_5_IntersectFiles"
        Me.Btn_8_5_IntersectFiles.Size = New System.Drawing.Size(369, 40)
        Me.Btn_8_5_IntersectFiles.TabIndex = 2
        Me.Btn_8_5_IntersectFiles.Text = "Find the Intersection of the Two Files"
        Me.Btn_8_5_IntersectFiles.UseVisualStyleBackColor = True
        '
        'Btn_8_5_ConcatWoRep
        '
        Me.Btn_8_5_ConcatWoRep.Location = New System.Drawing.Point(7, 72)
        Me.Btn_8_5_ConcatWoRep.Name = "Btn_8_5_ConcatWoRep"
        Me.Btn_8_5_ConcatWoRep.Size = New System.Drawing.Size(369, 40)
        Me.Btn_8_5_ConcatWoRep.TabIndex = 1
        Me.Btn_8_5_ConcatWoRep.Text = "Concatenate the Two FIles (without Repetitions)"
        Me.Btn_8_5_ConcatWoRep.UseVisualStyleBackColor = True
        '
        'Btn_8_5_ConcatWRep
        '
        Me.Btn_8_5_ConcatWRep.Location = New System.Drawing.Point(7, 26)
        Me.Btn_8_5_ConcatWRep.Name = "Btn_8_5_ConcatWRep"
        Me.Btn_8_5_ConcatWRep.Size = New System.Drawing.Size(369, 40)
        Me.Btn_8_5_ConcatWRep.TabIndex = 0
        Me.Btn_8_5_ConcatWRep.Text = "Concatenate the Two FIles (with Repetitions)"
        Me.Btn_8_5_ConcatWRep.UseVisualStyleBackColor = True
        '
        'GbDisplayFile_8_9
        '
        Me.GbDisplayFile_8_9.Controls.Add(Me.LstOutput_8_9)
        Me.GbDisplayFile_8_9.Controls.Add(Me.BtnSelect_8_9)
        Me.GbDisplayFile_8_9.Location = New System.Drawing.Point(19, 195)
        Me.GbDisplayFile_8_9.Name = "GbDisplayFile_8_9"
        Me.GbDisplayFile_8_9.Size = New System.Drawing.Size(271, 233)
        Me.GbDisplayFile_8_9.TabIndex = 3
        Me.GbDisplayFile_8_9.TabStop = False
        Me.GbDisplayFile_8_9.Text = "Display a File"
        '
        'LstOutput_8_9
        '
        Me.LstOutput_8_9.FormattingEnabled = True
        Me.LstOutput_8_9.ItemHeight = 20
        Me.LstOutput_8_9.Location = New System.Drawing.Point(19, 71)
        Me.LstOutput_8_9.Name = "LstOutput_8_9"
        Me.LstOutput_8_9.Size = New System.Drawing.Size(246, 144)
        Me.LstOutput_8_9.TabIndex = 1
        '
        'BtnSelect_8_9
        '
        Me.BtnSelect_8_9.Location = New System.Drawing.Point(42, 25)
        Me.BtnSelect_8_9.Name = "BtnSelect_8_9"
        Me.BtnSelect_8_9.Size = New System.Drawing.Size(189, 39)
        Me.BtnSelect_8_9.TabIndex = 0
        Me.BtnSelect_8_9.Text = "Select a Text File"
        Me.BtnSelect_8_9.UseVisualStyleBackColor = True
        '
        'GbNames_8_2_3
        '
        Me.GbNames_8_2_3.Controls.Add(Me.BtnDelete_8_2_3)
        Me.GbNames_8_2_3.Controls.Add(Me.BtnDetermine_8_2_3)
        Me.GbNames_8_2_3.Controls.Add(Me.BtnAdd_8_2_3)
        Me.GbNames_8_2_3.Controls.Add(Me.TxtName_8_2_3)
        Me.GbNames_8_2_3.Controls.Add(Me.LblName_8_2_3)
        Me.GbNames_8_2_3.Location = New System.Drawing.Point(695, 317)
        Me.GbNames_8_2_3.Name = "GbNames_8_2_3"
        Me.GbNames_8_2_3.Size = New System.Drawing.Size(339, 218)
        Me.GbNames_8_2_3.TabIndex = 4
        Me.GbNames_8_2_3.TabStop = False
        Me.GbNames_8_2_3.Text = "Manage File"
        '
        'BtnDelete_8_2_3
        '
        Me.BtnDelete_8_2_3.Location = New System.Drawing.Point(38, 154)
        Me.BtnDelete_8_2_3.Name = "BtnDelete_8_2_3"
        Me.BtnDelete_8_2_3.Size = New System.Drawing.Size(273, 31)
        Me.BtnDelete_8_2_3.TabIndex = 4
        Me.BtnDelete_8_2_3.Text = "Delete Person from File"
        Me.BtnDelete_8_2_3.UseVisualStyleBackColor = True
        '
        'BtnDetermine_8_2_3
        '
        Me.BtnDetermine_8_2_3.Location = New System.Drawing.Point(38, 117)
        Me.BtnDetermine_8_2_3.Name = "BtnDetermine_8_2_3"
        Me.BtnDetermine_8_2_3.Size = New System.Drawing.Size(273, 31)
        Me.BtnDetermine_8_2_3.TabIndex = 3
        Me.BtnDetermine_8_2_3.Text = "Determine if Person is in File"
        Me.BtnDetermine_8_2_3.UseVisualStyleBackColor = True
        '
        'BtnAdd_8_2_3
        '
        Me.BtnAdd_8_2_3.Location = New System.Drawing.Point(38, 80)
        Me.BtnAdd_8_2_3.Name = "BtnAdd_8_2_3"
        Me.BtnAdd_8_2_3.Size = New System.Drawing.Size(273, 31)
        Me.BtnAdd_8_2_3.TabIndex = 2
        Me.BtnAdd_8_2_3.Text = "Add Person to File"
        Me.BtnAdd_8_2_3.UseVisualStyleBackColor = True
        '
        'TxtName_8_2_3
        '
        Me.TxtName_8_2_3.Location = New System.Drawing.Point(102, 38)
        Me.TxtName_8_2_3.Name = "TxtName_8_2_3"
        Me.TxtName_8_2_3.Size = New System.Drawing.Size(209, 26)
        Me.TxtName_8_2_3.TabIndex = 1
        '
        'LblName_8_2_3
        '
        Me.LblName_8_2_3.AutoSize = True
        Me.LblName_8_2_3.Location = New System.Drawing.Point(41, 41)
        Me.LblName_8_2_3.Name = "LblName_8_2_3"
        Me.LblName_8_2_3.Size = New System.Drawing.Size(55, 20)
        Me.LblName_8_2_3.TabIndex = 0
        Me.LblName_8_2_3.Text = "Name:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text Documents (*.txt) | *.txt"
        '
        'Campbell_Ch8_Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 572)
        Me.Controls.Add(Me.GbNames_8_2_3)
        Me.Controls.Add(Me.GbDisplayFile_8_9)
        Me.Controls.Add(Me.Gb_8_5)
        Me.Controls.Add(Me.Gb_8_2)
        Me.Controls.Add(Me.Gb_8_1)
        Me.Name = "Campbell_Ch8_Lab"
        Me.Text = "Campbell Ch8 Lab"
        Me.Gb_8_1.ResumeLayout(False)
        Me.Gb_8_2.ResumeLayout(False)
        CType(Me.Dgv_8_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_8_5.ResumeLayout(False)
        Me.GbDisplayFile_8_9.ResumeLayout(False)
        Me.GbNames_8_2_3.ResumeLayout(False)
        Me.GbNames_8_2_3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gb_8_1 As GroupBox
    Friend WithEvents Btn_8_1 As Button
    Friend WithEvents Gb_8_2 As GroupBox
    Friend WithEvents Dgv_8_2 As DataGridView
    Friend WithEvents BtnSort As Button
    Friend WithEvents Gb_8_5 As GroupBox
    Friend WithEvents Btn_8_5_Remove2From1 As Button
    Friend WithEvents Btn_8_5_IntersectFiles As Button
    Friend WithEvents Btn_8_5_ConcatWoRep As Button
    Friend WithEvents Btn_8_5_ConcatWRep As Button
    Friend WithEvents GbDisplayFile_8_9 As GroupBox
    Friend WithEvents GbNames_8_2_3 As GroupBox
    Friend WithEvents LstOutput_8_9 As ListBox
    Friend WithEvents BtnSelect_8_9 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnDelete_8_2_3 As Button
    Friend WithEvents BtnDetermine_8_2_3 As Button
    Friend WithEvents BtnAdd_8_2_3 As Button
    Friend WithEvents TxtName_8_2_3 As TextBox
    Friend WithEvents LblName_8_2_3 As Label
End Class
