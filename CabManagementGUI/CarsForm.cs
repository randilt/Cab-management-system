using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CabManagementGUI
{
    public partial class CarsForm : Form
    {
        SqlDataAdapter adpt;
        DataTable dt;
        Admin admin;

        public CarsForm()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            ShowCarsData();
        }

        private void ShowCarsData()
        {
            DBConnector dbConnector = new DBConnector();
            adpt = new SqlDataAdapter("SELECT * FROM cars", dbConnector.GetConnection());
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllCars.DataSource = dt;
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
                admin.AddCar(carModel, carPlateNumber, carAvailability);
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
                    DataTable dt = Car.SearchCars(searchValue, isModelSelected, isPlateNumberSelected, isCarIDSelected);

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
            admin.RemoveCar(carIdInt);
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
            Car.UpdateAvailability(carIdInt);
            ShowCarsData();
        }
    }
}
