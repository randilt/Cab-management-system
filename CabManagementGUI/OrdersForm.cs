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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            showAllOrders();
        }

        private void showAllOrders()
        {
            Admin admin = new Admin();
            dataGridViewAllOrders.DataSource = admin.ViewOrders();


        }
    }
}
