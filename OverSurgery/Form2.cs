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
        private DBConnection con;

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
            this.bindingSource1.AddNew();
            
            
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
           
            //save patient to the patient DB
            this.Validate();
            this.patientBindingSource1.EndEdit();
            this.patientTableAdapter.Update(this.patientDataSet);
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.patientDataSet.Patient);

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            // remove one record
            this.patientBindingSource1.RemoveCurrent();
        }
    }
}
