namespace Mess_Management_System
{
    partial class ChiefDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiefDashboard));
            this.btnhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnMealData = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblWelUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHouseOwnerView = new System.Windows.Forms.Label();
            this.panelChiefLoad = new System.Windows.Forms.Panel();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAnnouncements);
            this.panel2.Controls.Add(this.btnMealData);
            this.panel2.Controls.Add(this.btnhome);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 646);
            this.panel2.TabIndex = 10;
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAnnouncements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnouncements.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncements.Location = new System.Drawing.Point(0, 122);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(208, 61);
            this.btnAnnouncements.TabIndex = 5;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // btnMealData
            // 
            this.btnMealData.BackColor = System.Drawing.Color.BlueViolet;
            this.btnMealData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMealData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealData.ForeColor = System.Drawing.Color.White;
            this.btnMealData.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMealData.Location = new System.Drawing.Point(0, 61);
            this.btnMealData.Name = "btnMealData";
            this.btnMealData.Size = new System.Drawing.Size(208, 61);
            this.btnMealData.TabIndex = 1;
            this.btnMealData.Text = "Meal Data";
            this.btnMealData.UseVisualStyleBackColor = false;
            this.btnMealData.Click += new System.EventHandler(this.btnMealData_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblWelUserName);
            this.panel4.Location = new System.Drawing.Point(379, 15);
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
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 60);
            this.panel1.TabIndex = 19;
            // 
            // lblHouseOwnerView
            // 
            this.lblHouseOwnerView.AutoSize = true;
            this.lblHouseOwnerView.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseOwnerView.ForeColor = System.Drawing.Color.White;
            this.lblHouseOwnerView.Location = new System.Drawing.Point(104, 3);
            this.lblHouseOwnerView.Name = "lblHouseOwnerView";
            this.lblHouseOwnerView.Size = new System.Drawing.Size(116, 53);
            this.lblHouseOwnerView.TabIndex = 0;
            this.lblHouseOwnerView.Text = "Chief";
            // 
            // panelChiefLoad
            // 
            this.panelChiefLoad.BackColor = System.Drawing.Color.Transparent;
            this.panelChiefLoad.Location = new System.Drawing.Point(228, 92);
            this.panelChiefLoad.Name = "panelChiefLoad";
            this.panelChiefLoad.Size = new System.Drawing.Size(1141, 645);
            this.panelChiefLoad.TabIndex = 23;
            // 
            // ChiefDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panelChiefLoad);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ChiefDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chief Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiefDashboard_FormClosing);
            this.Load += new System.EventHandler(this.ChiefDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Button btnMealData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHouseOwnerView;
        private System.Windows.Forms.Label lblWelUserName;
        private System.Windows.Forms.Panel panelChiefLoad;
    }
}