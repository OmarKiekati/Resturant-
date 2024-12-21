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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admHome));
            this.addEmp = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.addCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmp
            // 
            this.addEmp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addEmp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp.Location = new System.Drawing.Point(11, 144);
            this.addEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(294, 76);
            this.addEmp.TabIndex = 0;
            this.addEmp.Text = "add employee";
            this.addEmp.UseVisualStyleBackColor = false;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addProduct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Location = new System.Drawing.Point(11, 279);
            this.addProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(294, 76);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "add product";
            this.addProduct.UseVisualStyleBackColor = false;
            // 
            // addCat
            // 
            this.addCat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addCat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCat.Location = new System.Drawing.Point(11, 11);
            this.addCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(294, 76);
            this.addCat.TabIndex = 2;
            this.addCat.Text = "add category";
            this.addCat.UseVisualStyleBackColor = false;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // admHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(316, 366);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.addEmp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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