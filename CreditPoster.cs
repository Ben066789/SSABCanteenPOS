using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSA_B_Canteen.Cashier
{
    public partial class CreditPoster: Form
    {
        public CreditPoster()
        {
            InitializeComponent();
            SetupEmployeeSearchAutocomplete();
        }

        private void SetupEmployeeSearchAutocomplete()
        {
            var autoComplete = new AutoCompleteStringCollection();
            string connstring = "Server=127.0.0.1; Database=ssab_canteen; User ID=root; Password=;";

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT username FROM accounts";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autoComplete.Add(reader["username"].ToString());
                        }
                    }
                }
            }

            txtEmployeeSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtEmployeeSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtEmployeeSearch.AutoCompleteCustomSource = autoComplete;
        }

    }
}
