using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OverSurgery
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure that you want to close", "Exit",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uName = "1234";
                string pWord = "password";

                if ((txtUsername.Text == uName) && (txtPassword.Text == pWord))
                {
                    Main_Page tomain = new Main_Page();
                    this.Hide();
                    tomain.ShowDialog();
                    Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please try again");
            }

        }
    }
}
