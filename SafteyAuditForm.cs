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
    public partial class SafteyAuditForm : Form
    {
        private DBConnection dbConn;
        public SafteyAuditForm()
        {
            InitializeComponent();

            // Create instance of database object
            dbConn = DBConnection.getInstanceOfDBConnection();

        }

        // Counts number of interventions per section and then displays the total
        public void totalInterventions()
        {
            decimal A_count = numericUpDownA1.Value + numericUpDownA2.Value + numericUpDownA3.Value +
                              numericUpDownA4.Value + numericUpDownA5.Value;
            lbl_A_total.Text = A_count.ToString();

            decimal B_count = numericUpDownB1.Value + numericUpDownB2.Value + numericUpDownB3.Value;
            lbl_B_total.Text = B_count.ToString();
                          
            decimal C_count = numericUpDownC1.Value + numericUpDownC2.Value + numericUpDownC3.Value +
                              numericUpDownC4.Value;
            lbl_C_total.Text = C_count.ToString();

            decimal D_count = numericUpDownD1.Value + numericUpDownD2.Value + numericUpDownD3.Value;
            lbl_D_total.Text = D_count.ToString();

            decimal E_count = numericUpDownE1.Value + numericUpDownE2.Value + numericUpDownE3.Value;
            lbl_E_total.Text = E_count.ToString();

            decimal F_count = numericUpDownF1.Value + numericUpDownF2.Value + numericUpDownF3.Value;
            lbl_F_total.Text = F_count.ToString();

            decimal G_count = numericUpDownG1.Value + numericUpDownG2.Value + numericUpDownG3.Value;
            lbl_G_total.Text = G_count.ToString();

            // Total
            decimal total_count = A_count + B_count + C_count + D_count + E_count + F_count + G_count;
            lbl_total.Text = total_count.ToString();
        }
  
        private void btn_update_Click(object sender, EventArgs e)
        {
            // Update total intervention display
            totalInterventions();
        }

        private void btn_save_Click(object sender, EventArgs e)
        { 
            // Update total intervention display
            totalInterventions();

            // SQL statement used to pass as a parameter
            string sql;
            sql = "INSERT INTO FormData ([site], [work_area], [supervisor], [completed_by], [job_description], [inspector], [date], [type], [total_interventions]) VALUES (@site, @work_area, @supervisor, @completed_by, @job_description, @inspector, @date, @type, @total_interventions)";

            // Get data from fields in SafteyAuditForm and save to database
            dbConn.saveFormToDB(sql, tbx_site.Text, tbx_work_area.Text, tbx_supervisor.Text, tbx_completed_by.Text, tbx_job_description.Text, tbx_inspector.Text, Convert.ToString(dtp_date.Value), tbx_type.Text, lbl_total.Text);

            lbl_save_to_db.Text = "Successfully saved form data to database";
        }

        private void btn_show_form_Click(object sender, EventArgs e)
        {
            // Close this window and open the form data viewer window
            this.Hide();
            FormDataViewer fdv = new FormDataViewer();
            fdv.Show();
        }

        private void btn_clear_form_Click(object sender, EventArgs e)
        {
            // Clear form by creating a new one
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