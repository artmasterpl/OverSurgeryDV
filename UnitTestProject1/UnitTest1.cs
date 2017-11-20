using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void insToTable(String Name, String surname, String DoB, String street, String city)
        {
            
            //string insquerry = "insert into Patient([Name], [Surname], [Date Of Birth], [Street], [City]) values (@Name, @surname, @DoB, @street, @city)";
            ////openConnection();
            
            //SqlCommand insCmd = new SqlCommand(insquerry, connectioToDB);
            //AddPatient add = new AddPatient();

            //.getDBConnectionInstance().AddPatient(Name, surname, DoB, street, city);
            //// add data to table
            insCmd.Parameters.AddWithValue("@Name", Name);
            insCmd.Parameters.AddWithValue("@Surname", surname);
            insCmd.Parameters.AddWithValue("@Date Of Birth", DoB);
            insCmd.Parameters.AddWithValue("@Street", street);
            insCmd.Parameters.AddWithValue("@City", city);


            int affectrows = insCmd.ExecuteNonQuery();
            //MessageBox.Show(affectrows + "rows inserted");
        }
    }
}
