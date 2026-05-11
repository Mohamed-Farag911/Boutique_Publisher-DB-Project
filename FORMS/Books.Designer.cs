namespace Boutique_Publisher
{
    partial class Books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARGETAGEGROUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSet = new Boutique_Publisher.BoutiquePublisherDBDataSet();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.Show_Data = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new Boutique_Publisher.BoutiquePublisherDBDataSetTableAdapters.BOOKTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTargetAge = new System.Windows.Forms.ComboBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.gENREDataGridViewTextBoxColumn,
            this.tARGETAGEGROUPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKBindingSource1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(345, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(575, 329);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gENREDataGridViewTextBoxColumn
            // 
            this.gENREDataGridViewTextBoxColumn.DataPropertyName = "GENRE";
            this.gENREDataGridViewTextBoxColumn.HeaderText = "GENRE";
            this.gENREDataGridViewTextBoxColumn.Name = "gENREDataGridViewTextBoxColumn";
            this.gENREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tARGETAGEGROUPDataGridViewTextBoxColumn
            // 
            this.tARGETAGEGROUPDataGridViewTextBoxColumn.DataPropertyName = "TARGETAGEGROUP";
            this.tARGETAGEGROUPDataGridViewTextBoxColumn.HeaderText = "TARGETAGEGROUP";
            this.tARGETAGEGROUPDataGridViewTextBoxColumn.Name = "tARGETAGEGROUPDataGridViewTextBoxColumn";
            this.tARGETAGEGROUPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.boutiquePublisherDBDataSetBindingSource;
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
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(118, 170);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTitle.Size = new System.Drawing.Size(209, 25);
            this.txtTitle.TabIndex = 12;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(118, 116);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtISBN.Size = new System.Drawing.Size(209, 25);
            this.txtISBN.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title";

            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(72, 125);
            this.lable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(37, 17);
            this.lable1.TabIndex = 9;
            this.lable1.Text = "ISBN";
            // 
            // Show_Data
            // 
            this.Show_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Show_Data.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Data.ForeColor = System.Drawing.Color.Transparent;
            this.Show_Data.Location = new System.Drawing.Point(824, 405);
            this.Show_Data.Margin = new System.Windows.Forms.Padding(4);
            this.Show_Data.Name = "Show_Data";
            this.Show_Data.Size = new System.Drawing.Size(96, 42);
            this.Show_Data.TabIndex = 17;
            this.Show_Data.Text = "Show_Data";
            this.Show_Data.UseVisualStyleBackColor = false;
            this.Show_Data.Click += new System.EventHandler(this.Show_Data_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Crimson;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Transparent;
            this.Delete.Location = new System.Drawing.Point(354, 414);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 53);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.SteelBlue;
            this.update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Transparent;
            this.update.Location = new System.Drawing.Point(201, 415);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(126, 52);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.ForestGreen;
            this.insert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.Transparent;
            this.insert.Location = new System.Drawing.Point(59, 417);
            this.insert.Margin = new System.Windows.Forms.Padding(4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(116, 50);
            this.insert.TabIndex = 14;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.boutiquePublisherDBDataSetBindingSource;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ganre";
         
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Target Age Group";
           
            // 
            // cmbTargetAge
            // 
            this.cmbTargetAge.FormattingEnabled = true;
            this.cmbTargetAge.Location = new System.Drawing.Point(187, 268);
            this.cmbTargetAge.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTargetAge.Name = "cmbTargetAge";
            this.cmbTargetAge.Size = new System.Drawing.Size(140, 25);
            this.cmbTargetAge.TabIndex = 18;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(123, 217);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(204, 25);
            this.cmbGenre.TabIndex = 18;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(933, 589);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.cmbTargetAge);
            this.Controls.Add(this.Show_Data);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.BindingSource boutiquePublisherDBDataSetBindingSource;
        private BoutiquePublisherDBDataSet boutiquePublisherDBDataSet;
        private System.Windows.Forms.Button Show_Data;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private BoutiquePublisherDBDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARGETAGEGROUPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTargetAge;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}