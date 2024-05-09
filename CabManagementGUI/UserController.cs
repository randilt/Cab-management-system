using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CabManagementGUI
{
    internal class UserController
    {
        private string DB_CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\testl\Desktop\SDAM_Assignment\CabManagementSystem\CabManagementDB.mdf;Integrated Security=True;Connect Timeout=30";
        public UserController()
        {
            UserModel userModel = new UserModel();
        }

        public void AuthenticateUser(string username, string password)
        {
            UserModel userModel = new UserModel();
            if (userModel.Login(username, password))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = DB_CONNECTION_STRING;
                connection.Open();
                MessageBox.Show("Success! Connection opened successfully");
            }
            else
            {
                DialogResult result = MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { return; }
            }
        }
    }
}
