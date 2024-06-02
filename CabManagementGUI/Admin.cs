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


  
        // Method to viw customers
        public DataTable ViewCustomers()
        {
            string query = "SELECT * FROM customers";
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

        // Method to view all cars
        public DataTable ViewCars()
        {
            string query = "SELECT * FROM cars";
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

        // Method to view all drivers

        public DataTable ViewDrivers()
        {
            string query = "SELECT * FROM drivers";
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

        // Method to search for cars
        public DataTable SearchCars(string searchValue, bool isModelSelected, bool isPlateNumberSelected, bool isCarIDSelected)
        {
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

        // search for customers

        public DataTable SearchCustomers(string searchValue, string searchCriteria)
        {
            string query = "SELECT * FROM customers";
            DataTable dt = new DataTable();

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(query, connection);
                    adpt.Fill(dt);

                    string filterExpression = string.Empty;

                    switch (searchCriteria)
                    {
                        case "name":
                            filterExpression = $"name LIKE '%{searchValue}%'";
                            break;
                        case "customer_id":
                            if (int.TryParse(searchValue, out int customerId))
                            {
                                filterExpression = $"customer_id = {customerId}";
                            }
                            else
                            {
                                throw new ArgumentException("Invalid Customer ID");
                            }
                            break;
                        case "contact_number":
                            filterExpression = $"contact_number LIKE '%{searchValue}%'";
                            break;
                        case "email":
                            filterExpression = $"email LIKE '%{searchValue}%'";
                            break;
                        default:
                            throw new ArgumentException("Invalid search criteria");
                    }

                    DataRow[] result = dt.Select(filterExpression);

                    if (result.Length > 0)
                    {
                        return result.CopyToDataTable();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error searching customers: " + ex.Message);
                }
            }
        }
    }
}
