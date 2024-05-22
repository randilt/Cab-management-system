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
    public partial class CustomersForm : Form
    {
        SqlDataAdapter adpt;

        public CustomersForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            showCustomerData();
        }

        private void showCustomerData()
        {
            DBConnector dbConnector = new DBConnector();
            adpt = new SqlDataAdapter("select * from customers", dbConnector.GetConnection());
            DataTable dt = new DataTable(); 
            adpt.Fill(dt);
            dataGridViewAllCustomers.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustName.Text.Trim();
            string customerNIC = textBoxCustNIC.Text.Trim();
            string customerPhone = textBoxCustContact.Text.Trim();
            string customerEmail = textBoxCustEmail.Text.Trim();

            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerNIC) || string.IsNullOrEmpty(customerPhone) || string.IsNullOrEmpty(customerEmail))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Create an instance of the Customer class with provided details
                    Customer customer = new Customer(1,customerName, customerPhone, customerEmail, customerNIC);

                    // Call the AddCustomer method to add the customer to the database
                    customer.AddCustomer();

                    // Show success message
                    MessageBox.Show("Customer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxCustName.Text = "";
                    textBoxCustNIC.Text = "";
                    textBoxCustContact.Text = "";
                    textBoxCustEmail.Text = "";

                    showCustomerData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewAllCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isNameSelected = radioBtnCustName.Checked;
            bool isIDSelected = radioBtnCustID.Checked;
            bool isContactSelected = radioBtnCustPhone.Checked;
            bool isEmailSelected = radioBtnCustEmail.Checked;

            string searchValue = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a search value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBConnector dbConnector = new DBConnector();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from customers", dbConnector.GetConnection());
                DataTable dt = new DataTable();
                adpt.Fill(dt);

                if (isNameSelected)
                {
                    var result = dt.Select("name LIKE '%" + searchValue + "%'");
                    if (result.Length > 0)
                    {
                        dataGridViewFiltered.DataSource = result.CopyToDataTable();
                    }
                    else
                    {
                        MessageBox.Show("No records found with the given name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewFiltered.DataSource = null; // Clear the grid
                    }
                }
                else if (isIDSelected)
                {
                    int customerId;
                    if (int.TryParse(searchValue, out customerId))
                    {
                        var result = dt.Select($"customer_id = {customerId}");
                        if (result.Length > 0)
                        {
                            dataGridViewFiltered.DataSource = result.CopyToDataTable();
                        }
                        else
                        {
                            MessageBox.Show("No records found with the given Customer ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewFiltered.DataSource = null; // Clear the grid
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (isContactSelected)
                {
                    var result = dt.Select("contact_number LIKE '%" + searchValue + "%'");
                    if (result.Length > 0)
                    {
                        dataGridViewFiltered.DataSource = result.CopyToDataTable();
                    }
                    else
                    {
                        MessageBox.Show("No records found with the given contact number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewFiltered.DataSource = null; // Clear the grid
                    }
                }
                else if (isEmailSelected)
                {
                    var result = dt.Select("email LIKE '%" + searchValue + "%'");
                    if (result.Length > 0)
                    {
                        dataGridViewFiltered.DataSource = result.CopyToDataTable();
                    }
                    else
                    {
                        MessageBox.Show("No records found with the given email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewFiltered.DataSource = null; // Clear the grid
                    }
                }
                else
                {
                    MessageBox.Show("Please select a search filter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
