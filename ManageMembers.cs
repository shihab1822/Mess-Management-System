using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mess_Management_System
{
    public partial class ManageMembers : Form
    {
        private int selectedMemberId = -1;

        public ManageMembers()
        {
            InitializeComponent();
        }

        private void ManageMembers_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtMemberName.Text.Trim();
            bool isManager = chkbIsManager.Checked;
            DateTime joiningDate = dtpJoiningDate.Value.Date;
            string userIdText = cmbUserID.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(userIdText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(userIdText, out int userId))
            {
                MessageBox.Show("Please select a valid User ID.");
                return;
            }

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Members (Name, IsManager, JoiningDate, UserID) VALUES (@Name, @IsManager, @JoiningDate, @UserID)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@IsManager", isManager);
                        cmd.Parameters.AddWithValue("@JoiningDate", joiningDate);
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member saved successfully!");
                        LoadMembers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving member: " + ex.Message);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Members";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvManager.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading members: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == -1)
            {
                MessageBox.Show("Please select a member to update.");
                return;
            }

            string name = txtMemberName.Text.Trim();
            bool isManager = chkbIsManager.Checked;
            DateTime joiningDate = dtpJoiningDate.Value.Date;
            string userIdText = cmbUserID.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(userIdText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(userIdText, out int userId))
            {
                MessageBox.Show("Please select a valid User ID.");
                return;
            }

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Members SET Name=@Name, IsManager=@IsManager, JoiningDate=@JoiningDate, UserID=@UserID WHERE MemberID=@MemberID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@IsManager", isManager);
                        cmd.Parameters.AddWithValue("@JoiningDate", joiningDate);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@MemberID", selectedMemberId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member updated successfully!");
                        LoadMembers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating member: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == -1)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Members WHERE MemberID=@MemberID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", selectedMemberId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member deleted successfully!");
                            selectedMemberId = -1;
                            txtMemberName.Clear();
                            chkbIsManager.Checked = false;
                            dtpJoiningDate.Value = DateTime.Now;
                            cmbUserID.SelectedIndex = -1;
                            LoadMembers();
                        }
                        else
                        {
                            MessageBox.Show("No member was deleted. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting member: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
