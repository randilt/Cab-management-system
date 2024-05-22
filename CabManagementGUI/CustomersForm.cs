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
