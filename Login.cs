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
        private DBConnection dbConn;
        
        // Stores value of credentials in dataset to be checked
        private static string DBusername;
        private static string DBpassword;

        public Login()
        {
            InitializeComponent();

            // Connect to database
            dbConn = DBConnection.getInstanceOfDBConnection();
        }

        // Handles login
        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Create dataset and fill with requested Username and Password credentials from database
                /* !!! Vulnerable to SQL injection, need to secure !!! */
                DataSet credentials = dbConn.getLoginDataSet("SELECT * FROM users WHERE username= '" + Convert.ToString(tbx_username.Text) + "' AND password='" + Convert.ToString(tbx_password.Text) + "'");

                // Get values of Username and Password from dataset and set them to a variable
                DBusername = Convert.ToString(credentials.Tables[0].Rows[0]["username"]);
                DBpassword = Convert.ToString(credentials.Tables[0].Rows[0]["password"]);

                // Check credentials
                // Correct credentials
                if (tbx_username.Text == DBusername && tbx_password.Text == DBpassword)
                {
                    // Show the form once logged in
                    this.Hide();
                    SafteyAuditForm f2 = new SafteyAuditForm();
                    f2.Show();
                }
                // Incorrect credentials
                else
                {
                    lbl_login_error.Text = "Incorrect credentials provided";
                    tbx_password.Text = ""; // Clear text in password box to renter
                }
            }
            catch // Catches error when user enters incorrect credentials and data cannot be found in database
            {
                lbl_login_error.Text = "Incorrect credentials provided";
                tbx_password.Text = ""; // Clear text in password box to renter
            }
        }
    }    
}
