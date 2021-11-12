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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Handles login
         // TODO:
         // - 3 tries before locked out
         // - Password hint
         // - Connect to Main_DB to use stored credentials
        private void login_button_Click(object sender, EventArgs e)
        {
            // Correct credentials
            if (tbx_username.Text == "u" && tbx_password.Text == "p")
            {
                this.Hide();
                SafteyAuditForm f2 = new SafteyAuditForm();
                f2.Show();
            }
            // Incorrect credentials
            else
            {
                // Error message displayed in red under tbx_password in Login window
                lbl_login_error.Text = "Incorrect credentials provided";
                tbx_password.Text = ""; // Clear text in password box to renter
            }

        }
    }    
}
