namespace Mess_Management_System
{
    partial class ManageMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMembers));
            this.penalFlatsAndIncome = new System.Windows.Forms.Panel();
            this.dtpAnnounce = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtxtAnnounce = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHouseOwner = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.penalFlatsAndIncome.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseOwner)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // penalFlatsAndIncome
            // 
            this.penalFlatsAndIncome.BackColor = System.Drawing.Color.Transparent;
            this.penalFlatsAndIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penalFlatsAndIncome.Controls.Add(this.dtpAnnounce);
            this.penalFlatsAndIncome.Controls.Add(this.label2);
            this.penalFlatsAndIncome.Controls.Add(this.btnClear);
            this.penalFlatsAndIncome.Controls.Add(this.rtxtAnnounce);
            this.penalFlatsAndIncome.Controls.Add(this.label1);
            this.penalFlatsAndIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penalFlatsAndIncome.Location = new System.Drawing.Point(783, 3);
            this.penalFlatsAndIncome.Name = "penalFlatsAndIncome";
            this.penalFlatsAndIncome.Size = new System.Drawing.Size(337, 487);
            this.penalFlatsAndIncome.TabIndex = 40;
            // 
            // dtpAnnounce
            // 
            this.dtpAnnounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAnnounce.Location = new System.Drawing.Point(18, 68);
            this.dtpAnnounce.Name = "dtpAnnounce";
            this.dtpAnnounce.Size = new System.Drawing.Size(295, 27);
            this.dtpAnnounce.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(0, 444);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(335, 41);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // rtxtAnnounce
            // 
            this.rtxtAnnounce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtAnnounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAnnounce.Location = new System.Drawing.Point(18, 147);
            this.rtxtAnnounce.Name = "rtxtAnnounce";
            this.rtxtAnnounce.Size = new System.Drawing.Size(295, 193);
            this.rtxtAnnounce.TabIndex = 39;
            this.rtxtAnnounce.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Message:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.45681F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.54319F));
            this.tableLayoutPanel1.Controls.Add(this.penalFlatsAndIncome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvHouseOwner, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 540);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvHouseOwner
            // 
            this.dgvHouseOwner.AllowUserToAddRows = false;
            this.dgvHouseOwner.AllowUserToDeleteRows = false;
            this.dgvHouseOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouseOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHouseOwner.Location = new System.Drawing.Point(3, 3);
            this.dgvHouseOwner.Name = "dgvHouseOwner";
            this.dgvHouseOwner.ReadOnly = true;
            this.dgvHouseOwner.RowHeadersWidth = 51;
            this.dgvHouseOwner.RowTemplate.Height = 24;
            this.dgvHouseOwner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouseOwner.Size = new System.Drawing.Size(774, 487);
            this.dgvHouseOwner.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 41);
            this.panel1.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(625, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 39);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(314, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 39);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightGreen;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(3, 0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(146, 39);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(783, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 41);
            this.panel2.TabIndex = 42;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(335, 39);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // ManageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageMembers";
            this.Text = "ManageMembers";
            this.penalFlatsAndIncome.ResumeLayout(false);
            this.penalFlatsAndIncome.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseOwner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel penalFlatsAndIncome;
        private System.Windows.Forms.DateTimePicker dtpAnnounce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtxtAnnounce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHouseOwner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
    }
}