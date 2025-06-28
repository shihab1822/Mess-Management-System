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
            this.richTextBoxnote = new System.Windows.Forms.RichTextBox();
            this.lblnote = new System.Windows.Forms.Label();
            this.cmbFlatNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseOwner)).BeginInit();
            this.panelAnnouncements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.36777F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.63223F));
            this.tableLayoutPanel1.Controls.Add(this.dgvHouseOwner, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelAnnouncements, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvHouseOwner
            // 
            this.dgvHouseOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouseOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHouseOwner.Location = new System.Drawing.Point(3, 3);
            this.dgvHouseOwner.Name = "dgvHouseOwner";
            this.dgvHouseOwner.RowHeadersWidth = 51;
            this.dgvHouseOwner.RowTemplate.Height = 24;
            this.dgvHouseOwner.Size = new System.Drawing.Size(773, 534);
            this.dgvHouseOwner.TabIndex = 39;
            // 
            // panelAnnouncements
            // 
            this.panelAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnnouncements.Controls.Add(this.richTextBoxnote);
            this.panelAnnouncements.Controls.Add(this.lblnote);
            this.panelAnnouncements.Controls.Add(this.cmbFlatNo);
            this.panelAnnouncements.Controls.Add(this.label5);
            this.panelAnnouncements.Controls.Add(this.txtIncome);
            this.panelAnnouncements.Controls.Add(this.label2);
            this.panelAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnnouncements.Location = new System.Drawing.Point(782, 3);
            this.panelAnnouncements.Name = "panelAnnouncements";
            this.panelAnnouncements.Size = new System.Drawing.Size(338, 534);
            this.panelAnnouncements.TabIndex = 40;
            // 
            // richTextBoxnote
            // 
            this.richTextBoxnote.Location = new System.Drawing.Point(19, 196);
            this.richTextBoxnote.Name = "richTextBoxnote";
            this.richTextBoxnote.Size = new System.Drawing.Size(298, 92);
            this.richTextBoxnote.TabIndex = 43;
            this.richTextBoxnote.Text = "";
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.Location = new System.Drawing.Point(19, 173);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(49, 20);
            this.lblnote.TabIndex = 42;
            this.lblnote.Text = "Note:";
            // 
            // cmbFlatNo
            // 
            this.cmbFlatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFlatNo.FormattingEnabled = true;
            this.cmbFlatNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbFlatNo.Location = new System.Drawing.Point(19, 54);
            this.cmbFlatNo.Name = "cmbFlatNo";
            this.cmbFlatNo.Size = new System.Drawing.Size(298, 28);
            this.cmbFlatNo.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Flat No:";
            // 
            // txtIncome
            // 
            this.txtIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(19, 124);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(298, 27);
            this.txtIncome.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Income:";
            // 
            // HouseOwnerFlatsIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HouseOwnerFlatsIncome";
            this.Text = "HouseOwnerFlatsIncome";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseOwner)).EndInit();
            this.panelAnnouncements.ResumeLayout(false);
            this.panelAnnouncements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHouseOwner;
        private System.Windows.Forms.Panel panelAnnouncements;
        private System.Windows.Forms.RichTextBox richTextBoxnote;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.ComboBox cmbFlatNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label2;
    }
}