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
    public partial class TestResults : Form
    {
        public TestResults()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestResults_Load(object sender, EventArgs e)
        {
            this.patientTableAdapter1.FillBy(this.dataBaseOSDataSet1.Patient);
        }
        
        //Shows what row has been selected by the user
        private void patientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //checks if a row has been selected
            {
                DataGridViewRow row = this.patientDataGridView.Rows[e.RowIndex];
                //populate the text box
                string patientID = row.Cells[0].Value.ToString();
                string patientName = row.Cells[1].Value.ToString();
                string patientSurname = row.Cells[2].Value.ToString();
                string space = " ";

                patientSelected.Text = patientName + space + patientSurname;
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Printing " + patientSelected.Text + "'s test results..."); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
