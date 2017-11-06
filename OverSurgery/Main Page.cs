using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login tologin = new Login();
            this.Hide();
            tologin.ShowDialog();
            Environment.Exit(1);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure that you want to close", "Exit",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Patient tomain = new Patient();
            this.Hide();
            tomain.ShowDialog();
            Environment.Exit(1);
        }
    }
}
