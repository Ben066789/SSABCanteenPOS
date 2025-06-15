using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SSA_B_Canteen
{
    public partial class Cashier : Form
    {
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";

        public Cashier()
        {
            InitializeComponent();
            txtBoxBarcode.KeyDown += txtBoxBarcode_KeyDown;
            txtBoxQuantity.TextChanged += txtBoxQuantity_TextChanged;
            txtBoxQuantity.KeyDown += txtBoxQuantity_KeyDown;
            txtBoxCash.TextChanged += txtBoxCash_TextChanged;
            btnComplete.Click += btnComplete_Click;
            txtBoxCash.KeyDown += txtBoxCash_KeyDown;


            ItemList.Columns.Add("Barcode", "Barcode");
            ItemList.Columns.Add("ProductName", "Product Name");
            ItemList.Columns.Add("Quantity", "Quantity");
            ItemList.Columns.Add("Price", "Price");
            ItemList.Columns.Add("Total", "Total");
        }

        private void txtBoxBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBoxBarcode.Text;
                using (var conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT name, price FROM products WHERE barcode = @barcode LIMIT 1";
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblProductName.Text = reader["name"].ToString();
                                lblProductPrice.Text = reader["price"].ToString();
                                txtBoxQuantity.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }
                        }
                    }
                }
            }
        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(lblProductPrice.Text, out var price) && int.TryParse(txtBoxQuantity.Text, out var qty))
            {
                lblItemTotal.Text = (price * qty).ToString("0.00");
            }
            else
            {
                lblItemTotal.Text = "0.00";
            }
        }

        private void txtBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int qty = int.TryParse(txtBoxQuantity.Text, out var q) ? q : 0;
                decimal price = decimal.TryParse(lblProductPrice.Text, out var p) ? p : 0;
                decimal total = price * qty;
                ItemList.Rows.Add(txtBoxBarcode.Text, lblProductName.Text, qty, price, total);
                UpdateFinalTotal();
                txtBoxBarcode.Text = "";
                lblProductName.Text = "";
                lblProductPrice.Text = "";
                txtBoxQuantity.Text = "";
                lblItemTotal.Text = "";
                txtBoxBarcode.Focus();
            }
        }

        private void UpdateFinalTotal()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in ItemList.Rows)
            {
                if (row.IsNewRow) continue;
                sum += Convert.ToDecimal(row.Cells[4].Value);
            }
            lblFinalTotal.Text = sum.ToString("0.00");
        }

        private void txtBoxCash_TextChanged(object sender, EventArgs e)
        {
            decimal finalTotal = decimal.TryParse(lblFinalTotal.Text, out var ft) ? ft : 0;
            decimal cash = decimal.TryParse(txtBoxCash.Text, out var c) ? c : 0;
            lblChange.Text = (cash - finalTotal).ToString("0.00");
        }
        private void txtBoxCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in ItemList.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string barcode = row.Cells[0].Value.ToString();
                        int qty = Convert.ToInt32(row.Cells[2].Value);
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE products SET quantity = quantity - @qty WHERE barcode = @barcode";
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@barcode", barcode);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Transaction completed!");
                ItemList.Rows.Clear();
                UpdateFinalTotal();
                lblChange.Text = "";
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                foreach (DataGridViewRow row in ItemList.Rows)
                {
                    if (row.IsNewRow) continue;
                    string barcode = row.Cells[0].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells[2].Value);
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE products SET quantity = quantity - @qty WHERE barcode = @barcode";
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Transaction completed!");
            ItemList.Rows.Clear();
            UpdateFinalTotal();
            lblChange.Text = "";
        }
    }
}
