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
        SqlDataAdapter adpt;
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
        }

        private void ShowMyOrders()
        {
            DBConnector dbConnector = new DBConnector();
            // Retrieve the ID of the currently logged-in customer
            int loggedInCustomerId = UserController.LoggedInCustomer.CustomerId;
            adpt = new SqlDataAdapter("SELECT * FROM orders WHERE customer_id = @CustomerId", dbConnector.GetConnection());
            adpt.SelectCommand.Parameters.AddWithValue("@CustomerId", loggedInCustomerId);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewMyOrders.DataSource = dt;
            // Create a query to select orders placed by the logged-in customer
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
    }
}
