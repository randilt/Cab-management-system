using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class Order
    {
        private int _orderId;
        private string _currentLocation;
        private string _destination;
        private DateTime _orderTime;
        private Car _car;
        private Driver _driver;
        private int _customerId;

        public int OrderId
        {
            get { return _orderId; }
            private set { _orderId = value; }
        }

        public string CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public DateTime OrderTime
        {
            get { return _orderTime; }
            set { _orderTime = value; }
        }

        public Car Car
        {
            get { return _car; }
            set { _car = value; }
        }

        public Driver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public Order(string currentLocation, string destination, DateTime orderTime, Car car, Driver driver, int customerId)
        {
            _currentLocation = currentLocation;
            _destination = destination;
            _orderTime = orderTime;
            _car = car;
            _driver = driver;
            _customerId = customerId;
        }

        public string GetDetails()
        {
            return $"Order ID: {OrderId}\nCurrent Location: {CurrentLocation}\nDestination: {Destination}\nOrder Time: {OrderTime}\nCar: {Car.Model}\nDriver: {Driver.DriverId}\nCustomer ID: {CustomerId}";
        }

        public void SaveOrder()
        {
            DBConnector dbConnector = new DBConnector();
            string query = "INSERT INTO orders (current_location, customer_id, destination, order_date, car_id, driver_id) VALUES (@CurrentLocation, @CustomerId, @Destination, @OrderDate, @CarId, @DriverId)";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CurrentLocation", CurrentLocation);
                        cmd.Parameters.AddWithValue("@Destination", Destination);
                        cmd.Parameters.AddWithValue("@OrderDate", OrderTime);
                        cmd.Parameters.AddWithValue("@CarId", Car.CarId);
                        cmd.Parameters.AddWithValue("@DriverId", Driver.DriverId);
                        cmd.Parameters.AddWithValue("@CustomerId", CustomerId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order has been placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Car.UpdateAvailability(false);
                            Driver.UpdateAvailability(Driver.DriverId);
                        }
                        else
                        {
                            MessageBox.Show("Failed to place the order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public DataTable GetOrders()
        {
            DBConnector dbConnector = new DBConnector();
            string query = "SELECT * FROM orders";

            using (SqlConnection connection = dbConnector.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }
    }
}
