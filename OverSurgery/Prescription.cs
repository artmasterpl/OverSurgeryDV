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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseOSDataSet11.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter1.Fill(this.dataBaseOSDataSet11.Prescription);

        }

        private void ADD_Click(object sender, EventArgs e)
        {

        }
    }
}
