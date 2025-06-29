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
    public partial class HouseOwnerFlatsIncome : Form
    {
        private int _houseOwnerId;

        public HouseOwnerFlatsIncome(int houseOwnerId)
        {
            InitializeComponent();
            _houseOwnerId = houseOwnerId;
        }

        private void HouseOwnerFlatsIncome_Load(object sender, EventArgs e)
        {
            //LoadFlatsData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string flatAddress = txtFlatAddress.Text.Trim(); 
            string rentText = txtRent.Text.Trim();
            string description = rtxtDescription.Text.Trim();

            if (string.IsNullOrEmpty(flatAddress) || string.IsNullOrEmpty(rentText) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(rentText, out decimal rentAmount))
            {
                MessageBox.Show("Please enter a valid rent amount.");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True");

            try
            {
                con.Open();
                string query = "INSERT INTO Flats (FlatAddress, FlatDescription, RentAmount, HouseOwnerID) " +
                       "VALUES (@FlatAddress, @FlatDescription, @RentAmount, @HouseOwnerID)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FlatAddress", flatAddress);
                cmd.Parameters.AddWithValue("@FlatDescription", description);
                cmd.Parameters.AddWithValue("@RentAmount", rentAmount);
                cmd.Parameters.AddWithValue("@HouseOwnerID", _houseOwnerId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Flat added successfully!");
                LoadFlatsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                con.Close();
            }

        }

        private void LoadFlatsData()
        {

            SqlConnection con = new SqlConnection("Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True");
            try
            {
                con.Open();
                string query = "SELECT * FROM Flats WHERE HouseOwnerID = @HouseOwnerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@HouseOwnerID", _houseOwnerId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHouseOwner.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flats: " + ex.Message);
            }
            finally
            {

                con.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFlatsData();
        }

        private int selectedFlatId = -1;
        private void dgvHouseOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHouseOwner.Rows[e.RowIndex];
                selectedFlatId = Convert.ToInt32(row.Cells["FlatID"].Value);
                txtFlatAddress.Text = row.Cells["FlatAddress"].Value.ToString();
                txtRent.Text = row.Cells["RentAmount"].Value.ToString();
                rtxtDescription.Text = row.Cells["FlatDescription"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedFlatId == -1)
            {
                MessageBox.Show("Please select a flat to update.");
                return;
            }

            string flatAddress = txtFlatAddress.Text.Trim();
            string rentText = txtRent.Text.Trim();
            string description = rtxtDescription.Text.Trim();

            if (string.IsNullOrEmpty(flatAddress) || string.IsNullOrEmpty(rentText) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(rentText, out decimal rentAmount))
            {
                MessageBox.Show("Please enter a valid rent amount.");
                return;
            }

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);
            try
            {

                con.Open();
                string query = "UPDATE Flats SET FlatAddress=@FlatAddress, FlatDescription=@FlatDescription, RentAmount=@RentAmount WHERE FlatID=@FlatID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FlatAddress", flatAddress);
                cmd.Parameters.AddWithValue("@FlatDescription", description);
                cmd.Parameters.AddWithValue("@RentAmount", rentAmount);
                cmd.Parameters.AddWithValue("@FlatID", selectedFlatId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Flat updated successfully!");
                LoadFlatsData();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating flat: " + ex.Message);
            }
            finally
            {

                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFlatId == -1)
            {
                MessageBox.Show("Please select a flat to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this flat?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connString);
            try
            {
                con.Open();
                string query = "DELETE FROM Flats WHERE FlatID=@FlatID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FlatID", selectedFlatId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Flat deleted successfully!");
                    selectedFlatId = -1;
                    txtFlatAddress.Clear();
                    txtRent.Clear();
                    rtxtDescription.Clear();
                    LoadFlatsData();
                }
                else
                {
                    MessageBox.Show("No flat was deleted. Please try again.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error deleting flat: " + ex.Message);
            }
            finally
            {

                con.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFlatAddress.Clear();
            txtRent.Clear();
            rtxtDescription.Clear();
            selectedFlatId = -1;
        }
    }
}
