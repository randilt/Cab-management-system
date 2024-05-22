using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class Car
    {
        // Private fields
        private int _carId;
        private string _model;
        private string _plateNumber;
        private bool _availability;

        // Public properties with encapsulation
        public int CarId
        {
            get { return _carId; }
            private set { _carId = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string PlateNumber
        {
            get { return _plateNumber; }
            set { _plateNumber = value; }
        }

        public bool Availability
        {
            get { return _availability; }
            set { _availability = value; }
        }

        // Constructor
        public Car(string model, string plateNumber, bool availability)
        {
            _model = model;
            _plateNumber = plateNumber;
            _availability = availability;
        }

        // Method to get car details
        public string GetDetails()
        {
            return $"Model: {Model}\nPlate Number: {PlateNumber}\nAvailability: {Availability}";
        }

        public static List<Car>GetAvailableCars()
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
        // Method to update car availability
        public void UpdateAvailability(bool availability)
        {
            Availability = availability;
            DBConnector dbConnector = new DBConnector();
            string query = "UPDATE cars SET availability = @Availability WHERE car_id = @CarId";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Availability", Availability);
                        cmd.Parameters.AddWithValue("@CarId", CarId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car availability status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Method to search for cars
        public static DataTable SearchCars(string searchValue, bool isModelSelected, bool isPlateNumberSelected, bool isCarIDSelected)
        {
            DBConnector dbConnector = new DBConnector();
            string query = "";

            if (isModelSelected)
            {
                query = "SELECT * FROM cars WHERE model LIKE @SearchValue";
            }
            else if (isPlateNumberSelected)
            {
                query = "SELECT * FROM cars WHERE plate_number LIKE @SearchValue";
            }
            else if (isCarIDSelected)
            {
                if (int.TryParse(searchValue, out int carId))
                {
                    query = "SELECT * FROM cars WHERE car_id = @SearchValue";
                    searchValue = carId.ToString(); // Use the parsed carId
                }
                else
                {
                    throw new ArgumentException("Please enter a valid Car ID.");
                }
            }

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (isCarIDSelected)
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", searchValue);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                    }

                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    return dt;
                }
            }
        }
        
    }
}
