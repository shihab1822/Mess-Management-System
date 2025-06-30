namespace Mess_Management_System
{
    partial class ManagerAssignChiefs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerAssignChiefs));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.penalFlatsAndIncome = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMealTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.rtxtMealDescription = new System.Windows.Forms.RichTextBox();
            this.lblFoodDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMemberID = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.penalFlatsAndIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.45681F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.54319F));
            this.tableLayoutPanel1.Controls.Add(this.penalFlatsAndIncome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvManager, 0, 0);
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
            // penalFlatsAndIncome
            // 
            this.penalFlatsAndIncome.BackColor = System.Drawing.Color.Transparent;
            this.penalFlatsAndIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penalFlatsAndIncome.Controls.Add(this.cmbMemberID);
            this.penalFlatsAndIncome.Controls.Add(this.label1);
            this.penalFlatsAndIncome.Controls.Add(this.txtMealTime);
            this.penalFlatsAndIncome.Controls.Add(this.label5);
            this.penalFlatsAndIncome.Controls.Add(this.dtpDate);
            this.penalFlatsAndIncome.Controls.Add(this.lblMealDate);
            this.penalFlatsAndIncome.Controls.Add(this.rtxtMealDescription);
            this.penalFlatsAndIncome.Controls.Add(this.lblFoodDescription);
            this.penalFlatsAndIncome.Controls.Add(this.btnClear);
            this.penalFlatsAndIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penalFlatsAndIncome.Location = new System.Drawing.Point(783, 3);
            this.penalFlatsAndIncome.Name = "penalFlatsAndIncome";
            this.penalFlatsAndIncome.Size = new System.Drawing.Size(337, 487);
            this.penalFlatsAndIncome.TabIndex = 40;
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvManager
            // 
            this.dgvManager.AllowUserToAddRows = false;
            this.dgvManager.AllowUserToDeleteRows = false;
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManager.Location = new System.Drawing.Point(3, 3);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.ReadOnly = true;
            this.dgvManager.RowHeadersWidth = 51;
            this.dgvManager.RowTemplate.Height = 24;
            this.dgvManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManager.Size = new System.Drawing.Size(774, 487);
            this.dgvManager.TabIndex = 39;
            this.dgvManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManager_CellClick);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMealTime
            // 
            this.txtMealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealTime.Location = new System.Drawing.Point(27, 226);
            this.txtMealTime.Name = "txtMealTime";
            this.txtMealTime.Size = new System.Drawing.Size(252, 34);
            this.txtMealTime.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Meal Time:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(27, 150);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(256, 27);
            this.dtpDate.TabIndex = 47;
            // 
            // lblMealDate
            // 
            this.lblMealDate.AutoSize = true;
            this.lblMealDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealDate.ForeColor = System.Drawing.Color.White;
            this.lblMealDate.Location = new System.Drawing.Point(27, 115);
            this.lblMealDate.Name = "lblMealDate";
            this.lblMealDate.Size = new System.Drawing.Size(101, 20);
            this.lblMealDate.TabIndex = 46;
            this.lblMealDate.Text = "Meal Date:";
            // 
            // rtxtMealDescription
            // 
            this.rtxtMealDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMealDescription.Location = new System.Drawing.Point(27, 298);
            this.rtxtMealDescription.Name = "rtxtMealDescription";
            this.rtxtMealDescription.Size = new System.Drawing.Size(256, 95);
            this.rtxtMealDescription.TabIndex = 45;
            this.rtxtMealDescription.Text = "";
            // 
            // lblFoodDescription
            // 
            this.lblFoodDescription.AutoSize = true;
            this.lblFoodDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodDescription.ForeColor = System.Drawing.Color.White;
            this.lblFoodDescription.Location = new System.Drawing.Point(27, 275);
            this.lblFoodDescription.Name = "lblFoodDescription";
            this.lblFoodDescription.Size = new System.Drawing.Size(159, 20);
            this.lblFoodDescription.TabIndex = 44;
            this.lblFoodDescription.Text = "Food Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Member ID:";
            // 
            // cmbMemberID
            // 
            this.cmbMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMemberID.FormattingEnabled = true;
            this.cmbMemberID.Location = new System.Drawing.Point(27, 70);
            this.cmbMemberID.Name = "cmbMemberID";
            this.cmbMemberID.Size = new System.Drawing.Size(251, 28);
            this.cmbMemberID.TabIndex = 51;
            // 
            // ManagerAssignChiefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManagerAssignChiefs";
            this.Text = "ManagerAssignChiefs";
            this.Load += new System.EventHandler(this.ManagerAssignChiefs_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.penalFlatsAndIncome.ResumeLayout(false);
            this.penalFlatsAndIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel penalFlatsAndIncome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMealTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblMealDate;
        private System.Windows.Forms.RichTextBox rtxtMealDescription;
        private System.Windows.Forms.Label lblFoodDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMemberID;
    }
}