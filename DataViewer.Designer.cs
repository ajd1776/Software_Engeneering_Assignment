
namespace SE_WindowsFormsApp
{
    partial class FormDataViewer
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
            this.dgv_form = new System.Windows.Forms.DataGridView();
            this.btn_form_data = new System.Windows.Forms.Button();
            this.btn_user_data = new System.Windows.Forms.Button();
            this.btn_rtn_form = new System.Windows.Forms.Button();
            this.lbl_data_title = new System.Windows.Forms.Label();
            this.btn_rtn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_form)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_form
            // 
            this.dgv_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_form.Location = new System.Drawing.Point(12, 34);
            this.dgv_form.Name = "dgv_form";
            this.dgv_form.Size = new System.Drawing.Size(1046, 368);
            this.dgv_form.TabIndex = 0;
            // 
            // btn_form_data
            // 
            this.btn_form_data.Location = new System.Drawing.Point(12, 409);
            this.btn_form_data.Name = "btn_form_data";
            this.btn_form_data.Size = new System.Drawing.Size(128, 23);
            this.btn_form_data.TabIndex = 1;
            this.btn_form_data.Text = "Load form data";
            this.btn_form_data.UseVisualStyleBackColor = true;
            this.btn_form_data.Click += new System.EventHandler(this.btn_form_data_Click);
            // 
            // btn_user_data
            // 
            this.btn_user_data.Location = new System.Drawing.Point(146, 409);
            this.btn_user_data.Name = "btn_user_data";
            this.btn_user_data.Size = new System.Drawing.Size(128, 23);
            this.btn_user_data.TabIndex = 2;
            this.btn_user_data.Text = "Load user data";
            this.btn_user_data.UseVisualStyleBackColor = true;
            this.btn_user_data.Click += new System.EventHandler(this.btn_user_data_Click);
            // 
            // btn_rtn_form
            // 
            this.btn_rtn_form.Location = new System.Drawing.Point(280, 409);
            this.btn_rtn_form.Name = "btn_rtn_form";
            this.btn_rtn_form.Size = new System.Drawing.Size(128, 23);
            this.btn_rtn_form.TabIndex = 3;
            this.btn_rtn_form.Text = "Return to form";
            this.btn_rtn_form.UseVisualStyleBackColor = true;
            this.btn_rtn_form.Click += new System.EventHandler(this.btn_rtn_form_Click);
            // 
            // lbl_data_title
            // 
            this.lbl_data_title.AutoSize = true;
            this.lbl_data_title.Location = new System.Drawing.Point(13, 15);
            this.lbl_data_title.Name = "lbl_data_title";
            this.lbl_data_title.Size = new System.Drawing.Size(0, 13);
            this.lbl_data_title.TabIndex = 4;
            // 
            // btn_rtn_login
            // 
            this.btn_rtn_login.Location = new System.Drawing.Point(930, 408);
            this.btn_rtn_login.Name = "btn_rtn_login";
            this.btn_rtn_login.Size = new System.Drawing.Size(128, 23);
            this.btn_rtn_login.TabIndex = 5;
            this.btn_rtn_login.Text = "Return to login";
            this.btn_rtn_login.UseVisualStyleBackColor = true;
            this.btn_rtn_login.Click += new System.EventHandler(this.btn_rtn_login_Click);
            // 
            // FormDataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 440);
            this.Controls.Add(this.btn_rtn_login);
            this.Controls.Add(this.lbl_data_title);
            this.Controls.Add(this.btn_rtn_form);
            this.Controls.Add(this.btn_user_data);
            this.Controls.Add(this.btn_form_data);
            this.Controls.Add(this.dgv_form);
            this.Name = "FormDataViewer";
            this.Text = "Form Data Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_form;
        private System.Windows.Forms.Button btn_form_data;
        private System.Windows.Forms.Button btn_user_data;
        private System.Windows.Forms.Button btn_rtn_form;
        private System.Windows.Forms.Label lbl_data_title;
        private System.Windows.Forms.Button btn_rtn_login;
    }
}