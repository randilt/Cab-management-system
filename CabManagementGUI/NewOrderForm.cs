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
        Admin admin;
        public NewOrderForm()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
                showAvailableDrivers();
            showAvailableCars();
            
        }

        private void showAvailableCars()
        {
            List<Car> cars = CarManager.GetAvailableCars();
            cboAvailableCars.DataSource = cars;
            cboAvailableCars.DisplayMember = "Model";
            dataGridViewAvailableCars.DataSource = admin.ViewAvailableCars();


        }

        private void showAvailableDrivers()
        {
            List<Driver> drivers = DriverManager.GetAvailableDrivers();
            cboAvailableDrivers.DataSource = drivers;
            cboAvailableDrivers.DisplayMember = "DriverName";
            dataGridViewAvailableDrivers.DataSource = admin.ViewAvailableDrivers();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
