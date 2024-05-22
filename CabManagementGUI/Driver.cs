using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementGUI
{
    internal class Driver : Person
    {
        // Private fields
        private int _driverId;
        private bool _availability;

        // Public properties with encapsulation
        public int DriverId
        {
            get { return _driverId; }
            private set { _driverId = value; }
        }

        public bool Availability
        {
            get { return _availability; }
            set { _availability = value; }
        }

        // Constructor
        public Driver(int driverId, string name, string contactNumber, string email, string nic, bool availability)
            : base(name, contactNumber, email, nic)
        {
            _driverId = driverId;
            _availability = availability;
        }

        // Method to get driver details
        public string GetDetails()
        {
            return $"Driver ID: {DriverId}\nName: {Name}\nContact Number: {ContactNumber}\nEmail: {Email}\nNIC: {NIC}\nAvailability: {Availability}";
        }

        // Method to add driver to the database
        public void AddDriver()
        {
            DBConnector dbConnector = new DBConnector();
            string query = "INSERT INTO drivers (name, contact_number, email, nic, availability) VALUES (@Name, @ContactNumber, @Email, @NIC, @Availability)";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@NIC", NIC);
                        cmd.Parameters.AddWithValue("@Availability", Availability);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Driver added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add driver.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        // Method to update driver availability
        public void UpdateAvailability(bool availability)
        {
            Availability = availability;
            DBConnector dbConnector = new DBConnector();
            string query = "UPDATE drivers SET availability = @Availability WHERE driver_id = @DriverId";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Availability", Availability);
                        cmd.Parameters.AddWithValue("@DriverId", DriverId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Driver availability updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update driver availability.");
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
