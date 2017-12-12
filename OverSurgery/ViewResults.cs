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
    public partial class ViewResults : Form
    {
        TestResults fullName;
        public ViewResults(TestResults nameInc)
        {
            fullName = nameInc;
            InitializeComponent();
        }

        private void ViewResults_Load(object sender, EventArgs e)
        {
            //access test results for name of patient
            string patientName = fullName.fullPatientName;

            patientNameLabel.Text = ("Test Results for " + patientName);

            //split full name into first name last name
            var names = patientName.Split(' ');
            string patientFName = names[0];
            string patientLName = names[1];

            /*DBConnection con = new DBConnection();
            con.openConnection();
            DBConnection.getDBConnectionInstance().testResults(patientFName, patientLName);*/

        }
    }
}
