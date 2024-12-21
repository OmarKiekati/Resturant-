namespace resturant
{
    partial class addUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            this.user_name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.ADMIN = new System.Windows.Forms.RadioButton();
            this.EMPLOYEE = new System.Windows.Forms.RadioButton();
            this.user = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(50, 84);
            this.user_name.Margin = new System.Windows.Forms.Padding(2);
            this.user_name.Multiline = true;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(163, 31);
            this.user_name.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(50, 168);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(163, 32);
            this.pass.TabIndex = 1;
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ADMIN.Location = new System.Drawing.Point(50, 219);
            this.ADMIN.Margin = new System.Windows.Forms.Padding(2);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(53, 17);
            this.ADMIN.TabIndex = 4;
            this.ADMIN.TabStop = true;
            this.ADMIN.Text = "admin";
            this.ADMIN.UseVisualStyleBackColor = false;
            // 
            // EMPLOYEE
            // 
            this.EMPLOYEE.AutoSize = true;
            this.EMPLOYEE.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EMPLOYEE.Location = new System.Drawing.Point(142, 219);
            this.EMPLOYEE.Margin = new System.Windows.Forms.Padding(2);
            this.EMPLOYEE.Name = "EMPLOYEE";
            this.EMPLOYEE.Size = new System.Drawing.Size(71, 17);
            this.EMPLOYEE.TabIndex = 5;
            this.EMPLOYEE.TabStop = true;
            this.EMPLOYEE.Text = "employee";
            this.EMPLOYEE.UseVisualStyleBackColor = false;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.LightSeaGreen;
            this.user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(84, 52);
            this.user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(94, 19);
            this.user.TabIndex = 6;
            this.user.Text = "user name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.LightSeaGreen;
            this.password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(92, 134);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 19);
            this.password.TabIndex = 7;
            this.password.Text = "password";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(50, 273);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(163, 41);
            this.add.TabIndex = 8;
            this.add.Text = "add user";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(266, 366);
            this.Controls.Add(this.add);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.EMPLOYEE);
            this.Controls.Add(this.ADMIN);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user_name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addUser";
            this.Text = "add user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.RadioButton ADMIN;
        private System.Windows.Forms.RadioButton EMPLOYEE;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button add;
    }
}