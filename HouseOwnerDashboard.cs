using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Mess_Management_System
{
    public partial class HouseOwnerDashboard : Form
    {
        public HouseOwnerDashboard()
        {
            InitializeComponent();
        }

        

        HouseOwnerAnnounce hOA = new HouseOwnerAnnounce();

        private string _username;
        public HouseOwnerDashboard(string username) : this()
        {
            _username = username;
        }

        private void HouseOwnerDashboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide(); // Hide the parent form if it exists
            }
            lblWelUserName.Text = $"Welcome, {_username}";


        }

        private void HouseOwnerDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); // Show the parent form if it exists
            }

        }


        private void btnRentedFlatsandIncome_Click(object sender, EventArgs e)
        {
            int houseOwnerId = GetHouseOwnerIdByUsername(_username);
            if (houseOwnerId <= 0)
            {
                MessageBox.Show("Could not find HouseOwnerID for this user.");
                return;
            }

            var hOFI = new HouseOwnerFlatsIncome(houseOwnerId);
            hOFI.TopLevel = false;
            hOFI.AutoScroll = true;
            hOFI.FormBorderStyle = FormBorderStyle.None;
            hOFI.Dock = DockStyle.Fill;

            this.panelHouseOwnerLoad.Controls.Clear();
            this.panelHouseOwnerLoad.Controls.Add(hOFI);
            hOFI.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {

            hOA.TopLevel = false;
            hOA.AutoScroll = true;
            hOA.FormBorderStyle = FormBorderStyle.None;
            hOA.Dock = DockStyle.Fill;

            this.panelHouseOwnerLoad.Controls.Clear();
            this.panelHouseOwnerLoad.Controls.Add(hOA);
            hOA.Show();
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
