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
using System.Diagnostics;

namespace OverSurgery
{
    public partial class TestResults : Form
    {
        private DBConnection con;
        public string fullPatientName;
        private ViewResults viewResults;

        public TestResults()
        {
            InitializeComponent();
        }

        public TestResults(ViewResults viewResults)
        {
            this.viewResults = viewResults;
        }

        public string testPatient
        {
            get { return fullPatientName; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TestResults_Load(object sender, EventArgs e)
        {
            this.patientTableAdapter1.Fill(this.dataBaseOSDataSet1.Patient);
        }
        

        //Shows what row has been selected by the user
        public void patientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //checks if a row has been selected
            {
                DataGridViewRow row = this.patientDataGridView.Rows[e.RowIndex];
                //populate the text box
                string patientID = row.Cells[0].Value.ToString();
                string patientName = row.Cells[1].Value.ToString();
                string patientSurname = row.Cells[2].Value.ToString();

                //print the data to the text boxes
                patientSelected.Text = patientID;
                patientNameTB.Text = patientName;
                patientSurnameTB.Text = patientSurname;
                string space = " ";
                fullPatientName = patientName + space + patientSurname;
            }
        
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(patientNameTB.Text))
            {
                MessageBox.Show("Please select a patient."); //if nothing is selected this message will show
            }
            else
            {
                MessageBox.Show("Printing " + patientNameTB.Text + " " + patientSurnameTB.Text + "'s test results...");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(patientNameTB.Text))
            {
                MessageBox.Show("Please select a patient.");
            }
            else
            {
                ViewResults ss = new ViewResults(this);
                ss.Show();
            }


        }


    }
}
