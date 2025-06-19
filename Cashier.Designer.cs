namespace SSA_B_Canteen.Cashier
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxQuantity = new TextBox();
            panelItem = new Panel();
            txtBoxBarcode = new TextBox();
            lblItemTotal = new Label();
            label1 = new Label();
            label6 = new Label();
            lblFinalTotal = new Label();
            txtBoxCash = new TextBox();
            label8 = new Label();
            label9 = new Label();
            lblChange = new Label();
            panelTotal = new Panel();
            btnComplete = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)ItemList).BeginInit();
            panelItem.SuspendLayout();
            panelTotal.SuspendLayout();
            SuspendLayout();
            // 
            // ItemList
            // 
            ItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemList.Location = new Point(15, 25);
            ItemList.Name = "ItemList";
            ItemList.ReadOnly = true;
            ItemList.RowHeadersVisible = false;
            ItemList.Size = new Size(579, 522);
            ItemList.TabIndex = 0;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.Blue;
            lblProductName.Location = new Point(3, 46);
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
            lblProductPrice.Location = new Point(3, 106);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(104, 28);
            lblProductPrice.TabIndex = 1;
            lblProductPrice.Text = "priceHere";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 1;
            label3.Text = "Item:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 85);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 1;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 149);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 1;
            label5.Text = "Qty:";
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxQuantity.ForeColor = Color.Blue;
            txtBoxQuantity.Location = new Point(3, 173);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.Size = new Size(175, 29);
            txtBoxQuantity.TabIndex = 2;
            // 
            // panelItem
            // 
            panelItem.Controls.Add(txtBoxBarcode);
            panelItem.Controls.Add(lblProductName);
            panelItem.Controls.Add(lblItemTotal);
            panelItem.Controls.Add(lblProductPrice);
            panelItem.Controls.Add(txtBoxQuantity);
            panelItem.Controls.Add(label1);
            panelItem.Controls.Add(label5);
            panelItem.Controls.Add(label3);
            panelItem.Controls.Add(label4);
            panelItem.Location = new Point(597, 22);
            panelItem.Name = "panelItem";
            panelItem.Size = new Size(258, 266);
            panelItem.TabIndex = 3;
            // 
            // txtBoxBarcode
            // 
            txtBoxBarcode.BackColor = SystemColors.Window;
            txtBoxBarcode.Location = new Point(3, 3);
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Size = new Size(187, 23);
            txtBoxBarcode.TabIndex = 0;
            // 
            // lblItemTotal
            // 
            lblItemTotal.AutoSize = true;
            lblItemTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTotal.ForeColor = Color.Blue;
            lblItemTotal.Location = new Point(3, 226);
            lblItemTotal.Name = "lblItemTotal";
            lblItemTotal.Size = new Size(104, 28);
            lblItemTotal.TabIndex = 1;
            lblItemTotal.Text = "priceHere";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 205);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Item Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 1;
            label6.Text = "Total:";
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalTotal.ForeColor = Color.Blue;
            lblFinalTotal.Location = new Point(3, 27);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(104, 28);
            lblFinalTotal.TabIndex = 1;
            lblFinalTotal.Text = "totalPrice";
            // 
            // txtBoxCash
            // 
            txtBoxCash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxCash.ForeColor = Color.Blue;
            txtBoxCash.Location = new Point(3, 92);
            txtBoxCash.Name = "txtBoxCash";
            txtBoxCash.Size = new Size(175, 29);
            txtBoxCash.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 68);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 1;
            label8.Text = "Cash:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 128);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 1;
            label9.Text = "Total:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Blue;
            lblChange.Location = new Point(3, 149);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(127, 28);
            lblChange.TabIndex = 1;
            lblChange.Text = "totalChange";
            // 
            // panelTotal
            // 
            panelTotal.Controls.Add(btnComplete);
            panelTotal.Controls.Add(lblFinalTotal);
            panelTotal.Controls.Add(label8);
            panelTotal.Controls.Add(label6);
            panelTotal.Controls.Add(lblChange);
            panelTotal.Controls.Add(txtBoxCash);
            panelTotal.Controls.Add(label9);
            panelTotal.Location = new Point(597, 294);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(258, 250);
            panelTotal.TabIndex = 4;
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
            btnComplete.Location = new Point(3, 195);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(150, 40);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Confirm";
            btnComplete.TextColor = Color.White;
            btnComplete.UseVisualStyleBackColor = false;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 556);
            Controls.Add(panelItem);
            Controls.Add(ItemList);
            Controls.Add(panelTotal);
            Name = "Cashier";
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)ItemList).EndInit();
            panelItem.ResumeLayout(false);
            panelItem.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ItemList;
        private Label lblProductName;
        private Label lblProductPrice;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxQuantity;
        private Panel panelItem;
        private TextBox txtBoxCash;
        private Label lblFinalTotal;
        private Label label8;
        private Label label6;
        private Label lblChange;
        private Label label9;
        private Label lblItemTotal;
        private Label label1;
        private Panel panelTotal;
        private CustomControls.RJControls.RJButton btnComplete;
        private TextBox txtBoxBarcode;
    }
}