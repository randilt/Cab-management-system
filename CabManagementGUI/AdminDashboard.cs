using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabManagementGUI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // open CustomerForm.cs
            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();
            driversForm.Show();

        }
    }
}
