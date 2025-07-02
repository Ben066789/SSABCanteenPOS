namespace SSA_B_Canteen
{
    partial class BrowseItems
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
            dgvAllItems = new DataGridView();
            txtbxSearch = new TextBox();
            lblBrowse = new Label();
            btnUpdate = new CustomControls.RJControls.RJButton();
            btnShowUpdated = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dgvAllItems).BeginInit();
            SuspendLayout();
            // 
            // dgvAllItems
            // 
            dgvAllItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllItems.Location = new Point(12, 57);
            dgvAllItems.Name = "dgvAllItems";
            dgvAllItems.RowHeadersVisible = false;
            dgvAllItems.Size = new Size(1038, 606);
            dgvAllItems.TabIndex = 0;
            // 
            // txtbxSearch
            // 
            txtbxSearch.Font = new Font("Segoe UI", 12F);
            txtbxSearch.Location = new Point(808, 11);
            txtbxSearch.Name = "txtbxSearch";
            txtbxSearch.PlaceholderText = "Search";
            txtbxSearch.Size = new Size(242, 29);
            txtbxSearch.TabIndex = 1;
            // 
            // lblBrowse
            // 
            lblBrowse.AutoSize = true;
            lblBrowse.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            lblBrowse.ForeColor = Color.DodgerBlue;
            lblBrowse.Location = new Point(12, 12);
            lblBrowse.Name = "lblBrowse";
            lblBrowse.Size = new Size(94, 28);
            lblBrowse.TabIndex = 2;
            lblBrowse.Text = "Browse";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSlateBlue;
            btnUpdate.BackgroundColor = Color.MediumSlateBlue;
            btnUpdate.BorderColor = Color.PaleVioletRed;
            btnUpdate.BorderRadius = 0;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(652, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "rjButton1";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShowUpdated
            // 
            btnShowUpdated.BackColor = Color.MediumSlateBlue;
            btnShowUpdated.BackgroundColor = Color.MediumSlateBlue;
            btnShowUpdated.BorderColor = Color.PaleVioletRed;
            btnShowUpdated.BorderRadius = 0;
            btnShowUpdated.BorderSize = 0;
            btnShowUpdated.FlatAppearance.BorderSize = 0;
            btnShowUpdated.FlatStyle = FlatStyle.Flat;
            btnShowUpdated.ForeColor = Color.White;
            btnShowUpdated.Location = new Point(486, 11);
            btnShowUpdated.Name = "btnShowUpdated";
            btnShowUpdated.Size = new Size(150, 29);
            btnShowUpdated.TabIndex = 4;
            btnShowUpdated.Text = "rjButton1";
            btnShowUpdated.TextColor = Color.White;
            btnShowUpdated.UseVisualStyleBackColor = false;
            btnShowUpdated.Click += btnShowUpdated_Click;
            // 
            // BrowseItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 675);
            Controls.Add(btnShowUpdated);
            Controls.Add(btnUpdate);
            Controls.Add(lblBrowse);
            Controls.Add(txtbxSearch);
            Controls.Add(dgvAllItems);
            Name = "BrowseItems";
            Text = "Browse Items";
            ((System.ComponentModel.ISupportInitialize)dgvAllItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllItems;
        private TextBox txtbxSearch;
        private Label lblBrowse;
        private CustomControls.RJControls.RJButton btnUpdate;
        private CustomControls.RJControls.RJButton btnShowUpdated;
    }
}