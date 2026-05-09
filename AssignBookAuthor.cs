using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Boutique_Publisher
{
    public partial class AssignBookAuthor : Form
    {
        public AssignBookAuthor()
        {
            InitializeComponent();
        }

        // =========================================
        // FORM LOAD
        // =========================================

        private void AssignBookAuthor_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadBooks();
            LoadAssignments();

            // Grid Style
            dgvAssignments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAssignments.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAssignments.MultiSelect = false;

            dgvAssignments.ReadOnly = true;
        }

        // =========================================
        // LOAD AUTHORS
        // =========================================

        private void LoadAuthors()
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT AUTHOR_ID, NAME FROM AUTHOR",
                        con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbAuthor.DataSource = dt;

                cmbAuthor.DisplayMember = "NAME";

                cmbAuthor.ValueMember = "AUTHOR_ID";

                cmbAuthor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================================
        // LOAD BOOKS
        // =========================================

        private void LoadBooks()
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT ISBN, TITLE FROM BOOK",
                        con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbBook.DataSource = dt;

                cmbBook.DisplayMember = "TITLE";

                cmbBook.ValueMember = "ISBN";

                cmbBook.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================================
        // LOAD ASSIGNMENTS
        // =========================================

        private void LoadAssignments()
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

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

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                // مهم جدًا لمنع تكرار الأعمدة
                dgvAssignments.Columns.Clear();

                // ربط البيانات
                dgvAssignments.DataSource = dt;

                // شكل الجريد
                dgvAssignments.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvAssignments.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvAssignments.MultiSelect = false;

                dgvAssignments.ReadOnly = true;

                // أسماء الأعمدة
                dgvAssignments.Columns[0].HeaderText =
                    "Author ID";

                dgvAssignments.Columns[1].HeaderText =
                    "Author Name";

                dgvAssignments.Columns[2].HeaderText =
                    "ISBN";

                dgvAssignments.Columns[3].HeaderText =
                    "Book Title";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================================
        // ASSIGN AUTHOR TO BOOK
        // =========================================
        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (cmbAuthor.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Author");
                    return;
                }

                if (cmbBook.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Book");
                    return;
                }

                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                con.Open();

                // Prevent Duplicate Assignment
                SqlCommand checkCmd = new SqlCommand(
                    @"SELECT COUNT(*) 
                    FROM AUTHOR_BOOK
                    WHERE AUTHOR_ID=@AUTHOR_ID
                    AND ISBN=@ISBN",
                    con);

                checkCmd.Parameters.AddWithValue(
                    "@AUTHOR_ID",
                    cmbAuthor.SelectedValue);

                checkCmd.Parameters.AddWithValue(
                    "@ISBN",
                    cmbBook.SelectedValue);

                int count =
                    (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show(
                        "This assignment already exists");

                    con.Close();

                    return;
                }

                // Insert Assignment
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO AUTHOR_BOOK
                    (AUTHOR_ID, ISBN)
                    VALUES
                    (@AUTHOR_ID, @ISBN)",
                    con);

                cmd.Parameters.AddWithValue(
                    "@AUTHOR_ID",
                    cmbAuthor.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@ISBN",
                    cmbBook.SelectedValue);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadAssignments();

                MessageBox.Show(
                    "Author Assigned Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // =========================================
        // DELETE ASSIGNMENT
        // =========================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignments.CurrentRow == null)
                {
                    MessageBox.Show("Select assignment first");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Delete this assignment?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM AUTHOR_BOOK
                    WHERE AUTHOR_ID=@AUTHOR_ID
                    AND ISBN=@ISBN",
                    con);

                cmd.Parameters.AddWithValue(
                    "@AUTHOR_ID",
                    dgvAssignments.CurrentRow.Cells["AUTHOR_ID"].Value);

                cmd.Parameters.AddWithValue(
                    "@ISBN",
                    dgvAssignments.CurrentRow.Cells["ISBN"].Value);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadAssignments();

                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvAssignments.Rows[e.RowIndex];

                // Fill Author ComboBox
                cmbAuthor.SelectedValue =
                    row.Cells["AUTHOR_ID"].Value;

                // Fill Book ComboBox
                cmbBook.SelectedValue =
                    row.Cells["ISBN"].Value;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignments.CurrentRow == null)
                {
                    MessageBox.Show("Select assignment first");
                    return;
                }

                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                con.Open();

                string oldISBN =
                    dgvAssignments.CurrentRow.Cells["ISBN"].Value.ToString();

                int oldAuthorID =
                    Convert.ToInt32(
                        dgvAssignments.CurrentRow.Cells["AUTHOR_ID"].Value);

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE AUTHOR_BOOK
              SET AUTHOR_ID=@NEW_AUTHOR_ID,
                  ISBN=@NEW_ISBN
              WHERE AUTHOR_ID=@OLD_AUTHOR_ID
              AND ISBN=@OLD_ISBN",
                    con);

                cmd.Parameters.AddWithValue(
                    "@NEW_AUTHOR_ID",
                    cmbAuthor.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@NEW_ISBN",
                    cmbBook.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@OLD_AUTHOR_ID",
                    oldAuthorID);

                cmd.Parameters.AddWithValue(
                    "@OLD_ISBN",
                    oldISBN);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadAssignments();

                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}