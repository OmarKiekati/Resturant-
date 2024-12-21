namespace resturant
{
    partial class empHome
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
            this.viewProducts = new System.Windows.Forms.Button();
            this.viewCategories = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewProducts
            // 
            this.viewProducts.Location = new System.Drawing.Point(118, 30);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.Size = new System.Drawing.Size(177, 99);
            this.viewProducts.TabIndex = 0;
            this.viewProducts.Text = "view products";
            this.viewProducts.UseVisualStyleBackColor = true;
            // 
            // viewCategories
            // 
            this.viewCategories.Location = new System.Drawing.Point(118, 145);
            this.viewCategories.Name = "viewCategories";
            this.viewCategories.Size = new System.Drawing.Size(177, 99);
            this.viewCategories.TabIndex = 1;
            this.viewCategories.Text = "view categories";
            this.viewCategories.UseVisualStyleBackColor = true;
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(118, 271);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(177, 99);
            this.addOrder.TabIndex = 2;
            this.addOrder.Text = "add order";
            this.addOrder.UseVisualStyleBackColor = true;
            // 
            // empHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.viewCategories);
            this.Controls.Add(this.viewProducts);
            this.Name = "empHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewProducts;
        private System.Windows.Forms.Button viewCategories;
        private System.Windows.Forms.Button addOrder;
    }
}