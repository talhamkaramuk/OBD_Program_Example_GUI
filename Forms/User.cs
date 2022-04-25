using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class User : Form
    {


        public User()
        {
            InitializeComponent();
        }

        private void fillGrid()
        {
            string query1 = "select * from admin where type='sub'";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, Login.cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Login.cnn.Close();
            Login.rdr.Close();
        }

        private void User_Load(object sender, System.EventArgs e)
        {
            fillGrid();
        }

        private void tboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboxUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tboxPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tboxConfirm.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cboxType.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string query2 = "insert into admin(username, password, type) values(@username, @password, @type)";
            if (tboxUsername.Text != "" || tboxPassword.Text != "" || tboxConfirm.Text != "" || cboxType.Text != "")
            {
                if (tboxPassword.Text == tboxConfirm.Text)
                {
                    Login.cmd = new SqlCommand(query2, Login.cnn);
                    Login.cmd.Parameters.AddWithValue("@username", tboxUsername.Text);
                    Login.cmd.Parameters.AddWithValue("@password", tboxPassword.Text);
                    Login.cmd.Parameters.AddWithValue("@type", cboxType.SelectedItem.ToString());
                    Login.cnn.Open();
                    Login.cmd.ExecuteNonQuery();
                    tboxUsername.Text = "";
                    tboxPassword.Text = "";
                    tboxConfirm.Text = "";
                    cboxType.Text = "";
                    fillGrid();
                    Login.cnn.Close();
                }
                else
                {
                    MessageBox.Show("Please confirm password!", "Password Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill the necessary fields!", "Field Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (tboxDelUser.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query3 = "delete from admin where username=@username";
                    Login.cmd = new SqlCommand(query3, Login.cnn);
                    Login.cmd.Parameters.AddWithValue("@username", tboxDelUser.Text);
                    Login.cnn.Open();
                    Login.cmd.ExecuteNonQuery();
                    Login.cnn.Close();
                    fillGrid();
                    tboxDelUser.Text = "";
                }
            }
        }

        private void lblClear_Click(object sender, System.EventArgs e)
        {
            tboxUsername.Text = "";
            tboxPassword.Text = "";
            tboxConfirm.Text = "";
            tboxDelUser.Text = "";
            cboxType.Text = "";
        }
    }
}
