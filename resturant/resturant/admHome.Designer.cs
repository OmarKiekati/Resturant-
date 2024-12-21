namespace resturant
{
    partial class admHome
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
            this.addEmp = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.addCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmp
            // 
            this.addEmp.Location = new System.Drawing.Point(79, 89);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(145, 90);
            this.addEmp.TabIndex = 0;
            this.addEmp.Text = "add employee";
            this.addEmp.UseVisualStyleBackColor = true;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(289, 89);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(145, 90);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "add product";
            this.addProduct.UseVisualStyleBackColor = true;
            // 
            // addCat
            // 
            this.addCat.Location = new System.Drawing.Point(79, 226);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(145, 90);
            this.addCat.TabIndex = 2;
            this.addCat.Text = "add category";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // admHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.addEmp);
            this.Name = "admHome";
            this.Text = "admHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button addCat;
    }
}