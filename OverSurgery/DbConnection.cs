using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace OverSurgery
{
    public class DBConnection
    {

       
       
    
        private static string CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="" C:\Users\Artur\Desktop\Programming c#\Softwear Eng\Over Surgery\OverSurgery\OverSurgery\Patient.mdf;Integrated Security=True";
        //SqlConnection con = new SqlConnection(CS);
        private SqlConnection _con;
        private SqlCommand _cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;

        public DBConnection()
        {
            _con = new SqlConnection(CS);
            _con.Open();
        }

        public void DBclose()
        {
            _con.Close();
        }

       
        





        /* //attributes
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
              connectioToDB.Close();
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
        */
    }
    }

