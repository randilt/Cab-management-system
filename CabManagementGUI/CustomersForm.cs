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
                    Customer customer = new Customer(customerName, customerPhone, customerEmail, customerNIC);

                    // Call the AddCustomer method to add the customer to the database
                    customer.AddCustomer();

                    // Show success message
                    MessageBox.Show("Customer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxCustName.Text = "";
                    textBoxCustNIC.Text = "";
                    textBoxCustContact.Text = "";
                    textBoxCustEmail.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
