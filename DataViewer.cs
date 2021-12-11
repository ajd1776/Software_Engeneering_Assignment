using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_WindowsFormsApp
{
    public partial class FormDataViewer : Form
    {
        public FormDataViewer()
        {
            InitializeComponent();
        }

        private void btn_form_data_Click(object sender, EventArgs e)
        {
            lbl_data_title.Text = "Form Data";
            // display the data from table Person into the DataGridView
            // get the dataset from the DB and assign it to the dataGridView's DataSource
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM FormData");
            dgv_form.DataSource = ds.Tables[0];
        }

        private void btn_user_data_Click(object sender, EventArgs e)
        {
            lbl_data_title.Text = "User Data";
            // display the data from table Person into the DataGridView
            // get the dataset from the DB and assign it to the dataGridView's DataSource
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM users");
            dgv_form.DataSource = ds.Tables[0];
        }

        private void btn_rtn_form_Click(object sender, EventArgs e)
        {
            // Return to form window
            this.Hide();
            SafteyAuditForm f1 = new SafteyAuditForm();
            f1.Show();
        }

        private void btn_rtn_login_Click(object sender, EventArgs e)
        {
            // Return to login screen
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }
    }
}
