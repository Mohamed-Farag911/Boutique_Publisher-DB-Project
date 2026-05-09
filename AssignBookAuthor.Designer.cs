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
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.Auth_lable = new System.Windows.Forms.Label();
            this.Book_Lable = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.AUTHOR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiquePublisherDBDataSet = new Boutique_Publisher.BoutiquePublisherDBDataSet();
            this.aUTHOR_BOOKTableAdapter = new Boutique_Publisher.BoutiquePublisherDBDataSetTableAdapters.AUTHOR_BOOKTableAdapter();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORTableAdapter = new Boutique_Publisher.BoutiquePublisherDBDataSetTableAdapters.AUTHORTableAdapter();
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
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(84, 68);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(176, 21);
            this.cmbAuthor.TabIndex = 0;
            // 
            // cmbBook
            // 
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(84, 128);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(185, 21);
            this.cmbBook.TabIndex = 0;
            // 
            // Auth_lable
            // 
            this.Auth_lable.AutoSize = true;
            this.Auth_lable.Location = new System.Drawing.Point(35, 68);
            this.Auth_lable.Name = "Auth_lable";
            this.Auth_lable.Size = new System.Drawing.Size(38, 13);
            this.Auth_lable.TabIndex = 1;
            this.Auth_lable.Text = "Author";
            // 
            // Book_Lable
            // 
            this.Book_Lable.AutoSize = true;
            this.Book_Lable.Location = new System.Drawing.Point(35, 131);
            this.Book_Lable.MaximumSize = new System.Drawing.Size(50, 50);
            this.Book_Lable.Name = "Book_Lable";
            this.Book_Lable.Size = new System.Drawing.Size(32, 13);
            this.Book_Lable.TabIndex = 1;
            this.Book_Lable.Text = "Book";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(48, 184);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click_1);
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AUTHOR_ID,
            this.AuthorName,
            this.ISBN,
            this.BookTitle});
            this.dgvAssignments.Location = new System.Drawing.Point(333, 68);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.Size = new System.Drawing.Size(423, 247);
            this.dgvAssignments.TabIndex = 3;
            this.dgvAssignments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignments_CellContentClick);
            // 
            // AUTHOR_ID
            // 
            this.AUTHOR_ID.HeaderText = "Author ID";
            this.AUTHOR_ID.Name = "AUTHOR_ID";
            // 
            // AuthorName
            // 
            this.AuthorName.HeaderText = "Author Name";
            this.AuthorName.Name = "AuthorName";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // BookTitle
            // 
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.Name = "BookTitle";
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
            this.btnDelete.Location = new System.Drawing.Point(234, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(142, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AssignBookAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.Book_Lable);
            this.Controls.Add(this.Auth_lable);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.cmbAuthor);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}