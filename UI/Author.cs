using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Boutique_Publisher;

namespace Boutique_Publisher
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }
        private void LoadAuthors()
        {
            try
            {
                SqlConnection connection =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM AUTHOR",
                    connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                connection.Close();

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

        // =========================
        // VALIDATION
        // =========================

        private bool ValidateInputs()
        {
            // Name Required
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Author name is required");
                txtName.Focus();
                return false;
            }

            // Royalty Validation

            decimal royalty;

            if (numRoyalty.Value < 0 || numRoyalty.Value > 100)
            {
                MessageBox.Show("Royalty must be between 0 and 100");
                numRoyalty.Focus();
                return false;
            }


            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // =========================
        // SHOW DATA BUTTON
        // =========================

        private void Show_Data_Click(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                SqlConnection connection =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO AUTHOR
                    (NAME, BIOGRAPHY, ROYALTY_PERCENTAGE)
                    VALUES
                    (@NAME, @BIOGRAPHY, @ROYALTY)",
                    connection);

                cmd.Parameters.AddWithValue("@NAME", txtName.Text);
                cmd.Parameters.AddWithValue("@BIOGRAPHY", txtBio.Text);
                cmd.Parameters.AddWithValue("@ROYALTY", numRoyalty.Value);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Inserted Successfully");

                LoadAuthors();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(A_ID.Text))
                {
                    MessageBox.Show("Select author first");
                    return;
                }

                if (!ValidateInputs())
                    return;

                SqlConnection connection =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE AUTHOR
                    SET
                    NAME = @NAME,
                    BIOGRAPHY = @BIOGRAPHY,
                    ROYALTY_PERCENTAGE = @ROYALTY
                    WHERE AUTHOR_ID = @ID",
                    connection);

                cmd.Parameters.AddWithValue("@ID", A_ID.Text);
                cmd.Parameters.AddWithValue("@NAME", txtName.Text);
                cmd.Parameters.AddWithValue("@BIOGRAPHY", txtBio.Text);

                cmd.Parameters.AddWithValue("@ROYALTY", numRoyalty.Value);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Updated Successfully");

                LoadAuthors();

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
                if (string.IsNullOrWhiteSpace(A_ID.Text))
                {
                    MessageBox.Show("Select author first");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this author?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                SqlConnection connection =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM AUTHOR WHERE AUTHOR_ID = @ID",
                    connection);

                cmd.Parameters.AddWithValue("@ID", A_ID.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Deleted Successfully");

                LoadAuthors();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                A_ID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtBio.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value != DBNull.Value && row.Cells[3].Value != null)
                {
                    numRoyalty.Value = Convert.ToDecimal(row.Cells[3].Value);
                }
                else
                {
                    numRoyalty.Value = 0;
                }
            }

        }

        // =========================
        // CLEAR
        // =========================

        private void ClearFields()
        {
            A_ID.Clear();
            txtName.Clear();
            txtBio.Clear();
            numRoyalty.Value = 0;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
