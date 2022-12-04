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
    public partial class client_dashboard : Form
    {
        public client_dashboard()
        {
            InitializeComponent();
        }

        private void btnSearchExperts_Click(object sender, EventArgs e)
        {
            search_experts searchExperts = new search_experts();
            searchExperts.Show();
            this.Hide();
        }

        private void btnCustomerCares_Click(object sender, EventArgs e)
        {
            client_customer_care cCustomerCare = new client_customer_care();
            cCustomerCare.Show();
            this.Hide();
        }

        private void btnMyInformation_Click(object sender, EventArgs e)
        {
            client_my_info cMyInfo = new client_my_info();
            cMyInfo.Show();
            this.Hide();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            client_my_orders cMyOrders = new client_my_orders();
            cMyOrders.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startup_screen startScreen = new startup_screen();
            startScreen.Show();
            this.Hide();
        }
    }
}
