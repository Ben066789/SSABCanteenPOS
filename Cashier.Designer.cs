namespace SSA_B_Canteen
{
    partial class Cashier
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
            ItemList = new DataGridView();
            lblProductName = new Label();
            lblProductPrice = new Label();
            item = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxQuantity = new TextBox();
            pnlControls = new TableLayoutPanel();
            btnComplete = new CustomControls.RJControls.RJButton();
            txtBoxBarcode = new TextBox();
            lblItemTotal = new Label();
            label8 = new Label();
            label1 = new Label();
            lblFinalTotal = new Label();
            label9 = new Label();
            total = new Label();
            lblChange = new Label();
            txtBoxCash = new TextBox();
            mainPanel = new TableLayoutPanel();
            cancelCredit = new CustomControls.RJControls.RJButton();
            okCredit = new CustomControls.RJControls.RJButton();
            pnlCredit = new RoundedPanel();
            nameSearch = new TextBox();
            btnLogout = new CustomControls.RJControls.RJButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemList).BeginInit();
            pnlControls.SuspendLayout();
            mainPanel.SuspendLayout();
            pnlCredit.SuspendLayout();
            SuspendLayout();
            // 
            // ItemList
            // 
            ItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemList.Dock = DockStyle.Fill;
            ItemList.Location = new Point(3, 3);
            ItemList.Name = "ItemList";
            ItemList.ReadOnly = true;
            ItemList.RowHeadersVisible = false;
            ItemList.Size = new Size(696, 663);
            ItemList.TabIndex = 1;
            ItemList.TabStop = false;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.Blue;
            lblProductName.Location = new Point(3, 74);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(187, 28);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "productNameHere";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = Color.Blue;
            lblProductPrice.Location = new Point(3, 148);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(104, 28);
            lblProductPrice.TabIndex = 1;
            lblProductPrice.Text = "priceHere";
            // 
            // item
            // 
            item.AutoSize = true;
            item.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item.Location = new Point(3, 0);
            item.Name = "item";
            item.Size = new Size(49, 21);
            item.TabIndex = 1;
            item.Text = "Item:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 111);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 1;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 185);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 1;
            label5.Text = "Qty:";
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxQuantity.ForeColor = Color.Blue;
            txtBoxQuantity.Location = new Point(3, 225);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(175, 29);
            txtBoxQuantity.TabIndex = 2;
            // 
            // pnlControls
            // 
            pnlControls.ColumnCount = 1;
            pnlControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlControls.Controls.Add(btnComplete, 0, 16);
            pnlControls.Controls.Add(item, 0, 0);
            pnlControls.Controls.Add(txtBoxBarcode, 0, 1);
            pnlControls.Controls.Add(lblProductName, 0, 2);
            pnlControls.Controls.Add(lblItemTotal, 0, 8);
            pnlControls.Controls.Add(label8, 0, 11);
            pnlControls.Controls.Add(label1, 0, 7);
            pnlControls.Controls.Add(lblFinalTotal, 0, 10);
            pnlControls.Controls.Add(txtBoxQuantity, 0, 6);
            pnlControls.Controls.Add(label9, 0, 9);
            pnlControls.Controls.Add(lblProductPrice, 0, 4);
            pnlControls.Controls.Add(label4, 0, 3);
            pnlControls.Controls.Add(label5, 0, 5);
            pnlControls.Controls.Add(total, 0, 13);
            pnlControls.Controls.Add(lblChange, 0, 14);
            pnlControls.Controls.Add(txtBoxCash, 0, 12);
            pnlControls.Controls.Add(btnLogout, 0, 17);
            pnlControls.Dock = DockStyle.Fill;
            pnlControls.Location = new Point(705, 3);
            pnlControls.Name = "pnlControls";
            pnlControls.RowCount = 18;
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlControls.Size = new Size(279, 663);
            pnlControls.TabIndex = 6;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.MediumSlateBlue;
            btnComplete.BackgroundColor = Color.MediumSlateBlue;
            btnComplete.BorderColor = Color.PaleVioletRed;
            btnComplete.BorderRadius = 10;
            btnComplete.BorderSize = 0;
            btnComplete.FlatAppearance.BorderSize = 0;
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.ForeColor = Color.White;
            btnComplete.Location = new Point(3, 595);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(136, 30);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Confirm";
            btnComplete.TextColor = Color.White;
            btnComplete.UseVisualStyleBackColor = false;
            // 
            // txtBoxBarcode
            // 
            txtBoxBarcode.BackColor = SystemColors.Window;
            txtBoxBarcode.BorderStyle = BorderStyle.None;
            txtBoxBarcode.Location = new Point(3, 40);
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Size = new Size(273, 16);
            txtBoxBarcode.TabIndex = 0;
            // 
            // lblItemTotal
            // 
            lblItemTotal.AutoSize = true;
            lblItemTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTotal.ForeColor = Color.Blue;
            lblItemTotal.Location = new Point(3, 296);
            lblItemTotal.Name = "lblItemTotal";
            lblItemTotal.Size = new Size(104, 28);
            lblItemTotal.TabIndex = 1;
            lblItemTotal.Text = "priceHere";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 407);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 1;
            label8.Text = "Cash:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 259);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Item Total:";
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalTotal.ForeColor = Color.Blue;
            lblFinalTotal.Location = new Point(3, 370);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(104, 28);
            lblFinalTotal.TabIndex = 1;
            lblFinalTotal.Text = "totalPrice";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 333);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 1;
            label9.Text = "Total:";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(3, 481);
            total.Name = "total";
            total.Size = new Size(72, 21);
            total.TabIndex = 1;
            total.Text = "Change:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Blue;
            lblChange.Location = new Point(3, 518);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(127, 28);
            lblChange.TabIndex = 1;
            lblChange.Text = "totalChange";
            // 
            // txtBoxCash
            // 
            txtBoxCash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxCash.ForeColor = Color.Blue;
            txtBoxCash.Location = new Point(3, 447);
            txtBoxCash.Name = "txtBoxCash";
            txtBoxCash.Size = new Size(175, 29);
            txtBoxCash.TabIndex = 2;
            // 
            // mainPanel
            // 
            mainPanel.ColumnCount = 2;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.20253F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.7974682F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainPanel.Controls.Add(ItemList, 0, 0);
            mainPanel.Controls.Add(pnlControls, 1, 0);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.RowCount = 1;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainPanel.Size = new Size(987, 669);
            mainPanel.TabIndex = 5;
            // 
            // cancelCredit
            // 
            cancelCredit.BackColor = Color.MediumSlateBlue;
            cancelCredit.BackgroundColor = Color.MediumSlateBlue;
            cancelCredit.BorderColor = Color.PaleVioletRed;
            cancelCredit.BorderRadius = 10;
            cancelCredit.BorderSize = 0;
            cancelCredit.FlatAppearance.BorderSize = 0;
            cancelCredit.FlatStyle = FlatStyle.Flat;
            cancelCredit.ForeColor = Color.White;
            cancelCredit.Location = new Point(261, 98);
            cancelCredit.Name = "cancelCredit";
            cancelCredit.Size = new Size(105, 30);
            cancelCredit.TabIndex = 1;
            cancelCredit.Text = "Cancel";
            cancelCredit.TextColor = Color.White;
            cancelCredit.UseVisualStyleBackColor = false;
            // 
            // okCredit
            // 
            okCredit.BackColor = Color.MediumSlateBlue;
            okCredit.BackgroundColor = Color.MediumSlateBlue;
            okCredit.BorderColor = Color.PaleVioletRed;
            okCredit.BorderRadius = 10;
            okCredit.BorderSize = 0;
            okCredit.FlatAppearance.BorderSize = 0;
            okCredit.FlatStyle = FlatStyle.Flat;
            okCredit.ForeColor = Color.White;
            okCredit.Location = new Point(372, 98);
            okCredit.Name = "okCredit";
            okCredit.Size = new Size(105, 30);
            okCredit.TabIndex = 1;
            okCredit.Text = "OK";
            okCredit.TextColor = Color.White;
            okCredit.UseVisualStyleBackColor = false;
            okCredit.Click += okCredit_Click;
            // 
            // pnlCredit
            // 
            pnlCredit.BorderColor = Color.DarkGray;
            pnlCredit.BorderRadius = 20;
            pnlCredit.BorderSize = 7;
            pnlCredit.Controls.Add(label2);
            pnlCredit.Controls.Add(cancelCredit);
            pnlCredit.Controls.Add(okCredit);
            pnlCredit.Controls.Add(nameSearch);
            pnlCredit.Location = new Point(0, 0);
            pnlCredit.Name = "pnlCredit";
            pnlCredit.Size = new Size(502, 144);
            pnlCredit.TabIndex = 7;
            // 
            // nameSearch
            // 
            nameSearch.Font = new Font("Segoe UI", 14F);
            nameSearch.Location = new Point(24, 60);
            nameSearch.Name = "nameSearch";
            nameSearch.Size = new Size(453, 32);
            nameSearch.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumSlateBlue;
            btnLogout.BackgroundColor = Color.MediumSlateBlue;
            btnLogout.BorderColor = Color.PaleVioletRed;
            btnLogout.BorderRadius = 10;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(3, 632);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(136, 28);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.TextColor = Color.White;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(24, 24);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 2;
            label2.Text = "Credit";
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 669);
            Controls.Add(pnlCredit);
            Controls.Add(mainPanel);
            Name = "Cashier";
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)ItemList).EndInit();
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            mainPanel.ResumeLayout(false);
            pnlCredit.ResumeLayout(false);
            pnlCredit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ItemList;
        private Label lblProductName;
        private Label lblProductPrice;
        private Label item;
        private Label label4;
        private Label label5;
        private TextBox txtBoxQuantity;
        private Label label1;
        private TableLayoutPanel mainPanel;
        private TextBox txtBoxBarcode;
        private Label lblItemTotal;
        private TableLayoutPanel pnlControls;
        private CustomControls.RJControls.RJButton btnComplete;
        private Label label8;
        private Label lblFinalTotal;
        private Label label9;
        private Label total;
        private Label lblChange;
        private TextBox txtBoxCash;
        private CustomControls.RJControls.RJButton cancelCredit;
        private CustomControls.RJControls.RJButton okCredit;
        private RoundedPanel pnlCredit;
        private TextBox nameSearch;
        private CustomControls.RJControls.RJButton btnLogout;
        private Label label2;
    }
}