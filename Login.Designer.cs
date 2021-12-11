
namespace SE_WindowsFormsApp
{
    partial class Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_sername = new System.Windows.Forms.Label();
            this.lbl_assword = new System.Windows.Forms.Label();
            this.lbl_login_error = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.Location = new System.Drawing.Point(190, 146);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.login_button_Click);
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(146, 77);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(119, 20);
            this.tbx_username.TabIndex = 1;
            this.tbx_username.Tag = "";
            this.tbx_username.Text = "a";
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(146, 103);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(119, 20);
            this.tbx_password.TabIndex = 2;
            this.tbx_password.Text = "b";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(70, 37);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(216, 20);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Please enter login credentials";
            // 
            // lbl_sername
            // 
            this.lbl_sername.AutoSize = true;
            this.lbl_sername.Location = new System.Drawing.Point(85, 80);
            this.lbl_sername.Name = "lbl_sername";
            this.lbl_sername.Size = new System.Drawing.Size(55, 13);
            this.lbl_sername.TabIndex = 4;
            this.lbl_sername.Text = "Username";
            // 
            // lbl_assword
            // 
            this.lbl_assword.AutoSize = true;
            this.lbl_assword.Location = new System.Drawing.Point(85, 106);
            this.lbl_assword.Name = "lbl_assword";
            this.lbl_assword.Size = new System.Drawing.Size(53, 13);
            this.lbl_assword.TabIndex = 5;
            this.lbl_assword.Text = "Password";
            // 
            // lbl_login_error
            // 
            this.lbl_login_error.AutoSize = true;
            this.lbl_login_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_login_error.Location = new System.Drawing.Point(85, 130);
            this.lbl_login_error.Name = "lbl_login_error";
            this.lbl_login_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_login_error.TabIndex = 6;
            // 
            // btn_signup
            // 
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_signup.Location = new System.Drawing.Point(88, 146);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 7;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(348, 181);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_login_error);
            this.Controls.Add(this.lbl_assword);
            this.Controls.Add(this.lbl_sername);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Text = "A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_sername;
        private System.Windows.Forms.Label lbl_assword;
        private System.Windows.Forms.Label lbl_login_error;
        private System.Windows.Forms.Button btn_signup;
    }
}

