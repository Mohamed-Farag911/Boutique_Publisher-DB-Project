namespace Boutique_Publisher
{
    partial class Formats
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
            this.dgvFormats = new System.Windows.Forms.DataGridView();
            this.fORMATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSet = new Boutique_Publisher.BoutiquePublisherDBDataSet();
            this.txtFormatID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBookTitle = new System.Windows.Forms.ComboBox();
            this.cmbFormatType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numProductionCost = new System.Windows.Forms.NumericUpDown();
            this.numRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.fORMATTableAdapter = new Boutique_Publisher.BoutiquePublisherDBDataSetTableAdapters.FORMATTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductionCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetailPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFormats
            // 
            this.dgvFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormats.Location = new System.Drawing.Point(377, 37);
            this.dgvFormats.Name = "dgvFormats";
            this.dgvFormats.Size = new System.Drawing.Size(513, 311);
            this.dgvFormats.TabIndex = 0;
            this.dgvFormats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormats_CellContentClick);
            // 
            // fORMATBindingSource
            // 
            this.fORMATBindingSource.DataMember = "FORMAT";
            this.fORMATBindingSource.DataSource = this.boutiquePublisherDBDataSet;
            // 
            // boutiquePublisherDBDataSet
            // 
            this.boutiquePublisherDBDataSet.DataSetName = "BoutiquePublisherDBDataSet";
            this.boutiquePublisherDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFormatID
            // 
            this.txtFormatID.Enabled = false;
            this.txtFormatID.Location = new System.Drawing.Point(174, 68);
            this.txtFormatID.Name = "txtFormatID";
            this.txtFormatID.Size = new System.Drawing.Size(82, 20);
            this.txtFormatID.TabIndex = 6;
            this.txtFormatID.TextChanged += new System.EventHandler(this.A_ID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISBN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Format_ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(174, 119);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(159, 20);
            this.txtISBN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book Title";
            // 
            // cmbBookTitle
            // 
            this.cmbBookTitle.FormattingEnabled = true;
            this.cmbBookTitle.Location = new System.Drawing.Point(174, 162);
            this.cmbBookTitle.Name = "cmbBookTitle";
            this.cmbBookTitle.Size = new System.Drawing.Size(159, 21);
            this.cmbBookTitle.TabIndex = 9;
            this.cmbBookTitle.SelectedIndexChanged += new System.EventHandler(this.cmbBookTitle_SelectedIndexChanged);
            // 
            // cmbFormatType
            // 
            this.cmbFormatType.FormattingEnabled = true;
            this.cmbFormatType.Location = new System.Drawing.Point(174, 210);
            this.cmbFormatType.Name = "cmbFormatType";
            this.cmbFormatType.Size = new System.Drawing.Size(159, 21);
            this.cmbFormatType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Format Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Proudction Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Retail Cost";
            // 
            // numProductionCost
            // 
            this.numProductionCost.DecimalPlaces = 2;
            this.numProductionCost.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numProductionCost.Location = new System.Drawing.Point(188, 266);
            this.numProductionCost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numProductionCost.Name = "numProductionCost";
            this.numProductionCost.Size = new System.Drawing.Size(120, 20);
            this.numProductionCost.TabIndex = 14;
            this.numProductionCost.ThousandsSeparator = true;
            // 
            // numRetailPrice
            // 
            this.numRetailPrice.DecimalPlaces = 2;
            this.numRetailPrice.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numRetailPrice.Location = new System.Drawing.Point(188, 328);
            this.numRetailPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numRetailPrice.Name = "numRetailPrice";
            this.numRetailPrice.Size = new System.Drawing.Size(120, 20);
            this.numRetailPrice.TabIndex = 15;
            this.numRetailPrice.ThousandsSeparator = true;
            // 
            // fORMATTableAdapter
            // 
            this.fORMATTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(410, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 52);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(215, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 52);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Green;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(52, 387);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 53);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Formats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 460);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.numRetailPrice);
            this.Controls.Add(this.numProductionCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFormatType);
            this.Controls.Add(this.cmbBookTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtFormatID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFormats);
            this.Name = "Formats";
            this.Text = "Formats";
            this.Load += new System.EventHandler(this.Formats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductionCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetailPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormats;
        private System.Windows.Forms.TextBox txtFormatID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBookTitle;
        private System.Windows.Forms.ComboBox cmbFormatType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numProductionCost;
        private System.Windows.Forms.NumericUpDown numRetailPrice;
        private BoutiquePublisherDBDataSet boutiquePublisherDBDataSet;
        private System.Windows.Forms.BindingSource fORMATBindingSource;
        private BoutiquePublisherDBDataSetTableAdapters.FORMATTableAdapter fORMATTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}