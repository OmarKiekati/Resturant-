namespace resturant
{
    partial class addProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduct));
            this.name = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.ingrediants = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPro = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(15, 51);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 31);
            this.name.TabIndex = 0;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(174, 51);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(125, 31);
            this.price.TabIndex = 1;
            // 
            // ingrediants
            // 
            this.ingrediants.Location = new System.Drawing.Point(11, 146);
            this.ingrediants.Margin = new System.Windows.Forms.Padding(2);
            this.ingrediants.Multiline = true;
            this.ingrediants.Name = "ingrediants";
            this.ingrediants.Size = new System.Drawing.Size(125, 31);
            this.ingrediants.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // addPro
            // 
            this.addPro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPro.Location = new System.Drawing.Point(11, 214);
            this.addPro.Margin = new System.Windows.Forms.Padding(2);
            this.addPro.Name = "addPro";
            this.addPro.Size = new System.Drawing.Size(301, 36);
            this.addPro.TabIndex = 9;
            this.addPro.Text = "add product";
            this.addPro.UseVisualStyleBackColor = false;
            this.addPro.Click += new System.EventHandler(this.addPro_Click);
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(174, 146);
            this.categories.Margin = new System.Windows.Forms.Padding(2);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(125, 21);
            this.categories.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "ingediants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "price";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(323, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.addPro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingrediants);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addProduct";
            this.Text = "addProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox ingrediants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPro;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}