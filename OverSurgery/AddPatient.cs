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
using System.Data;

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
            try
            {
                con = new DBConnection();
                this.bindingSource2.AddNew();
                con.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dataBaseOSDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.dataBaseOSDataSet.Patient);


        }
        // save data into database
        private void SAVE_Click(object sender, EventArgs e)
        {

            try
            {
                con = new DBConnection();
               
                con.openConnection();
                DBConnection.getDBConnectionInstance().AddPatient(textBoxName.Text, textBoxSurname.Text, textBoxDoB.Text, textBoxStreetName.Text, textBoxCity.Text);
                this.Validate();
                con.insToTable(textBoxName.Text, textBoxSurname.Text, textBoxDoB.Text, textBoxStreetName.Text, textBoxCity.Text);

                this.bindingSource2.EndEdit();
                this.patientTableAdapter.Update(this.dataBaseOSDataSet.Patient);

                //string insquerry = "insert into Patient([Name], [Surname], [Date Od Birth], [Street], [City]) values (@Name, @surname, @DoB, @street, @city)";

                //SqlCommand insCmd = new SqlCommand(insquerry);
                
                //// add data to table
                //insCmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                //insCmd.Parameters.AddWithValue("@Surname", textBoxSurname.Text);
                //insCmd.Parameters.AddWithValue("@Date Of Birth", textBoxDoB.Text);
                //insCmd.Parameters.AddWithValue("@Street", textBoxStreetName.Text);
                //insCmd.Parameters.AddWithValue("@City", textBoxCity.Text);
                //int affectrows = insCmd.ExecuteNonQuery();
                //MessageBox.Show(affectrows + "rows inserted");


            }

            
            //catch (Exception ex)
            //    {
            //    MessageBox.Show(ex.Message);
            //    }
            finally
                 {
            con.closeConnection();
             }

             }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            con = new DBConnection();
            con.openConnection();
            
                
        }
    }
    }

