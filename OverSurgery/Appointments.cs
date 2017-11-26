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
    public partial class x : Form
    {
        //private const int MorningShiftStarts = 9;
        //private const int MorningShiftEnds = 18;

     //   private const int AfternoonShiftStarts = 14;
       // private const int AfternoonShiftEnds = 18;

        public x()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            this.textBoxSelectedDate.Text = "Date Changed: Start = " +
            e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        }

        private void x_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dataBaseOSDataSet2.Appointment' table. You can move, or remove it, as needed.
            //this.appointmentTableAdapter1.Fill(this.dataBaseOSDataSet2.Appointment);
            //// TODO: This line of code loads data into the 'dataBaseOSDataSet1.Appointment' table. You can move, or remove it, as needed.
            //this.appointmentTableAdapter.Fill(this.dataBaseOSDataSet1.Appointment);
            CreateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DBConnection con = new DBConnection();
            //con.openConnection();
          
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //DateTime date = new DateTime();
            DBConnection con = new DBConnection();
            Constant cons = new Constant();

            con.openConnection();

            cons.queryApointmentTime = "SELECT AppointmentStart FROM [Appointment] ";

            this.textBoxSelectedDate.Text = "Date Selected: Start = " + e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
            string date;
            date = e.Start.ToShortDateString();
            

            // get the selected date
            //date = monthCalendar1.DateSelected;
            //sqlStatement = "SELECT ??? FROM .....WHERE date =....
            //DataSet dsTimes = DBConnection.getDBConnectionInstance().getTimes(sqlStatement, ...); 
            //populate the list??? with the data from the dsTimes



        }

        private void textBoxSelectedDate_TextChanged(object sender, EventArgs e)
        {
            
            this.textBoxSelectedDate.Text = ""+ monthCalendar1.SelectionRange.Start;
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            
        }
        public void CreateListView()
        {
            DBConnection con = new DBConnection();
            con.openConnection();
            Constant cons = new Constant();
            cons.queryApointmentTime = "SELECT AppointmentStart FROM [Appointment] ";
            DataSet dsTime = DBConnection.getDBConnectionInstance().getDataSet(cons.queryApointmentTime);
            SqlCommand sqComm = new SqlCommand(cons.queryApointmentTime);
            
           // DataSet dsTimes = DBConnection.getDBConnectionInstance().getDataSet(cons.queryApointmentTime);
            //try
            //{
               SqlDataReader dr = sqComm.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["AppointmentStart"].ToString());
                    item.SubItems.Add(dr["Staff_ID"].ToString());
                    item.SubItems.Add(dr["Patient_ID"].ToString());

                    listView1.Items.Add(item);

                }
           // }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            con.closeConnection();




            // DataTable dt = new DataTable("Appointment");
            // listView1.Columns.Add("Hours", 100);
            //ListView listviewOBJ = new ListView();
            ////allow user to edit item text
            //listView1.LabelEdit = true;
            //listView1.CheckBoxes = true;
            //listView1.FullRowSelect = true;

            //int max = DBConnection.getDBConnectionInstance().;
            //  for (int i = 0; i >20; i++)
            // {
            // listView1.Columns.Add("Time", 50);
            // listView1.Columns.Add("John", 60);
            // }

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }
    }
}
