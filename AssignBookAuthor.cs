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
            LoadAuthors();
            LoadBooks();
            LoadAssignments();
        }

        // =========================================
        // DATA LOADING
        // =========================================

        private void LoadAuthors()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT AUTHOR_ID, NAME FROM AUTHOR", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbAuthor.DataSource = dt;
                    cmbAuthor.DisplayMember = "NAME";
                    cmbAuthor.ValueMember = "AUTHOR_ID";
                    cmbAuthor.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ISBN, TITLE FROM BOOK", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbBook.DataSource = dt;
                    cmbBook.DisplayMember = "TITLE";
                    cmbBook.ValueMember = "ISBN";
                    cmbBook.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadAssignments()
        {
            try
            {
                string query = @"
                    SELECT A.AUTHOR_ID, A.NAME AS AuthorName, B.ISBN, B.TITLE AS BookTitle
                    FROM AUTHOR_BOOK AB
                    INNER JOIN AUTHOR A ON AB.AUTHOR_ID = A.AUTHOR_ID
                    INNER JOIN BOOK B ON AB.ISBN = B.ISBN";

                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAssignments.DataSource = dt;
                }

                FormatGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormatGrid()
        {
            // Grid Style
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.MultiSelect = false;
            dgvAssignments.ReadOnly = true;

            // Headers
            if (dgvAssignments.Columns.Count > 0)
            {
                dgvAssignments.Columns[0].HeaderText = "Author ID";
                dgvAssignments.Columns[1].HeaderText = "Author Name";
                dgvAssignments.Columns[2].HeaderText = "ISBN";
                dgvAssignments.Columns[3].HeaderText = "Book Title";
            }
        }

        // =========================================
        // CRUD OPERATIONS
        // =========================================

        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            if (cmbAuthor.SelectedIndex == -1 || cmbBook.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both an Author and a Book");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();

                    // 1. Prevent Duplicate
                    string checkQuery = "SELECT COUNT(*) FROM AUTHOR_BOOK WHERE AUTHOR_ID=@A_ID AND ISBN=@ISBN";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@A_ID", cmbAuthor.SelectedValue);
                    checkCmd.Parameters.AddWithValue("@ISBN", cmbBook.SelectedValue);

                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("This assignment already exists");
                        return;
                    }

                    // 2. Insert
                    string insertQuery = "INSERT INTO AUTHOR_BOOK (AUTHOR_ID, ISBN) VALUES (@A_ID, @ISBN)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@A_ID", cmbAuthor.SelectedValue);
                    cmd.Parameters.AddWithValue("@ISBN", cmbBook.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Author Assigned Successfully");
                LoadAssignments();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.CurrentRow == null)
            {
                MessageBox.Show("Select an assignment from the table first");
                return;
            }

            try
            {
                string oldISBN = dgvAssignments.CurrentRow.Cells["ISBN"].Value.ToString();
                int oldAuthorID = Convert.ToInt32(dgvAssignments.CurrentRow.Cells["AUTHOR_ID"].Value);

                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();
                    string query = @"UPDATE AUTHOR_BOOK 
                                     SET AUTHOR_ID=@NEW_A_ID, ISBN=@NEW_ISBN 
                                     WHERE AUTHOR_ID=@OLD_A_ID AND ISBN=@OLD_ISBN";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NEW_A_ID", cmbAuthor.SelectedValue);
                    cmd.Parameters.AddWithValue("@NEW_ISBN", cmbBook.SelectedValue);
                    cmd.Parameters.AddWithValue("@OLD_A_ID", oldAuthorID);
                    cmd.Parameters.AddWithValue("@OLD_ISBN", oldISBN);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Updated Successfully");
                LoadAssignments();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbAuthor.SelectedIndex == -1 || cmbBook.SelectedIndex == -1)
            {
                MessageBox.Show("Select assignment first");
                return;
            }

            if (MessageBox.Show("Delete this assignment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();
                    string query = "DELETE FROM AUTHOR_BOOK WHERE AUTHOR_ID=@A_ID AND ISBN=@ISBN";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@A_ID", dgvAssignments.CurrentRow.Cells["AUTHOR_ID"].Value);
                    cmd.Parameters.AddWithValue("@ISBN", dgvAssignments.CurrentRow.Cells["ISBN"].Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted Successfully");
                LoadAssignments();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // =========================================
        // UTILITIES
        // =========================================

        private void ClearFields()
        {
            cmbAuthor.SelectedIndex = -1;
            cmbBook.SelectedIndex = -1;
        }

        private void dgvAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAssignments.Rows[e.RowIndex];
                cmbAuthor.SelectedValue = row.Cells["AUTHOR_ID"].Value;
                cmbBook.SelectedValue = row.Cells["ISBN"].Value;
            }
        }
    }
}