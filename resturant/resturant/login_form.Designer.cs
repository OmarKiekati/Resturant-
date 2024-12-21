namespace resturant
{
    partial class login_form
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
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(59, 133);
            this.user_name.Multiline = true;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(234, 35);
            this.user_name.TabIndex = 0;
            this.user_name.Text = "enter use name";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(59, 255);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(234, 35);
            this.password.TabIndex = 1;
            this.password.Text = "enter password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(110, 347);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(127, 32);
            this.login.TabIndex = 2;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Name = "login_form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
    }
}

