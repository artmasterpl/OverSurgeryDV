using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace OverSurgery
{
    public partial class Patient : Form
    {
        string connesctionString;

        SqlConnection connection;

        public Patient()
        {
            InitializeComponent();
           
                connesctionString = ConfigurationManager.ConnectionStrings
                     ["OverSurgery.Properties.Settings.DataConnectionString"].ConnectionString;
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Main_Load(object sender, EventArgs e)
        {
            

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // log out 
            Login ss = new Login();
            this.Close();
            ss.Show();
        }

        private void patientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient ss = new AddPatient();
            ss.Show();
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page tomain = new Main_Page();
            this.Hide();
            tomain.ShowDialog();
            Environment.Exit(1);
        }
    }
}
