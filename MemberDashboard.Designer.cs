namespace Mess_Management_System
{
    partial class MemberDashboard
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
            this.btnhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnBillingInformation = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUtilityPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRentPay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelUserName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblHouseOwnerView = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAnnouncements);
            this.panel2.Controls.Add(this.btnBillingInformation);
            this.panel2.Controls.Add(this.btnPayments);
            this.panel2.Controls.Add(this.btnhome);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 646);
            this.panel2.TabIndex = 2;
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAnnouncements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnouncements.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.Gray;
            this.btnAnnouncements.Location = new System.Drawing.Point(0, 183);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(208, 61);
            this.btnAnnouncements.TabIndex = 8;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            // 
            // btnBillingInformation
            // 
            this.btnBillingInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBillingInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillingInformation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillingInformation.ForeColor = System.Drawing.Color.Gray;
            this.btnBillingInformation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBillingInformation.Location = new System.Drawing.Point(0, 122);
            this.btnBillingInformation.Name = "btnBillingInformation";
            this.btnBillingInformation.Size = new System.Drawing.Size(208, 61);
            this.btnBillingInformation.TabIndex = 7;
            this.btnBillingInformation.Text = "Billing Information";
            this.btnBillingInformation.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.Gray;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPayments.Location = new System.Drawing.Point(0, 61);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(208, 61);
            this.btnPayments.TabIndex = 2;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnBillsandPayments_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpPayDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtUtilityPay);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtRentPay);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1091, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 587);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPayDate.Location = new System.Drawing.Point(16, 186);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(244, 27);
            this.dtpPayDate.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pay Date:";
            // 
            // txtUtilityPay
            // 
            this.txtUtilityPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUtilityPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilityPay.Location = new System.Drawing.Point(16, 125);
            this.txtUtilityPay.Name = "txtUtilityPay";
            this.txtUtilityPay.Size = new System.Drawing.Size(244, 27);
            this.txtUtilityPay.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Utility Pay:";
            // 
            // txtRentPay
            // 
            this.txtRentPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentPay.Location = new System.Drawing.Point(16, 64);
            this.txtRentPay.Name = "txtRentPay";
            this.txtRentPay.Size = new System.Drawing.Size(244, 27);
            this.txtRentPay.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rent Pay:";
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(228, 90);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(857, 588);
            this.dgvMember.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(228, 685);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(857, 52);
            this.panel4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(706, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Create";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(359, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblWelUserName);
            this.panel1.Location = new System.Drawing.Point(379, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 59);
            this.panel1.TabIndex = 22;
            // 
            // lblWelUserName
            // 
            this.lblWelUserName.AutoSize = true;
            this.lblWelUserName.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblWelUserName.Location = new System.Drawing.Point(294, 2);
            this.lblWelUserName.Name = "lblWelUserName";
            this.lblWelUserName.Size = new System.Drawing.Size(400, 53);
            this.lblWelUserName.TabIndex = 2;
            this.lblWelUserName.Text = "Welcome, UserName";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblHouseOwnerView);
            this.panel5.Location = new System.Drawing.Point(13, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 60);
            this.panel5.TabIndex = 21;
            // 
            // lblHouseOwnerView
            // 
            this.lblHouseOwnerView.AutoSize = true;
            this.lblHouseOwnerView.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseOwnerView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHouseOwnerView.Location = new System.Drawing.Point(86, 3);
            this.lblHouseOwnerView.Name = "lblHouseOwnerView";
            this.lblHouseOwnerView.Size = new System.Drawing.Size(178, 53);
            this.lblHouseOwnerView.TabIndex = 0;
            this.lblHouseOwnerView.Text = "Member";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Location = new System.Drawing.Point(1091, 686);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 51);
            this.panel6.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(277, 49);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "MemberDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberDashboard_FormClosing);
            this.Load += new System.EventHandler(this.MemberDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblHouseOwnerView;
        private System.Windows.Forms.Label lblWelUserName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Button btnBillingInformation;
        private System.Windows.Forms.TextBox txtRentPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUtilityPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.Label label4;
    }
}

