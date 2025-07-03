namespace SSA_B_Canteen
{
    partial class SalesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSales = new DataGridView();
            btnExport = new Button();
            fromDate = new DateTimePicker();
            toDate = new DateTimePicker();
            btnGo = new Button();
            lblTotalSum = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(444, 59);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersVisible = false;
            dgvSales.Size = new Size(763, 383);
            dgvSales.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(649, 24);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // fromDate
            // 
            fromDate.Location = new Point(730, 24);
            fromDate.Name = "fromDate";
            fromDate.Size = new Size(200, 23);
            fromDate.TabIndex = 3;
            // 
            // toDate
            // 
            toDate.Location = new Point(936, 24);
            toDate.Name = "toDate";
            toDate.Size = new Size(200, 23);
            toDate.TabIndex = 3;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(1142, 22);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(59, 25);
            btnGo.TabIndex = 4;
            btnGo.Text = "button1";
            btnGo.UseVisualStyleBackColor = true;
            // 
            // lblTotalSum
            // 
            lblTotalSum.AutoSize = true;
            lblTotalSum.Font = new Font("Century Gothic", 25F, FontStyle.Bold);
            lblTotalSum.ForeColor = Color.RoyalBlue;
            lblTotalSum.Location = new Point(936, 457);
            lblTotalSum.Name = "lblTotalSum";
            lblTotalSum.Size = new Size(93, 40);
            lblTotalSum.TabIndex = 5;
            lblTotalSum.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(64, 64, 64);
            lblTotal.Location = new Point(877, 471);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(67, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total: ";
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 518);
            Controls.Add(lblTotalSum);
            Controls.Add(lblTotal);
            Controls.Add(btnGo);
            Controls.Add(toDate);
            Controls.Add(fromDate);
            Controls.Add(btnExport);
            Controls.Add(dgvSales);
            Name = "SalesReport";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSales;
        private Button btnExport;
        private DateTimePicker fromDate;
        private DateTimePicker toDate;
        private Button btnGo;
        private Label lblTotalSum;
        private Label lblTotal;
    }
}