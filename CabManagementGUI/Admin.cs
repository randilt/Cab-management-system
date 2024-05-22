using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class Admin
    {
        private DBConnector dbConnector;

        public Admin()
        {
            dbConnector = new DBConnector();
        }

        // Method to add a new car
        public void AddCar(string model, string plateNumber, bool availability)
        {
            string queryCheckPlateNumber = "SELECT COUNT(*) FROM cars WHERE plate_number = @PlateNumber";
            string queryAddCar = "INSERT INTO cars (model, plate_number, availability) VALUES (@Model, @PlateNumber, @Availability)";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Check if the plate number already exists
                    using (SqlCommand cmdCheckPlateNumber = new SqlCommand(queryCheckPlateNumber, connection))
                    {
                        cmdCheckPlateNumber.Parameters.AddWithValue("@PlateNumber", plateNumber);
                        int count = (int)cmdCheckPlateNumber.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Plate number already exists. Please use a different plate number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method if plate number is not unique
                        }
                    }

                    // Insert the new car if plate number is unique
                    using (SqlCommand cmdAddCar = new SqlCommand(queryAddCar, connection))
                    {
                        cmdAddCar.Parameters.AddWithValue("@Model", model);
                        cmdAddCar.Parameters.AddWithValue("@PlateNumber", plateNumber);
                        cmdAddCar.Parameters.AddWithValue("@Availability", availability);

                        int rowsAffected = cmdAddCar.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Method to remove a car by its ID
        public void RemoveCar(int carId)
        {
            string query = "DELETE FROM cars WHERE car_id = @CarId";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CarId", carId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to view available cars
        public DataTable ViewAvailableCars()
        {
            string query = "SELECT * FROM cars WHERE availability = 1";
            DataTable dt = new DataTable();

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        // Method to add a new driver
        public void AddDriver(string name, string contactNumber, bool availability)
        {
            string query = "INSERT INTO drivers (name, contact_number, availability) VALUES (@Name, @ContactNumber, @Availability)";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Availability", availability);

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
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to remove a driver by their ID
        public void RemoveDriver(int driverId)
        {
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
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to view available drivers
        public DataTable ViewAvailableDrivers()
        {
            string query = "SELECT * FROM drivers WHERE availability = 1";
            DataTable dt = new DataTable();

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        // Method to view all orders
        public DataTable ViewOrders()
        {
            string query = "SELECT * FROM orders";
            DataTable dt = new DataTable();

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }
    }
}
