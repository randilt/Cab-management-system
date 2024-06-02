using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementGUI
{
    public class Customer : Person
    {
        private int _customerId;
        private string _password;

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public Customer(int customerId, string name, string contactNumber, string email, string nic, string password)
            : base(name, contactNumber, email, nic)
        {
            _customerId = customerId;
            Name = name;
            ContactNumber = contactNumber;
            Email = email;
            NIC = nic;
            _password = password;
        }
        

        // Overloaded constructor
        public Customer(string name, string contactNumber, string email, string nic, string password)
            : base(name, contactNumber, email, nic)
        {
            Name = name;
            ContactNumber = contactNumber;
            Email = email;
            NIC = nic;
            _password = password;
        }

        public string GetDetails()
        {
            return $"Customer ID: {CustomerId}\nName: {Name}\nContact Number: {ContactNumber}\nEmail: {Email}\nNIC: {NIC}";
        }

        public static DataTable ViewCustomerOrders(Customer loggedInCustomer)
        {
            int customerId = loggedInCustomer.CustomerId;
            DBConnector dbConnector = new DBConnector();
            string query = "SELECT * FROM orders WHERE customer_id = @CustomerId";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return null;
                }
            }
        }
        public static void AddCustomer(Customer customer)
        {
            // Create a new instance of DBConnector to obtain a database connection
            DBConnector dbConnector = new DBConnector();

            // Define the SQL query to insert a new customer
            string query = "INSERT INTO customers (name, contact_number, email, nic, password) VALUES (@Name, @ContactNumber, @Email, @NIC, @Password)";

            // Create a SqlConnection object using the connection string obtained from DBConnector
            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SqlCommand to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Name", customer.Name);
                        cmd.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", customer.Email);
                        cmd.Parameters.AddWithValue("@NIC", customer.NIC);
                        cmd.Parameters.AddWithValue("@Password", customer._password);

                        // Execute the SQL command to insert the customer
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the insertion was successful
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Customer added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add customer.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
