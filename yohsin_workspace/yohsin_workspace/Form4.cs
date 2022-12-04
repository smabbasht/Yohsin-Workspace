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
    public partial class freelancer_dashboard : Form
    {
        public freelancer_dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void horizontalDivider_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            freelancer_my_order fMyOrders = new freelancer_my_order();
            fMyOrders.Show();
            this.Hide();
        }

        private void btnMyRequests_Click(object sender, EventArgs e)
        {
            my_requests myRequests = new my_requests();
            myRequests.Show();
            this.Hide();
        }

        private void btnMyInformation_Click(object sender, EventArgs e)
        {
            freelancer_my_information fMyInfo = new freelancer_my_information();
            fMyInfo.Show();
            this.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            my_profile myProfile = new my_profile();
            myProfile.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startup_screen startScreen = new startup_screen();
            startScreen.Show();
            this.Hide();
        }

        private void btnCustomerCare_Click(object sender, EventArgs e)
        {
            freelancer_customer_care fCustomerCare = new freelancer_customer_care();
            fCustomerCare.Show();
            this.Hide();
        }
    }
}
