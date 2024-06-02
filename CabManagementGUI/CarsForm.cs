using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CabManagementGUI
{
    public partial class CarsForm : Form
    {
        CarManager carManager;
        Admin admin;

        public CarsForm()
        {
            InitializeComponent();
            carManager = new CarManager();
            admin = new Admin();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            ShowCarsData();
        }

        private void ShowCarsData()
        {
            dataGridViewAllCars.DataSource = admin.ViewCars();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add new car
            string carModel = textBoxCarModel.Text.Trim();
            string carPlateNumber = textBoxCarPlateNo.Text.Trim();
            bool carAvailability = checkBoxAvailability.Checked;

            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(carPlateNumber))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Car car = new Car(carModel, carPlateNumber, carAvailability);
                carManager.AddCar(car);
                ShowCarsData();
            }
        }

        private void buttonSearchCars_Click(object sender, EventArgs e)
        {
            bool isModelSelected = radioBtnCarModel.Checked;
            bool isPlateNumberSelected = radioBtnCarPlateNo.Checked;
            bool isCarIDSelected = radioBtnCarID.Checked;

            string searchValue = textBoxCarSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a search value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataTable dt = admin.SearchCars(searchValue, isModelSelected, isPlateNumberSelected, isCarIDSelected);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewFilteredCars.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewFilteredCars.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonNewCar_Click(object sender, EventArgs e)
        {
            // Remove car
            string carId = textBoxCarID.Text;
            // Convert string to int
            int carIdInt = Convert.ToInt32(carId);
            carManager.RemoveCar(carIdInt);
            ShowCarsData();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string carId = textBoxCarID.Text;
            // Convert string to int
            int carIdInt = Convert.ToInt32(carId);
            carManager.UpdateAvailability(carIdInt);
            MessageBox.Show("Car availability updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            ShowCarsData();
        }
    }
}
