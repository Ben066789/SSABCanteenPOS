namespace SSA_B_Canteen.Admin
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsername = new CustomControls.RJControls.RJTextBox();
            txtPassword = new CustomControls.RJControls.RJTextBox();
            loginBtn = new CustomControls.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderColor = Color.DodgerBlue;
            txtUsername.BorderFocusColor = Color.LightSkyBlue;
            txtUsername.BorderRadius = 8;
            txtUsername.BorderSize = 2;
            txtUsername.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsername.Location = new Point(88, 365);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(10, 7, 10, 7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.DarkGray;
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 31);
            txtUsername.TabIndex = 1;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.DodgerBlue;
            txtPassword.BorderFocusColor = Color.LightSkyBlue;
            txtPassword.BorderRadius = 8;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(88, 404);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 31);
            txtPassword.TabIndex = 2;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DodgerBlue;
            loginBtn.BackgroundColor = Color.DodgerBlue;
            loginBtn.BorderColor = Color.CornflowerBlue;
            loginBtn.BorderRadius = 10;
            loginBtn.BorderSize = 0;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(146, 442);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(119, 31);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.TextColor = Color.White;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(64, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 520);
            Controls.Add(loginBtn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtUsername;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private CustomControls.RJControls.RJButton loginBtn;
        private PictureBox pictureBox1;
    }
}