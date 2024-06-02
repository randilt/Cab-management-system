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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonCustRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxCustUsername.Text.Trim();
            string contactNumber = textBoxCustPhoneNo.Text.Trim();
            string email = textBoxCustEmail.Text.Trim();
            string nic = textBoxCustNIC.Text.Trim();
            string password = textBoxCustPassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer customer = new Customer(name, contactNumber, email, nic, password);
        
                Customer.AddCustomer(customer);
                MessageBox.Show("Customer added successfully, Please Login to the application now!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }

        }
    }
}
