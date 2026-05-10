namespace Boutique_Publisher
{
    partial class Author
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A_ID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Show_Data = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aUTHORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIOGRAPHYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOYALTYPERCENTAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSet = new Boutique_Publisher.BoutiquePublisherDBDataSet();
            this.aUTHORTableAdapter = new Boutique_Publisher.BoutiquePublisherDBDataSetTableAdapters.AUTHORTableAdapter();
            this.lable2 = new System.Windows.Forms.Label();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numRoyalty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoyalty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTHOR_ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // A_ID
            // 
            this.A_ID.Enabled = false;
            this.A_ID.Location = new System.Drawing.Point(157, 51);
            this.A_ID.Name = "A_ID";
            this.A_ID.Size = new System.Drawing.Size(82, 20);
            this.A_ID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 3;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Green;
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(52, 277);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(111, 62);
            this.insert.TabIndex = 4;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(190, 275);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(108, 68);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(325, 275);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(90, 68);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Show_Data
            // 
            this.Show_Data.Location = new System.Drawing.Point(661, 250);
            this.Show_Data.Name = "Show_Data";
            this.Show_Data.Size = new System.Drawing.Size(82, 32);
            this.Show_Data.TabIndex = 7;
            this.Show_Data.Text = "Show_Data";
            this.Show_Data.UseVisualStyleBackColor = true;
            this.Show_Data.Click += new System.EventHandler(this.Show_Data_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aUTHORIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.bIOGRAPHYDataGridViewTextBoxColumn,
            this.rOYALTYPERCENTAGEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aUTHORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(300, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 218);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aUTHORIDDataGridViewTextBoxColumn
            // 
            this.aUTHORIDDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR_ID";
            this.aUTHORIDDataGridViewTextBoxColumn.HeaderText = "AUTHOR_ID";
            this.aUTHORIDDataGridViewTextBoxColumn.Name = "aUTHORIDDataGridViewTextBoxColumn";
            this.aUTHORIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // bIOGRAPHYDataGridViewTextBoxColumn
            // 
            this.bIOGRAPHYDataGridViewTextBoxColumn.DataPropertyName = "BIOGRAPHY";
            this.bIOGRAPHYDataGridViewTextBoxColumn.HeaderText = "BIOGRAPHY";
            this.bIOGRAPHYDataGridViewTextBoxColumn.Name = "bIOGRAPHYDataGridViewTextBoxColumn";
            // 
            // rOYALTYPERCENTAGEDataGridViewTextBoxColumn
            // 
            this.rOYALTYPERCENTAGEDataGridViewTextBoxColumn.DataPropertyName = "ROYALTY_PERCENTAGE";
            this.rOYALTYPERCENTAGEDataGridViewTextBoxColumn.HeaderText = "ROYALTY_PERCENTAGE";
            this.rOYALTYPERCENTAGEDataGridViewTextBoxColumn.Name = "rOYALTYPERCENTAGEDataGridViewTextBoxColumn";
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.boutiquePublisherDBDataSetBindingSource;
            // 
            // boutiquePublisherDBDataSetBindingSource
            // 
            this.boutiquePublisherDBDataSetBindingSource.DataSource = this.boutiquePublisherDBDataSet;
            this.boutiquePublisherDBDataSetBindingSource.Position = 0;
            // 
            // boutiquePublisherDBDataSet
            // 
            this.boutiquePublisherDBDataSet.DataSetName = "BoutiquePublisherDBDataSet";
            this.boutiquePublisherDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(48, 157);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(80, 20);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "Biography";
            this.lable2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(134, 145);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(143, 58);
            this.txtBio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Royalty%";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // numRoyalty
            // 
            this.numRoyalty.DecimalPlaces = 2;
            this.numRoyalty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numRoyalty.Location = new System.Drawing.Point(139, 224);
            this.numRoyalty.Name = "numRoyalty";
            this.numRoyalty.Size = new System.Drawing.Size(50, 20);
            this.numRoyalty.TabIndex = 9;
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numRoyalty);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Show_Data);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.A_ID);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Author";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoyalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox A_ID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Show_Data;
        private System.Windows.Forms.BindingSource boutiquePublisherDBDataSetBindingSource;
        private BoutiquePublisherDBDataSet boutiquePublisherDBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private BoutiquePublisherDBDataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIOGRAPHYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOYALTYPERCENTAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRoyalty;
    }
}

