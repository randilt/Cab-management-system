using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class CarManager
    {

        // Method to add car to db

        public void AddCar(Car car)
        {
            DBConnector dbConnector = new DBConnector();
            string query = "INSERT INTO cars (model, plate_number, availability) VALUES (@Model, @PlateNumber, @Availability)";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Model", car.Model);
                        cmd.Parameters.AddWithValue("@PlateNumber", car.PlateNumber);
                        cmd.Parameters.AddWithValue("@Availability", car.Availability);

                        int rowsAffected = cmd.ExecuteNonQuery();
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
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to remove car

        public void RemoveCar(int carId)
        {
            DBConnector dbConnector = new DBConnector();
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
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update car availability
        public void UpdateAvailability(int carId)
        {

            DBConnector dbConnector = new DBConnector();
            string query = "UPDATE cars SET availability = ~availability WHERE car_id = @CarId";

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
                            Console.WriteLine("Car availability updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Car availability update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static List<Car> GetAvailableCars()
        {
            DBConnector dbConnector = new DBConnector();
            string query = "SELECT * FROM cars WHERE availability = 1";
            List<Car> cars = new List<Car>();

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Car car = new Car(reader["model"].ToString(), reader["plate_number"].ToString(), Convert.ToBoolean(reader["availability"]));
                        car.CarId = Convert.ToInt32(reader["car_id"]);
                        cars.Add(car);
                    }
                }
            }
            return cars;
        }
    }
}
