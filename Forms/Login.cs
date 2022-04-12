using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class Login : Form
    {
        // Fields
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public static bool login;
        public static string type;
        public static string username;
        public static SqlConnection cnn;
        //

        string connString = "Data Source=CASPER;Initial Catalog=test;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string query = "select * from admin where username = '" + tboxUsername.Text + "' and password = '" + tboxPassword.Text + "'";

            conn = new SqlConnection(connString);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            cnn = conn;
            if (reader.Read())
            {
                login = true;
                username = reader.GetString(1);
                type = reader.GetString(3);
                MessageBox.Show("Logged in successfully", "", MessageBoxButtons.OK);
            }

            reader.Close(); // Close sqlreader process
            cmd.Dispose();  // Close/dispose sqlcommand process
            conn.Close();   // Close database connection
            Close();        // Close "Login" form
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
