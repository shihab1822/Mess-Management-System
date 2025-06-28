using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mess_Management_System
{
    public partial class HouseOwnerDashboard : Form
    {
        public HouseOwnerDashboard()
        {
            InitializeComponent();
        }

        HouseOwnerFlatsIncome hOFI = new HouseOwnerFlatsIncome(); 
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
    }
}
