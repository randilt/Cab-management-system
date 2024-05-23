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
        public static Customer LoggedInCustomer { get; private set; } // Store the logged-in customer
        public UserController(CustomerLogin form1)
        {

        }


        // Method to authenticate a customer
        public void AuthenticateCustomer(string username, string password)
        {
            DBConnector dBConnector = new DBConnector();
            SqlConnection connection = dBConnector.GetConnection();

            try
            {
                connection.Open();

                string query = "SELECT * FROM customers WHERE name = @Username AND password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Create a new Customer object with data from the database
                                int customerId = reader.GetInt32(reader.GetOrdinal("customer_id"));
                                string name = reader.GetString(reader.GetOrdinal("name"));
                                string contactNumber = reader.GetString(reader.GetOrdinal("contact_number"));
                                string email = reader.GetString(reader.GetOrdinal("email"));
                                string nic = reader.GetString(reader.GetOrdinal("nic"));

                                // Initialize the LoggedInCustomer property
                                LoggedInCustomer = new Customer(customerId, name, contactNumber, email, nic, password);

                                MessageBox.Show("Authentication successful, please continue to the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                CustomerDashboard customerDashboard = new CustomerDashboard();
                                customerDashboard.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void AuthenticateUser(string username, string password)
        {
            UserModel userModel = new UserModel();

            if (userModel.Login(username, password))
            {
                // Create a new instance of the DBConnector class
                DBConnector dbConnector = new DBConnector();
                // Create a connection to the database
                SqlConnection connection = dbConnector.GetConnection();
                connection.Open();

                try
                {
                    // Check if user exists in database and retrieve their role
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT role FROM users WHERE username = @Username AND password = @Password";
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string role = reader["role"].ToString();

                            // Authentication successful
                            DialogResult result = MessageBox.Show("Authentication successful, please continue to the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {


                                if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    // Show the AdminForm if the user's role is an admin
                                    AdminDashboard adminDashboard = new AdminDashboard();
                                    adminDashboard.Show();
                                }
                                else
                                {
                                    // Show the CustomerForm if the user's role is not an admin
                                    CustomerDashboard customerDashboard = new CustomerDashboard();
                                    customerDashboard.Show();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}