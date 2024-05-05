using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CabManagementGUI
{
    public partial class Form1 : Form
    {
        private string DB_CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\testl\Desktop\SDAM_Assignment\CabManagementSystem\CabManagementDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToString();
            string password = textBoxPassword.Text.ToString();

            if( String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) )
            {
                DialogResult result = MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if( result == DialogResult.OK ) { return; }
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = DB_CONNECTION_STRING;
                connection.Open();
                MessageBox.Show("Success! Connection opened successfully");
            }
        }
    }
}
