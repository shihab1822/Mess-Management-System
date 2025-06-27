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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mess_Management_System
{
    public partial class ManagerDashboard : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True");

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private string _username;
        public ManagerDashboard(string username) : this()
        {
            _username = username;
        }
        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide(); // Hide the parent form if it exists
            }
            lblWelUserName.Text = $"Welcome, {_username}";

            string query = "SELECT Username FROM Users";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbUsername.Items.Add(reader["Username"].ToString());
                    }
                }
                conn.Close();
            }
        }

        private void ManagerDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); // Show the parent form if it exists
            }
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {


            string query = "SELECT * FROM Members";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvManager.DataSource = dt;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtMemberName.Text.Trim();
            bool isManager = chkbIsManager.Checked;
            DateTime joiningDate = dtpJoiningDate.Value.Date;
            string username = cmbUsername.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please fill in all fields and select a valid user.");
                return;
            }

            int userId = GetUserIdByUsername(username);
            if (userId <= 0)
            {
                MessageBox.Show("Selected user does not exist.");
                return;
            }

            try
            {
                string query = "INSERT INTO Members (Name, isManager, JoiningDate, UserID) VALUES (@Name, @IsManager, @JoiningDate, @UserID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@IsManager", isManager);
                    cmd.Parameters.AddWithValue("@JoiningDate", joiningDate);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private int GetUserIdByUsername(string username)
        {
            int userId = -1;
            string query = "SELECT UserID FROM Users WHERE Username = @Username";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
                conn.Close();
            }
            return userId;
        }
    }
}


