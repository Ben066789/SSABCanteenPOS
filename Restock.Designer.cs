namespace SSA_B_Canteen
{
    partial class Restock
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
            dgvToConfirm = new DataGridView();
            lblBrowse = new Label();
            dgvItems = new DataGridView();
            btnConfirm = new Button();
            txtBoxSearch = new TextBox();
            label1 = new Label();
            txtBoxQty = new TextBox();
            txtBoxPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtBoxCurrStock = new TextBox();
            txtBoxDateAdded = new TextBox();
            label4 = new Label();
            txtBoxCost = new TextBox();
            lblItemName = new Label();
            label6 = new Label();
            btnAdd = new Button();
            roundedPanelGrad1 = new RoundedPanelGrad();
            roundedPanelGrad2 = new RoundedPanelGrad();
            ((System.ComponentModel.ISupportInitialize)dgvToConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            roundedPanelGrad1.SuspendLayout();
            roundedPanelGrad2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvToConfirm
            // 
            dgvToConfirm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToConfirm.Location = new Point(15, 11);
            dgvToConfirm.Name = "dgvToConfirm";
            dgvToConfirm.ReadOnly = true;
            dgvToConfirm.RowHeadersVisible = false;
            dgvToConfirm.Size = new Size(529, 510);
            dgvToConfirm.TabIndex = 0;
            // 
            // lblBrowse
            // 
            lblBrowse.AutoSize = true;
            lblBrowse.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            lblBrowse.ForeColor = Color.DodgerBlue;
            lblBrowse.Location = new Point(12, 12);
            lblBrowse.Name = "lblBrowse";
            lblBrowse.Size = new Size(103, 28);
            lblBrowse.TabIndex = 3;
            lblBrowse.Text = "Restock";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(10, 11);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.Size = new Size(709, 282);
            dgvItems.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(396, 541);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(146, 35);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Font = new Font("Segoe UI", 12F);
            txtBoxSearch.Location = new Point(18, 50);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(217, 29);
            txtBoxSearch.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(11, 369);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 6;
            label1.Text = "Quantity";
            // 
            // txtBoxQty
            // 
            txtBoxQty.Font = new Font("Segoe UI", 12F);
            txtBoxQty.Location = new Point(11, 337);
            txtBoxQty.Name = "txtBoxQty";
            txtBoxQty.Size = new Size(187, 29);
            txtBoxQty.TabIndex = 7;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Font = new Font("Segoe UI", 12F);
            txtBoxPrice.Location = new Point(11, 459);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(187, 29);
            txtBoxPrice.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(12, 491);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 6;
            label2.Text = "Selling Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(240, 359);
            label3.Name = "label3";
            label3.Size = new Size(94, 16);
            label3.TabIndex = 6;
            label3.Text = "Current Stock";
            // 
            // txtBoxCurrStock
            // 
            txtBoxCurrStock.BackColor = Color.White;
            txtBoxCurrStock.BorderStyle = BorderStyle.None;
            txtBoxCurrStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxCurrStock.ForeColor = Color.DodgerBlue;
            txtBoxCurrStock.Location = new Point(240, 337);
            txtBoxCurrStock.Name = "txtBoxCurrStock";
            txtBoxCurrStock.ReadOnly = true;
            txtBoxCurrStock.Size = new Size(187, 22);
            txtBoxCurrStock.TabIndex = 7;
            // 
            // txtBoxDateAdded
            // 
            txtBoxDateAdded.BackColor = Color.White;
            txtBoxDateAdded.BorderStyle = BorderStyle.None;
            txtBoxDateAdded.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxDateAdded.ForeColor = Color.DodgerBlue;
            txtBoxDateAdded.Location = new Point(240, 389);
            txtBoxDateAdded.Name = "txtBoxDateAdded";
            txtBoxDateAdded.ReadOnly = true;
            txtBoxDateAdded.Size = new Size(187, 22);
            txtBoxDateAdded.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(11, 429);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 6;
            label4.Text = "Cost Price";
            // 
            // txtBoxCost
            // 
            txtBoxCost.Font = new Font("Segoe UI", 12F);
            txtBoxCost.Location = new Point(11, 397);
            txtBoxCost.Name = "txtBoxCost";
            txtBoxCost.Size = new Size(187, 29);
            txtBoxCost.TabIndex = 7;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.White;
            lblItemName.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblItemName.ForeColor = Color.DodgerBlue;
            lblItemName.Location = new Point(6, 305);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(88, 23);
            lblItemName.TabIndex = 3;
            lblItemName.Text = "Restock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(240, 410);
            label6.Name = "label6";
            label6.Size = new Size(86, 16);
            label6.TabIndex = 6;
            label6.Text = "Date Added";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(573, 541);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Confirm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // roundedPanelGrad1
            // 
            roundedPanelGrad1.BorderColor = Color.BlanchedAlmond;
            roundedPanelGrad1.BorderRadius = 10;
            roundedPanelGrad1.BorderSize = 1;
            roundedPanelGrad1.Controls.Add(dgvToConfirm);
            roundedPanelGrad1.Controls.Add(btnConfirm);
            roundedPanelGrad1.GradientAngle = 90F;
            roundedPanelGrad1.GradientColor1 = Color.White;
            roundedPanelGrad1.GradientColor2 = Color.White;
            roundedPanelGrad1.Location = new Point(771, 85);
            roundedPanelGrad1.Name = "roundedPanelGrad1";
            roundedPanelGrad1.Size = new Size(558, 586);
            roundedPanelGrad1.TabIndex = 8;
            // 
            // roundedPanelGrad2
            // 
            roundedPanelGrad2.BorderColor = Color.BlanchedAlmond;
            roundedPanelGrad2.BorderRadius = 10;
            roundedPanelGrad2.BorderSize = 1;
            roundedPanelGrad2.Controls.Add(lblItemName);
            roundedPanelGrad2.Controls.Add(txtBoxQty);
            roundedPanelGrad2.Controls.Add(txtBoxCost);
            roundedPanelGrad2.Controls.Add(txtBoxPrice);
            roundedPanelGrad2.Controls.Add(btnAdd);
            roundedPanelGrad2.Controls.Add(txtBoxCurrStock);
            roundedPanelGrad2.Controls.Add(txtBoxDateAdded);
            roundedPanelGrad2.Controls.Add(label1);
            roundedPanelGrad2.Controls.Add(label3);
            roundedPanelGrad2.Controls.Add(label4);
            roundedPanelGrad2.Controls.Add(label6);
            roundedPanelGrad2.Controls.Add(label2);
            roundedPanelGrad2.Controls.Add(dgvItems);
            roundedPanelGrad2.GradientAngle = 90F;
            roundedPanelGrad2.GradientColor1 = Color.White;
            roundedPanelGrad2.GradientColor2 = Color.White;
            roundedPanelGrad2.Location = new Point(12, 85);
            roundedPanelGrad2.Name = "roundedPanelGrad2";
            roundedPanelGrad2.Size = new Size(734, 586);
            roundedPanelGrad2.TabIndex = 8;
            // 
            // Restock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 683);
            Controls.Add(roundedPanelGrad2);
            Controls.Add(txtBoxSearch);
            Controls.Add(lblBrowse);
            Controls.Add(roundedPanelGrad1);
            Name = "Restock";
            Text = "Restock";
            ((System.ComponentModel.ISupportInitialize)dgvToConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            roundedPanelGrad1.ResumeLayout(false);
            roundedPanelGrad2.ResumeLayout(false);
            roundedPanelGrad2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvToConfirm;
        private Label lblBrowse;
        private DataGridView dgvItems;
        private Button btnConfirm;
        private TextBox txtBoxSearch;
        private Label label1;
        private TextBox txtBoxQty;
        private TextBox txtBoxPrice;
        private Label label2;
        private Label label3;
        private TextBox txtBoxCurrStock;
        private TextBox txtBoxDateAdded;
        private Label label4;
        private TextBox txtBoxCost;
        private Label lblItemName;
        private Label label6;
        private Button btnAdd;
        private RoundedPanelGrad roundedPanelGrad1;
        private RoundedPanelGrad roundedPanelGrad2;
    }
}