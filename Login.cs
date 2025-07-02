using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SSA_B_Canteen.Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Texts.Trim();
            string password = txtPassword.Texts.Trim();

            string query = "SELECT employee_id, role FROM accounts WHERE username = @username AND password = @password LIMIT 1";

            using (MySqlConnection connection = new MySqlConnection(connstring))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();
                                int employeeId = Convert.ToInt32(reader["employee_id"]);

                                // Set status to 1 (active)
                                reader.Close();
                                using (var updateCmd = new MySqlCommand("UPDATE accounts SET status = 1 WHERE employee_id = @eid", connection))
                                {
                                    updateCmd.Parameters.AddWithValue("@eid", employeeId);
                                    updateCmd.ExecuteNonQuery();
                                }

                                if (role == "admin")
                                {
                                    var adminDashboard = new AdminDashboard();
                                    adminDashboard.Show();
                                    this.Hide();
                                }
                                else if (role == "cashier")
                                {
                                    var cashierForm = new Cashier(employeeId);
                                    cashierForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Unknown role.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
