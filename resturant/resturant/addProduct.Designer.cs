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
            this.name = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.ingrediants = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addPro = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(97, 55);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(237, 37);
            this.name.TabIndex = 0;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(97, 122);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(237, 37);
            this.price.TabIndex = 1;
            // 
            // ingrediants
            // 
            this.ingrediants.Location = new System.Drawing.Point(97, 182);
            this.ingrediants.Multiline = true;
            this.ingrediants.Name = "ingrediants";
            this.ingrediants.Size = new System.Drawing.Size(237, 37);
            this.ingrediants.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ingediants";
            // 
            // addPro
            // 
            this.addPro.Location = new System.Drawing.Point(150, 309);
            this.addPro.Name = "addPro";
            this.addPro.Size = new System.Drawing.Size(110, 23);
            this.addPro.TabIndex = 9;
            this.addPro.Text = "add product";
            this.addPro.UseVisualStyleBackColor = true;
            this.addPro.Click += new System.EventHandler(this.addPro_Click);
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(150, 237);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(121, 24);
            this.categories.TabIndex = 10;
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.addPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingrediants);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addPro;
        private System.Windows.Forms.ComboBox categories;
    }
}