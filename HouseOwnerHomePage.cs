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
    public partial class HouseOwnerHomePage : Form
    {
        private string _username; 

        public HouseOwnerHomePage()
        {
            InitializeComponent();
        }

        public HouseOwnerHomePage(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void HouseOwnerHomePage_Load(object sender, EventArgs e)
        {
            int houseOwnerId = GetHouseOwnerIdByUsername(_username);
            if (houseOwnerId <= 0)
            {
                rtxtIncomeSummary.Text = "No flats found.";
                txtAnnounce.Text = "No announcements found.";
                return;
            }


            string connString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();

                    // Total Rent
                    string rentQuery = "SELECT ISNULL(SUM(CAST(RentAmount AS DECIMAL(18,2))), 0) FROM Flats WHERE HouseOwnerID = @HouseOwnerID";
                    using (SqlCommand rentCmd = new SqlCommand(rentQuery, con))
                    {
                        rentCmd.Parameters.AddWithValue("@HouseOwnerID", houseOwnerId);
                        object totalRent = rentCmd.ExecuteScalar();
                        rtxtIncomeSummary.Text = $"Total Rent: {totalRent} Tk";
                    }

                    // Latest Announcement
                    string announceQuery = "SELECT TOP 1 AnnounceText FROM Announcements ORDER BY AnnounceDate DESC";
                    using (SqlCommand announceCmd = new SqlCommand(announceQuery, con))
                    {
                        object latestAnnounce = announceCmd.ExecuteScalar();
                        txtAnnounce.Text = latestAnnounce != null ? latestAnnounce.ToString() : "No announcements found.";
                    }
                }
                catch (Exception ex)
                {
                    rtxtIncomeSummary.Text = "Error loading data: " + ex.Message;
                    txtAnnounce.Text = "Error loading data: " + ex.Message;
                }
            }
        }

        private int GetHouseOwnerIdByUsername(string username)
        {
            int houseOwnerId = -1;
            string connectionString = "Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT UserID FROM Users WHERE Username = @Username";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        houseOwnerId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving HouseOwnerID: " + ex.Message);
                }
            }
            return houseOwnerId;
        }
        
    }
}
