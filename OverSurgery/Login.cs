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

        // Exit button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Login button
        private void button1_Click(object sender, EventArgs e)
        {
            // check if login and password are correct
           
            if (DBConnection.getDBConnectionInstance().isLogin(tbUserName.Text, tbPwd.Text) == "1")
            {
                this.Hide();

                Main ss = new Main();
                ss.Show();
            } // if not correct show this msg
            else
            {
                MessageBox.Show("Please Check your Username or Password");
            }

        }

        private void tbPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
