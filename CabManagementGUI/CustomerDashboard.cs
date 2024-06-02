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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            ShowMyOrders();
            label1.Text = "Welcome, " + UserController.LoggedInCustomer.Name+ "!";
        }

        private void ShowMyOrders()
        {
            dataGridViewMyOrders.DataSource = Customer.ViewCustomerOrders(UserController.LoggedInCustomer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm();
            newOrderForm.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ShowMyOrders();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
