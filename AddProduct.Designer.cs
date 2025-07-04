namespace SSA_B_Canteen
{
    partial class AddProduct
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
            txtBoxQuantity = new CustomControls.RJControls.RJTextBox();
            barcode = new Label();
            txtBoxName = new CustomControls.RJControls.RJTextBox();
            txtBoxBarcode = new CustomControls.RJControls.RJTextBox();
            panel1 = new Panel();
            btnGenBarcode = new CustomControls.RJControls.RJButton();
            btnAdd = new CustomControls.RJControls.RJButton();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtBoxPrice = new CustomControls.RJControls.RJTextBox();
            txtBoxCostPrice = new CustomControls.RJControls.RJTextBox();
            btnConfirm = new CustomControls.RJControls.RJButton();
            ListProducts = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListProducts).BeginInit();
            SuspendLayout();
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.BackColor = SystemColors.Window;
            txtBoxQuantity.BorderColor = Color.DodgerBlue;
            txtBoxQuantity.BorderFocusColor = Color.CornflowerBlue;
            txtBoxQuantity.BorderRadius = 5;
            txtBoxQuantity.BorderSize = 2;
            txtBoxQuantity.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxQuantity.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxQuantity.Location = new Point(15, 191);
            txtBoxQuantity.Margin = new Padding(4);
            txtBoxQuantity.Multiline = false;
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Padding = new Padding(10, 7, 10, 7);
            txtBoxQuantity.PasswordChar = false;
            txtBoxQuantity.PlaceholderColor = Color.DarkGray;
            txtBoxQuantity.PlaceholderText = "";
            txtBoxQuantity.Size = new Size(235, 31);
            txtBoxQuantity.TabIndex = 2;
            txtBoxQuantity.Texts = "";
            txtBoxQuantity.UnderlinedStyle = false;
            // 
            // barcode
            // 
            barcode.AutoSize = true;
            barcode.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            barcode.ForeColor = SystemColors.ControlDarkDark;
            barcode.Location = new Point(15, 52);
            barcode.Name = "barcode";
            barcode.Size = new Size(58, 16);
            barcode.TabIndex = 10;
            barcode.Text = "Barcode";
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = SystemColors.Window;
            txtBoxName.BorderColor = Color.DodgerBlue;
            txtBoxName.BorderFocusColor = Color.CornflowerBlue;
            txtBoxName.BorderRadius = 5;
            txtBoxName.BorderSize = 2;
            txtBoxName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxName.Location = new Point(15, 131);
            txtBoxName.Margin = new Padding(4);
            txtBoxName.Multiline = false;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Padding = new Padding(10, 7, 10, 7);
            txtBoxName.PasswordChar = false;
            txtBoxName.PlaceholderColor = Color.DarkGray;
            txtBoxName.PlaceholderText = "";
            txtBoxName.Size = new Size(235, 31);
            txtBoxName.TabIndex = 1;
            txtBoxName.Texts = "";
            txtBoxName.UnderlinedStyle = false;
            // 
            // txtBoxBarcode
            // 
            txtBoxBarcode.BackColor = SystemColors.Window;
            txtBoxBarcode.BorderColor = Color.White;
            txtBoxBarcode.BorderFocusColor = Color.White;
            txtBoxBarcode.BorderRadius = 5;
            txtBoxBarcode.BorderSize = 2;
            txtBoxBarcode.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBarcode.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxBarcode.Location = new Point(15, 72);
            txtBoxBarcode.Margin = new Padding(4);
            txtBoxBarcode.Multiline = false;
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Padding = new Padding(10, 7, 10, 7);
            txtBoxBarcode.PasswordChar = false;
            txtBoxBarcode.PlaceholderColor = Color.DarkGray;
            txtBoxBarcode.PlaceholderText = "";
            txtBoxBarcode.Size = new Size(128, 31);
            txtBoxBarcode.TabIndex = 0;
            txtBoxBarcode.Texts = "";
            txtBoxBarcode.UnderlinedStyle = false;
            txtBoxBarcode._TextChanged += txtBoxBarcode__TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(btnGenBarcode);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(barcode);
            panel1.Controls.Add(txtBoxPrice);
            panel1.Controls.Add(txtBoxCostPrice);
            panel1.Controls.Add(txtBoxQuantity);
            panel1.Controls.Add(txtBoxName);
            panel1.Controls.Add(txtBoxBarcode);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 471);
            panel1.TabIndex = 0;
            // 
            // btnGenBarcode
            // 
            btnGenBarcode.BackColor = Color.DodgerBlue;
            btnGenBarcode.BackgroundColor = Color.DodgerBlue;
            btnGenBarcode.BorderColor = Color.DarkGray;
            btnGenBarcode.BorderRadius = 10;
            btnGenBarcode.BorderSize = 0;
            btnGenBarcode.FlatAppearance.BorderSize = 0;
            btnGenBarcode.FlatStyle = FlatStyle.Flat;
            btnGenBarcode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenBarcode.ForeColor = Color.White;
            btnGenBarcode.Location = new Point(15, 353);
            btnGenBarcode.Name = "btnGenBarcode";
            btnGenBarcode.Size = new Size(121, 32);
            btnGenBarcode.TabIndex = 6;
            btnGenBarcode.TabStop = false;
            btnGenBarcode.Text = "Generate Barcode";
            btnGenBarcode.TextColor = Color.White;
            btnGenBarcode.UseVisualStyleBackColor = false;
            btnGenBarcode.Click += btnGenBarcode_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.BackgroundColor = Color.DodgerBlue;
            btnAdd.BorderColor = Color.White;
            btnAdd.BorderRadius = 10;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(15, 14);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 10;
            label2.Text = "Add Item";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(15, 231);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 1;
            label5.Text = "Cost Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(15, 291);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 1;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(15, 171);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 1;
            label3.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(15, 111);
            label1.Name = "label1";
            label1.Size = new Size(43, 16);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.BackColor = SystemColors.Window;
            txtBoxPrice.BorderColor = Color.DodgerBlue;
            txtBoxPrice.BorderFocusColor = Color.CornflowerBlue;
            txtBoxPrice.BorderRadius = 5;
            txtBoxPrice.BorderSize = 2;
            txtBoxPrice.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPrice.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxPrice.Location = new Point(15, 310);
            txtBoxPrice.Margin = new Padding(4);
            txtBoxPrice.Multiline = false;
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Padding = new Padding(10, 7, 10, 7);
            txtBoxPrice.PasswordChar = false;
            txtBoxPrice.PlaceholderColor = Color.DarkGray;
            txtBoxPrice.PlaceholderText = "";
            txtBoxPrice.Size = new Size(142, 31);
            txtBoxPrice.TabIndex = 4;
            txtBoxPrice.Texts = "";
            txtBoxPrice.UnderlinedStyle = false;
            // 
            // txtBoxCostPrice
            // 
            txtBoxCostPrice.BackColor = SystemColors.Window;
            txtBoxCostPrice.BorderColor = Color.DodgerBlue;
            txtBoxCostPrice.BorderFocusColor = Color.CornflowerBlue;
            txtBoxCostPrice.BorderRadius = 5;
            txtBoxCostPrice.BorderSize = 2;
            txtBoxCostPrice.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCostPrice.ForeColor = Color.FromArgb(64, 64, 64);
            txtBoxCostPrice.Location = new Point(15, 251);
            txtBoxCostPrice.Margin = new Padding(4);
            txtBoxCostPrice.Multiline = false;
            txtBoxCostPrice.Name = "txtBoxCostPrice";
            txtBoxCostPrice.Padding = new Padding(10, 7, 10, 7);
            txtBoxCostPrice.PasswordChar = false;
            txtBoxCostPrice.PlaceholderColor = Color.DarkGray;
            txtBoxCostPrice.PlaceholderText = "";
            txtBoxCostPrice.Size = new Size(142, 31);
            txtBoxCostPrice.TabIndex = 3;
            txtBoxCostPrice.Texts = "";
            txtBoxCostPrice.UnderlinedStyle = false;
            // 
            // btnConfirm
            // 
            btnConfirm.AutoSize = true;
            btnConfirm.BackColor = Color.DodgerBlue;
            btnConfirm.BackgroundColor = Color.DodgerBlue;
            btnConfirm.BorderColor = Color.White;
            btnConfirm.BorderRadius = 10;
            btnConfirm.BorderSize = 0;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(857, 415);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(135, 32);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextColor = Color.White;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // ListProducts
            // 
            ListProducts.Location = new Point(273, 12);
            ListProducts.Name = "ListProducts";
            ListProducts.RowHeadersVisible = false;
            ListProducts.Size = new Size(728, 446);
            ListProducts.TabIndex = 8;
            ListProducts.TabStop = false;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1013, 470);
            Controls.Add(btnConfirm);
            Controls.Add(ListProducts);
            Controls.Add(panel1);
            Name = "AddProduct";
            Text = "Item Entry";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView listProducts;
        private CustomControls.RJControls.RJTextBox txtBoxQuantity;
        private Label barcode;
        private CustomControls.RJControls.RJTextBox txtBoxName;
        private CustomControls.RJControls.RJTextBox txtBoxBarcode;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton btnConfirm;
        private CustomControls.RJControls.RJButton btnGenBarcode;
        private Label label4;
        private CustomControls.RJControls.RJTextBox txtBoxCostPrice;
        private Label label5;
        private CustomControls.RJControls.RJTextBox txtBoxPrice;
        private DataGridView ListProducts;
    }
}