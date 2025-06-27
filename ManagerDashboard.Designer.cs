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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblManagerView = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnBillingInformation = new System.Windows.Forms.Button();
            this.btnViewFlatRentals = new System.Windows.Forms.Button();
            this.btnAssignChiefs = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblManagerView);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 69);
            this.panel1.TabIndex = 5;
            // 
            // lblManagerView
            // 
            this.lblManagerView.AutoSize = true;
            this.lblManagerView.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblManagerView.Location = new System.Drawing.Point(569, 17);
            this.lblManagerView.Name = "lblManagerView";
            this.lblManagerView.Size = new System.Drawing.Size(184, 35);
            this.lblManagerView.TabIndex = 0;
            this.lblManagerView.Text = "Manager View";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnhome.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.Gray;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnhome.Location = new System.Drawing.Point(3, 13);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(204, 61);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            // 
            // dgvManager
            // 
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Location = new System.Drawing.Point(228, 91);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.RowHeadersWidth = 51;
            this.dgvManager.RowTemplate.Height = 24;
            this.dgvManager.Size = new System.Drawing.Size(926, 646);
            this.dgvManager.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1160, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 646);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnAnnouncements);
            this.panel2.Controls.Add(this.btnBillingInformation);
            this.panel2.Controls.Add(this.btnViewFlatRentals);
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
            this.btnAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAnnouncements.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.Gray;
            this.btnAnnouncements.Location = new System.Drawing.Point(3, 348);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(204, 61);
            this.btnAnnouncements.TabIndex = 5;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            // 
            // btnBillingInformation
            // 
            this.btnBillingInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBillingInformation.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillingInformation.ForeColor = System.Drawing.Color.Gray;
            this.btnBillingInformation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBillingInformation.Location = new System.Drawing.Point(3, 281);
            this.btnBillingInformation.Name = "btnBillingInformation";
            this.btnBillingInformation.Size = new System.Drawing.Size(204, 61);
            this.btnBillingInformation.TabIndex = 4;
            this.btnBillingInformation.Text = "Billing Information";
            this.btnBillingInformation.UseVisualStyleBackColor = false;
            // 
            // btnViewFlatRentals
            // 
            this.btnViewFlatRentals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewFlatRentals.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFlatRentals.ForeColor = System.Drawing.Color.Gray;
            this.btnViewFlatRentals.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnViewFlatRentals.Location = new System.Drawing.Point(3, 214);
            this.btnViewFlatRentals.Name = "btnViewFlatRentals";
            this.btnViewFlatRentals.Size = new System.Drawing.Size(204, 61);
            this.btnViewFlatRentals.TabIndex = 3;
            this.btnViewFlatRentals.Text = "View Flat Rentals";
            this.btnViewFlatRentals.UseVisualStyleBackColor = false;
            // 
            // btnAssignChiefs
            // 
            this.btnAssignChiefs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAssignChiefs.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignChiefs.ForeColor = System.Drawing.Color.Gray;
            this.btnAssignChiefs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAssignChiefs.Location = new System.Drawing.Point(3, 147);
            this.btnAssignChiefs.Name = "btnAssignChiefs";
            this.btnAssignChiefs.Size = new System.Drawing.Size(204, 61);
            this.btnAssignChiefs.TabIndex = 2;
            this.btnAssignChiefs.Text = "Assign Chiefs";
            this.btnAssignChiefs.UseVisualStyleBackColor = false;
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnManageMembers.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMembers.ForeColor = System.Drawing.Color.Gray;
            this.btnManageMembers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnManageMembers.Location = new System.Drawing.Point(3, 80);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(204, 61);
            this.btnManageMembers.TabIndex = 1;
            this.btnManageMembers.Text = "Manage Members";
            this.btnManageMembers.UseVisualStyleBackColor = false;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvManager);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerDashboard_FormClosing);
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManagerView;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Button btnBillingInformation;
        private System.Windows.Forms.Button btnViewFlatRentals;
        private System.Windows.Forms.Button btnAssignChiefs;
        private System.Windows.Forms.Button btnManageMembers;
    }
}