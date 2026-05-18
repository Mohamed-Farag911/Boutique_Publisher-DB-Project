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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
           
            cmbGenre.Items.AddRange(new string[] { "Fantasy", "Horror", "Romance", "Drama", "Science Fiction" });

       
            cmbTargetAge.Items.AddRange(new string[] { "Kids", "Teens", "Adults" });

            
            // LoadBooks(); 
        }

        // =========================
        // DATA LOADING & GRID STYLE
        // =========================
        private void LoadBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM BOOK", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                // Grid Style (Matching Author style)
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // VALIDATION
        // =========================
        private bool ValidateInputs()
        {
            // ISBN Required
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("ISBN is required");
                txtISBN.Focus();
                return false;
            }

            // Title Required
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Book title is required");
                txtTitle.Focus();
                return false;
            }

            return true;
        }

        // =========================
        // BUTTON EVENTS
        // =========================
        private void Show_Data_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO BOOK (ISBN, TITLE, GENRE, TARGETAGEGROUP) VALUES (@ISBN, @TITLE, @GENRE, @TARGETAGEGROUP)",
                        connection);

                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@TITLE", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@GENRE", cmbGenre.Text);
                    cmd.Parameters.AddWithValue("@TARGETAGEGROUP", cmbTargetAge.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Inserted Successfully");
                LoadBooks();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtISBN.Text))
                {
                    MessageBox.Show("Select a book via ISBN first");
                    return;
                }

                if (!ValidateInputs()) return;

                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE BOOK SET TITLE = @TITLE, GENRE = @GENRE, TARGETAGEGROUP = @TARGETAGEGROUP WHERE ISBN = @ISBN",
                        connection);

                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@TITLE", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@GENRE", cmbGenre.Text);
                    cmd.Parameters.AddWithValue("@TARGETAGEGROUP", cmbTargetAge.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Updated Successfully");
                LoadBooks();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtISBN.Text))
                {
                    MessageBox.Show("Select a book via ISBN first");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this book?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;

                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM BOOK WHERE ISBN = @ISBN", connection);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted Successfully");
                LoadBooks();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // UTILITIES
        // =========================
        private void ClearFields()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            cmbGenre.SelectedIndex = -1;
            cmbTargetAge.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtISBN.Text = row.Cells[0].Value?.ToString();
                txtTitle.Text = row.Cells[1].Value?.ToString();
                cmbGenre.Text = row.Cells[2].Value?.ToString();
                cmbTargetAge.Text = row.Cells[3].Value?.ToString();
            }
        }
    }
}