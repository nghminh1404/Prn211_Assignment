namespace Prn211_Assignment.Forms
{
    partial class BillForm
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
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intomoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbBillName = new System.Windows.Forms.Label();
            this.lbBillNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCashierName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.productName,
            this.quantity,
            this.intomoney});
            this.dgvBill.Location = new System.Drawing.Point(178, 124);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 25;
            this.dgvBill.Size = new System.Drawing.Size(396, 398);
            this.dgvBill.TabIndex = 76;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // intomoney
            // 
            this.intomoney.HeaderText = "Into Money";
            this.intomoney.MinimumWidth = 6;
            this.intomoney.Name = "intomoney";
            // 
            // lbBillName
            // 
            this.lbBillName.AutoSize = true;
            this.lbBillName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBillName.Location = new System.Drawing.Point(178, 82);
            this.lbBillName.Name = "lbBillName";
            this.lbBillName.Size = new System.Drawing.Size(105, 23);
            this.lbBillName.TabIndex = 77;
            this.lbBillName.Text = "Bill Number:";
            // 
            // lbBillNumber
            // 
            this.lbBillNumber.AutoSize = true;
            this.lbBillNumber.Location = new System.Drawing.Point(289, 85);
            this.lbBillNumber.Name = "lbBillNumber";
            this.lbBillNumber.Size = new System.Drawing.Size(49, 20);
            this.lbBillNumber.TabIndex = 78;
            this.lbBillNumber.Text = "00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(178, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "Cashier:";
            // 
            // lbCashierName
            // 
            this.lbCashierName.AutoSize = true;
            this.lbCashierName.Location = new System.Drawing.Point(255, 48);
            this.lbCashierName.Name = "lbCashierName";
            this.lbCashierName.Size = new System.Drawing.Size(95, 20);
            this.lbCashierName.TabIndex = 80;
            this.lbCashierName.Text = "cashierName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(289, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 28);
            this.label6.TabIndex = 81;
            this.label6.Text = "Payment receipt";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCashierName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBillNumber);
            this.Controls.Add(this.lbBillName);
            this.Controls.Add(this.dgvBill);
            this.Name = "BillForm";
            this.Text = "BillForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBill;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn intomoney;
        private Label lbBillName;
        private Label lbBillNumber;
        private Label label2;
        private Label lbCashierName;
        private Label label6;
    }
}