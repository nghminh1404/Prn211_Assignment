namespace Prn211_Assignment
{
    partial class MainForm
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
            this.btProduct = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btProduct
            // 
            this.btProduct.Location = new System.Drawing.Point(70, 198);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(152, 70);
            this.btProduct.TabIndex = 0;
            this.btProduct.Text = "Product";
            this.btProduct.UseVisualStyleBackColor = true;
            this.btProduct.Click += new System.EventHandler(this.btProduct_Click);
            // 
            // btUser
            // 
            this.btUser.Location = new System.Drawing.Point(310, 198);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(152, 70);
            this.btUser.TabIndex = 1;
            this.btUser.Text = "User";
            this.btUser.UseVisualStyleBackColor = true;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(544, 198);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(152, 70);
            this.btOrder.TabIndex = 2;
            this.btOrder.Text = "Order";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btCart
            // 
            this.btCart.Location = new System.Drawing.Point(770, 198);
            this.btCart.Name = "btCart";
            this.btCart.Size = new System.Drawing.Size(152, 70);
            this.btCart.TabIndex = 3;
            this.btCart.Text = "Cart";
            this.btCart.UseVisualStyleBackColor = true;
            this.btCart.Click += new System.EventHandler(this.btCart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 492);
            this.Controls.Add(this.btCart);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.btProduct);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btProduct;
        private Button btUser;
        private Button btOrder;
        private Button btCart;
    }
}