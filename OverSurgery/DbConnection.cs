using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace OverSurgery
{ 
    class DBConnection
    {
        
        
        //attributes
        private static DBConnection _instance;

        private static string connectionString;

        private SqlConnection connectioToDB;

        private SqlDataAdapter dataAdapter;


        //properties
        public static string ConnectionStr
        {
            set
            {
                connectionString = value;
            }
        }

        //methods
        public static DBConnection getDBConnectionInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();

            return _instance;
        }

        // Open the connection
        public void openConnection()
        {
            // create the connection to the database as an instance of SqlConnection
            connectioToDB = new SqlConnection(connectionString);

            //open connection
            connectioToDB.Open();
        }

        public void closeConnection()
        {
            connectioToDB = new SqlConnection(connectionString);
            connectioToDB.Close();
        }

        public String isLogin(String userName, String pwd)
        {

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Artur\Documents\DataLogin.mdf;Integrated Security=True;Connect Timeout=30");

            openConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From [Login] where Username='" + userName + "' and Password='" + pwd + "'", connectioToDB);
            DataTable dt = new DataTable();
            DataSet DS = new DataSet();

            DS.Tables.Add(dt);
            sda.Fill(dt);
            closeConnection();

            return dt.Rows[0][0].ToString();

        }

       public void AddPatient(String Name, String surname, String DoB, String street, String city)
        {

            //open conecction
            openConnection();
            // initialize the sqldataadapter object, that retrives data from the table [Patient]
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Patient]", connectionString);
            
            DataSet DS = new DataSet();           
            sda.Fill(DS);
            
            // add row to the table
            DataRow row = DS.Tables[0].NewRow();
            row["Name"] = Name;
            row["Surname"] = surname;
            row["Date Of Birth"] = DoB;
            row["Street"] = street;
            row["City"] = city;

            DS.Tables[0].Rows.Add(row);


            //initialize sqlcommandbuilder to update, insert and delete properties 
            SqlCommandBuilder cmdB = new SqlCommandBuilder(sda);
            sda.UpdateCommand = cmdB.GetUpdateCommand();
            sda.InsertCommand = cmdB.GetInsertCommand();
            sda.DeleteCommand = cmdB.GetDeleteCommand();

            sda.Update(DS);

           
        }


        

        //create a data set for a certain request
        public DataSet getDataSet(String sqlStatement)
        {
            DataSet dataSet = new DataSet();

            //open connection
            openConnection();

            //create the data adapter object
            dataAdapter = new SqlDataAdapter(sqlStatement, connectioToDB);

            //fill in the data set
            dataAdapter.Fill(dataSet);

            //close connection
            closeConnection();

            return dataSet;
        }

        public void insToTable(String Name, String surname, String DoB, String street, String city)
        {
            string insquerry = "insert into Patient([Name], [Surname], [Date Of Birth], [Street], [City]) values (@Name, @surname, @DoB, @street, @city)";
            openConnection();

            SqlCommand insCmd = new SqlCommand(insquerry, connectioToDB);
            //AddPatient add = new AddPatient();

            getDBConnectionInstance().AddPatient(Name, surname, DoB, street, city);
            // add data to table
            insCmd.Parameters.AddWithValue("@Name", Name);
            insCmd.Parameters.AddWithValue("@Surname", surname);
            insCmd.Parameters.AddWithValue("@DoB", DoB);
            insCmd.Parameters.AddWithValue("@Street", street);
            insCmd.Parameters.AddWithValue("@City", city);
            
            
            int affectrows = insCmd.ExecuteNonQuery();
            closeConnection();
            //MessageBox.Show(affectrows + "rows inserted");
        }


        public void testResults(String id)
        {
            string searchQuery = "SELECT [Name], [Surname] FROM [Patient] WHERE [Id]='" + id + "'";
            openConnection();

            SqlCommand testCmd = new SqlCommand(searchQuery, connectioToDB);

            using (SqlDataReader dr = testCmd.ExecuteReader())
            {
                while(dr.Read())
                {
                    string resultQuery = dr[0].ToString();
                }
            }
        }

            
        }
    }


