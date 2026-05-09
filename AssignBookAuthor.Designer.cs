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
            this.boutiquePublisherDBDataSet = new Boutique_Publisher.BoutiquePublisherDBDataSet();
            this.boutiquePublisherDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHOR_BOOKTableAdapter = new Boutique_Publisher.BoutiquePublisherDBDataSetTableAdapters.AUTHOR_BOOKTableAdapter();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORTableAdapter = new Boutique_Publisher.BoutiquePublisherDBDataSetTableAdapters.AUTHORTableAdapter();
            this.aUTHORBOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORBOOKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Author_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBOOKBindingSource)).BeginInit();
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
            this.btnAssign.Location = new System.Drawing.Point(98, 184);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.AutoGenerateColumns = false;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author_ID,
            this.Author_Name,
            this.ISBN,
            this.Book_Title});
            this.dgvAssignments.DataSource = this.aUTHORBOOKBindingSource;
            this.dgvAssignments.Location = new System.Drawing.Point(333, 68);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.Size = new System.Drawing.Size(423, 247);
            this.dgvAssignments.TabIndex = 3;
            // 
            // boutiquePublisherDBDataSet
            // 
            this.boutiquePublisherDBDataSet.DataSetName = "BoutiquePublisherDBDataSet";
            this.boutiquePublisherDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boutiquePublisherDBDataSetBindingSource
            // 
            this.boutiquePublisherDBDataSetBindingSource.DataSource = this.boutiquePublisherDBDataSet;
            this.boutiquePublisherDBDataSetBindingSource.Position = 0;
            // 
            // aUTHORBOOKBindingSource
            // 
            this.aUTHORBOOKBindingSource.DataMember = "AUTHOR_BOOK";
            this.aUTHORBOOKBindingSource.DataSource = this.boutiquePublisherDBDataSetBindingSource;
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
            // Author_ID
            // 
            this.Author_ID.HeaderText = "Author ID";
            this.Author_ID.Name = "Author_ID";
            // 
            // Author_Name
            // 
            this.Author_Name.HeaderText = "Author Name";
            this.Author_Name.Name = "Author_Name";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Book_Title
            // 
            this.Book_Title.HeaderText = "Book Title";
            this.Book_Title.Name = "Book_Title";
            // 
            // AssignBookAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiquePublisherDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBOOKBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Title;
        private System.Windows.Forms.BindingSource aUTHORBOOKBindingSource1;
        private System.Windows.Forms.BindingSource aUTHORBOOKBindingSource2;
    }
}