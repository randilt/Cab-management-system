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
        private Form1 form1; // Reference to Form1

        public UserController(Form1 form1)
        {
            this.form1 = form1;
        }

        public void AuthenticateUser(string username, string password)
        {
            UserModel userModel = new UserModel();

            if (userModel.Login(username, password))
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = DB_CONNECTION_STRING;
                connection.Open();

                // check if user exists in database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // user exists
                        DialogResult result = MessageBox.Show("Authentication successful, please continue to the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            // Hide the original Form1 instance
                            form1.Hide();

                            // Show the HomeForm
                            HomeForm homeForm = new HomeForm();
                            homeForm.Show();
                        }
                    }
                }
                else
                {
                    // user does not exist
                    DialogResult result = MessageBox.Show("Invalid Credentials, Please Retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK) { return; }
                }

                // Close the connection after use
                connection.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK) { return; }
            }
        }
    }
}