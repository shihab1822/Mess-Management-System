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
    public partial class ChiefDashboard : Form
    {
        public ChiefDashboard()
        {
            InitializeComponent();
        }

        ChiefAnnounce chA = new ChiefAnnounce();
        ChiefMealData chMD = new ChiefMealData();

        private string _username;
        public ChiefDashboard(string username) : this()
        {
            _username = username;
        }
        private void ChiefDashboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide(); // Hide the parent form if it exists
            }
            lblWelUserName.Text = $"Welcome, {_username}";
        }

        private void ChiefDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); // Hide the parent form if it exists
            }
        }

        private void btnMealData_Click(object sender, EventArgs e)
        {
            chMD.TopLevel = false;
            chMD.AutoScroll = true;
            chMD.FormBorderStyle = FormBorderStyle.None;
            chMD.Dock = DockStyle.Fill;

            this.panelChiefLoad.Controls.Clear();
            this.panelChiefLoad.Controls.Add(chMD);
            chMD.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            chA.TopLevel = false;
            chA.AutoScroll = true;
            chA.FormBorderStyle = FormBorderStyle.None;
            chA.Dock = DockStyle.Fill;

            this.panelChiefLoad.Controls.Clear();
            this.panelChiefLoad.Controls.Add(chA);
            chA.Show();

        }
    }
}
