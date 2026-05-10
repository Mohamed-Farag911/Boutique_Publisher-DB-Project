namespace Boutique_Publisher
{
    partial class RoyaltyReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvRoyalty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRoyalties = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoyalty)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Boutique_Publisher.Properties.Resources.refresh_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvRoyalty
            // 
            this.dgvRoyalty.AllowUserToAddRows = false;
            this.dgvRoyalty.AllowUserToDeleteRows = false;
            this.dgvRoyalty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoyalty.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvRoyalty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoyalty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoyalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoyalty.EnableHeadersVisualStyles = false;
            this.dgvRoyalty.GridColor = System.Drawing.Color.Black;
            this.dgvRoyalty.Location = new System.Drawing.Point(164, 12);
            this.dgvRoyalty.Name = "dgvRoyalty";
            this.dgvRoyalty.ReadOnly = true;
            this.dgvRoyalty.RowHeadersVisible = false;
            this.dgvRoyalty.Size = new System.Drawing.Size(883, 445);
            this.dgvRoyalty.TabIndex = 3;
            this.dgvRoyalty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoyalty_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Royalries";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Location = new System.Drawing.Point(263, 506);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Revenue";
            // 
            // lblTotalRoyalties
            // 
            this.lblTotalRoyalties.AutoSize = true;
            this.lblTotalRoyalties.Location = new System.Drawing.Point(562, 506);
            this.lblTotalRoyalties.Name = "lblTotalRoyalties";
            this.lblTotalRoyalties.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRoyalties.TabIndex = 4;
            this.lblTotalRoyalties.Text = "label1";
            // 
            // RoyaltyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 658);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalRoyalties);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRoyalty);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RoyaltyReport";
            this.Text = "RoyaltyReport";
            this.Load += new System.EventHandler(this.RoyaltyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoyalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRoyalty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRoyalties;
    }
}