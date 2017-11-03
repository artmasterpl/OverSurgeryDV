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
    public partial class AddPatient : Form
    {
        

        public AddPatient()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            
        }

        private void SAVE_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Patient tomain = new Patient();
            this.Hide();
            tomain.ShowDialog();
            Environment.Exit(1);
        }
    }
}
