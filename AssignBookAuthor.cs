using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique_Publisher
{
    public partial class AssignBookAuthor : Form
    {
        public AssignBookAuthor()
        {
            InitializeComponent();
        }

        private void AssignBookAuthor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boutiquePublisherDBDataSet.AUTHOR' table. You can move, or remove it, as needed.
            this.aUTHORTableAdapter.Fill(this.boutiquePublisherDBDataSet.AUTHOR);
            // TODO: This line of code loads data into the 'boutiquePublisherDBDataSet.AUTHOR_BOOK' table. You can move, or remove it, as needed.
            this.aUTHOR_BOOKTableAdapter.Fill(this.boutiquePublisherDBDataSet.AUTHOR_BOOK);
            LoadAuthors();
            LoadBooks();
            LoadAssignments();
        }

        private void LoadAuthors()
        {
            SqlConnection con = new SqlConnection(
                "Data Source=.\\SQLEXPRESS;Initial Catalog=BoutiquePublisherDB;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT AUTHOR_ID, NAME FROM AUTHOR", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbAuthor.DataSource = dt;
            cmbAuthor.DisplayMember = "NAME";
            cmbAuthor.ValueMember = "AUTHOR_ID";
        }
        private void LoadBooks()
        {
        
            SqlConnection con = new SqlConnection(
                "Data Source=.\\SQLEXPRESS;Initial Catalog=BoutiquePublisherDB;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT ISBN, TITLE FROM BOOK", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbBook.DataSource = dt;
            cmbBook.DisplayMember = "TITLE";
            cmbBook.ValueMember = "ISBN";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO AUTHOR_BOOK (AUTHOR_ID, ISBN) VALUES (@AUTHOR_ID, @ISBN)",
                    con);

                cmd.Parameters.AddWithValue("@AUTHOR_ID", cmbAuthor.SelectedValue);
                cmd.Parameters.AddWithValue("@ISBN", cmbBook.SelectedValue);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadAssignments();

                MessageBox.Show("Assigned Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAssignments()
        {
            SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString);

            string query = @"
    SELECT 
        A.AUTHOR_ID,
        A.NAME AS AuthorName,
        B.ISBN,
        B.TITLE AS BookTitle
    FROM AUTHOR_BOOK AB
    INNER JOIN AUTHOR A
        ON AB.AUTHOR_ID = A.AUTHOR_ID
    INNER JOIN BOOK B
        ON AB.ISBN = B.ISBN";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvAssignments.DataSource = dt;
        }


    }
}
