namespace SSA_B_Canteen
{
    partial class AdminDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAccMgr = new CustomControls.RJControls.RJButton();
            dgvSales = new DataGridView();
            lblTotal = new Label();
            lblTotalSum = new Label();
            roundedPanel1 = new RoundedPanel();
            btnAllItems = new CustomControls.RJControls.RJButton();
            btnRestock = new CustomControls.RJControls.RJButton();
            btnInventoryEntry = new CustomControls.RJControls.RJButton();
            label1 = new Label();
            roundedPanelGrad1 = new RoundedPanelGrad();
            rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanelGrad1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAccMgr
            // 
            btnAccMgr.BackColor = Color.CornflowerBlue;
            btnAccMgr.BackgroundColor = Color.CornflowerBlue;
            btnAccMgr.BorderColor = Color.White;
            btnAccMgr.BorderRadius = 10;
            btnAccMgr.BorderSize = 0;
            btnAccMgr.FlatAppearance.BorderSize = 0;
            btnAccMgr.FlatStyle = FlatStyle.Flat;
            btnAccMgr.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccMgr.ForeColor = Color.White;
            btnAccMgr.Location = new Point(242, 20);
            btnAccMgr.Name = "btnAccMgr";
            btnAccMgr.Size = new Size(174, 46);
            btnAccMgr.TabIndex = 1;
            btnAccMgr.Text = "Account Manager";
            btnAccMgr.TextColor = Color.White;
            btnAccMgr.UseVisualStyleBackColor = false;
            btnAccMgr.Click += btnAccMgr_Click;
            // 
            // dgvSales
            // 
            dgvSales.BackgroundColor = SystemColors.ButtonFace;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.GridColor = Color.Gainsboro;
            dgvSales.Location = new Point(242, 72);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersVisible = false;
            dgvSales.Size = new Size(942, 374);
            dgvSales.TabIndex = 2;
            dgvSales.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(64, 64, 64);
            lblTotal.Location = new Point(841, 472);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(67, 23);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: ";
            // 
            // lblTotalSum
            // 
            lblTotalSum.AutoSize = true;
            lblTotalSum.Font = new Font("Century Gothic", 25F, FontStyle.Bold);
            lblTotalSum.ForeColor = Color.RoyalBlue;
            lblTotalSum.Location = new Point(900, 458);
            lblTotalSum.Name = "lblTotalSum";
            lblTotalSum.Size = new Size(93, 40);
            lblTotalSum.TabIndex = 3;
            lblTotalSum.Text = "Total";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.BorderRadius = 5;
            roundedPanel1.BorderSize = 7;
            roundedPanel1.Controls.Add(btnAllItems);
            roundedPanel1.Controls.Add(btnRestock);
            roundedPanel1.Controls.Add(btnInventoryEntry);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.Location = new Point(8, 25);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(207, 197);
            roundedPanel1.TabIndex = 4;
            // 
            // btnAllItems
            // 
            btnAllItems.BackColor = Color.CornflowerBlue;
            btnAllItems.BackgroundColor = Color.CornflowerBlue;
            btnAllItems.BorderColor = Color.White;
            btnAllItems.BorderRadius = 10;
            btnAllItems.BorderSize = 0;
            btnAllItems.FlatAppearance.BorderSize = 0;
            btnAllItems.FlatStyle = FlatStyle.Flat;
            btnAllItems.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            btnAllItems.ForeColor = Color.White;
            btnAllItems.Location = new Point(17, 26);
            btnAllItems.Name = "btnAllItems";
            btnAllItems.Size = new Size(172, 46);
            btnAllItems.TabIndex = 1;
            btnAllItems.Text = "Browse";
            btnAllItems.TextColor = Color.White;
            btnAllItems.UseVisualStyleBackColor = false;
            btnAllItems.Click += btnAllItems_Click;
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.CornflowerBlue;
            btnRestock.BackgroundColor = Color.CornflowerBlue;
            btnRestock.BorderColor = Color.White;
            btnRestock.BorderRadius = 10;
            btnRestock.BorderSize = 0;
            btnRestock.FlatAppearance.BorderSize = 0;
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            btnRestock.ForeColor = Color.White;
            btnRestock.Location = new Point(17, 130);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(172, 46);
            btnRestock.TabIndex = 1;
            btnRestock.Text = "Restock";
            btnRestock.TextColor = Color.White;
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // btnInventoryEntry
            // 
            btnInventoryEntry.BackColor = Color.CornflowerBlue;
            btnInventoryEntry.BackgroundColor = Color.CornflowerBlue;
            btnInventoryEntry.BorderColor = Color.White;
            btnInventoryEntry.BorderRadius = 10;
            btnInventoryEntry.BorderSize = 0;
            btnInventoryEntry.FlatAppearance.BorderSize = 0;
            btnInventoryEntry.FlatStyle = FlatStyle.Flat;
            btnInventoryEntry.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            btnInventoryEntry.ForeColor = Color.White;
            btnInventoryEntry.Location = new Point(17, 78);
            btnInventoryEntry.Name = "btnInventoryEntry";
            btnInventoryEntry.Size = new Size(172, 46);
            btnInventoryEntry.TabIndex = 1;
            btnInventoryEntry.Text = "Entry";
            btnInventoryEntry.TextColor = Color.White;
            btnInventoryEntry.UseVisualStyleBackColor = false;
            btnInventoryEntry.Click += btnAddProducts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 5;
            label1.Text = "Inventory";
            // 
            // roundedPanelGrad1
            // 
            roundedPanelGrad1.BorderColor = Color.White;
            roundedPanelGrad1.BorderRadius = 10;
            roundedPanelGrad1.BorderSize = 1;
            roundedPanelGrad1.Controls.Add(label1);
            roundedPanelGrad1.Controls.Add(rjButton1);
            roundedPanelGrad1.Controls.Add(roundedPanel1);
            roundedPanelGrad1.GradientAngle = 120F;
            roundedPanelGrad1.GradientColor1 = Color.White;
            roundedPanelGrad1.GradientColor2 = SystemColors.ActiveCaption;
            roundedPanelGrad1.Location = new Point(12, 72);
            roundedPanelGrad1.Name = "roundedPanelGrad1";
            roundedPanelGrad1.Size = new Size(220, 374);
            roundedPanelGrad1.TabIndex = 6;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.CornflowerBlue;
            rjButton1.BackgroundColor = Color.CornflowerBlue;
            rjButton1.BorderColor = Color.White;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(25, 250);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(172, 46);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "Restock";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnRestock_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 518);
            Controls.Add(lblTotalSum);
            Controls.Add(roundedPanelGrad1);
            Controls.Add(btnAccMgr);
            Controls.Add(lblTotal);
            Controls.Add(dgvSales);
            ForeColor = Color.FromArgb(64, 64, 64);
            Name = "AdminDashboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanelGrad1.ResumeLayout(false);
            roundedPanelGrad1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.RJControls.RJButton btnAccMgr;
        private DataGridView dgvSales;
        private Label lblTotal;
        private Label lblTotalSum;
        private RoundedPanel roundedPanel1;
        private Label label1;
        private CustomControls.RJControls.RJButton btnAllItems;
        private CustomControls.RJControls.RJButton btnInventoryEntry;
        private RoundedPanelGrad roundedPanelGrad1;
        private CustomControls.RJControls.RJButton btnRestock;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}
