
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
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.Location = new System.Drawing.Point(101, 110);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.login_button_Click);
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(76, 48);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(119, 20);
            this.tbx_username.TabIndex = 1;
            this.tbx_username.Tag = "";
            this.tbx_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(76, 74);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(119, 20);
            this.tbx_password.TabIndex = 2;
            this.tbx_password.TextChanged += new System.EventHandler(this.Text_Password_TextChanged);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(64, 13);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(145, 13);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Please enter login credentials";
            this.lbl_login.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_sername
            // 
            this.lbl_sername.AutoSize = true;
            this.lbl_sername.Location = new System.Drawing.Point(15, 51);
            this.lbl_sername.Name = "lbl_sername";
            this.lbl_sername.Size = new System.Drawing.Size(55, 13);
            this.lbl_sername.TabIndex = 4;
            this.lbl_sername.Text = "Username";
            // 
            // lbl_assword
            // 
            this.lbl_assword.AutoSize = true;
            this.lbl_assword.Location = new System.Drawing.Point(15, 77);
            this.lbl_assword.Name = "lbl_assword";
            this.lbl_assword.Size = new System.Drawing.Size(53, 13);
            this.lbl_assword.TabIndex = 5;
            this.lbl_assword.Text = "Password";
            this.lbl_assword.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(239, 166);
            this.Controls.Add(this.lbl_assword);
            this.Controls.Add(this.lbl_sername);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Text = "Login";
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
    }
}

