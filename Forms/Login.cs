using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Sample_2.Forms
{
    public partial class Login : Form
    {
        // Fields
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        public static bool login;
        public static string type;
        public static string username;
        public static SqlConnection cnn;
        public static SqlCommand cmd;
        public static SqlDataReader rdr;
        //

        string connString = "Data Source=CASPER;Initial Catalog=test;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string query = "select * from admin where username = '" + tboxUsername.Text + "' and password = '" + tboxPassword.Text + "'";

            if (tboxUsername.Text != "" && tboxPassword.Text != "")
            {
                conn = new SqlConnection(connString);
                conn.Open();
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                cnn = conn;
                cmd = command;
                rdr = reader;
                if (reader.Read())
                {
                    login = true;
                    username = reader.GetString(1);
                    type = reader.GetString(3);
                    MessageBox.Show("Logged in successfully", "", MessageBoxButtons.OK);
                }
                reader.Close();
                Hide();
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void tboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
