namespace SSA_B_Canteen
{
    partial class AccountManager
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
            AccountList = new DataGridView();
            panel1 = new Panel();
            ArchiveAccount = new CustomControls.RJControls.RJButton();
            createAccBtn = new CustomControls.RJControls.RJButton();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            Password = new CustomControls.RJControls.RJTextBox();
            LastName = new CustomControls.RJControls.RJTextBox();
            FirstName = new CustomControls.RJControls.RJTextBox();
            SearchAccList = new TextBox();
            Username = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)AccountList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AccountList
            // 
            AccountList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountList.Location = new Point(273, 52);
            AccountList.Name = "AccountList";
            AccountList.RowHeadersVisible = false;
            AccountList.Size = new Size(728, 406);
            AccountList.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(ArchiveAccount);
            panel1.Controls.Add(createAccBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(LastName);
            panel1.Controls.Add(FirstName);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 471);
            panel1.TabIndex = 4;
            // 
            // ArchiveAccount
            // 
            ArchiveAccount.BackColor = Color.DodgerBlue;
            ArchiveAccount.BackgroundColor = Color.DodgerBlue;
            ArchiveAccount.BorderColor = Color.White;
            ArchiveAccount.BorderRadius = 10;
            ArchiveAccount.BorderSize = 0;
            ArchiveAccount.FlatAppearance.BorderSize = 0;
            ArchiveAccount.FlatStyle = FlatStyle.Flat;
            ArchiveAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ArchiveAccount.ForeColor = Color.White;
            ArchiveAccount.Location = new Point(15, 415);
            ArchiveAccount.Name = "ArchiveAccount";
            ArchiveAccount.Size = new Size(109, 32);
            ArchiveAccount.TabIndex = 5;
            ArchiveAccount.Text = "Archive Account";
            ArchiveAccount.TextColor = Color.White;
            ArchiveAccount.UseVisualStyleBackColor = false;
            // 
            // createAccBtn
            // 
            createAccBtn.BackColor = Color.DodgerBlue;
            createAccBtn.BackgroundColor = Color.DodgerBlue;
            createAccBtn.BorderColor = Color.White;
            createAccBtn.BorderRadius = 10;
            createAccBtn.BorderSize = 0;
            createAccBtn.FlatAppearance.BorderSize = 0;
            createAccBtn.FlatStyle = FlatStyle.Flat;
            createAccBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAccBtn.ForeColor = Color.White;
            createAccBtn.Location = new Point(15, 302);
            createAccBtn.Name = "createAccBtn";
            createAccBtn.Size = new Size(109, 32);
            createAccBtn.TabIndex = 5;
            createAccBtn.Text = "Create";
            createAccBtn.TextColor = Color.White;
            createAccBtn.UseVisualStyleBackColor = false;
            createAccBtn.Click += createAccBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(15, 14);
            label3.Name = "label3";
            label3.Size = new Size(224, 28);
            label3.TabIndex = 10;
            label3.Text = "Account Manager";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(15, 181);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 1;
            label5.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(15, 245);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(15, 116);
            label6.Name = "label6";
            label6.Size = new Size(67, 16);
            label6.TabIndex = 1;
            label6.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(15, 52);
            label7.Name = "label7";
            label7.Size = new Size(67, 16);
            label7.TabIndex = 1;
            label7.Text = "First Name";
            // 
            // Password
            // 
            Password.BackColor = SystemColors.Window;
            Password.BorderColor = Color.DodgerBlue;
            Password.BorderFocusColor = Color.CornflowerBlue;
            Password.BorderRadius = 5;
            Password.BorderSize = 2;
            Password.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.FromArgb(64, 64, 64);
            Password.Location = new Point(15, 264);
            Password.Margin = new Padding(4);
            Password.Multiline = false;
            Password.Name = "Password";
            Password.Padding = new Padding(10, 7, 10, 7);
            Password.PasswordChar = false;
            Password.PlaceholderColor = Color.DarkGray;
            Password.PlaceholderText = "";
            Password.Size = new Size(235, 31);
            Password.TabIndex = 4;
            Password.Texts = "";
            Password.UnderlinedStyle = false;
            // 
            // LastName
            // 
            LastName.BackColor = SystemColors.Window;
            LastName.BorderColor = Color.DodgerBlue;
            LastName.BorderFocusColor = Color.CornflowerBlue;
            LastName.BorderRadius = 5;
            LastName.BorderSize = 2;
            LastName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastName.ForeColor = Color.FromArgb(64, 64, 64);
            LastName.Location = new Point(15, 136);
            LastName.Margin = new Padding(4);
            LastName.Multiline = false;
            LastName.Name = "LastName";
            LastName.Padding = new Padding(10, 7, 10, 7);
            LastName.PasswordChar = false;
            LastName.PlaceholderColor = Color.DarkGray;
            LastName.PlaceholderText = "";
            LastName.Size = new Size(235, 31);
            LastName.TabIndex = 2;
            LastName.Texts = "";
            LastName.UnderlinedStyle = false;
            // 
            // FirstName
            // 
            FirstName.BackColor = SystemColors.Window;
            FirstName.BorderColor = Color.DodgerBlue;
            FirstName.BorderFocusColor = Color.CornflowerBlue;
            FirstName.BorderRadius = 5;
            FirstName.BorderSize = 2;
            FirstName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstName.ForeColor = Color.FromArgb(64, 64, 64);
            FirstName.Location = new Point(15, 72);
            FirstName.Margin = new Padding(4);
            FirstName.Multiline = false;
            FirstName.Name = "FirstName";
            FirstName.Padding = new Padding(10, 7, 10, 7);
            FirstName.PasswordChar = false;
            FirstName.PlaceholderColor = Color.DarkGray;
            FirstName.PlaceholderText = "";
            FirstName.Size = new Size(235, 31);
            FirstName.TabIndex = 1;
            FirstName.Texts = "";
            FirstName.UnderlinedStyle = false;
            // 
            // SearchAccList
            // 
            SearchAccList.Font = new Font("Segoe UI", 13F);
            SearchAccList.Location = new Point(273, 12);
            SearchAccList.Name = "SearchAccList";
            SearchAccList.PlaceholderText = "Search";
            SearchAccList.Size = new Size(456, 31);
            SearchAccList.TabIndex = 5;
            // 
            // Username
            // 
            Username.BackColor = SystemColors.Window;
            Username.BorderColor = Color.DodgerBlue;
            Username.BorderFocusColor = Color.CornflowerBlue;
            Username.BorderRadius = 5;
            Username.BorderSize = 2;
            Username.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.FromArgb(64, 64, 64);
            Username.Location = new Point(15, 201);
            Username.Margin = new Padding(4);
            Username.Multiline = false;
            Username.Name = "Username";
            Username.Padding = new Padding(10, 7, 10, 7);
            Username.PasswordChar = false;
            Username.PlaceholderColor = Color.DarkGray;
            Username.PlaceholderText = "";
            Username.Size = new Size(235, 31);
            Username.TabIndex = 3;
            Username.Texts = "";
            Username.UnderlinedStyle = false;
            // 
            // AccountManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 470);
            Controls.Add(SearchAccList);
            Controls.Add(panel1);
            Controls.Add(AccountList);
            Name = "AccountManager";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AccountList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AccountList;
        private Panel panel1;
        private CustomControls.RJControls.RJButton createAccBtn;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private CustomControls.RJControls.RJTextBox FirstName;
        private CustomControls.RJControls.RJTextBox LastName;
        private CustomControls.RJControls.RJTextBox Password;
        private Label label6;
        private CustomControls.RJControls.RJButton ArchiveAccount;
        private TextBox SearchAccList;
        private CustomControls.RJControls.RJTextBox Username;
    }
}