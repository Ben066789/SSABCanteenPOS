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
            pnlNavigate = new Panel();
            btnCashier = new CustomControls.RJControls.RJButton();
            btnAddProducts = new CustomControls.RJControls.RJButton();
            pnlNavigate.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavigate
            // 
            pnlNavigate.Controls.Add(btnCashier);
            pnlNavigate.Controls.Add(btnAddProducts);
            pnlNavigate.Location = new Point(12, 145);
            pnlNavigate.Name = "pnlNavigate";
            pnlNavigate.Size = new Size(179, 455);
            pnlNavigate.TabIndex = 0;
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.CornflowerBlue;
            btnCashier.BackgroundColor = Color.CornflowerBlue;
            btnCashier.BorderColor = Color.White;
            btnCashier.BorderRadius = 10;
            btnCashier.BorderSize = 0;
            btnCashier.FlatAppearance.BorderSize = 0;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.ForeColor = Color.White;
            btnCashier.Location = new Point(3, 56);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(172, 46);
            btnCashier.TabIndex = 1;
            btnCashier.Text = "Cashier";
            btnCashier.TextColor = Color.White;
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.BackColor = Color.CornflowerBlue;
            btnAddProducts.BackgroundColor = Color.CornflowerBlue;
            btnAddProducts.BorderColor = Color.White;
            btnAddProducts.BorderRadius = 10;
            btnAddProducts.BorderSize = 0;
            btnAddProducts.FlatAppearance.BorderSize = 0;
            btnAddProducts.FlatStyle = FlatStyle.Flat;
            btnAddProducts.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProducts.ForeColor = Color.White;
            btnAddProducts.Location = new Point(4, 4);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(172, 46);
            btnAddProducts.TabIndex = 1;
            btnAddProducts.Text = "Add Item";
            btnAddProducts.TextColor = Color.White;
            btnAddProducts.UseVisualStyleBackColor = false;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 612);
            Controls.Add(pnlNavigate);
            Name = "AdminDashboard";
            Text = "Form1";
            pnlNavigate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNavigate;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton btnAddProducts;
        private CustomControls.RJControls.RJButton btnCashier;
    }
}
