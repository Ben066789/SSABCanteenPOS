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

            ListProducts.Columns.Add("Barcode", "Barcode");
            ListProducts.Columns.Add("Name", "Name");
            ListProducts.Columns.Add("Quantity", "Quantity");
            ListProducts.Columns.Add("CostPrice", "Cost Price");
            ListProducts.Columns.Add("Price", "Price");
            ListProducts.Columns.Add("DateAdded", "Date Added");
        }
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";
        private void btnGenBarcode_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }
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

            txtBoxBarcode.Texts = string.Empty;
            txtBoxName.Texts = string.Empty;
            txtBoxQuantity.Texts = string.Empty;
            txtBoxCostPrice.Texts = string.Empty;
            txtBoxPrice.Texts = string.Empty;
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
        }
        private void txtBoxBarcode__TextChanged(object sender, EventArgs e)
        {
            int expectedLength = 13;

            if (txtBoxBarcode.Texts.Length == expectedLength)
            {
                using (var conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {   
                        cmd.CommandText = "SELECT barcode, name, quantity, cost_price, price, date_added FROM products WHERE barcode = @barcode LIMIT 1";
                        cmd.Parameters.AddWithValue("@barcode", txtBoxBarcode.Texts);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Product exists, fill the fields
                                txtBoxName.Texts = reader["name"].ToString();
                                txtBoxQuantity.Texts = reader["quantity"].ToString();
                                txtBoxCostPrice.Texts = reader["cost_price"].ToString();
                                txtBoxPrice.Texts = reader["price"].ToString();

                                // Add to ListProducts if not already present
                                bool alreadyInGrid = false;
                                foreach (DataGridViewRow row in ListProducts.Rows)
                                {
                                    if (!row.IsNewRow && row.Cells[0].Value?.ToString() == reader["barcode"].ToString())
                                    {
                                        alreadyInGrid = true;
                                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                                        break;
                                    }
                                }
                                if (!alreadyInGrid)
                                {
                                    int idx = ListProducts.Rows.Add(
                                        reader["barcode"].ToString(),
                                        reader["name"].ToString(),
                                        reader["quantity"].ToString(),
                                        reader["cost_price"].ToString(),
                                        reader["price"].ToString(),
                                        Convert.ToDateTime(reader["date_added"]).ToString("yyyy-MM-dd HH:mm:ss")
                                    );
                                    ListProducts.Rows[idx].DefaultCellStyle.BackColor = Color.LightGreen;
                                }

                                MessageBox.Show("Product already exists. Details loaded and added to the list.");
                            }
                            else
                            {
                                // Product does not exist, clear fields for new entry
                                txtBoxName.Texts = string.Empty;
                                txtBoxQuantity.Texts = string.Empty;
                                txtBoxCostPrice.Texts = string.Empty;
                                txtBoxPrice.Texts = string.Empty;
                            }
                        }
                    }
                }

                SendKeys.Send("{TAB}");
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ListProducts.Rows.Count == 0)
            {
                MessageBox.Show("No products to add.");
                return;
            }

            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO products
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
        }
    }
}
