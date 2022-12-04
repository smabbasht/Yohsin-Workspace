﻿using System;
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
    public partial class search_experts : Form
    {
        public search_experts()
        {
            InitializeComponent();
            comboBox1.Items.Add("Data Analysis");
            comboBox1.Items.Add("Web Development");
            comboBox1.Items.Add("App Development");
            comboBox1.Items.Add("Writing");
            comboBox1.Items.Add("UI/UX Design");
            comboBox1.Items.Add("Graphic Design");
            comboBox1.Items.Add("Financial Consultancy");
            comboBox1.Items.Add("Book Review");
            comboBox1.SelectedIndex = 3;
        }

        //private void btnSearchExperts_Click(object sender, EventArgs e)
        //{
        //    search_experts searchExperts = new search_experts();
        //    searchExperts.Show();
        //    this.Hide();
        //}

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

        private void horizontalDivider_Click(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchExperts_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
