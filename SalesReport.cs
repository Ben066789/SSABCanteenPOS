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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SSA_B_Canteen
{
    public partial class SalesReport : Form
    {
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";

        public SalesReport()
        {
            InitializeComponent();
            btnGo.Click += BtnGo_Click;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            LoadSalesByDate();
        }

        private void LoadSalesByDate()
        {
            using var conn = new MySqlConnection(connstring);
            conn.Open();

            string query = @"
                SELECT DATE(date_created) AS SaleDate, SUM(total_price) AS TotalSales
                FROM sales
                WHERE DATE(date_created) BETWEEN @from AND @to
                GROUP BY SaleDate
                ORDER BY SaleDate";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@from", fromDate.Value.Date);
            cmd.Parameters.AddWithValue("@to", toDate.Value.Date);

            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);

            dgvSales.DataSource = dt;

            // --- DataGridView Styling ---
            dgvSales.EnableHeadersVisualStyles = false;
            dgvSales.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSales.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            dgvSales.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            dgvSales.DefaultCellStyle.BackColor = Color.White;
            dgvSales.DefaultCellStyle.ForeColor = Color.Black;
            dgvSales.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvSales.RowTemplate.Height = 32;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.MultiSelect = false;
            dgvSales.ReadOnly = true;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dt.Columns.Count >= 2)
            {
                dgvSales.Columns[0].HeaderText = "Date";
                dgvSales.Columns[1].HeaderText = "Total Sales";
            }

            // --- Grand Total Calculation ---
            decimal grandTotal = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["TotalSales"] != DBNull.Value)
                    grandTotal += Convert.ToDecimal(row["TotalSales"]);
            }
            lblTotalSum.Text = $"{grandTotal:N2}";
        }
        private void ExportSalesReportToPDF(string filePath)
        {
            // Create a new PDF document
            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
            pdfDoc.Open();

            // Add a title
            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            pdfDoc.Add(new Paragraph("Sales Report", titleFont));
            pdfDoc.Add(new Paragraph($"Date Range: {fromDate.Value:yyyy-MM-dd} to {toDate.Value:yyyy-MM-dd}"));
            pdfDoc.Add(new Paragraph(" ")); // Empty line

            // Create a table with the same number of columns as dgvSales
            PdfPTable table = new PdfPTable(dgvSales.Columns.Count);
            table.WidthPercentage = 100;

            // Add headers
            foreach (DataGridViewColumn column in dgvSales.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                table.AddCell(cell);
            }

            // Add data rows
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.IsNewRow) continue;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value?.ToString() ?? "");
                }
            }

            pdfDoc.Add(table);

            // Add grand total if you have a label for it
            pdfDoc.Add(new Paragraph(" "));
            pdfDoc.Add(new Paragraph("Grand Total: " + lblTotalSum.Text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
            pdfDoc.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files (*.pdf)|*.pdf", FileName = "SalesReport.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportSalesReportToPDF(sfd.FileName);
                    MessageBox.Show("PDF exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
