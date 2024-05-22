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
        SqlDataAdapter adpt;
        public DriversForm()
        {
            InitializeComponent();
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
            DBConnector dbConnector = new DBConnector();
            adpt = new SqlDataAdapter("select * from drivers", dbConnector.GetConnection());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllDrivers.DataSource = dt;
            
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



                Driver.AddDriver(driverName, driverPhone, driverEmail, driverNIC, driverAvailability);
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
                Driver.UpdateAvailability(driverId);
                ShowDriversData();
        }

        private void buttonRemoveDriver_Click(object sender, EventArgs e)
        {
           
                int driverId = Convert.ToInt32(textBoxDriverID.Text);
                Driver.RemoveDriver(driverId);
                ShowDriversData();  

        }
    }
}
