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
    public partial class startup_screen : Form
    {
        public startup_screen()
        {
            InitializeComponent();
        }

        private void startup_screen_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            registration_screen regScreen = new registration_screen();
            regScreen.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            login_screen logScreen = new login_screen();
            logScreen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
