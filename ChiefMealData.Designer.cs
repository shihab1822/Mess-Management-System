namespace Mess_Management_System
{
    partial class ChiefMealData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiefMealData));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblFoodDescription = new System.Windows.Forms.Label();
            this.dgvChief = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChief)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvChief, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpJoiningDate);
            this.panel3.Controls.Add(this.lblMealDate);
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.lblFoodDescription);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(789, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 487);
            this.panel3.TabIndex = 14;
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.Location = new System.Drawing.Point(25, 64);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(256, 27);
            this.dtpJoiningDate.TabIndex = 35;
            // 
            // lblMealDate
            // 
            this.lblMealDate.AutoSize = true;
            this.lblMealDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealDate.ForeColor = System.Drawing.Color.White;
            this.lblMealDate.Location = new System.Drawing.Point(25, 33);
            this.lblMealDate.Name = "lblMealDate";
            this.lblMealDate.Size = new System.Drawing.Size(91, 20);
            this.lblMealDate.TabIndex = 34;
            this.lblMealDate.Text = "Meal Date:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(256, 95);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // lblFoodDescription
            // 
            this.lblFoodDescription.AutoSize = true;
            this.lblFoodDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodDescription.ForeColor = System.Drawing.Color.White;
            this.lblFoodDescription.Location = new System.Drawing.Point(25, 108);
            this.lblFoodDescription.Name = "lblFoodDescription";
            this.lblFoodDescription.Size = new System.Drawing.Size(142, 20);
            this.lblFoodDescription.TabIndex = 29;
            this.lblFoodDescription.Text = "Food Description:";
            // 
            // dgvChief
            // 
            this.dgvChief.AllowUserToAddRows = false;
            this.dgvChief.AllowUserToDeleteRows = false;
            this.dgvChief.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChief.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChief.Location = new System.Drawing.Point(3, 3);
            this.dgvChief.Name = "dgvChief";
            this.dgvChief.ReadOnly = true;
            this.dgvChief.RowHeadersWidth = 51;
            this.dgvChief.RowTemplate.Height = 24;
            this.dgvChief.Size = new System.Drawing.Size(780, 487);
            this.dgvChief.TabIndex = 13;
            // 
            // ChiefMealData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChiefMealData";
            this.Text = "ChiefMealData";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChief)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvChief;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Label lblMealDate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblFoodDescription;
    }
}