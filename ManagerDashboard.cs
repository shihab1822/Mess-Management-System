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
            ManageMembers mm = new ManageMembers();
            mm.TopLevel = false;
            mm.AutoScroll = true;
            mm.FormBorderStyle = FormBorderStyle.None;
            mm.Dock = DockStyle.Fill;

            this.panelManagerLoad.Controls.Clear();
            this.panelManagerLoad.Controls.Add(mm);
            mm.Show();


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

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            ManagerAnnounce maNA = new ManagerAnnounce();
            maNA.TopLevel = false;
            maNA.AutoScroll = true;
            maNA.FormBorderStyle = FormBorderStyle.None;
            maNA.Dock = DockStyle.Fill;

            this.panelManagerLoad.Controls.Clear();
            this.panelManagerLoad.Controls.Add(maNA);
            maNA.Show();
        }

        private void btnAssignChiefs_Click(object sender, EventArgs e)
        {
            ManagerAssignChiefs maAC = new ManagerAssignChiefs();
            maAC.TopLevel = false;
            maAC.AutoScroll = true;
            maAC.FormBorderStyle = FormBorderStyle.None;
            maAC.Dock = DockStyle.Fill;

            this.panelManagerLoad.Controls.Clear();
            this.panelManagerLoad.Controls.Add(maAC);
            maAC.Show();
        }

        private void btnBillingInformation_Click(object sender, EventArgs e)
        {
            BillingInformation bi = new BillingInformation();
            bi.TopLevel = false;
            bi.AutoScroll = true;
            bi.FormBorderStyle = FormBorderStyle.None;
            bi.Dock = DockStyle.Fill;

            this.panelManagerLoad.Controls.Clear();
            this.panelManagerLoad.Controls.Add(bi);
            bi.Show();
        }
    }
}


