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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._OverSurgery_2003mdbDataSet1);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_OverSurgery_2003mdbDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this._OverSurgery_2003mdbDataSet1.Patient);
            // TODO: This line of code loads data into the '_OverSurgery_2003mdbDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this._OverSurgery_2003mdbDataSet1.Patient);

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
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._OverSurgery_2003mdbDataSet1);

        }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient ss = new AddPatient();
            ss.Show();
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
