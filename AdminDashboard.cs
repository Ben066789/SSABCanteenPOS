using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
//using ScottPlot;
//using ScottPlot.WinForms;
//using ScottPlot.TickGenerators;
using System.Data;


namespace SSA_B_Canteen
{
    public partial class AdminDashboard : Form
    {
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";
        //private DataGridView dgvProducts;
        private System.Windows.Forms.Timer salesUpdateTimer;
        private DateTime startOfDay = DateTime.Today;
        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load;
            this.KeyPreview = true;
            //this.KeyDown += keydown_exit;
            this.FormClosing += AdminDashboard_FormClosing;
            dgvSales.RowPrePaint += dgvSales_Style;
            LoadSalesSummary();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //--for line graph--//
            /*salesUpdateTimer = new System.Windows.Forms.Timer();
            salesUpdateTimer.Interval = 60000; // update every minute
            salesUpdateTimer.Tick += SalesUpdateTimer_Tick;
            salesUpdateTimer.Start();
            UpdateSalesLineGraph();*/

        }
        /*private void SalesUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateSalesLineGraph();
        }*/
        /*private void UpdateSalesLineGraph()
        {
            var times = new List<DateTime>();
            var amounts = new List<double>();

            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                string query = @"
        SELECT 
            HOUR(date_created) AS hour,
            SUM(total_price) AS total
        FROM sales
        WHERE DATE(date_created) = CURDATE()
        GROUP BY hour
        ORDER BY hour";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    double cumulativeTotal = 0;

                    while (reader.Read())
                    {
                        int hour = reader.GetInt32("hour");
                        double total = reader.IsDBNull("total") ? 0 : Convert.ToDouble(reader["total"]);
                        cumulativeTotal += total;

                        times.Add(DateTime.Today.AddHours(hour));
                        amounts.Add(cumulativeTotal);
                    }
                }
            }
            DateTime[] dtXs = times.ToArray();
            double[] ys = amounts.ToArray();

            // Clear the plot
            formsPlot1.Plot.Clear();
            formsPlot1.UserInputProcessor.IsEnabled = false;

            // Plot the sales data using DateTime X values
            var scatter = formsPlot1.Plot.Add.Scatter(dtXs, ys);
            scatter.MarkerSize = 5;
            scatter.Color = ScottPlot.Colors.Blue;

            // Setup the bottom axis to use DateTime ticks
            var axis = formsPlot1.Plot.Axes.DateTimeTicksBottom();

            // Apply a custom formatter
            static string CustomFormatter(DateTime dt)
            {
                // Show full time if zoomed in, only date if zoomed out (or tweak this)
                return dt.ToString("h tt"); // shows "8 AM", "2 PM", etc.
            }

            var tickGen = (ScottPlot.TickGenerators.DateTimeAutomatic)axis.TickGenerator;
            tickGen.LabelFormatter = CustomFormatter;

            // Add titles
            formsPlot1.Plot.Title("Cumulative Sales Throughout the Day");
            formsPlot1.Plot.XLabel("Time");
            formsPlot1.Plot.YLabel("Total Sales Amount");

            formsPlot1.Refresh();
        }*/ //for line graph
        /*private void chartTable_Load(object sender, EventArgs e)
        {
            formsPlot1.Plot.Add.Bar(position: 1, value: 5, error: 1);
            formsPlot1.Plot.Add.Bar(position: 2, value: 7, error: 2);
            formsPlot1.Plot.Add.Bar(position: 3, value: 6, error: 1);
            formsPlot1.Plot.Add.Bar(position: 4, value: 8, error: 2);

            Tick[] ticks =
            {
            new(1, "Apple"),
            new(2, "Orange"),
            new(3, "Pear"),
            new(4, "Banana"),
            };

            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            formsPlot1.Plot.HideGrid();
            formsPlot1.Plot.Axes.Margins(bottom: 0);
            formsPlot1.Refresh();
        }*/
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct();
            addProductForm.Show();
        }
        /*private void btnCashier_Click(object sender, EventArgs e)
        {
            var cashierForm = new Cashier();
            cashierForm.Show();
        }*/
        private void btnAccMgr_Click(object sender, EventArgs e)
        {
            var accountManagerForm = new SSA_B_Canteen.AccountManager();
            accountManagerForm.Show();
        }
        private void LoadSalesSummary()
        {
            using var conn = new MySqlConnection(connstring);
            conn.Open();
            // LEFT JOIN to include all cashiers, even those without sales
            string query = @"
                SELECT a.status, a.username, a.firstname, IFNULL(SUM(s.total_price), 0) AS total_sales
                FROM accounts a
                LEFT JOIN sales s ON s.employee_id = a.employee_id AND DATE(s.date_created) = CURDATE()
                WHERE a.role = 'cashier'
                GROUP BY a.employee_id, a.status, a.username, a.firstname
                ORDER BY total_sales DESC";
            using var cmd = new MySqlCommand(query, conn);
            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            dgvSales.DataSource = dt;

            // Hide selection highlight
            dgvSales.DefaultCellStyle.SelectionBackColor = dgvSales.DefaultCellStyle.BackColor;
            dgvSales.DefaultCellStyle.SelectionForeColor = dgvSales.DefaultCellStyle.ForeColor;
            dgvSales.RowHeadersDefaultCellStyle.SelectionBackColor = dgvSales.RowHeadersDefaultCellStyle.BackColor;
            dgvSales.RowHeadersDefaultCellStyle.SelectionForeColor = dgvSales.RowHeadersDefaultCellStyle.ForeColor;
            dgvSales.EnableHeadersVisualStyles = false;

            dgvSales.Font = new Font("Segoe UI", 14F);
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.Columns[0].HeaderText = "Status";
            dgvSales.Columns[1].HeaderText = "Username";
            dgvSales.Columns[2].HeaderText = "Firstname";
            dgvSales.Columns[3].HeaderText = "Total Sales";

            // Capitalize status text
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.IsNewRow) continue;
                var cell = row.Cells[0];
                var status = cell.Value?.ToString()?.ToLower();
                if (status == "active")
                    cell.Value = "Active";
                else if (status == "inactive")
                    cell.Value = "Inactive";
                else if (!string.IsNullOrEmpty(status))
                    cell.Value = char.ToUpper(status[0]) + status.Substring(1);
            }

            // Get total sales sum for the day (all cashiers)
            string totalQuery = @"
                SELECT IFNULL(SUM(s.total_price),0)
                FROM sales s
                JOIN accounts a ON s.employee_id = a.employee_id
                WHERE DATE(s.date_created) = CURDATE() AND a.role = 'cashier'";
            using var totalCmd = new MySqlCommand(totalQuery, conn);
            var total = Convert.ToDecimal(totalCmd.ExecuteScalar());
            lblTotalSum.Text = $"{total:N2}";
        }


        private void dgvSales_Style(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvSales.Rows[e.RowIndex];
            if (row.IsNewRow) return;
            var cell = row.Cells[0];
            var status = cell.Value?.ToString();
            if (status == "Active")
            {
                cell.Style.ForeColor = Color.Green;
                cell.Style.Font = new Font(dgvSales.Font, FontStyle.Bold);
            }
            else if (status == "Inactive")
            {
                cell.Style.ForeColor = Color.Red;
                cell.Style.Font = new Font(dgvSales.Font, FontStyle.Bold);
            }
            else
            {
                cell.Style.ForeColor = Color.Gray;
                cell.Style.Font = dgvSales.Font;
            }
        }
        private void btnAllItems_Click(object sender, EventArgs e)
        {
            var BrowseItems = new BrowseItems();
            BrowseItems.Show();
        }
        private void btnRestock_Click(object sender, EventArgs e)
        {
            var Restock = new Restock();
            Restock.Show();
        }
        //--EXITS--//
        /*private void keydown_exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Exit Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }*/
        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        //--EXITS--//


    }
}
