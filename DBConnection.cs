using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_WindowsFormsApp
{
    class DBConnection
    {
        // Private object of the class itself
        private static DBConnection _instance;

        // Connection string
        private static string connStr;

        // Connection to the DB
        private SqlConnection connToDB;


        // Constructor
        private DBConnection()
        {
            connStr = Properties.Settings.Default.Connection; // Gets connection string from Properties file
        }


        // A static method that creates an unique object of the class itself
        public static DBConnection getInstanceOfDBConnection()
        {
            // Create the object only if it doesn't exist  
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }


        // Returns a data set built based on the query sent as parameter
        public DataSet getLoginDataSet(string sqlQuery)
        {
            // Create an empty dataset
            DataSet dataSet = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                // Open the connection
                connToDB.Open();

                // Create the object dataAdapter to send a query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                // Fill in the dataset
                dataAdapter.Fill(dataSet);

                connToDB.Close();
            }
            return dataSet;
        }


        // Method that saves data into the database
        public void saveFormToDB(string sqlQuery, 
                                 string site, 
                                 string work_area, 
                                 string supervisor, 
                                 string completed_by, 
                                 string job_description, 
                                 string inspector, 
                                 string date, 
                                 string type)
        {
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                // Try to open connection
                try
                {
                    connToDB.Open();

                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                    // Set the sqlCommand's properties
                    sqlCommand.CommandType = CommandType.Text;

                    // Add the parameters to the sqlCommand
                    sqlCommand.Parameters.Add(new SqlParameter("site", site));
                    sqlCommand.Parameters.Add(new SqlParameter("work_area", work_area));
                    sqlCommand.Parameters.Add(new SqlParameter("supervisor", supervisor));
                    sqlCommand.Parameters.Add(new SqlParameter("completed_by", completed_by));
                    sqlCommand.Parameters.Add(new SqlParameter("job_description", job_description));
                    sqlCommand.Parameters.Add(new SqlParameter("inspector", inspector));
                    sqlCommand.Parameters.Add(new SqlParameter("date", date));
                    sqlCommand.Parameters.Add(new SqlParameter("type", type));

                    // Execute the save command
                    sqlCommand.ExecuteNonQuery();

                    connToDB.Close();   
                }
                // If unable to open a connection
                catch
                {
                    Console.WriteLine("Unable to connect to database");
                }
            }
        }
    }
}
