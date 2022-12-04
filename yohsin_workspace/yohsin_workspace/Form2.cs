using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yohsin_workspace
{
    public partial class login_screen : Form
    {
        public login_screen()
        {
            InitializeComponent();
        }

        // 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_screen_Load(object sender, EventArgs e)
        {
            cboxAccountType.Items.Add("Freelancer");
            cboxAccountType.Items.Add("Client");
            cboxAccountType.Items.Add("Administrator");
        }
        // lblLoginScreenTitle
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxAccountType.SelectedValue = cboxAccountType.SelectedItem.ToString();

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblAccountType_Click(object sender, EventArgs e)
        {

        }
        // Horizontal Divider Line
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // yohsin logo
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            freelancer_dashboard freelancerDashboard = new freelancer_dashboard();
            freelancerDashboard.Show();
            this.Hide();
        }
    }
}
