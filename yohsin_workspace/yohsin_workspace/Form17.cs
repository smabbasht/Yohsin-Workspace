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
    public partial class freelancer_complete_profile : Form
    {
        public freelancer_complete_profile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void freelancer_complete_profile_Load(object sender, EventArgs e)
        {

        }

        private void lblBankName_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            freelancer_dashboard fDashboard = new freelancer_dashboard();
            fDashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration_screen regScreen = new registration_screen();
            regScreen.Show();
            this.Hide();
        }
    }
}