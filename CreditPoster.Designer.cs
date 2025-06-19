namespace SSA_B_Canteen.Cashier
{
    partial class CreditPoster
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
            txtEmployeeSearch = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtEmployeeSearch
            // 
            txtEmployeeSearch.Font = new Font("Segoe UI", 12F);
            txtEmployeeSearch.Location = new Point(12, 12);
            txtEmployeeSearch.Name = "txtEmployeeSearch";
            txtEmployeeSearch.Size = new Size(275, 29);
            txtEmployeeSearch.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(197, 47);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(90, 31);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(101, 47);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CreditPoster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 85);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtEmployeeSearch);
            Name = "CreditPoster";
            Text = "Credit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeSearch;
        private Button btnOK;
        private Button btnCancel;
    }
}