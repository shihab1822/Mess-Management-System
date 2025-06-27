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
    public partial class MemberDashboard: Form
    {
        public MemberDashboard()
        {
            InitializeComponent();
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide(); // Hide the parent form if it exists
            }
        }

        private void MemberDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); // show  the parent form if it exists
            }
        }
    }
}
