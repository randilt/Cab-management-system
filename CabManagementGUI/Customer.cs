using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementGUI
{
    public class Customer : Person
    {
        private int _customerId;

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public Customer(int customerId, string name, string contactNumber, string email, string nic)
            : base(name, contactNumber, email, nic)
        {
            _customerId = customerId;
            Name = name;
            ContactNumber = contactNumber;
            Email = email;
            NIC = nic;
        }

        public string GetDetails()
        {
            return $"Customer ID: {CustomerId}\nName: {Name}\nContact Number: {ContactNumber}\nEmail: {Email}\nNIC: {NIC}";
        }

        public void AddCustomer()
        {
            // Create a new instance of DBConnector to obtain a database connection
            DBConnector dbConnector = new DBConnector();

            // Define the SQL query to insert a new customer
            string query = "INSERT INTO customers (name, contact_number, email, nic) VALUES (@Name, @ContactNumber, @Email, @NIC)";

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
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@ContactNumber", this.ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        cmd.Parameters.AddWithValue("@NIC", this.NIC);

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
