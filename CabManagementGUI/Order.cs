using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class Order
    {
        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public int DriverId { get; set; }

        public int CarId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CurrentLocation { get; set; }
        public string Destination { get; set; }

        

        // Constructor
        public Order(int customerId, int driverId, int carId, DateTime orderDate, string currentLocation, string destination)
        {
            CustomerId = customerId;
            DriverId = driverId;
            CarId = carId;
            OrderDate = orderDate;
            CurrentLocation = currentLocation;
            Destination = destination;
        }

        // Method to add order to the database
        public void AddOrder()
        {
            DBConnector dbConnector = new DBConnector();
            string query = "INSERT INTO orders (customer_id, driver_id, car_id, order_date, current_location, destination) VALUES (@CustomerId, @DriverId, @CarId, @OrderDate, @CurrentLocation, @Destination)";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                        cmd.Parameters.AddWithValue("@DriverId", DriverId);
                        cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                        cmd.Parameters.AddWithValue("@CurrentLocation", CurrentLocation);
                        cmd.Parameters.AddWithValue("@Destination", Destination);
                        cmd.Parameters.AddWithValue("@CarId", CarId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
