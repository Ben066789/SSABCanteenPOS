using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace SSA_B_Canteen
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
            FetchAccounts();
            AccountListStyle();
        }
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";
        private void AccountListStyle()
        {
            AccountList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccountList.MultiSelect = false;
            AccountList.BorderStyle = BorderStyle.None;
            AccountList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            AccountList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AccountList.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            AccountList.DefaultCellStyle.SelectionForeColor = Color.Black;
            AccountList.BackgroundColor = Color.White;

            AccountList.EnableHeadersVisualStyles = false;
            AccountList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            AccountList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            AccountList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            AccountList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AccountList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            AccountList.AllowUserToResizeRows = false;
            AccountList.AllowUserToResizeColumns = false;
        }
        private void FetchAccounts()
        {
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                conn.Open();
                string query = "SELECT * FROM Accounts";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    AccountList.DataSource = dt;
                }
            }
        }
        private void createAccBtn_Click(object sender, EventArgs e)
        {
            string firstname = FirstName.Texts;
            string lastname = LastName.Texts;
            string username = Username.Texts;
            string password = Password.Texts;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    string query = "INSERT INTO accounts (firstname, lastname, username, password) VALUES (@FirstName, @LastName, @Username, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstname);
                        cmd.Parameters.AddWithValue("@LastName", lastname);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account created successfully!");
                FetchAccounts(); // Refresh the account list after creation
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
