using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient; // Add this at the top

namespace SSA_B_Canteen
{
    public partial class AdminDashboard : Form
    {

        private string connstring = "Server=localhost;Database=ssab_canteen;Trusted_Connection=True;";
        private DataGridView dgvProducts;
        public AdminDashboard()
        {
            InitializeComponent();
        }


        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct();
            addProductForm.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            var cashierForm = new Cashier.Cashier();
            cashierForm.Show();
        }

        private void btnAccMgr_Click(object sender, EventArgs e)
        {
            var accountManagerForm = new SSA_B_Canteen.AccountManager();
            accountManagerForm.Show();
        }
    }
}
