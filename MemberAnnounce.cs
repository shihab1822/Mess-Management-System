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
    public partial class MemberAnnounce : Form
    {
        public MemberAnnounce()
        {
            InitializeComponent();
        }

        private int selectedAnnounceId = -1;
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime announcementDate = DateTime.Now;
            string announcementText = rtxtAnnounce.Text.Trim();

            if (string.IsNullOrEmpty(announcementText))
            {
                MessageBox.Show("Please enter an announcement.");
                return;
            }

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();
                string query = "INSERT INTO Announcements (AnnounceDate, AnnounceText) VALUES ( @AnnounceDate, @AnnounceText)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AnnounceDate", announcementDate);
                cmd.Parameters.AddWithValue("@AnnounceText", announcementText);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Announcement saved successfully!");
                LoadAnnounceData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving announcement: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void LoadAnnounceData()
        {
            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();
                string query = "SELECT * FROM Announcements";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHouseOwner.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading announcements: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAnnounceData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAnnounceId == -1)
            {
                MessageBox.Show("Please select an announcement to update.");
                return;
            }

            string announcementText = rtxtAnnounce.Text.Trim();
            //DateTime announcementDate = dtpAnnounce.Value;

            if (string.IsNullOrEmpty(announcementText))
            {
                MessageBox.Show("Please enter an announcement.");
                return;
            }
            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();
                //string query = "UPDATE Announcements SET AnnounceText=@AnnounceText, AnnounceDate=@AnnounceDate WHERE AnnounceID=@AnnounceID";
                string query = "UPDATE Announcements SET AnnounceText=@AnnounceText WHERE AnnounceID=@AnnounceID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AnnounceText", announcementText);
                //cmd.Parameters.AddWithValue("@AnnounceDate", announcementDate);
                cmd.Parameters.AddWithValue("@AnnounceID", selectedAnnounceId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Announcement updated successfully!");
                    LoadAnnounceData();

                }

                else
                {
                    MessageBox.Show("No announcement was updated. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating announcement: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgvHouseOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHouseOwner.Rows[e.RowIndex];
                selectedAnnounceId = Convert.ToInt32(row.Cells["AnnounceID"].Value);
                rtxtAnnounce.Text = row.Cells["AnnounceText"].Value.ToString();
                dtpAnnounce.Value = Convert.ToDateTime(row.Cells["AnnounceDate"].Value);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAnnounceId == -1)
            {
                MessageBox.Show("Please select an announcement to delete.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to delete this announcement?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);

            try
            {
                con.Open();
                string query = "DELETE FROM Announcements WHERE AnnounceID=@AnnounceID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AnnounceID", selectedAnnounceId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Announcement deleted successfully!");
                    selectedAnnounceId = -1;
                    rtxtAnnounce.Clear();
                    dtpAnnounce.Value = DateTime.Now;
                    LoadAnnounceData();

                }
                else
                {
                    MessageBox.Show("No announcement was deleted. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting announcement: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtAnnounce.Clear();
            dtpAnnounce.Value = DateTime.Now;
            selectedAnnounceId = -1;
        }
    }
}
