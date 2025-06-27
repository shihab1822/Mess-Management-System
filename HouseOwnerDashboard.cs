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
    }
}
