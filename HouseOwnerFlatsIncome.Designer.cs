namespace Mess_Management_System
{
    partial class HouseOwnerFlatsIncome
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHouseOwner = new System.Windows.Forms.DataGridView();
            this.panelAnnouncements = new System.Windows.Forms.Panel();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblnote = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHouseOwner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlatAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseOwner)).BeginInit();
            this.panelAnnouncements.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.36777F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.63223F));
            this.tableLayoutPanel1.Controls.Add(this.dgvHouseOwner, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelAnnouncements, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 540);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.dgvHouseOwner.Size = new System.Drawing.Size(773, 487);
            this.dgvHouseOwner.TabIndex = 39;
            // 
            // panelAnnouncements
            // 
            this.panelAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnnouncements.Controls.Add(this.txtFlatAddress);
            this.panelAnnouncements.Controls.Add(this.txtHouseOwner);
            this.panelAnnouncements.Controls.Add(this.label1);
            this.panelAnnouncements.Controls.Add(this.rtxtDescription);
            this.panelAnnouncements.Controls.Add(this.lblnote);
            this.panelAnnouncements.Controls.Add(this.label5);
            this.panelAnnouncements.Controls.Add(this.txtRent);
            this.panelAnnouncements.Controls.Add(this.label2);
            this.panelAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnnouncements.Location = new System.Drawing.Point(782, 3);
            this.panelAnnouncements.Name = "panelAnnouncements";
            this.panelAnnouncements.Size = new System.Drawing.Size(338, 487);
            this.panelAnnouncements.TabIndex = 40;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(23, 196);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(298, 92);
            this.rtxtDescription.TabIndex = 43;
            this.rtxtDescription.Text = "";
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.Location = new System.Drawing.Point(23, 173);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(100, 20);
            this.lblnote.TabIndex = 42;
            this.lblnote.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Flat Address:";
            // 
            // txtRent
            // 
            this.txtRent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRent.Location = new System.Drawing.Point(23, 124);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(298, 27);
            this.txtRent.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Rent:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 41);
            this.panel1.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(336, 39);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(625, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(313, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightGreen;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(0, 0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(146, 39);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(782, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 41);
            this.panel2.TabIndex = 42;
            // 
            // txtHouseOwner
            // 
            this.txtHouseOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHouseOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseOwner.Location = new System.Drawing.Point(23, 334);
            this.txtHouseOwner.Name = "txtHouseOwner";
            this.txtHouseOwner.Size = new System.Drawing.Size(298, 27);
            this.txtHouseOwner.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "House Owner:";
            // 
            // txtFlatAddress
            // 
            this.txtFlatAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlatAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlatAddress.Location = new System.Drawing.Point(23, 54);
            this.txtFlatAddress.Name = "txtFlatAddress";
            this.txtFlatAddress.Size = new System.Drawing.Size(298, 27);
            this.txtFlatAddress.TabIndex = 46;
            // 
            // HouseOwnerFlatsIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HouseOwnerFlatsIncome";
            this.Text = "HouseOwnerFlatsIncome";
            this.Load += new System.EventHandler(this.HouseOwnerFlatsIncome_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseOwner)).EndInit();
            this.panelAnnouncements.ResumeLayout(false);
            this.panelAnnouncements.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHouseOwner;
        private System.Windows.Forms.Panel panelAnnouncements;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHouseOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFlatAddress;
    }
}