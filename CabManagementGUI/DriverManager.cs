using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class DriverManager
    {

        public void AddDriver(Driver driver)
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
                        cmd.Parameters.AddWithValue("@Name", driver.DriverName);
                        cmd.Parameters.AddWithValue("@ContactNumber", driver.DriverContactNumber);
                        cmd.Parameters.AddWithValue("@Email", driver.DriverEmail);
                        cmd.Parameters.AddWithValue("@NIC", driver.DriverNIC);
                        cmd.Parameters.AddWithValue("@Availability", driver.Availability);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Driver added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add driver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to remove driver
        public void RemoveDriver(int driverId)
        {
            DBConnector dbConnector = new DBConnector();
            string query = "DELETE FROM drivers WHERE driver_id = @DriverId";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DriverId", driverId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Driver removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove driver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update driver availability
        public void UpdateAvailability(int driverId)
        {

            DBConnector dbConnector = new DBConnector();
            string query = "UPDATE drivers SET availability = ~availability WHERE driver_id = @DriverId";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DriverId", driverId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Driver availability updated successfully."); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to update driver availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static List<Driver> GetAvailableDrivers()
        {
            List<Driver> drivers = new List<Driver>();
            DBConnector dbConnector = new DBConnector();
            string query = "SELECT * FROM drivers WHERE availability = 1";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int driverId = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string contactNumber = reader.GetString(2);
                                string email = reader.GetString(3);
                                string nic = reader.GetString(4);
                                bool availability = reader.GetBoolean(5);

                                Driver driver = new Driver(driverId, name, contactNumber, email, nic, availability); // here the overloaded constructor is used
                                drivers.Add(driver);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return drivers;
        }
    }
}
