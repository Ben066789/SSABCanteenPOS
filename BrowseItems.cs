using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace SSA_B_Canteen
{
    public partial class BrowseItems : Form
    {
        private int originalQuantityValue = 0;
        private bool isLoading = false;
        private DataTable allItemsTable = new DataTable();
        public BrowseItems()
        {
            InitializeComponent();
            LoadItems();
            tableStyle();
            txtbxSearch.TextChanged += txtbxSearch_TextChanged;
            dgvAllItems.CellValueChanged += dgvAllItems_CellValueChanged;
            dgvAllItems.CellValidating += dgvAllItems_CellValidating;
            dgvAllItems.CellBeginEdit += dgvAllItems_CellBeginEdit;
            dgvAllItems.CellParsing += dgvAllItems_CellParsing;
            dgvAllItems.Scroll += dgvAllItems_Scroll;
            dgvAllItems.KeyDown += dgvAllItems_KeyDown;
        }
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";
        private void SetupColumns()
        {
            foreach (DataGridViewColumn col in dgvAllItems.Columns)
                col.ReadOnly = col.Name != "quantity";
            if (dgvAllItems.Columns["name"] != null)
                dgvAllItems.Columns["name"].DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            if (dgvAllItems.Columns["barcode"] != null)
                dgvAllItems.Columns["barcode"].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            if (dgvAllItems.Columns["updated"] != null)
                dgvAllItems.Columns["updated"].Visible = true; // Set to false if you want to hide it later
            foreach (DataGridViewRow row in dgvAllItems.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["updated"].Value is bool updated && updated)
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
        private void LoadItems(int offset = 0)
        {
            string query = "SELECT barcode, name, quantity, cost_price, price, date_added, date_updated FROM items LIMIT @limit OFFSET @offset";
            using (MySqlConnection conn = new MySqlConnection(connstring))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@limit", 20); // batch size
                adapter.SelectCommand.Parameters.AddWithValue("@offset", offset);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Ensure schema is set up on first load
                if (allItemsTable.Columns.Count == 0)
                {
                    allItemsTable = dt.Clone();
                    if (!allItemsTable.Columns.Contains("updated"))
                        allItemsTable.Columns.Add("updated", typeof(bool));
                }

                // Add "updated" column to dt if missing (for consistency)
                if (!dt.Columns.Contains("updated"))
                    dt.Columns.Add("updated", typeof(bool));

                foreach (DataRow row in dt.Rows)
                {
                    var newBarcode = row["barcode"] == DBNull.Value ? "" : row["barcode"].ToString();
                    bool exists = allItemsTable.AsEnumerable()
                        .Any(r => (r["barcode"] == DBNull.Value ? "" : r["barcode"].ToString()) == newBarcode);

                    if (!exists)
                    {
                        var newRow = allItemsTable.NewRow();
                        foreach (DataColumn col in allItemsTable.Columns)
                        {
                            if (dt.Columns.Contains(col.ColumnName))
                                newRow[col.ColumnName] = row[col.ColumnName];
                            else if (col.ColumnName == "updated")
                                newRow["updated"] = false;
                        }
                        allItemsTable.Rows.Add(newRow);
                    }
                }

                dgvAllItems.DataSource = allItemsTable;
                SetupColumns();
            }
        }


        private void dgvAllItems_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (!isLoading && dgvAllItems.DisplayedRowCount(false) + dgvAllItems.FirstDisplayedScrollingRowIndex >= dgvAllItems.RowCount)
                {
                    isLoading = true;
                    // Use allItemsTable.Rows.Count as the offset for the next batch
                    LoadItems(allItemsTable.Rows.Count);
                    isLoading = false;
                }
            }
        }
        private void dgvAllItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvAllItems.Columns[e.ColumnIndex].Name == "quantity")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out _))
                {
                    if (!dgvAllItems.IsCurrentCellInEditMode)
                        return;
                    MessageBox.Show("Please enter a valid integer for quantity.");
                    e.Cancel = true;
                }
            }
        }


        private void dgvAllItems_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (dgvAllItems.Columns[e.ColumnIndex].Name == "quantity")
            {
                var row = dgvAllItems.Rows[e.RowIndex];
                int currentValue = 0;
                if (row.Cells["quantity"].Value != null && row.Cells["quantity"].Value != DBNull.Value)
                    int.TryParse(row.Cells["quantity"].Value.ToString(), out currentValue);

                if (int.TryParse(e.Value?.ToString(), out int inputValue))
                {
                    e.Value = currentValue + inputValue;
                    e.ParsingApplied = true;
                }
                else
                {
                    // Optionally, show an error or set e.ParsingApplied = false to reject invalid input
                    e.ParsingApplied = false;
                }
            }
        }


        private void dgvAllItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvAllItems.Columns[e.ColumnIndex].Name == "quantity")
            {
                var row = dgvAllItems.Rows[e.RowIndex];
                int.TryParse(row.Cells["quantity"].Value?.ToString(), out originalQuantityValue);
            }
        }


        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvAllItems.IsCurrentCellInEditMode)
                dgvAllItems.EndEdit(); // or just return;
            SearchItems(txtbxSearch.Text);
        }

        private void dgvAllItems_KeyDown(object sender, KeyEventArgs e)
        {
            // If only one row (excluding the new row), suppress Enter key
            int visibleRowCount = dgvAllItems.Rows.Cast<DataGridViewRow>().Count(r => r.Visible && !r.IsNewRow);
            if (visibleRowCount == 1 && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void dgvAllItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllItems.Columns[e.ColumnIndex].Name == "quantity")
            {
                var row = dgvAllItems.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.LightYellow;
                row.Cells["updated"].Value = true; // Mark as updated for sorting

                // Also update the corresponding row in allItemsTable
                var barcode = row.Cells["barcode"].Value?.ToString();
                if (!string.IsNullOrEmpty(barcode))
                {
                    var found = allItemsTable.AsEnumerable()
                        .FirstOrDefault(r => r["barcode"].ToString() == barcode);
                    if (found != null)
                    {
                        found["updated"] = true;
                        // Optionally, also update the quantity in allItemsTable to keep in sync
                        found["quantity"] = row.Cells["quantity"].Value;
                    }
                }
            }
        }

        private void SearchItems(string searchText)
        {
            // If editing, do not change the DataSource
            if (dgvAllItems.IsCurrentCellInEditMode)
            {
                // Optionally, end edit or just return
                dgvAllItems.EndEdit();
                // return; // Uncomment this line to completely block search while editing
            }

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvAllItems.DataSource = allItemsTable;
            }
            else
            {
                string query = @"SELECT barcode, name, quantity, cost_price, price, date_added, date_updated 
                         FROM items
                         WHERE barcode LIKE @search OR name LIKE @search";
                using (MySqlConnection conn = new MySqlConnection(connstring))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Add "updated" column if missing
                    if (!dt.Columns.Contains("updated"))
                        dt.Columns.Add("updated", typeof(bool));

                    foreach (DataRow row in dt.Rows)
                    {
                        var barcode = row["barcode"]?.ToString();
                        // Merge "updated" marker from allItemsTable
                        var updatedRow = allItemsTable.AsEnumerable()
                            .FirstOrDefault(r => r["barcode"]?.ToString() == barcode);
                        if (updatedRow != null && updatedRow["updated"] is bool updated && updated)
                        {
                            row["updated"] = true;
                        }
                        // If not in allItemsTable, add it
                        if (updatedRow == null)
                        {
                            var newRow = allItemsTable.NewRow();
                            foreach (DataColumn col in allItemsTable.Columns)
                            {
                                if (dt.Columns.Contains(col.ColumnName))
                                    newRow[col.ColumnName] = row[col.ColumnName];
                                else if (col.ColumnName == "updated")
                                    newRow["updated"] = row["updated"];
                            }
                            allItemsTable.Rows.Add(newRow);
                        }
                    }

                    dgvAllItems.DataSource = dt;
                }
            }
            SetupColumns();
        }


        private void tableStyle()
        {
            dgvAllItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllItems.MultiSelect = false;
            dgvAllItems.BorderStyle = BorderStyle.None;
            dgvAllItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvAllItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAllItems.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvAllItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAllItems.BackgroundColor = Color.White;

            dgvAllItems.EnableHeadersVisualStyles = false;
            dgvAllItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAllItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvAllItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvAllItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAllItems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //Font settings
            dgvAllItems.AllowUserToResizeRows = false;
            dgvAllItems.AllowUserToResizeColumns = false;
            dgvAllItems.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            dgvAllItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            dgvAllItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAllItems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvAllItems.AllowUserToResizeRows = false;
            dgvAllItems.AllowUserToResizeColumns = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using var conn = new MySqlConnection(connstring);
            conn.Open();

            foreach (DataGridViewRow row in dgvAllItems.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["updated"].Value is bool updated && updated)
                {
                    string barcode = row.Cells["barcode"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    DateTime now = DateTime.Now;

                    string query = "UPDATE items SET quantity=@quantity, date_updated=@date_updated WHERE barcode=@barcode";
                    using var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@date_updated", now);
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    cmd.ExecuteNonQuery();

                    row.Cells["date_updated"].Value = now;
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.Cells["updated"].Value = false;
                }
            }
        }

        private void btnShowUpdated_Click(object sender, EventArgs e)
        {
            // Filter allItemsTable for updated rows
            var updatedRows = allItemsTable.AsEnumerable()
                .Where(r => r.Field<bool?>("updated") == true);

            if (updatedRows.Any())
            {
                // Create a DataTable from the filtered rows
                DataTable updatedTable = updatedRows.CopyToDataTable();
                dgvAllItems.DataSource = updatedTable;
                SetupColumns();
            }
            else
            {
                // Optionally, clear the grid or show a message
                dgvAllItems.DataSource = null;
                MessageBox.Show("No updated items found.");
            }
        }




        /*private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentOffset >= pageSize)
            {
                currentOffset -= pageSize;
                LoadItems(currentOffset);
            }
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (allItemsTable.Rows.Count > currentOffset + pageSize)
            {
                currentOffset += pageSize;
                LoadItems(currentOffset);
            }
            else
            {
                // Try to load more from DB
                currentOffset += pageSize;
                LoadItems(currentOffset);
            }
        }*/
    }
}