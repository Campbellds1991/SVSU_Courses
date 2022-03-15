<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
		Me.lblName = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.lblSize = New System.Windows.Forms.Label()
		Me.nudSize = New System.Windows.Forms.NumericUpDown()
		Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
		Me.lblQuantity = New System.Windows.Forms.Label()
		Me.gbCrust = New System.Windows.Forms.GroupBox()
		Me.radCrustPepperoni = New System.Windows.Forms.RadioButton()
		Me.radCrustHam = New System.Windows.Forms.RadioButton()
		Me.radCrustCheese = New System.Windows.Forms.RadioButton()
		Me.radCrustGarlic = New System.Windows.Forms.RadioButton()
		Me.radCrustPlain = New System.Windows.Forms.RadioButton()
		Me.gbToppings = New System.Windows.Forms.GroupBox()
		Me.chkToppingAnchovies = New System.Windows.Forms.CheckBox()
		Me.chkToppingBacon = New System.Windows.Forms.CheckBox()
		Me.chkToppingBananaPepper = New System.Windows.Forms.CheckBox()
		Me.chkToppingBlkOlive = New System.Windows.Forms.CheckBox()
		Me.chkToppingExCheese = New System.Windows.Forms.CheckBox()
		Me.chkToppingGrnOlive = New System.Windows.Forms.CheckBox()
		Me.chkToppingGrnPepper = New System.Windows.Forms.CheckBox()
		Me.chkToppingHam = New System.Windows.Forms.CheckBox()
		Me.chkToppingMushroom = New System.Windows.Forms.CheckBox()
		Me.chkToppingPepperoni = New System.Windows.Forms.CheckBox()
		Me.chkToppingPineapple = New System.Windows.Forms.CheckBox()
		Me.chkToppingSausage = New System.Windows.Forms.CheckBox()

		Me.cmdPlaceOrder = New System.Windows.Forms.Button()
		CType(Me.nudSize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbCrust.SuspendLayout()
		Me.gbToppings.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(16, 13)
		Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(113, 17)
		Me.lblName.TabIndex = 0
		Me.lblName.Text = "Customer Name:"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(137, 10)
		Me.txtName.Margin = New System.Windows.Forms.Padding(2)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(431, 22)
		Me.txtName.TabIndex = 1
		'
		'lblSize
		'
		Me.lblSize.AutoSize = True
		Me.lblSize.Location = New System.Drawing.Point(16, 54)
		Me.lblSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblSize.Name = "lblSize"
		Me.lblSize.Size = New System.Drawing.Size(77, 17)
		Me.lblSize.TabIndex = 2
		Me.lblSize.Text = "Pizza Size:"
		'
		'nudSize
		'
		Me.nudSize.Location = New System.Drawing.Point(137, 53)
		Me.nudSize.Margin = New System.Windows.Forms.Padding(2)
		Me.nudSize.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
		Me.nudSize.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
		Me.nudSize.Name = "nudSize"
		Me.nudSize.Size = New System.Drawing.Size(121, 22)
		Me.nudSize.TabIndex = 3
		Me.nudSize.Value = New Decimal(New Integer() {12, 0, 0, 0})
		'
		'nudQuantity
		'
		Me.nudQuantity.Location = New System.Drawing.Point(446, 53)
		Me.nudQuantity.Margin = New System.Windows.Forms.Padding(2)
		Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudQuantity.Name = "nudQuantity"
		Me.nudQuantity.Size = New System.Drawing.Size(121, 22)
		Me.nudQuantity.TabIndex = 5
		Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblQuantity
		'
		Me.lblQuantity.AutoSize = True
		Me.lblQuantity.Location = New System.Drawing.Point(361, 54)
		Me.lblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblQuantity.Name = "lblQuantity"
		Me.lblQuantity.Size = New System.Drawing.Size(65, 17)
		Me.lblQuantity.TabIndex = 4
		Me.lblQuantity.Text = "Quantity:"
		'
		'gbCrust
		'
		Me.gbCrust.Controls.Add(Me.radCrustPepperoni)
		Me.gbCrust.Controls.Add(Me.radCrustHam)
		Me.gbCrust.Controls.Add(Me.radCrustCheese)
		Me.gbCrust.Controls.Add(Me.radCrustGarlic)
		Me.gbCrust.Controls.Add(Me.radCrustPlain)
		Me.gbCrust.Location = New System.Drawing.Point(20, 95)
		Me.gbCrust.Margin = New System.Windows.Forms.Padding(2)
		Me.gbCrust.Name = "gbCrust"
		Me.gbCrust.Padding = New System.Windows.Forms.Padding(2)
		Me.gbCrust.Size = New System.Drawing.Size(547, 69)
		Me.gbCrust.TabIndex = 6
		Me.gbCrust.TabStop = False
		Me.gbCrust.Text = "Stuffed Crust Selection:"
		'
		'radCrustPepperoni
		'
		Me.radCrustPepperoni.AutoSize = True
		Me.radCrustPepperoni.Location = New System.Drawing.Point(422, 27)
		Me.radCrustPepperoni.Margin = New System.Windows.Forms.Padding(2)
		Me.radCrustPepperoni.Name = "radCrustPepperoni"
		Me.radCrustPepperoni.Size = New System.Drawing.Size(94, 21)
		Me.radCrustPepperoni.TabIndex = 4
		Me.radCrustPepperoni.TabStop = True
		Me.radCrustPepperoni.Text = "Pepperoni"
		Me.radCrustPepperoni.UseVisualStyleBackColor = True
		'
		'radCrustHam
		'
		Me.radCrustHam.AutoSize = True
		Me.radCrustHam.Location = New System.Drawing.Point(328, 27)
		Me.radCrustHam.Margin = New System.Windows.Forms.Padding(2)
		Me.radCrustHam.Name = "radCrustHam"
		Me.radCrustHam.Size = New System.Drawing.Size(58, 21)
		Me.radCrustHam.TabIndex = 3
		Me.radCrustHam.TabStop = True
		Me.radCrustHam.Text = "Ham"
		Me.radCrustHam.UseVisualStyleBackColor = True
		'
		'radCrustCheese
		'
		Me.radCrustCheese.AutoSize = True
		Me.radCrustCheese.Location = New System.Drawing.Point(214, 27)
		Me.radCrustCheese.Margin = New System.Windows.Forms.Padding(2)
		Me.radCrustCheese.Name = "radCrustCheese"
		Me.radCrustCheese.Size = New System.Drawing.Size(77, 21)
		Me.radCrustCheese.TabIndex = 2
		Me.radCrustCheese.TabStop = True
		Me.radCrustCheese.Text = "Cheese"
		Me.radCrustCheese.UseVisualStyleBackColor = True
		'
		'radCrustGarlic
		'
		Me.radCrustGarlic.AutoSize = True
		Me.radCrustGarlic.Location = New System.Drawing.Point(113, 27)
		Me.radCrustGarlic.Margin = New System.Windows.Forms.Padding(2)
		Me.radCrustGarlic.Name = "radCrustGarlic"
		Me.radCrustGarlic.Size = New System.Drawing.Size(66, 21)
		Me.radCrustGarlic.TabIndex = 1
		Me.radCrustGarlic.TabStop = True
		Me.radCrustGarlic.Text = "Garlic"
		Me.radCrustGarlic.UseVisualStyleBackColor = True
		'
		'radCrustPlain
		'
		Me.radCrustPlain.AutoSize = True
		Me.radCrustPlain.Checked = True
		Me.radCrustPlain.Location = New System.Drawing.Point(18, 27)
		Me.radCrustPlain.Margin = New System.Windows.Forms.Padding(2)
		Me.radCrustPlain.Name = "radCrustPlain"
		Me.radCrustPlain.Size = New System.Drawing.Size(60, 21)
		Me.radCrustPlain.TabIndex = 0
		Me.radCrustPlain.TabStop = True
		Me.radCrustPlain.Text = "Plain"
		Me.radCrustPlain.UseVisualStyleBackColor = True
		'
		'gbToppings
		'
		Me.gbToppings.Controls.Add(Me.chkToppingAnchovies)
		Me.gbToppings.Controls.Add(Me.chkToppingBacon)
		Me.gbToppings.Controls.Add(Me.chkToppingBananaPepper)
		Me.gbToppings.Controls.Add(Me.chkToppingBlkOlive)
		Me.gbToppings.Controls.Add(Me.chkToppingExCheese)
		Me.gbToppings.Controls.Add(Me.chkToppingGrnOlive)
		Me.gbToppings.Controls.Add(Me.chkToppingGrnPepper)
		Me.gbToppings.Controls.Add(Me.chkToppingHam)
		Me.gbToppings.Controls.Add(Me.chkToppingMushroom)
		Me.gbToppings.Controls.Add(Me.chkToppingPepperoni)
		Me.gbToppings.Controls.Add(Me.chkToppingPineapple)
		Me.gbToppings.Controls.Add(Me.chkToppingSausage)
		Me.gbToppings.Location = New System.Drawing.Point(20, 181)
		Me.gbToppings.Margin = New System.Windows.Forms.Padding(2)
		Me.gbToppings.Name = "gbToppings"
		Me.gbToppings.Padding = New System.Windows.Forms.Padding(2)
		Me.gbToppings.Size = New System.Drawing.Size(547, 170)
		Me.gbToppings.TabIndex = 7
		Me.gbToppings.TabStop = False
		Me.gbToppings.Text = "Toppings:"
		'
		'chkToppingAnchovies
		'
		Me.chkToppingAnchovies.AutoSize = True
		Me.chkToppingAnchovies.Location = New System.Drawing.Point(422, 119)
		Me.chkToppingAnchovies.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingAnchovies.Name = "chkToppingAnchovies"
		Me.chkToppingAnchovies.Size = New System.Drawing.Size(95, 21)
		Me.chkToppingAnchovies.TabIndex = 11
		Me.chkToppingAnchovies.Text = "Anchovies"
		Me.chkToppingAnchovies.UseVisualStyleBackColor = True
		'
		'chkToppingExCheese
		'
		Me.chkToppingExCheese.AutoSize = True
		Me.chkToppingExCheese.Location = New System.Drawing.Point(422, 75)
		Me.chkToppingExCheese.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingExCheese.Name = "chkToppingExCheese"
		Me.chkToppingExCheese.Size = New System.Drawing.Size(114, 21)
		Me.chkToppingExCheese.TabIndex = 7
		Me.chkToppingExCheese.Text = "Extra Cheese"
		Me.chkToppingExCheese.UseVisualStyleBackColor = True
		'
		'chkToppingSausage
		'
		Me.chkToppingSausage.AutoSize = True
		Me.chkToppingSausage.Location = New System.Drawing.Point(422, 31)
		Me.chkToppingSausage.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingSausage.Name = "chkToppingSausage"
		Me.chkToppingSausage.Size = New System.Drawing.Size(86, 21)
		Me.chkToppingSausage.TabIndex = 3
		Me.chkToppingSausage.Text = "Sausage"
		Me.chkToppingSausage.UseVisualStyleBackColor = True
		'
		'chkToppingBacon
		'
		Me.chkToppingBacon.AutoSize = True
		Me.chkToppingBacon.Location = New System.Drawing.Point(293, 119)
		Me.chkToppingBacon.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingBacon.Name = "chkToppingBacon"
		Me.chkToppingBacon.Size = New System.Drawing.Size(70, 21)
		Me.chkToppingBacon.TabIndex = 10
		Me.chkToppingBacon.Text = "Bacon"
		Me.chkToppingBacon.UseVisualStyleBackColor = True
		'
		'chkToppingPineapple
		'
		Me.chkToppingPineapple.AutoSize = True
		Me.chkToppingPineapple.Location = New System.Drawing.Point(293, 75)
		Me.chkToppingPineapple.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingPineapple.Name = "chkToppingPineapple"
		Me.chkToppingPineapple.Size = New System.Drawing.Size(93, 21)
		Me.chkToppingPineapple.TabIndex = 6
		Me.chkToppingPineapple.Text = "Pineapple"
		Me.chkToppingPineapple.UseVisualStyleBackColor = True
		'
		'chkToppingMushroom
		'
		Me.chkToppingMushroom.AutoSize = True
		Me.chkToppingMushroom.Location = New System.Drawing.Point(293, 31)
		Me.chkToppingMushroom.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingMushroom.Name = "chkToppingMushroom"
		Me.chkToppingMushroom.Size = New System.Drawing.Size(103, 21)
		Me.chkToppingMushroom.TabIndex = 2
		Me.chkToppingMushroom.Text = "Mushrooms"
		Me.chkToppingMushroom.UseVisualStyleBackColor = True
		'
		'chkToppingBananaPepper
		'
		Me.chkToppingBananaPepper.AutoSize = True
		Me.chkToppingBananaPepper.Location = New System.Drawing.Point(153, 119)
		Me.chkToppingBananaPepper.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingBananaPepper.Name = "chkToppingBananaPepper"
		Me.chkToppingBananaPepper.Size = New System.Drawing.Size(136, 21)
		Me.chkToppingBananaPepper.TabIndex = 9
		Me.chkToppingBananaPepper.Text = "Banana Peppers"
		Me.chkToppingBananaPepper.UseVisualStyleBackColor = True
		'
		'chkToppingGrnOlive
		'
		Me.chkToppingGrnOlive.AutoSize = True
		Me.chkToppingGrnOlive.Location = New System.Drawing.Point(153, 75)
		Me.chkToppingGrnOlive.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingGrnOlive.Name = "chkToppingGrnOlive"
		Me.chkToppingGrnOlive.Size = New System.Drawing.Size(113, 21)
		Me.chkToppingGrnOlive.TabIndex = 5
		Me.chkToppingGrnOlive.Text = "Green Olives"
		Me.chkToppingGrnOlive.UseVisualStyleBackColor = True
		'
		'chkToppingBlkOlive
		'
		Me.chkToppingBlkOlive.AutoSize = True
		Me.chkToppingBlkOlive.Location = New System.Drawing.Point(153, 31)
		Me.chkToppingBlkOlive.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingBlkOlive.Name = "chkToppingBlkOlive"
		Me.chkToppingBlkOlive.Size = New System.Drawing.Size(107, 21)
		Me.chkToppingBlkOlive.TabIndex = 1
		Me.chkToppingBlkOlive.Text = "Black Olives"
		Me.chkToppingBlkOlive.UseVisualStyleBackColor = True
		'
		'chkToppingGrnPepper
		'
		Me.chkToppingGrnPepper.AutoSize = True
		Me.chkToppingGrnPepper.Location = New System.Drawing.Point(18, 119)
		Me.chkToppingGrnPepper.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingGrnPepper.Name = "chkToppingGrnPepper"
		Me.chkToppingGrnPepper.Size = New System.Drawing.Size(127, 21)
		Me.chkToppingGrnPepper.TabIndex = 8
		Me.chkToppingGrnPepper.Text = "Green Peppers"
		Me.chkToppingGrnPepper.UseVisualStyleBackColor = True
		'
		'chkToppingHam
		'
		Me.chkToppingHam.AutoSize = True
		Me.chkToppingHam.Location = New System.Drawing.Point(18, 75)
		Me.chkToppingHam.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingHam.Name = "chkToppingHam"
		Me.chkToppingHam.Size = New System.Drawing.Size(59, 21)
		Me.chkToppingHam.TabIndex = 4
		Me.chkToppingHam.Text = "Ham"
		Me.chkToppingHam.UseVisualStyleBackColor = True
		'
		'chkToppingPepperoni
		'
		Me.chkToppingPepperoni.AutoSize = True
		Me.chkToppingPepperoni.Location = New System.Drawing.Point(18, 31)
		Me.chkToppingPepperoni.Margin = New System.Windows.Forms.Padding(2)
		Me.chkToppingPepperoni.Name = "chkToppingPepperoni"
		Me.chkToppingPepperoni.Size = New System.Drawing.Size(95, 21)
		Me.chkToppingPepperoni.TabIndex = 0
		Me.chkToppingPepperoni.Text = "Pepperoni"
		Me.chkToppingPepperoni.UseVisualStyleBackColor = True
		'
		'cmdPlaceOrder
		'
		Me.cmdPlaceOrder.Location = New System.Drawing.Point(20, 363)
		Me.cmdPlaceOrder.Margin = New System.Windows.Forms.Padding(2)
		Me.cmdPlaceOrder.Name = "cmdPlaceOrder"
		Me.cmdPlaceOrder.Size = New System.Drawing.Size(547, 54)
		Me.cmdPlaceOrder.TabIndex = 8
		Me.cmdPlaceOrder.Text = "Place Order"
		Me.cmdPlaceOrder.UseVisualStyleBackColor = True
		'
		'frmOrder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(591, 433)
		Me.Controls.Add(Me.cmdPlaceOrder)
		Me.Controls.Add(Me.gbToppings)
		Me.Controls.Add(Me.gbCrust)
		Me.Controls.Add(Me.nudQuantity)
		Me.Controls.Add(Me.lblQuantity)
		Me.Controls.Add(Me.nudSize)
		Me.Controls.Add(Me.lblSize)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.lblName)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "frmOrder"
		Me.Text = "Pizza Planet Order Form"
		CType(Me.nudSize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbCrust.ResumeLayout(False)
		Me.gbCrust.PerformLayout()
		Me.gbToppings.ResumeLayout(False)
		Me.gbToppings.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblName As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents lblSize As Label
	Friend WithEvents nudSize As NumericUpDown
	Friend WithEvents nudQuantity As NumericUpDown
	Friend WithEvents lblQuantity As Label
	Friend WithEvents gbCrust As GroupBox
	Friend WithEvents radCrustPepperoni As RadioButton
	Friend WithEvents radCrustHam As RadioButton
	Friend WithEvents radCrustCheese As RadioButton
	Friend WithEvents radCrustGarlic As RadioButton
	Friend WithEvents radCrustPlain As RadioButton
	Friend WithEvents gbToppings As GroupBox
	Friend WithEvents chkToppingAnchovies As CheckBox
	Friend WithEvents chkToppingExCheese As CheckBox
	Friend WithEvents chkToppingSausage As CheckBox
	Friend WithEvents chkToppingBacon As CheckBox
	Friend WithEvents chkToppingPineapple As CheckBox
	Friend WithEvents chkToppingMushroom As CheckBox
	Friend WithEvents chkToppingBananaPepper As CheckBox
	Friend WithEvents chkToppingGrnOlive As CheckBox
	Friend WithEvents chkToppingBlkOlive As CheckBox
	Friend WithEvents chkToppingGrnPepper As CheckBox
	Friend WithEvents chkToppingHam As CheckBox
	Friend WithEvents chkToppingPepperoni As CheckBox
	Friend WithEvents cmdPlaceOrder As Button
End Class
