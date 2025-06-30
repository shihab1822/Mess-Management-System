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

namespace Mess_Management_System
{
    public partial class ManagerAssignChiefs : Form
    {
        private int selectedMealId = -1;

        public ManagerAssignChiefs()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string memberIdText = cmbMemberID.SelectedItem?.ToString();
            DateTime date = dtpDate.Value.Date;
            string mealTime = txtMealTime.Text.Trim();
            string mealDescription = rtxtMealDescription.Text.Trim();


            if (string.IsNullOrEmpty(memberIdText) || string.IsNullOrEmpty(mealTime) || string.IsNullOrEmpty(mealDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(memberIdText, out int memberId))
            {
                MessageBox.Show("Please enter a valid Member ID.");
                return;
            }

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO MealData (MemberID, Date, MealTime, MealDescription) VALUES (@MemberID, @Date, @MealTime, @MealDescription)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@MealTime", mealTime);
                        cmd.Parameters.AddWithValue("@MealDescription", mealDescription);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Meal data saved successfully!");
                        LoadMealData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving meal data: " + ex.Message);
                }
            }
        }

        private void LoadMealData()
        {
            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM MealData";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvManager.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading meal data: " + ex.Message);
                }
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMealData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMealId == -1)
            {
                MessageBox.Show("Please select a meal record to update.");
                return;
            }

            string memberIdText = cmbMemberID.SelectedItem?.ToString();
            DateTime date = dtpDate.Value.Date;
            string mealTime = txtMealTime.Text.Trim();
            string mealDescription = rtxtMealDescription.Text.Trim();

            if (string.IsNullOrEmpty(memberIdText) || string.IsNullOrEmpty(mealTime) || string.IsNullOrEmpty(mealDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(memberIdText, out int memberId))
            {
                MessageBox.Show("Please enter a valid Member ID.");
                return;
            }

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE MealData SET MemberID=@MemberID, Date=@Date, MealTime=@MealTime, MealDescription=@MealDescription WHERE MealID=@MealID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@MealTime", mealTime);
                        cmd.Parameters.AddWithValue("@MealDescription", mealDescription);
                        cmd.Parameters.AddWithValue("@MealID", selectedMealId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Meal data updated successfully!");
                        LoadMealData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating meal data: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMemberID.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            txtMealTime.Clear();
            rtxtMealDescription.Clear();
            selectedMealId = -1;
        }

        private void dgvManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvManager.Rows[e.RowIndex];
                selectedMealId = Convert.ToInt32(row.Cells["MealID"].Value);
                cmbMemberID.Text = row.Cells["MemberID"].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                txtMealTime.Text = row.Cells["MealTime"].Value.ToString();
                rtxtMealDescription.Text = row.Cells["MealDescription"].Value.ToString();
            }
        }

        private void PopulateMemberIDs()
        {
            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT MemberID FROM Members";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbMemberID.Items.Add(reader["MemberID"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Member IDs: " + ex.Message);
                }
            }
        }

        private void ManagerAssignChiefs_Load(object sender, EventArgs e)
        {
            PopulateMemberIDs();
        }
    }
}
