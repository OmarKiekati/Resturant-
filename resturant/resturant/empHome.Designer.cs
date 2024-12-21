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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empHome));
            this.viewProducts = new System.Windows.Forms.Button();
            this.viewCategories = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewProducts
            // 
            this.viewProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.viewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewProducts.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProducts.Location = new System.Drawing.Point(11, 144);
            this.viewProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.Size = new System.Drawing.Size(294, 76);
            this.viewProducts.TabIndex = 0;
            this.viewProducts.Text = "view products";
            this.viewProducts.UseVisualStyleBackColor = false;
            // 
            // viewCategories
            // 
            this.viewCategories.BackColor = System.Drawing.Color.LightSeaGreen;
            this.viewCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewCategories.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCategories.Location = new System.Drawing.Point(11, 11);
            this.viewCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewCategories.Name = "viewCategories";
            this.viewCategories.Size = new System.Drawing.Size(294, 76);
            this.viewCategories.TabIndex = 1;
            this.viewCategories.Text = "view categories";
            this.viewCategories.UseVisualStyleBackColor = false;
            // 
            // addOrder
            // 
            this.addOrder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addOrder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrder.Location = new System.Drawing.Point(11, 279);
            this.addOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(294, 76);
            this.addOrder.TabIndex = 2;
            this.addOrder.Text = "add order";
            this.addOrder.UseVisualStyleBackColor = false;
            // 
            // empHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(316, 366);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.viewCategories);
            this.Controls.Add(this.viewProducts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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