﻿using System;
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
    public partial class MemberDashboard: Form
    {
        public MemberDashboard()
        {
            InitializeComponent();
        }

        private string _username;
        public MemberDashboard(string username) : this()
        {
            _username = username;
        }
        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide(); // Hide the parent form if it exists
            }
            lblWelUserName.Text = $"Welcome, {_username}";
        }

        private void MemberDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); // show  the parent form if it exists
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {

        }

        private void btnRentaFlat_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            MemberAnnounce mA = new MemberAnnounce();
            mA.TopLevel = false;
            mA.AutoScroll = true;
            mA.FormBorderStyle = FormBorderStyle.None;
            mA.Dock = DockStyle.Fill;

            this.panelMemberLoad.Controls.Clear();
            this.panelMemberLoad.Controls.Add(mA);
            mA.Show();
        }

        private void btnBillingInformation_Click(object sender, EventArgs e)
        {
            BillingInformation bi = new BillingInformation();
            bi.TopLevel = false;
            bi.AutoScroll = true;
            bi.FormBorderStyle = FormBorderStyle.None;
            bi.Dock = DockStyle.Fill;

            this.panelMemberLoad.Controls.Clear();
            this.panelMemberLoad.Controls.Add(bi);
            bi.Show();
        }
    }
}
