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
    public partial class registration_screen : Form
    {
        public registration_screen()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cboxAccountType.Items.Add("Freelancer");
            cboxAccountType.Items.Add("Client");
            cboxAccountType.Items.Add("Administrator");
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void cboxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblPersonalDetails_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistrationTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboxAccountType.SelectedItem.ToString() == "Freelancer")
            {
                freelancer_dashboard freelancerDashboard = new freelancer_dashboard();
                freelancerDashboard.Show();
            }
            else if (cboxAccountType.SelectedItem.ToString() == "Client")
            {
                client_dashboard clientDashboard = new client_dashboard();
                clientDashboard.Show();
            }
            else
            {
                freelancer_dashboard adminDashboard = new freelancer_dashboard();
                adminDashboard.Show();
            }
            this.Hide();
        }
    }
}
