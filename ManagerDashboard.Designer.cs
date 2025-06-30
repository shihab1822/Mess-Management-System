namespace Mess_Management_System
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            this.btnhome = new System.Windows.Forms.Button();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkbIsManager = new System.Windows.Forms.CheckBox();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnBillingInformation = new System.Windows.Forms.Button();
            this.btnAssignChiefs = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblWelUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHouseOwnerView = new System.Windows.Forms.Label();
            this.panelManagerLoad = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.BlueViolet;
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 0);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(208, 61);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            // 
            // dgvManager
            // 
            this.dgvManager.AllowUserToAddRows = false;
            this.dgvManager.AllowUserToDeleteRows = false;
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Location = new System.Drawing.Point(228, 91);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.ReadOnly = true;
            this.dgvManager.RowHeadersWidth = 51;
            this.dgvManager.RowTemplate.Height = 24;
            this.dgvManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManager.Size = new System.Drawing.Size(857, 588);
            this.dgvManager.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbUsername);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.chkbIsManager);
            this.panel3.Controls.Add(this.dtpJoiningDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtMemberName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtMemberID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1091, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 588);
            this.panel3.TabIndex = 7;
            // 
            // cmbUsername
            // 
            this.cmbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(36, 54);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(185, 28);
            this.cmbUsername.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Username:";
            // 
            // chkbIsManager
            // 
            this.chkbIsManager.AutoSize = true;
            this.chkbIsManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbIsManager.Location = new System.Drawing.Point(160, 247);
            this.chkbIsManager.Name = "chkbIsManager";
            this.chkbIsManager.Size = new System.Drawing.Size(18, 17);
            this.chkbIsManager.TabIndex = 22;
            this.chkbIsManager.UseVisualStyleBackColor = true;
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.Location = new System.Drawing.Point(36, 316);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(189, 27);
            this.dtpJoiningDate.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Joining Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Is Manager:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtMemberName.Location = new System.Drawing.Point(36, 193);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(184, 27);
            this.txtMemberName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtMemberID.Location = new System.Drawing.Point(36, 125);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(184, 27);
            this.txtMemberID.TabIndex = 14;
            this.txtMemberID.Text = "Auto Generated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Member ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAnnouncements);
            this.panel2.Controls.Add(this.btnBillingInformation);
            this.panel2.Controls.Add(this.btnAssignChiefs);
            this.panel2.Controls.Add(this.btnManageMembers);
            this.panel2.Controls.Add(this.btnhome);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 646);
            this.panel2.TabIndex = 6;
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAnnouncements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnouncements.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncements.Location = new System.Drawing.Point(0, 244);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(208, 61);
            this.btnAnnouncements.TabIndex = 5;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // btnBillingInformation
            // 
            this.btnBillingInformation.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBillingInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillingInformation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillingInformation.ForeColor = System.Drawing.Color.White;
            this.btnBillingInformation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBillingInformation.Location = new System.Drawing.Point(0, 183);
            this.btnBillingInformation.Name = "btnBillingInformation";
            this.btnBillingInformation.Size = new System.Drawing.Size(208, 61);
            this.btnBillingInformation.TabIndex = 4;
            this.btnBillingInformation.Text = "Billing Information";
            this.btnBillingInformation.UseVisualStyleBackColor = false;
            this.btnBillingInformation.Click += new System.EventHandler(this.btnBillingInformation_Click);
            // 
            // btnAssignChiefs
            // 
            this.btnAssignChiefs.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAssignChiefs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignChiefs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignChiefs.ForeColor = System.Drawing.Color.White;
            this.btnAssignChiefs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAssignChiefs.Location = new System.Drawing.Point(0, 122);
            this.btnAssignChiefs.Name = "btnAssignChiefs";
            this.btnAssignChiefs.Size = new System.Drawing.Size(208, 61);
            this.btnAssignChiefs.TabIndex = 2;
            this.btnAssignChiefs.Text = "Assign Chiefs";
            this.btnAssignChiefs.UseVisualStyleBackColor = false;
            this.btnAssignChiefs.Click += new System.EventHandler(this.btnAssignChiefs_Click);
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.BackColor = System.Drawing.Color.BlueViolet;
            this.btnManageMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageMembers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMembers.ForeColor = System.Drawing.Color.White;
            this.btnManageMembers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnManageMembers.Location = new System.Drawing.Point(0, 61);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(208, 61);
            this.btnManageMembers.TabIndex = 1;
            this.btnManageMembers.Text = "Manage Members";
            this.btnManageMembers.UseVisualStyleBackColor = false;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblWelUserName);
            this.panel4.Location = new System.Drawing.Point(379, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 59);
            this.panel4.TabIndex = 20;
            // 
            // lblWelUserName
            // 
            this.lblWelUserName.AutoSize = true;
            this.lblWelUserName.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelUserName.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblWelUserName.Location = new System.Drawing.Point(294, 2);
            this.lblWelUserName.Name = "lblWelUserName";
            this.lblWelUserName.Size = new System.Drawing.Size(400, 53);
            this.lblWelUserName.TabIndex = 2;
            this.lblWelUserName.Text = "Welcome, UserName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHouseOwnerView);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 60);
            this.panel1.TabIndex = 19;
            // 
            // lblHouseOwnerView
            // 
            this.lblHouseOwnerView.AutoSize = true;
            this.lblHouseOwnerView.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseOwnerView.ForeColor = System.Drawing.Color.White;
            this.lblHouseOwnerView.Location = new System.Drawing.Point(83, 2);
            this.lblHouseOwnerView.Name = "lblHouseOwnerView";
            this.lblHouseOwnerView.Size = new System.Drawing.Size(183, 53);
            this.lblHouseOwnerView.TabIndex = 0;
            this.lblHouseOwnerView.Text = "Manager";
            // 
            // panelManagerLoad
            // 
            this.panelManagerLoad.BackColor = System.Drawing.Color.Transparent;
            this.panelManagerLoad.Location = new System.Drawing.Point(229, 92);
            this.panelManagerLoad.Name = "panelManagerLoad";
            this.panelManagerLoad.Size = new System.Drawing.Size(1141, 645);
            this.panelManagerLoad.TabIndex = 24;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panelManagerLoad);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvManager);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerDashboard_FormClosing);
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Button btnBillingInformation;
        private System.Windows.Forms.Button btnAssignChiefs;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHouseOwnerView;
        private System.Windows.Forms.Label lblWelUserName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.CheckBox chkbIsManager;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelManagerLoad;
    }
}