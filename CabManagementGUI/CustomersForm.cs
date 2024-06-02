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
        Admin admin;


        public CustomersForm()
        {
            InitializeComponent();
            admin = new Admin();
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
            dataGridViewAllCustomers.DataSource = admin.ViewCustomers();

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
                Admin admin = new Admin();
                string searchCriteria = "";

                if (isNameSelected)
                {
                    searchCriteria = "name";
                }
                else if (isIDSelected)
                {
                    searchCriteria = "customer_id";
                }
                else if (isContactSelected)
                {
                    searchCriteria = "contact_number";
                }
                else if (isEmailSelected)
                {
                    searchCriteria = "email";
                }
                else
                {
                    MessageBox.Show("Please select a search filter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    DataTable result = admin.SearchCustomers(searchValue, searchCriteria);

                    if (result != null && result.Rows.Count > 0)
                    {
                        dataGridViewFiltered.DataSource = result;
                    }
                    else
                    {
                        MessageBox.Show("No records found with the given search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewFiltered.DataSource = null; // Clear the grid
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
