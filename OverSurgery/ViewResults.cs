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
            //WHERE [Name] =" + patientFName + " AND Surname =" + patientLName, conn

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lewis\Documents\GitHub\OverSurgeryDV\OverSurgery\DataBaseOS.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("SELECT * FROM [Table] WHERE Name = '" + patientFName + "' AND Surname = '" + patientLName + "'", conn ); //finds the test results from the name of the patient

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    pNameTB.Text = (reader["Name"].ToString()); //Adds the sql results into the text boxes
                    pSNameTB.Text = (reader["surname"].ToString());
                    testTypeTB.Text = (reader["Test Type"].ToString());
                    testDateTB.Text = (reader["Test Date"].ToString());
                    testResultsTB.Text = (reader["Test Results"].ToString());
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
