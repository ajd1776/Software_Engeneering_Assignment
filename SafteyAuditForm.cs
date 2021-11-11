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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDownA1_ValueChanged(object sender, EventArgs e)
        {

        }

        // Counts number of interventions per section and then displays the total
        public void total_interventions()
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

            decimal total_count = A_count + B_count + C_count + D_count + E_count + F_count + G_count;
            lbl_total.Text = total_count.ToString();

        }

        // Display is updated when user clicks button
        private void button1_Click(object sender, EventArgs e)
        {
            total_interventions();
        }

    }
}

