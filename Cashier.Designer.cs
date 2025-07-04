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
            pnlControls = new TableLayoutPanel();
            txtBoxBarcode = new TextBox();
            btnLogout = new CustomControls.RJControls.RJButton();
            label1 = new Label();
            lblItemTotal = new Label();
            label9 = new Label();
            lblFinalTotal = new Label();
            label8 = new Label();
            txtBoxCash = new TextBox();
            btnBrowseItems = new CustomControls.RJControls.RJButton();
            label3 = new Label();
            label5 = new Label();
            lblChange = new Label();
            total = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn10 = new Button();
            btn20 = new Button();
            btn50 = new Button();
            btn1000 = new Button();
            btn500 = new Button();
            btn200 = new Button();
            btn100 = new Button();
            chkSMode = new CheckBox();
            mainPanel = new TableLayoutPanel();
            cancelCredit = new CustomControls.RJControls.RJButton();
            okCredit = new CustomControls.RJControls.RJButton();
            pnlCredit = new RoundedPanel();
            label2 = new Label();
            nameSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ItemList).BeginInit();
            pnlControls.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            ItemList.RowHeadersVisible = false;
            ItemList.Size = new Size(683, 663);
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
            lblProductName.Size = new Size(117, 28);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Item Name";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = Color.Blue;
            lblProductPrice.Location = new Point(3, 149);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(59, 28);
            lblProductPrice.TabIndex = 1;
            lblProductPrice.Text = "Price";
            // 
            // item
            // 
            item.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            item.AutoSize = true;
            item.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item.Location = new Point(3, 16);
            item.Name = "item";
            item.Size = new Size(76, 21);
            item.TabIndex = 1;
            item.Text = "Barcode:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 128);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 1;
            label4.Text = "Price:";
            // 
            // pnlControls
            // 
            pnlControls.ColumnCount = 2;
            pnlControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            pnlControls.Controls.Add(item, 0, 0);
            pnlControls.Controls.Add(txtBoxBarcode, 0, 1);
            pnlControls.Controls.Add(lblProductName, 0, 2);
            pnlControls.Controls.Add(lblProductPrice, 0, 4);
            pnlControls.Controls.Add(label4, 0, 3);
            pnlControls.Controls.Add(btnLogout, 0, 17);
            pnlControls.Controls.Add(label1, 0, 5);
            pnlControls.Controls.Add(lblItemTotal, 0, 6);
            pnlControls.Controls.Add(label9, 0, 8);
            pnlControls.Controls.Add(lblFinalTotal, 0, 9);
            pnlControls.Controls.Add(label8, 0, 10);
            pnlControls.Controls.Add(txtBoxCash, 0, 11);
            pnlControls.Controls.Add(btnBrowseItems, 0, 16);
            pnlControls.Controls.Add(label3, 1, 1);
            pnlControls.Controls.Add(label5, 1, 11);
            pnlControls.Controls.Add(lblChange, 0, 14);
            pnlControls.Controls.Add(total, 0, 13);
            pnlControls.Controls.Add(tableLayoutPanel1, 0, 12);
            pnlControls.Dock = DockStyle.Fill;
            pnlControls.Location = new Point(692, 3);
            pnlControls.Name = "pnlControls";
            pnlControls.RowCount = 18;
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.095238F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 3.80952382F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.362776F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 4.57413244F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 6.466877F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 2.83911681F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 3.94321775F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.362776F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 3.4700315F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.82677174F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4330711F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 6.929134F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 4.72440958F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            pnlControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlControls.Size = new Size(292, 663);
            pnlControls.TabIndex = 6;
            // 
            // txtBoxBarcode
            // 
            txtBoxBarcode.BackColor = SystemColors.Control;
            txtBoxBarcode.BorderStyle = BorderStyle.None;
            txtBoxBarcode.Location = new Point(3, 40);
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Size = new Size(197, 16);
            txtBoxBarcode.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.BackColor = Color.DodgerBlue;
            btnLogout.BackgroundColor = Color.DodgerBlue;
            btnLogout.BorderColor = Color.PaleVioletRed;
            btnLogout.BorderRadius = 10;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(3, 638);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(236, 22);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.TextColor = Color.White;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 191);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Item Total:";
            // 
            // lblItemTotal
            // 
            lblItemTotal.AutoSize = true;
            lblItemTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTotal.ForeColor = Color.Blue;
            lblItemTotal.Location = new Point(3, 212);
            lblItemTotal.Name = "lblItemTotal";
            lblItemTotal.Size = new Size(108, 28);
            lblItemTotal.TabIndex = 1;
            lblItemTotal.Text = "Item Total";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 275);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 1;
            label9.Text = "Total:";
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalTotal.ForeColor = Color.Blue;
            lblFinalTotal.Location = new Point(3, 296);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(59, 28);
            lblFinalTotal.TabIndex = 1;
            lblFinalTotal.Text = "Total";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 331);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 1;
            label8.Text = "Cash:";
            // 
            // txtBoxCash
            // 
            txtBoxCash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxCash.ForeColor = Color.Blue;
            txtBoxCash.Location = new Point(3, 355);
            txtBoxCash.Name = "txtBoxCash";
            txtBoxCash.Size = new Size(175, 29);
            txtBoxCash.TabIndex = 2;
            // 
            // btnBrowseItems
            // 
            btnBrowseItems.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBrowseItems.BackColor = Color.DodgerBlue;
            btnBrowseItems.BackgroundColor = Color.DodgerBlue;
            btnBrowseItems.BorderColor = Color.PaleVioletRed;
            btnBrowseItems.BorderRadius = 10;
            btnBrowseItems.BorderSize = 0;
            btnBrowseItems.FlatAppearance.BorderSize = 0;
            btnBrowseItems.FlatStyle = FlatStyle.Flat;
            btnBrowseItems.ForeColor = Color.White;
            btnBrowseItems.Location = new Point(3, 602);
            btnBrowseItems.Name = "btnBrowseItems";
            btnBrowseItems.Size = new Size(236, 28);
            btnBrowseItems.TabIndex = 3;
            btnBrowseItems.Text = "Browse Items";
            btnBrowseItems.TextColor = Color.White;
            btnBrowseItems.UseVisualStyleBackColor = false;
            btnBrowseItems.Click += btnBrowseItems_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(248, 45);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 4;
            label3.Text = "[F2]";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(251, 360);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 4;
            label5.Text = "[+]";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblChange.ForeColor = Color.Green;
            lblChange.Location = new Point(3, 524);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(214, 44);
            lblChange.TabIndex = 1;
            lblChange.Text = "totalChange";
            // 
            // total
            // 
            total.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(3, 503);
            total.Name = "total";
            total.Size = new Size(72, 21);
            total.TabIndex = 1;
            total.Text = "Change:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn10, 0, 0);
            tableLayoutPanel1.Controls.Add(btn20, 1, 0);
            tableLayoutPanel1.Controls.Add(btn50, 2, 0);
            tableLayoutPanel1.Controls.Add(btn1000, 3, 1);
            tableLayoutPanel1.Controls.Add(btn500, 2, 1);
            tableLayoutPanel1.Controls.Add(btn200, 1, 1);
            tableLayoutPanel1.Controls.Add(btn100, 0, 1);
            tableLayoutPanel1.Controls.Add(chkSMode, 3, 0);
            tableLayoutPanel1.Location = new Point(3, 392);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(236, 92);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btn10
            // 
            btn10.Anchor = AnchorStyles.None;
            btn10.Font = new Font("Segoe UI", 8F);
            btn10.Location = new Point(3, 3);
            btn10.Name = "btn10";
            btn10.Size = new Size(53, 40);
            btn10.TabIndex = 0;
            btn10.Text = "10 [Insert]";
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            btn20.Anchor = AnchorStyles.None;
            btn20.Font = new Font("Segoe UI", 8F);
            btn20.Location = new Point(62, 3);
            btn20.Name = "btn20";
            btn20.RightToLeft = RightToLeft.No;
            btn20.Size = new Size(53, 40);
            btn20.TabIndex = 0;
            btn20.Text = "20 [End]";
            btn20.UseVisualStyleBackColor = true;
            // 
            // btn50
            // 
            btn50.Anchor = AnchorStyles.None;
            btn50.Font = new Font("Segoe UI", 8F);
            btn50.Location = new Point(121, 3);
            btn50.Name = "btn50";
            btn50.Size = new Size(53, 40);
            btn50.TabIndex = 0;
            btn50.Text = "50 [PgUp]";
            btn50.UseVisualStyleBackColor = true;
            // 
            // btn1000
            // 
            btn1000.Anchor = AnchorStyles.None;
            btn1000.Location = new Point(180, 49);
            btn1000.Name = "btn1000";
            btn1000.Size = new Size(53, 40);
            btn1000.TabIndex = 0;
            btn1000.Text = "1000 [Up]";
            btn1000.UseVisualStyleBackColor = true;
            // 
            // btn500
            // 
            btn500.Anchor = AnchorStyles.None;
            btn500.Location = new Point(121, 49);
            btn500.Name = "btn500";
            btn500.Size = new Size(53, 40);
            btn500.TabIndex = 0;
            btn500.Text = "500 [PgDn]";
            btn500.UseVisualStyleBackColor = true;
            // 
            // btn200
            // 
            btn200.Anchor = AnchorStyles.None;
            btn200.Font = new Font("Segoe UI", 8F);
            btn200.Location = new Point(62, 49);
            btn200.Name = "btn200";
            btn200.Size = new Size(53, 40);
            btn200.TabIndex = 0;
            btn200.Text = "200 [Home]";
            btn200.UseVisualStyleBackColor = true;
            // 
            // btn100
            // 
            btn100.Anchor = AnchorStyles.None;
            btn100.Location = new Point(3, 49);
            btn100.Name = "btn100";
            btn100.Size = new Size(53, 40);
            btn100.TabIndex = 0;
            btn100.Text = "100 [Del]";
            btn100.UseVisualStyleBackColor = true;
            // 
            // chkSMode
            // 
            chkSMode.AutoSize = true;
            chkSMode.Location = new Point(180, 3);
            chkSMode.Name = "chkSMode";
            chkSMode.Size = new Size(53, 19);
            chkSMode.TabIndex = 1;
            chkSMode.Text = "checkBox1";
            chkSMode.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.ColumnCount = 2;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.8074951F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.192503F));
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
            // nameSearch
            // 
            nameSearch.Font = new Font("Segoe UI", 14F);
            nameSearch.Location = new Point(24, 60);
            nameSearch.Name = "nameSearch";
            nameSearch.Size = new Size(453, 32);
            nameSearch.TabIndex = 0;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel mainPanel;
        private TextBox txtBoxBarcode;
        private Label lblItemTotal;
        private TableLayoutPanel pnlControls;
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
        private Label label1;
        private CustomControls.RJControls.RJButton btnBrowseItems;
        private Label label3;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn10;
        private Button btn20;
        private Button btn50;
        private Button btn100;
        private Button btn200;
        private Button btn500;
        private Button btn1000;
        private CheckBox chkSMode;
    }
}