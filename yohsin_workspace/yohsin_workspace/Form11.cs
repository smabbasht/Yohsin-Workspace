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
    public partial class admin_customer_care : Form
    {
        public admin_customer_care()
        {
            InitializeComponent();
            DataGridViewButtonColumn viewDetails = new DataGridViewButtonColumn();
            viewDetails.Name = "view_details";
            viewDetails.Text = "View Details";
        }

        private void btnCutomerCare_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startup_screen startScreen = new startup_screen();
            startScreen.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
