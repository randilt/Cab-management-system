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
    public partial class DriversForm : Form
    {
        Admin admin;
        DriverManager driverManager;
        public DriversForm()
        {
            InitializeComponent();
            admin = new Admin();
            driverManager = new DriverManager();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            ShowDriversData();
        }

        private void ShowDriversData()
        {
            dataGridViewAllDrivers.DataSource = admin.ViewDrivers();
            
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            try
            {
                string driverName = textBoxDriverName.Text;
                string driverPhone = textBoxDriverPhone.Text;
                string driverEmail = textBoxDriverEmail.Text;
                string driverNIC = textBoxDriverNIC.Text;
                bool driverAvailability = checkBoxDriverAvailability.Checked;


                Driver driver = new Driver(driverName, driverPhone, driverEmail, driverNIC, driverAvailability);
                driverManager.AddDriver(driver);
                ShowDriversData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the driver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAvailabilitySwitch_Click(object sender, EventArgs e)
        {
         
                int driverId = Convert.ToInt32(textBoxDriverID.Text);
                try
                {
                       driverManager.UpdateAvailability(driverId);
                       MessageBox.Show("Driver availability updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Failed to update driver availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ShowDriversData();
        }

        private void buttonRemoveDriver_Click(object sender, EventArgs e)
        {
                int driverId = Convert.ToInt32(textBoxDriverID.Text);
                driverManager.RemoveDriver(driverId);
                ShowDriversData();  
        }
    }
}
