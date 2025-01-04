using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class RemoveUserForm : Form
    {
        private UserHandler userHandler;
        public RemoveUserForm()
        {
            InitializeComponent();
            userHandler = new UserHandler();
            LoadUserData();
        }
        private void LoadUserData()
        {
            using (SqlConnection connection = new SqlConnection(userHandler.ConnectionString))
            {
                string query = "SELECT USERNAME FROM UserLogin";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsers.DataSource = dataTable;
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                string username = row.Cells["USERNAME"].Value.ToString();

                if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("You cannot delete the admin user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    userHandler.RemoveUser(username);
                    LoadUserData(); // Refresh the DataGridView
                }
            }
        }

        private void RemoveUserForm_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
