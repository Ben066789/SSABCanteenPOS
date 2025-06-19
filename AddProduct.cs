using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace SSA_B_Canteen
{
    public partial class AddProduct : Form
    {

        public AddProduct()
        {
            InitializeComponent();
            ListProductsStyling();
            txtBoxBarcode.Select();
            ListProducts.CellClick += ListProducts_CellClick;



            ListProducts.Columns.Add("Barcode", "Barcode");
            ListProducts.Columns.Add("Name", "Name");
            ListProducts.Columns.Add("Quantity", "Quantity");
            ListProducts.Columns.Add("CostPrice", "Cost Price");
            ListProducts.Columns.Add("Price", "Price");
            ListProducts.Columns.Add("DateAdded", "Date Added");

            btnAdd.Enabled = true;
            //TIMER CONSTRUCTOr
            barcodeTimer = new System.Windows.Forms.Timer();
            barcodeTimer.Interval = BarcodeDelay;
            barcodeTimer.Tick += BarcodeTimer_Tick;
        }
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";
        private void btnGenBarcode_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        } //to be added
        private void ListProductsStyling()
        {
            ListProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListProducts.MultiSelect = false;
            ListProducts.BorderStyle = BorderStyle.None;
            ListProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ListProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListProducts.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            ListProducts.DefaultCellStyle.SelectionForeColor = Color.Black;
            ListProducts.BackgroundColor = Color.White;

            ListProducts.EnableHeadersVisualStyles = false;
            ListProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ListProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ListProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ListProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ListProducts.AllowUserToResizeRows = false;
            ListProducts.AllowUserToResizeColumns = false;
        }
        private void clearTextFields() 
        {
            txtBoxBarcode.Texts = string.Empty;
            txtBoxName.Texts = string.Empty;
            txtBoxQuantity.Texts = string.Empty;
            txtBoxCostPrice.Texts = string.Empty;
            txtBoxPrice.Texts = string.Empty;
        }
        /*private void refreshProductTable()
        {
            ListProducts.Rows.Clear();
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT barcode, name, quantity, cost_price, price, date_added FROM items";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idx = ListProducts.Rows.Add(
                                reader["barcode"].ToString(),
                                reader["name"].ToString(),
                                reader["quantity"].ToString(),
                                reader["cost_price"].ToString(),
                                reader["price"].ToString(),
                                Convert.ToDateTime(reader["date_added"]).ToString("yyyy-MM-dd HH:mm:ss")
                            );
                        }
                    }
                }
            }
        }*/
        //---BUTTON CLICK EVENTS---//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string barcode = txtBoxBarcode.Texts;
            string name = txtBoxName.Texts;
            int quantity = int.TryParse(txtBoxQuantity.Texts, out var q) ? q : 0;
            decimal costPrice = decimal.TryParse(txtBoxCostPrice.Texts, out var c) ? c : 0;
            decimal price = decimal.TryParse(txtBoxPrice.Texts, out var p) ? p : 0;

            if (string.IsNullOrWhiteSpace(barcode) ||
                string.IsNullOrWhiteSpace(name) ||
                quantity <= 0 ||
                costPrice <= 0 ||
                price <= 0)
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            string dateAdded = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            ListProducts.Rows.Add(barcode, name, quantity, costPrice, price, dateAdded);

            clearTextFields();
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ListProducts.Rows.Count == 0)
            {
                MessageBox.Show("No items to add.");
                return;
            }

            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO items
                (barcode, name, quantity, cost_price, price, date_added) 
                VALUES (@barcode, @name, @quantity, @cost_price, @price, @date_added)";

                    foreach (DataGridViewRow row in ListProducts.Rows)
                    {
                        if (row.IsNewRow) continue; // Skip the new row placeholder

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@barcode", row.Cells[0].Value ?? "");
                        cmd.Parameters.AddWithValue("@name", row.Cells[1].Value ?? "");
                        cmd.Parameters.AddWithValue("@quantity", row.Cells[2].Value ?? 0);
                        cmd.Parameters.AddWithValue("@cost_price", row.Cells[3].Value ?? 0);
                        cmd.Parameters.AddWithValue("@price", row.Cells[4].Value ?? 0);
                        cmd.Parameters.AddWithValue("@date_added", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Products added successfully.");
            ListProducts.Rows.Clear();
            clearTextFields();
        }
        /*private void btnUpdate_Click(object sender, EventArgs e)
        {
            string barcode = txtBoxBarcode.Texts;
            int addQuantity = int.TryParse(txtBoxQuantity.Texts, out var q) ? q : 0;
            decimal newCostPrice = decimal.TryParse(txtBoxCostPrice.Texts, out var c) ? c : 0;
            decimal newPrice = decimal.TryParse(txtBoxPrice.Texts, out var p) ? p : 0;

            if (string.IsNullOrWhiteSpace(barcode) || addQuantity <= 0 || newCostPrice <= 0 || newPrice <= 0)
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();

                // Get current quantity
                int currentQuantity = 0;
                using (var getCmd = conn.CreateCommand())
                {
                    getCmd.CommandText = "SELECT quantity FROM items WHERE barcode = @barcode";
                    getCmd.Parameters.AddWithValue("@barcode", barcode);
                    var result = getCmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out var existingQty))
                    {
                        currentQuantity = existingQty;
                    }
                }

                // Update product
                using (var updateCmd = conn.CreateCommand())
                {
                    updateCmd.CommandText = @"UPDATE items 
                SET quantity = @quantity, cost_price = @cost_price, price = @price, date_added = @date_added
                WHERE barcode = @barcode";
                    updateCmd.Parameters.AddWithValue("@quantity", currentQuantity + addQuantity);
                    updateCmd.Parameters.AddWithValue("@cost_price", newCostPrice);
                    updateCmd.Parameters.AddWithValue("@price", newPrice);
                    updateCmd.Parameters.AddWithValue("@date_added", DateTime.Now);
                    updateCmd.Parameters.AddWithValue("@barcode", barcode);

                    updateCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product updated successfully.");

            // Optionally, refresh the DataGridView or clear fields
            clearTextFields();
            txtBoxName.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            refreshProductTable();
        }*/
        //---BUTTON CLICK EVENTS---//

        //----IF EXISTS EVENTS---//
        private System.Windows.Forms.Timer barcodeTimer;
        private const int BarcodeDelay = 200;
        private void txtBoxBarcode__TextChanged(object sender, EventArgs e)
        {
            int expectedLength = 13;
            if (txtBoxBarcode.Texts.Length == expectedLength)
            {
                barcodeTimer.Stop();
                barcodeTimer.Start();
            }
            else
            {
                barcodeTimer.Stop();
            }
        }
        private void BarcodeTimer_Tick(object sender, EventArgs e)
        {
            barcodeTimer.Stop();

            int expectedLength = 13;
            if (txtBoxBarcode.Texts.Length != expectedLength)
                return;

            bool productExists = false;
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT barcode, name, quantity, cost_price, price, date_added FROM items WHERE barcode = @barcode LIMIT 1";
                    cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Texts);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string info = $"Barcode: {reader["barcode"]}\n" +
                                          $"Name: {reader["name"]}\n" +
                                          $"Quantity: {reader["quantity"]}\n" +
                                          $"Cost Price: {reader["cost_price"]}\n" +
                                          $"Price: {reader["price"]}\n" +
                                          $"Date Added: {Convert.ToDateTime(reader["date_added"]).ToString("yyyy-MM-dd HH:mm:ss")}";
                            MessageBox.Show(info, "Product Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            productExists = true;
                            clearTextFields();
                        }
                    }
                }
            }
            if (!productExists)
            {
                txtBoxName.Focus();
            }
        }
        //----IF EXISTS---//

        /*private void txtBoxBarcode__TextChanged(object sender, EventArgs e)
        {
            int expectedLength = 13;

            if (txtBoxBarcode.Texts.Length == expectedLength)
            {
                bool productExists = false;
                using (var conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT barcode, name, quantity, cost_price, price, date_added FROM items WHERE barcode = @barcode LIMIT 1";
                        cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Texts);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string info = $"Barcode: {reader["barcode"]}\n" +
                                              $"Name: {reader["name"]}\n" +
                                              $"Quantity: {reader["quantity"]}\n" +
                                              $"Cost Price: {reader["cost_price"]}\n" +
                                              $"Price: {reader["price"]}\n" +
                                              $"Date Added: {Convert.ToDateTime(reader["date_added"]).ToString("yyyy-MM-dd HH:mm:ss")}";
                                MessageBox.Show(info, "Product Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                productExists = true;
                            }
                        }
                    }
                }
                if (!productExists)
                {
                    txtBoxName.Focus();
                }
            }
        }*/
        private void ListProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ListProducts.Rows.Count)
            {
                var row = ListProducts.Rows[e.RowIndex];
                txtBoxBarcode.Texts = row.Cells[0].Value?.ToString() ?? "";
                txtBoxName.Texts = row.Cells[1].Value?.ToString() ?? "";
                txtBoxQuantity.Texts = row.Cells[2].Value?.ToString() ?? "";
                txtBoxCostPrice.Texts = row.Cells[3].Value?.ToString() ?? "";
                txtBoxPrice.Texts = row.Cells[4].Value?.ToString() ?? "";

                btnAdd.Enabled = false;
            }
        }
    }
}
