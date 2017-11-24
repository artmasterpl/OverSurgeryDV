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
    public partial class Test_Results : Form
    {
        public Test_Results()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = comboBox1.SelectedValue.ToString();

        }

        private void Test_Results_Load(object sender, EventArgs e)
        {
            DBConnection.getDBConnectionInstance();
            
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Artur\Documents\DataLogin.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand sc = new SqlCommand("select name,surname from Patient");
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("surname", typeof(string));
            dt.Load(reader);

            comboBox1.ValueMember = "name";
            comboBox1.DisplayMember = "surname";
            comboBox1.DataSource = dt;

            
        }
    }
}
