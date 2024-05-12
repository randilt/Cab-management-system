using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class DatabaseHelper
    {
        private string DB_CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\testl\Desktop\SDAM_Assignment\CabManagementSystem\CabManagementDB.mdf;Integrated Security=True;Connect Timeout=30";

        public void OpenConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DB_CONNECTION_STRING;
            connection.Open();
        }

        public void CloseConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DB_CONNECTION_STRING;
            connection.Close();
        }
        
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DB_CONNECTION_STRING;
            return connection;
        }   
    }
}
