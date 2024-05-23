using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabManagementGUI
{
    
    public partial class NewOrderForm : Form
    {
        SqlDataAdapter adpt;
        public NewOrderForm()
        {
            InitializeComponent();
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            showAvailableDrivers();
            showAvailableCars();
            
        }

        private void showAvailableCars()
        {
            List<Car> cars = Car.GetAvailableCars();
            cboAvailableCars.DataSource = cars;
            cboAvailableCars.DisplayMember = "Model";
            DBConnector dbConnector = new DBConnector();
            adpt = new SqlDataAdapter("SELECT * FROM cars WHERE availability = 1", dbConnector.GetConnection());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAvailableCars.DataSource = dt;


        }

        private void showAvailableDrivers()
        {
            List<Driver> drivers = Driver.GetAvailableDrivers();
            cboAvailableDrivers.DataSource = drivers;
            cboAvailableDrivers.DisplayMember = "DriverName";
            DBConnector dbConnector = new DBConnector();
            adpt = new SqlDataAdapter("SELECT * FROM drivers WHERE availability = 1", dbConnector.GetConnection());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAvailableDrivers.DataSource = dt;

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            string currentLocation = textBoxPickupLocation.Text;
            string destination = textBoxDestination.Text;
            DateTime orderTime = dateTimePickerOrderTime.Value;
            Car selectedCar = (Car)cboAvailableCars.SelectedItem;
            Driver selectedDriver = (Driver)cboAvailableDrivers.SelectedItem;

            if (selectedCar == null || selectedDriver == null)
            {
                MessageBox.Show("Please select both a car and a driver.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order order = new Order(currentLocation, destination, orderTime, selectedCar, selectedDriver, UserController.LoggedInCustomer.CustomerId);

            try
            {
                order.SaveOrder();
                MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh available cars and drivers
                showAvailableCars();
                showAvailableDrivers();
                cboAvailableCars.SelectedItem = null;
                cboAvailableDrivers.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to place the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
