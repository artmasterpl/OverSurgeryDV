﻿using System;
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
    }
}