using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yohsin_workspace.Resources;

namespace yohsin_workspace
{
    public partial class client_customer_care : Form
    {
        public client_customer_care()
        {
            InitializeComponent();
        }

        private void btnSearchExperts_Click(object sender, EventArgs e)
        {
            search_experts searchExperts = new search_experts();
            searchExperts.Show();
            this.Hide();
        }

        //private void btnCustomerCares_Click(object sender, EventArgs e)
        //{
        //    client_customer_care cCustomerCare = new client_customer_care();
        //    cCustomerCare.Show();
        //    this.Hide();
        //}

        //private void btnMyInformation_Click(object sender, EventArgs e)
        //{
        //}

        //private void btnMyOrders_Click(object sender, EventArgs e)
        //{
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startup_screen startScreen = new startup_screen();
            startScreen.Show();
            this.Hide();
        }

        private void btnMyOrders_Click_1(object sender, EventArgs e)
        {
            client_my_orders cMyOrders = new client_my_orders();
            cMyOrders.Show();
            this.Hide();

        }

        private void btnMyInformation_Click_1(object sender, EventArgs e)
        {
            client_my_info cMyInfo = new client_my_info();
            cMyInfo.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            raise_new_issue raiseNewIssue = new raise_new_issue();
            raiseNewIssue.Show();
        }
    }
}
