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
    public partial class Main : Form
    {
        string connesctionString;

        public Main()
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

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void checkAvaliabilityToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void makeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x ss = new x();
            ss.Show();
        }

        private void checkThePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prescription ss = new Prescription();
            ss.Show();
        }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient ss = new AddPatient();
            ss.Show();
        }

        private void testResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_Results ss = new Test_Results();
            ss.Show();
        }
    }
}
