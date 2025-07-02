using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SSA_B_Canteen
{
    public partial class Restock : Form
    {
        private string connectionString = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";

        private int selectedItemId = -1;

        public Restock()
        {
            InitializeComponent();
            txtBoxSearch.TextChanged += textBoxSearch_TextChanged;
            btnConfirm.Click += btnConfirm_Click;
            dgvToConfirm.Rows.Clear();
            dgvItems.DataSource = null; // Start with empty grid
            if (dgvToConfirm.Columns.Count == 0)
            {
                dgvToConfirm.Columns.Add("item_id", "Item ID");
                dgvToConfirm.Columns.Add("name", "Name");
                dgvToConfirm.Columns.Add("qty", "Quantity");
                dgvToConfirm.Columns.Add("cost", "Cost");
                dgvToConfirm.Columns.Add("price", "Price");
                dgvToConfirm.Columns.Add("date", "Date");
            }
            dgvItems.CellClick += dgvItems_CellClick;
            dgvToConfirm.Columns["item_id"].Visible = false;
            StyleDataGridView(dgvItems);
            StyleDataGridView(dgvToConfirm);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadItemsToGrid(txtBoxSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedItemId == -1) return;
            dgvToConfirm.Rows.Add(
                selectedItemId,
                lblItemName.Text,
                txtBoxQty.Text,
                txtBoxCost.Text,
                txtBoxPrice.Text,
                DateTime.Now.ToString("yyyy-MM-dd")
            );
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            foreach (DataGridViewRow row in dgvToConfirm.Rows)
            {
                if (row.IsNewRow) continue;
                int id = Convert.ToInt32(row.Cells[0].Value);
                int qty = Convert.ToInt32(row.Cells[2].Value);
                decimal cost = Convert.ToDecimal(row.Cells[3].Value);
                decimal price = Convert.ToDecimal(row.Cells[4].Value);

                string update = @"UPDATE items 
                          SET quantity = quantity + @qty, 
                              cost_price = @cost, 
                              price = @price, 
                              date_updated = NOW() 
                          WHERE item_id = @id";
                using var cmd = new MySqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Items restocked and updated!");
            dgvToConfirm.Rows.Clear();
        }
        private void LoadItemsToGrid(string search = "")
        {
            if (string.IsNullOrWhiteSpace(search))
            {
                dgvItems.DataSource = null; // Show nothing if search is empty
                return;
            }

            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "SELECT item_id, name, quantity, cost_price, price, date_updated FROM items WHERE name LIKE @search";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            dgvItems.DataSource = dt;
            dgvItems.ClearSelection();

            // Hide the item_id column if it exists
            if (dgvItems.Columns.Contains("item_id"))
                dgvItems.Columns["item_id"].Visible = false;
        }
        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvItems.Rows[e.RowIndex];
                selectedItemId = Convert.ToInt32(row.Cells["item_id"].Value);
                lblItemName.Text = row.Cells["name"].Value.ToString();
                txtBoxCurrStock.Text = row.Cells["quantity"].Value.ToString();
                txtBoxCost.Text = Convert.ToDecimal(row.Cells["cost_price"].Value).ToString("F2");
                txtBoxPrice.Text = Convert.ToDecimal(row.Cells["price"].Value).ToString("F2");
                txtBoxDateAdded.Text = Convert.ToDateTime(row.Cells["date_updated"].Value).ToString("yyyy-MM-dd");
            }
        }
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }
    }
}

