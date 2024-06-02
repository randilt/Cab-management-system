using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CabManagementGUI
{
    internal class DBConnector
    {
        private static string FILE_PATH = @"C:\Users\testl\Desktop\SDAM_Assignment\CabManagementSystem\CabManagementDB.mdf"; // replace the path with the path to the database file 
        private string DB_CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + FILE_PATH + ";Integrated Security=True";

        // method to return connection to other classes to connect to the database
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DB_CONNECTION_STRING;
            return connection;
        }
    }

}
