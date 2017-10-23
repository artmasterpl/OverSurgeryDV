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

        private void AddPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_OverSurgery_2003mdbDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this._OverSurgery_2003mdbDataSet1.Patient);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patientBindingSource.EndEdit();
            patientTableAdapter.Update(_OverSurgery_2003mdbDataSet1.Patient);
        }
    }
}
