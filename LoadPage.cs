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
    public partial class LoadPage : Form
    {
        public LoadPage()
        {
            InitializeComponent();
        }

        private void LoadPage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();
        }
    }
}
