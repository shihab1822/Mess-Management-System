namespace Mess_Management_System
{
    partial class HouseOwnerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHouseOwnerView = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnRentedFlatsandIncome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblWelUserName = new System.Windows.Forms.Label();
            this.panelHouseOwnerLoad = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHouseOwnerView);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 60);
            this.panel1.TabIndex = 13;
            // 
            // lblHouseOwnerView
            // 
            this.lblHouseOwnerView.AutoSize = true;
            this.lblHouseOwnerView.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseOwnerView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHouseOwnerView.Location = new System.Drawing.Point(45, 2);
            this.lblHouseOwnerView.Name = "lblHouseOwnerView";
            this.lblHouseOwnerView.Size = new System.Drawing.Size(266, 53);
            this.lblHouseOwnerView.TabIndex = 0;
            this.lblHouseOwnerView.Text = "House Owner";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.Gray;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 0);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(208, 61);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAnnouncements);
            this.panel2.Controls.Add(this.btnRentedFlatsandIncome);
            this.panel2.Controls.Add(this.btnhome);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 646);
            this.panel2.TabIndex = 14;
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAnnouncements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnouncements.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.Gray;
            this.btnAnnouncements.Location = new System.Drawing.Point(0, 122);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(208, 61);
            this.btnAnnouncements.TabIndex = 5;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // btnRentedFlatsandIncome
            // 
            this.btnRentedFlatsandIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRentedFlatsandIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentedFlatsandIncome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentedFlatsandIncome.ForeColor = System.Drawing.Color.Gray;
            this.btnRentedFlatsandIncome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRentedFlatsandIncome.Location = new System.Drawing.Point(0, 61);
            this.btnRentedFlatsandIncome.Name = "btnRentedFlatsandIncome";
            this.btnRentedFlatsandIncome.Size = new System.Drawing.Size(208, 61);
            this.btnRentedFlatsandIncome.TabIndex = 2;
            this.btnRentedFlatsandIncome.Text = "Rented Flats and Income";
            this.btnRentedFlatsandIncome.UseVisualStyleBackColor = false;
            this.btnRentedFlatsandIncome.Click += new System.EventHandler(this.btnRentedFlatsandIncome_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblWelUserName);
            this.panel4.Location = new System.Drawing.Point(378, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 59);
            this.panel4.TabIndex = 18;
            // 
            // lblWelUserName
            // 
            this.lblWelUserName.AutoSize = true;
            this.lblWelUserName.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblWelUserName.Location = new System.Drawing.Point(294, 2);
            this.lblWelUserName.Name = "lblWelUserName";
            this.lblWelUserName.Size = new System.Drawing.Size(400, 53);
            this.lblWelUserName.TabIndex = 1;
            this.lblWelUserName.Text = "Welcome, UserName";
            // 
            // panelHouseOwnerLoad
            // 
            this.panelHouseOwnerLoad.Location = new System.Drawing.Point(228, 92);
            this.panelHouseOwnerLoad.Name = "panelHouseOwnerLoad";
            this.panelHouseOwnerLoad.Size = new System.Drawing.Size(1141, 645);
            this.panelHouseOwnerLoad.TabIndex = 23;
            // 
            // HouseOwnerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panelHouseOwnerLoad);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "HouseOwnerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Owner Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HouseOwnerDashboard_FormClosing);
            this.Load += new System.EventHandler(this.HouseOwnerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHouseOwnerView;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Button btnRentedFlatsandIncome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblWelUserName;
        private System.Windows.Forms.Panel panelHouseOwnerLoad;
    }
}