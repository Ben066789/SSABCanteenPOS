using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace SSA_B_Canteen
{
    public partial class Cashier : Form
    {
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";
        //private CreditForm creditForm;
        private Dictionary<string, int> nameToId = new();
        private int _employeeId;
        public Cashier(int employeeId)
        {
            _employeeId = employeeId;
            InitializeComponent();
            txtBoxBarcode.KeyDown += txtBoxBarcode_KeyDown;
            txtBoxQuantity.TextChanged += txtBoxQuantity_TextChanged;
            txtBoxQuantity.KeyDown += txtBoxQuantity_KeyDown;
            txtBoxCash.TextChanged += txtBoxCash_TextChanged;
            btnComplete.Click += btnComplete_Click;
            txtBoxCash.KeyDown += txtBoxCash_KeyDown;
            this.FormClosing += Cashier_FormClosing;
            this.KeyPreview = true;
            this.KeyDown += Cashier_KeyDown;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Resize += Cashier_Resize;
            pnlCredit.Visible = false;

            ItemList.Columns.Add("Barcode", "Barcode");
            ItemList.Columns.Add("ProductName", "Product Name");
            ItemList.Columns.Add("Quantity", "Quantity");
            ItemList.Columns.Add("Price", "Price");
            ItemList.Columns.Add("Total", "Total");

            okCredit.Click += okCredit_Click;

            txtBoxBarcode.Focus();
            tableStyle();
            LoadEmployeeNames();
        }
        private void LoadEmployeeNames()
        {
            nameToId.Clear();
            nameSearch.AutoCompleteCustomSource.Clear();
            using var conn = new MySqlConnection(connstring);
            conn.Open();
            using var cmd = new MySqlCommand("SELECT employee_id, firstname, lastname FROM accounts", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string fullname = $"{reader["firstname"]} {reader["lastname"]}";
                int id = Convert.ToInt32(reader["employee_id"]);
                nameToId[fullname] = id;
                nameSearch.AutoCompleteCustomSource.Add(fullname);
            }
            nameSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nameSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        /*public class CreditItem
        {
            public int ItemId { get; set; }
            public string Barcode { get; set; }
            public int Quantity { get; set; }
            public decimal CostPrice { get; set; }
            public decimal TotalPrice { get; set; }
        }*/
        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                bool hasItems = false;
                foreach (DataGridViewRow row in ItemList.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        hasItems = true;
                        break;
                    }
                }
                if (!hasItems)
                {
                    ToolTip tt = new ToolTip();
                    tt.Show("No items to credit.", this, this.Width / 2, this.Height / 2, 2000);
                    e.Handled = true;
                    return;
                }

                // Center pnlCredit on the form
                pnlCredit.Left = (this.ClientSize.Width - pnlCredit.Width) / 2;
                pnlCredit.Top = (this.ClientSize.Height - pnlCredit.Height) / 2;

                pnlCredit.Visible = true;
                pnlCredit.BringToFront();
                pnlCredit.Focus();
                e.Handled = true;
            }
        }
        /*public void DeductQuantities(List<CreditItem> items)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                foreach (var item in items)
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE items SET quantity = quantity - @qty WHERE id = @itemid";
                        cmd.Parameters.AddWithValue("@qty", item.Quantity);
                        cmd.Parameters.AddWithValue("@itemid", item.ItemId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }*/
        private int GetEffectiveQuantity()
        {
            if (int.TryParse(txtBoxQuantity.Text, out int qty) && qty > 1)
                return qty;
            return 1;
        }
        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent closing on Alt+F4 or clicking the X button
                e.Cancel = true;
                MessageBox.Show("Closing the application is disabled.");
            }
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
                        cmd.CommandText = "SELECT name, price FROM items WHERE barcode = @barcode LIMIT 1";
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
            if (decimal.TryParse(lblProductPrice.Text, out var price))
            {
                int qty = GetEffectiveQuantity();
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
                int qty = GetEffectiveQuantity();
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
                if (ItemList.Rows.Count == 0 || (ItemList.Rows.Count == 1 && ItemList.Rows[0].IsNewRow))
                {
                    MessageBox.Show("No items to sell.");
                    return;
                }

                // TODO: Replace with actual logic to get the logged-in cashier's employee_id
                int employeeId = _employeeId;
                if (employeeId == 0)
                {
                    MessageBox.Show("No cashier selected.");
                    return;
                }

                using (var conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in ItemList.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string barcode = row.Cells[0].Value.ToString();
                        int qty = Convert.ToInt32(row.Cells[2].Value);

                        // Get item_id and price from items table
                        int itemId = 0;
                        decimal price = 0;
                        using (var cmd = new MySqlCommand("SELECT item_id, price FROM items WHERE barcode = @barcode", conn))
                        {
                            cmd.Parameters.AddWithValue("@barcode", barcode);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    itemId = Convert.ToInt32(reader["item_id"]);
                                    price = Convert.ToDecimal(reader["price"]);
                                }
                                else
                                {
                                    MessageBox.Show($"Item with barcode {barcode} not found.");
                                    continue;
                                }
                            }
                        }

                        decimal totalPrice = Convert.ToDecimal(row.Cells[4].Value);

                        // Insert into sales table
                        string insSale = @"INSERT INTO sales (item_id, employee_id, qty, price, total_price, date_created)
                                   VALUES (@itemid, @empid, @qty, @cost, @total, NOW())";
                        using (var cmd = new MySqlCommand(insSale, conn))
                        {
                            cmd.Parameters.AddWithValue("@itemid", itemId);
                            cmd.Parameters.AddWithValue("@empid", employeeId);
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@cost", price);
                            cmd.Parameters.AddWithValue("@total", totalPrice);
                            cmd.ExecuteNonQuery();
                        }

                        // Deduct quantity from items table
                        using (var cmd = new MySqlCommand("UPDATE items SET quantity = quantity - @qty WHERE item_id = @itemid", conn))
                        {
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@itemid", itemId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Sale transaction completed!");
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
                        cmd.CommandText = "UPDATE items SET quantity = quantity - @qty WHERE barcode = @barcode";
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
        private void tableStyle()
        {
            ItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemList.MultiSelect = false;
            ItemList.BorderStyle = BorderStyle.None;
            ItemList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ItemList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemList.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            ItemList.DefaultCellStyle.SelectionForeColor = Color.Black;
            ItemList.BackgroundColor = Color.White;

            ItemList.EnableHeadersVisualStyles = false;
            ItemList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ItemList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ItemList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ItemList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ItemList.AllowUserToResizeRows = false;
            ItemList.AllowUserToResizeColumns = false;
        }
        private void Cashier_Resize(object sender, EventArgs e)
        {
            float scale = Math.Min((float)this.Width / 1280, (float)this.Height / 720); // Use your design size
            ItemList.DefaultCellStyle.Font = new Font("Segoe UI", 16F * scale);
            ItemList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F * scale, FontStyle.Bold);

            //label font scale
            lblProductName.Font = new Font("Segoe UI", 18F * scale, FontStyle.Bold);
            lblProductPrice.Font = new Font("Segoe UI", 16F * scale);
            lblItemTotal.Font = new Font("Segoe UI", 16F * scale);
            lblFinalTotal.Font = new Font("Segoe UI", 20F * scale, FontStyle.Bold);
            lblChange.Font = new Font("Segoe UI", 20F * scale, FontStyle.Bold);

            if (pnlCredit.Visible)
            {
                pnlCredit.Left = (this.ClientSize.Width - pnlCredit.Width) / 2;
                pnlCredit.Top = (this.ClientSize.Height - pnlCredit.Height) / 2;
            }
        }
        private void okCredit_Click(object sender, EventArgs e)
        {
            var inputName = nameSearch.Text.Trim();
            if (!nameToId.TryGetValue(inputName, out int employeeId))
            {
                MessageBox.Show("Please select a valid name.");
                return;
            }

            if (ItemList.Rows.Count == 0 || (ItemList.Rows.Count == 1 && ItemList.Rows[0].IsNewRow))
            {
                MessageBox.Show("No items to credit.");
                return;
            }

            var items = new List<(int itemId, int qty, decimal price, decimal totalPrice)>();

            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                foreach (DataGridViewRow row in ItemList.Rows)
                {
                    if (row.IsNewRow) continue;
                    string barcode = row.Cells[0].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells[2].Value);

                    // Get item_id and price
                    using var cmd = new MySqlCommand("SELECT item_id, price FROM items WHERE barcode = @barcode", conn);
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int itemId = Convert.ToInt32(reader["item_id"]);
                        decimal price = Convert.ToDecimal(reader["price"]);
                        decimal totalPrice = Convert.ToDecimal(row.Cells[4].Value);
                        items.Add((itemId, qty, price, totalPrice));
                    }
                    reader.Close();
                }

                // Insert into credit_transaction (set total_price to 0 for now)
                string insCredTrans = "INSERT INTO credit_transactions (employee_id, total_price, amount_paid, status, date_created) VALUES (@eid, 0, 0, 'unpaid', NOW()); SELECT LAST_INSERT_ID();";
                int creditId;
                using (var cmd = new MySqlCommand(insCredTrans, conn))
                {
                    cmd.Parameters.AddWithValue("@eid", employeeId);
                    creditId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Insert into credit_items and deduct quantity
                foreach (var item in items)
                {
                    string insCredItems = "INSERT INTO credit_items (credit_id, item_id, qty, price, total_price) VALUES (@cid, @itemid, @qty, @cost, @total);";
                    using (var cmd = new MySqlCommand(insCredItems, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", creditId);
                        cmd.Parameters.AddWithValue("@itemid", item.itemId);
                        cmd.Parameters.AddWithValue("@qty", item.qty);
                        cmd.Parameters.AddWithValue("@cost", item.price);
                        cmd.Parameters.AddWithValue("@total", item.totalPrice);
                        cmd.ExecuteNonQuery();
                    }

                    // Deduct quantity
                    using (var cmd = new MySqlCommand("UPDATE items SET quantity = quantity - @qty WHERE item_id = @itemid", conn))
                    {
                        cmd.Parameters.AddWithValue("@qty", item.qty);
                        cmd.Parameters.AddWithValue("@itemid", item.itemId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Update credit_transactions.total_price to the sum of related credit_items
                using (var cmd = new MySqlCommand(
                    "UPDATE credit_transactions SET total_price = (SELECT SUM(total_price) FROM credit_items WHERE credit_id = @cid) WHERE credit_id = @cid", conn))
                {
                    cmd.Parameters.AddWithValue("@cid", creditId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Credit transaction completed!");
            ItemList.Rows.Clear();
            UpdateFinalTotal();
            pnlCredit.Visible = false;
        } 
    }
}

