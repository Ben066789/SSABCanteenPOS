namespace SSA_B_Canteen
{
    partial class Credit
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
            dataGridViewAutoSizePnl = new FlowLayoutPanel();
            employeeCredit = new DataGridView();
            label2 = new Label();
            searchBar = new TextBox();
            dataGridViewAutoSizePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeCredit).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAutoSizePnl
            // 
            dataGridViewAutoSizePnl.Controls.Add(employeeCredit);
            dataGridViewAutoSizePnl.Location = new Point(15, 73);
            dataGridViewAutoSizePnl.Name = "dataGridViewAutoSizePnl";
            dataGridViewAutoSizePnl.Size = new Size(859, 416);
            dataGridViewAutoSizePnl.TabIndex = 0;
            // 
            // employeeCredit
            // 
            employeeCredit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeCredit.Location = new Point(3, 3);
            employeeCredit.Name = "employeeCredit";
            employeeCredit.Size = new Size(854, 408);
            employeeCredit.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(18, 22);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 11;
            label2.Text = "Credit";
            // 
            // searchBar
            // 
            searchBar.Font = new Font("Segoe UI", 12F);
            searchBar.Location = new Point(582, 25);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(290, 29);
            searchBar.TabIndex = 12;
            // 
            // Credit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 502);
            Controls.Add(searchBar);
            Controls.Add(label2);
            Controls.Add(dataGridViewAutoSizePnl);
            Name = "Credit";
            Text = "Form1";
            dataGridViewAutoSizePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeCredit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel dataGridViewAutoSizePnl;
        private DataGridView employeeCredit;
        private Label label2;
        private TextBox searchBar;
    }
}