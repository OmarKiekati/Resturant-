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
            this.user_name.Location = new System.Drawing.Point(67, 104);
            this.user_name.Multiline = true;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(216, 45);
            this.user_name.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(67, 206);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(216, 45);
            this.pass.TabIndex = 1;
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.Location = new System.Drawing.Point(67, 291);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(65, 20);
            this.ADMIN.TabIndex = 4;
            this.ADMIN.TabStop = true;
            this.ADMIN.Text = "admin";
            this.ADMIN.UseVisualStyleBackColor = true;
            // 
            // EMPLOYEE
            // 
            this.EMPLOYEE.AutoSize = true;
            this.EMPLOYEE.Location = new System.Drawing.Point(180, 291);
            this.EMPLOYEE.Name = "EMPLOYEE";
            this.EMPLOYEE.Size = new System.Drawing.Size(89, 20);
            this.EMPLOYEE.TabIndex = 5;
            this.EMPLOYEE.TabStop = true;
            this.EMPLOYEE.Text = "employee";
            this.EMPLOYEE.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(64, 85);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(70, 16);
            this.user.TabIndex = 6;
            this.user.Text = "user name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(64, 187);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(66, 16);
            this.password.TabIndex = 7;
            this.password.Text = "password";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(128, 348);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 8;
            this.add.Text = "add user";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.EMPLOYEE);
            this.Controls.Add(this.ADMIN);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user_name);
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