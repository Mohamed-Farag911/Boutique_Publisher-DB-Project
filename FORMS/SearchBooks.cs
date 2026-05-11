using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Publisher
{
    public partial class SearchBooks : Form
    {
        public SearchBooks()
        {
            InitializeComponent();
        }

        // =====================================
        // FORM LOAD
        // =====================================
        private void SearchBooks_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Add("All");
            cmbFilter.Items.Add("Title");
            cmbFilter.Items.Add("Genre");
            cmbFilter.Items.Add("ISBN");
            cmbFilter.Items.Add("Author");
            cmbFilter.Items.Add("Format");

            cmbFilter.SelectedIndex = 0;

            LoadBooks();
        }

        // =====================================
        // LOAD ALL BOOKS
        // =====================================
        private void LoadBooks()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    string query = @"
                    SELECT DISTINCT
                        B.ISBN,
                        B.TITLE,
                        B.GENRE,
                        B.TARGETAGEGROUP,
                        A.NAME AS AuthorName,
                        F.FORMAT_TYPE
                    FROM BOOK B
                    LEFT JOIN AUTHOR_BOOK AB
                        ON B.ISBN = AB.ISBN
                    LEFT JOIN AUTHOR A
                        ON AB.AUTHOR_ID = A.AUTHOR_ID
                    LEFT JOIN FORMAT F
                        ON B.ISBN = F.ISBN";

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

                // Grid Style
                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.MultiSelect = false;

                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =====================================
        // SEARCH BUTTON
        // =====================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text.Trim();
                string filter = cmbFilter.Text;

                using (SqlConnection connection =
                    new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    string query = @"
                    SELECT DISTINCT
                        B.ISBN,
                        B.TITLE,
                        B.GENRE,
                        B.TARGETAGEGROUP,
                        A.NAME AS AuthorName,
                        F.FORMAT_TYPE
                    FROM BOOK B
                    LEFT JOIN AUTHOR_BOOK AB
                        ON B.ISBN = AB.ISBN
                    LEFT JOIN AUTHOR A
                        ON AB.AUTHOR_ID = A.AUTHOR_ID
                    LEFT JOIN FORMAT F
                        ON B.ISBN = F.ISBN
                    WHERE ";

                    if (filter == "Title")
                    {
                        query += "B.TITLE LIKE @search";
                    }
                    else if (filter == "Genre")
                    {
                        query += "B.GENRE LIKE @search";
                    }
                    else if (filter == "ISBN")
                    {
                        query += "B.ISBN LIKE @search";
                    }
                    else if (filter == "Author")
                    {
                        query += "A.NAME LIKE @search";
                    }
                    else if (filter == "Format")
                    {
                        query += "F.FORMAT_TYPE LIKE @search";
                    }
                    else
                    {
                        query += @"
                        B.TITLE LIKE @search OR
                        B.GENRE LIKE @search OR
                        B.ISBN LIKE @search OR
                        A.NAME LIKE @search OR
                        F.FORMAT_TYPE LIKE @search";
                    }

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@search",
                        "%" + search + "%");

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =====================================
        // RESET BUTTON
        // =====================================
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            cmbFilter.SelectedIndex = 0;

            LoadBooks();
        }
    }
}