namespace Boutique_Publisher
{
    partial class AssignBookAuthor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.Auth_lable = new System.Windows.Forms.Label();
            this.Book_Lable = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.aUTHORBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSet = new Boutique_Publisher.BoutiquePublisherDBDataSet();
            this.aUTHOR_BOOKTableAdapter = new Boutique_Publisher.UI.BoutiquePublisherDBDataSetTableAdapters.AUTHOR_BOOKTableAdapter();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORTableAdapter = new Boutique_Publisher.UI.BoutiquePublisherDBDataSetTableAdapters.AUTHORTableAdapter();
            this.aUTHORBOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORBOOKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBOOKBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(112, 84);
            this.cmbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(233, 28);
            this.cmbAuthor.TabIndex = 0;
            // 
            // cmbBook
            // 
            this.cmbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(112, 158);
            this.cmbBook.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(245, 28);
            this.cmbBook.TabIndex = 0;
            // 
            // Auth_lable
            // 
            this.Auth_lable.AutoSize = true;
            this.Auth_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auth_lable.Location = new System.Drawing.Point(20, 87);
            this.Auth_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Auth_lable.Name = "Auth_lable";
            this.Auth_lable.Size = new System.Drawing.Size(63, 20);
            this.Auth_lable.TabIndex = 1;
            this.Auth_lable.Text = "Author";
            // 
            // Book_Lable
            // 
            this.Book_Lable.AutoSize = true;
            this.Book_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Lable.Location = new System.Drawing.Point(20, 165);
            this.Book_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Book_Lable.MaximumSize = new System.Drawing.Size(67, 62);
            this.Book_Lable.Name = "Book_Lable";
            this.Book_Lable.Size = new System.Drawing.Size(50, 20);
            this.Book_Lable.TabIndex = 1;
            this.Book_Lable.Text = "Book";
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Green;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAssign.Location = new System.Drawing.Point(16, 226);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(125, 60);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click_1);
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.AllowUserToAddRows = false;
            this.dgvAssignments.AllowUserToDeleteRows = false;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.EnableHeadersVisualStyles = false;
            this.dgvAssignments.GridColor = System.Drawing.Color.Gray;
            this.dgvAssignments.Location = new System.Drawing.Point(444, 87);
            this.dgvAssignments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAssignments.MultiSelect = false;
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.ReadOnly = true;
            this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAssignments.Size = new System.Drawing.Size(580, 387);
            this.dgvAssignments.TabIndex = 3;
            this.dgvAssignments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignments_CellContentClick);
            this.dgvAssignments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignments_CellContentClick);
            // 
            // aUTHORBOOKBindingSource
            // 
            this.aUTHORBOOKBindingSource.DataMember = "AUTHOR_BOOK";
            this.aUTHORBOOKBindingSource.DataSource = this.boutiquePublisherDBDataSetBindingSource;
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
            // aUTHOR_BOOKTableAdapter
            // 
            this.aUTHOR_BOOKTableAdapter.ClearBeforeFill = true;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.boutiquePublisherDBDataSetBindingSource;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // aUTHORBOOKBindingSource1
            // 
            this.aUTHORBOOKBindingSource1.DataMember = "AUTHOR_BOOK";
            this.aUTHORBOOKBindingSource1.DataSource = this.boutiquePublisherDBDataSetBindingSource;
            // 
            // aUTHORBOOKBindingSource2
            // 
            this.aUTHORBOOKBindingSource2.DataMember = "AUTHOR_BOOK";
            this.aUTHORBOOKBindingSource2.DataSource = this.boutiquePublisherDBDataSetBindingSource;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(311, 226);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 60);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(153, 226);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 60);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AssignBookAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.Book_Lable);
            this.Controls.Add(this.Auth_lable);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.cmbAuthor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignBookAuthor";
            this.Text = "AssignBookAuthor";
            this.Load += new System.EventHandler(this.AssignBookAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBOOKBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label Auth_lable;
        private System.Windows.Forms.Label Book_Lable;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.BindingSource boutiquePublisherDBDataSetBindingSource;
        private BoutiquePublisherDBDataSet boutiquePublisherDBDataSet;
        private System.Windows.Forms.BindingSource aUTHORBOOKBindingSource;
        private BoutiquePublisherDBDataSetTableAdapters.AUTHOR_BOOKTableAdapter aUTHOR_BOOKTableAdapter;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private BoutiquePublisherDBDataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.BindingSource aUTHORBOOKBindingSource1;
        private System.Windows.Forms.BindingSource aUTHORBOOKBindingSource2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}