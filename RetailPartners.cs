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
    public partial class RetailPartners : Form
    {
        public RetailPartners()
        {
            InitializeComponent();
        }
        // =====================================
        // FORM LOAD
        // =====================================

        private void RetailPartners_Load(
            object sender,
            EventArgs e)
        {
            LoadPartners();

            txtPartnerID.ReadOnly = true;

            dgvPartners.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPartners.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPartners.MultiSelect = false;

            dgvPartners.ReadOnly = true;
        }
        // =====================================
        // LOAD PARTNERS
        // =====================================

        private void LoadPartners()
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM RETAILPARTNER",
                        con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvPartners.Columns.Clear();

                dgvPartners.DataSource = dt;

                dgvPartners.Columns[0].HeaderText =
                    "Partner ID";

                dgvPartners.Columns[1].HeaderText =
                    "Partner Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // =====================================
        // GRID CLICK
        // =====================================
        private void dgvFormats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvPartners.Rows[e.RowIndex];

                txtPartnerID.Text =
                    row.Cells[0].Value.ToString();

                txtPartnerName.Text =
                    row.Cells[1].Value.ToString();
            }
        }

        // =====================================
        // INSERT
        // =====================================

        private void btnInsert_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO RETAILPARTNER
                    (PARTNER_NAME)

                    VALUES
                    (@PARTNER_NAME)",
                    con);

                cmd.Parameters.AddWithValue(
                    "@PARTNER_NAME",
                    txtPartnerName.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadPartners();

                ClearFields();

                MessageBox.Show(
                    "Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // =====================================
        // UPDATE
        // =====================================

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtPartnerID.Text))
                {
                    MessageBox.Show(
                        "Select partner first");

                    return;
                }

                if (!ValidateInputs())
                    return;

                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE RETAILPARTNER

                    SET
                    PARTNER_NAME=@PARTNER_NAME

                    WHERE PARTNER_ID=@PARTNER_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@PARTNER_ID",
                    txtPartnerID.Text);

                cmd.Parameters.AddWithValue(
                    "@PARTNER_NAME",
                    txtPartnerName.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadPartners();

                ClearFields();

                MessageBox.Show(
                    "Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        

        // =====================================
        // DELETE
        // =====================================

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtPartnerID.Text))
                {
                    MessageBox.Show(
                        "Select partner first");

                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Delete this partner?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM RETAILPARTNER

                    WHERE PARTNER_ID=@PARTNER_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@PARTNER_ID",
                    txtPartnerID.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadPartners();

                ClearFields();

                MessageBox.Show(
                    "Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // =====================================
        // VALIDATION
        // =====================================

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(
                txtPartnerName.Text))
            {
                MessageBox.Show(
                    "Enter Partner Name");

                txtPartnerName.Focus();

                return false;
            }

            return true;
        }

        // =====================================
        // CLEAR
        // =====================================

        private void ClearFields()
        {
            txtPartnerID.Clear();

            txtPartnerName.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
