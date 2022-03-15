namespace HW1_Campbell
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdPurchaseTotal = new System.Windows.Forms.Button();
            this.cmdBackorder = new System.Windows.Forms.Button();
            this.lstOutputView = new System.Windows.Forms.ListView();
            this.MicrolandDB = new HW1_Campbell._HW_1_MicrolandDataSet();
            this.ordersTableAdapter = new HW1_Campbell._HW_1_MicrolandDataSetTableAdapters.OrdersTableAdapter();
            this.inventoryTableAdapter = new HW1_Campbell._HW_1_MicrolandDataSetTableAdapters.InventoryTableAdapter();
            this.customersTableAdapter = new HW1_Campbell._HW_1_MicrolandDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MicrolandDB)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPurchaseTotal
            // 
            this.cmdPurchaseTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdPurchaseTotal.Location = new System.Drawing.Point(12, 12);
            this.cmdPurchaseTotal.Name = "cmdPurchaseTotal";
            this.cmdPurchaseTotal.Size = new System.Drawing.Size(466, 120);
            this.cmdPurchaseTotal.TabIndex = 0;
            this.cmdPurchaseTotal.Text = "Todays Purchase Total";
            this.cmdPurchaseTotal.UseVisualStyleBackColor = true;
            this.cmdPurchaseTotal.Click += new System.EventHandler(this.GetPurchaseTotal);
            // 
            // cmdBackorder
            // 
            this.cmdBackorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdBackorder.Location = new System.Drawing.Point(523, 12);
            this.cmdBackorder.Name = "cmdBackorder";
            this.cmdBackorder.Size = new System.Drawing.Size(465, 120);
            this.cmdBackorder.TabIndex = 1;
            this.cmdBackorder.Text = "Items To Be Ordered";
            this.cmdBackorder.UseVisualStyleBackColor = true;
            this.cmdBackorder.Click += new System.EventHandler(this.GetBackorderAmmounts);
            // 
            // lstOutputView
            // 
            this.lstOutputView.Font = new System.Drawing.Font("Courier New", 12F);
            this.lstOutputView.Location = new System.Drawing.Point(12, 156);
            this.lstOutputView.Name = "lstOutputView";
            this.lstOutputView.Size = new System.Drawing.Size(976, 832);
            this.lstOutputView.TabIndex = 2;
            this.lstOutputView.UseCompatibleStateImageBehavior = false;
            this.lstOutputView.View = System.Windows.Forms.View.List;
            // 
            // MicrolandDB
            // 
            this.MicrolandDB.DataSetName = "_HW_1_MicrolandDataSet";
            this.MicrolandDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.lstOutputView);
            this.Controls.Add(this.cmdBackorder);
            this.Controls.Add(this.cmdPurchaseTotal);
            this.Name = "Form1";
            this.Text = "Microland Order System";
            ((System.ComponentModel.ISupportInitialize)(this.MicrolandDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _HW_1_MicrolandDataSet MicrolandDB;
        private System.Windows.Forms.Button cmdPurchaseTotal;
        private System.Windows.Forms.Button cmdBackorder;
        private System.Windows.Forms.ListView lstOutputView;
        private _HW_1_MicrolandDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private _HW_1_MicrolandDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private _HW_1_MicrolandDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}

