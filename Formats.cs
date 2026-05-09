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
    public partial class Formats : Form
    {
        public Formats()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formats_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadFormatTypes();
            LoadFormats();

            txtFormatID.ReadOnly = true;

            dgvFormats.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvFormats.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvFormats.MultiSelect = false;

            dgvFormats.ReadOnly = true;

        }
        // =========================================
        // LOAD BOOKS INTO COMBOBOX
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

                cmbBookTitle.DataSource = dt;

                cmbBookTitle.DisplayMember = "TITLE";

                cmbBookTitle.ValueMember = "ISBN";

                cmbBookTitle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // =========================================
        // LOAD FORMAT TYPES INTO COMBOBOX
        // =========================================

        private void LoadFormatTypes()
        {
            cmbFormatType.Items.Clear();

            cmbFormatType.Items.Add("Hardcover");
            cmbFormatType.Items.Add("Paperback");
            cmbFormatType.Items.Add("Ebook");
            cmbFormatType.Items.Add("Audiobook");
        }
        // =========================================
        // LOAD FORMATS
        // =========================================

        private void LoadFormats()
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                string query = @"
                SELECT
                    F.FORMAT_ID,
                    F.ISBN,
                    B.TITLE AS BookTitle,
                    F.FORMAT_TYPE,
                    F.PRODUCTION_COST,
                    F.RETAIL_PRICE

                FROM FORMAT F

                INNER JOIN BOOK B
                    ON F.ISBN = B.ISBN";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvFormats.Columns.Clear();

                dgvFormats.DataSource = dt;

                dgvFormats.Columns[0].HeaderText =
                    "Format ID";

                dgvFormats.Columns[1].HeaderText =
                    "ISBN";

                dgvFormats.Columns[2].HeaderText =
                    "Book Title";

                dgvFormats.Columns[3].HeaderText =
                    "Format Type";

                dgvFormats.Columns[4].HeaderText =
                    "Production Cost";

                dgvFormats.Columns[5].HeaderText =
                    "Retail Price";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // =========================================
        // INSERT
        // =========================================

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO FORMAT
                    (ISBN, FORMAT_TYPE, PRODUCTION_COST, RETAIL_PRICE)

                    VALUES
                    (@ISBN, @FORMAT_TYPE,
                     @PRODUCTION_COST, @RETAIL_PRICE)",
                    con);

                cmd.Parameters.AddWithValue(
                    "@ISBN",
                    cmbBookTitle.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@FORMAT_TYPE",
                    cmbFormatType.Text);

                cmd.Parameters.AddWithValue(
                    "@PRODUCTION_COST",
                    numProductionCost.Value);

                cmd.Parameters.AddWithValue(
                    "@RETAIL_PRICE",
                    numRetailPrice.Value);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadFormats();

                ClearFields();

                MessageBox.Show("Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================================
        // UPDATE
        // =========================================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFormatID.Text))
                {
                    MessageBox.Show("Select format first");
                    return;
                }

                if (!ValidateInputs())
                    return;

                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE FORMAT

                    SET
                    ISBN=@ISBN,
                    FORMAT_TYPE=@FORMAT_TYPE,
                    PRODUCTION_COST=@PRODUCTION_COST,
                    RETAIL_PRICE=@RETAIL_PRICE

                    WHERE FORMAT_ID=@FORMAT_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@FORMAT_ID",
                    txtFormatID.Text);

                cmd.Parameters.AddWithValue(
                    "@ISBN",
                    cmbBookTitle.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@FORMAT_TYPE",
                    cmbFormatType.Text);

                cmd.Parameters.AddWithValue(
                    "@PRODUCTION_COST",
                    numProductionCost.Value);

                cmd.Parameters.AddWithValue(
                    "@RETAIL_PRICE",
                    numRetailPrice.Value);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadFormats();

                ClearFields();

                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // =========================================
        // DELETE
        // =========================================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFormatID.Text))
                {
                    MessageBox.Show("Select format first");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Delete this format?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM FORMAT WHERE FORMAT_ID=@FORMAT_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@FORMAT_ID",
                    txtFormatID.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadFormats();

                ClearFields();

                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // =========================================
        // GRID CLICK
        // =========================================

        private void dgvFormats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvFormats.Rows[e.RowIndex];

                txtFormatID.Text =
                    row.Cells[0].Value.ToString();

                cmbBookTitle.SelectedValue =
                    row.Cells[1].Value.ToString();

                cmbFormatType.Text =
                    row.Cells[3].Value.ToString();

                numProductionCost.Value =
                    Convert.ToDecimal(row.Cells[4].Value);

                numRetailPrice.Value =
                    Convert.ToDecimal(row.Cells[5].Value);
            }

        }

        // =========================================
        // VALIDATION
        // =========================================

        private bool ValidateInputs()
        {
            if (cmbBookTitle.SelectedIndex == -1)
            {
                MessageBox.Show("Select Book");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbFormatType.Text))
            {
                MessageBox.Show("Enter Format Type");
                return false;
            }

            if (numProductionCost.Value < 0)
            {
                MessageBox.Show("Invalid Production Cost");
                return false;
            }

            if (numRetailPrice.Value < 0)
            {
                MessageBox.Show("Invalid Retail Price");
                return false;
            }

            return true;
        }

        // =========================================
        // CLEAR
        // =========================================

        private void ClearFields()
        {
            txtFormatID.Clear();

            cmbBookTitle.SelectedIndex = -1;

            cmbFormatType.SelectedIndex = -1;

            numProductionCost.Value = 0;

            numRetailPrice.Value = 0;
        }

        private void cmbBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBookTitle.SelectedValue != null)
            {
                txtISBN.Text =
                    cmbBookTitle.SelectedValue.ToString();
            }
        }
    }
}
