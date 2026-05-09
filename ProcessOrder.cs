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
    public partial class ProcessOrder : Form
    {
        public ProcessOrder()
        {
            InitializeComponent();
        }
        // =========================================
        // FORM LOAD
        // =========================================
        private void ProcessOrder_Load(object sender, EventArgs e)
        {
           
            LoadPartners();
            LoadBooks();
            LoadOrders();

            txtOrderID.ReadOnly = true;

            dgvOrders.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrders.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvOrders.MultiSelect = false;

            dgvOrders.ReadOnly = true;

            dgvOrders.RowHeadersVisible = false;

            dgvOrders.AllowUserToAddRows = false;

            lblRetailPrice.Text = "0.00";

            lblTotalPrice.Text = "0.00";

          
            lblDate.Text =
                DateTime.Now.ToShortDateString();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text =
                DateTime.Now.ToString("hh:mm:ss tt");
        }
        // =========================================
        // LOAD PARTNERS
        // =========================================

        private void LoadPartners()
        {
            SqlConnection con =
                new SqlConnection(
                    DatabaseHelper.ConnectionString);

            SqlDataAdapter da =
                new SqlDataAdapter(
                    @"SELECT PARTNER_ID,
                      PARTNER_NAME
                      FROM RETAILPARTNER",
                    con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbPartner.DataSource = dt;

            cmbPartner.DisplayMember =
                "PARTNER_NAME";

            cmbPartner.ValueMember =
                "PARTNER_ID";

            cmbPartner.SelectedIndex = -1;
        }

        // =========================================
        // LOAD BOOKS
        // =========================================

        private void LoadBooks()
        {
            SqlConnection con =
                new SqlConnection(
                    DatabaseHelper.ConnectionString);

            SqlDataAdapter da =
                new SqlDataAdapter(
                    @"SELECT
                      ISBN,
                      TITLE

                      FROM BOOK",
                    con);

            DataTable dt = new DataTable();

            da.Fill(dt);


            cmbBook.DisplayMember =
                "TITLE";

            cmbBook.ValueMember =
                "ISBN";
            cmbBook.DataSource = dt;

            cmbBook.SelectedIndex = -1;
        }

        // =========================================
        // LOAD FORMATS BASED ON BOOK
        // =========================================

        private void cmbBook_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbBook.SelectedValue == null)
                    return;

                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                SqlDataAdapter da =
                    new SqlDataAdapter(
                    @"SELECT
                      FORMAT_ID,
                      FORMAT_TYPE

                      FROM FORMAT

                      WHERE ISBN=@ISBN",
                    con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@ISBN",
                    cmbBook.SelectedValue);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbFormat.DataSource = dt;

                cmbFormat.DisplayMember =
                    "FORMAT_TYPE";

                cmbFormat.ValueMember =
                    "FORMAT_ID";

                cmbFormat.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        // =========================================
        // GET RETAIL PRICE
        // =========================================

        private void cmbFormat_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbFormat.SelectedValue == null)
                    return;

                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT RETAIL_PRICE
                      FROM FORMAT
                      WHERE FORMAT_ID=@FORMAT_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@FORMAT_ID",
                    cmbFormat.SelectedValue);

                object result =
                    cmd.ExecuteScalar();

                if (result != null)
                {
                    decimal retailPrice =
                        Convert.ToDecimal(result);

                    lblRetailPrice.Text =
                        retailPrice.ToString("0.00");

                    CalculateTotalPrice();
                }

                con.Close();
            }
            catch
            {

            }
        }

        // =========================================
        // CALCULATE TOTAL PRICE
        // =========================================

        private void CalculateTotalPrice()
        {
            decimal retailPrice = 0;

            decimal.TryParse(
                lblRetailPrice.Text,
                out retailPrice);

            decimal totalPrice =
                retailPrice * numQuantity.Value;

            lblTotalPrice.Text =
                totalPrice.ToString("0.00");
        }

        // =========================================
        // QUANTITY CHANGED
        // =========================================

        private void numQuantity_ValueChanged(
            object sender,
            EventArgs e)
        {
            CalculateTotalPrice();
        }

        // =========================================
        // LOAD ORDERS
        // =========================================

        private void LoadOrders()
        {
            SqlConnection con =
                new SqlConnection(
                    DatabaseHelper.ConnectionString);

            string query = @"

            SELECT

                O.ORDER_ID,

                RP.PARTNER_NAME,

                B.TITLE AS BookTitle,

                F.FORMAT_TYPE,

                O.ORDER_DATE,

                O.QUANTITY,

                F.RETAIL_PRICE,

                (O.QUANTITY * F.RETAIL_PRICE)
                AS TotalPrice

            FROM [ORDER] O

            INNER JOIN RETAILPARTNER RP
                ON O.PARTNER_ID = RP.PARTNER_ID

            INNER JOIN FORMAT F
                ON O.FORMAT_ID = F.FORMAT_ID

            INNER JOIN BOOK B
                ON F.ISBN = B.ISBN";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvOrders.Columns.Clear();

            dgvOrders.DataSource = dt;
        }


        // =========================================
        // GRID CLICK
        // =========================================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvOrders.Rows[e.RowIndex];

                txtOrderID.Text =
                    row.Cells[0].Value.ToString();

                cmbPartner.Text =
                    row.Cells[1].Value.ToString();
                cmbBook.Text =
                    row.Cells[2].Value.ToString();

                cmbFormat.Text =
                    row.Cells[3].Value.ToString();

                numQuantity.Value =
                    Convert.ToDecimal(
                        row.Cells[5].Value);

                lblRetailPrice.Text =
                    row.Cells[6].Value.ToString();

                lblTotalPrice.Text =
                    row.Cells[7].Value.ToString();
            }
        }

        private void btnUpdate_Click(
     object sender,
     EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtOrderID.Text))
                {
                    MessageBox.Show(
                        "Select order first");

                    return;
                }

                if (!ValidateInputs())
                    return;

                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"UPDATE [ORDER]

            SET

            FORMAT_ID=@FORMAT_ID,
            PARTNER_ID=@PARTNER_ID,
            QUANTITY=@QUANTITY

            WHERE ORDER_ID=@ORDER_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@ORDER_ID",
                    txtOrderID.Text);

                cmd.Parameters.AddWithValue(
                    "@FORMAT_ID",
                    cmbFormat.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@PARTNER_ID",
                    cmbPartner.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@QUANTITY",
                    numQuantity.Value);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadOrders();

                ClearFields();

                MessageBox.Show(
                    "Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================================
        // DELETE ORDER
        // =========================================

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtOrderID.Text))
                {
                    MessageBox.Show(
                        "Select order first");

                    return;
                }

                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"DELETE FROM [ORDER]
                      WHERE ORDER_ID=@ORDER_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@ORDER_ID",
                    txtOrderID.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadOrders();

                ClearFields();

                MessageBox.Show(
                    "Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        // =========================================
        // INSERT ORDER
        // =========================================

        private void btnProcess_Click(
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

                SqlCommand cmd =
                    new SqlCommand(
                    @"INSERT INTO [ORDER]

                    (FORMAT_ID,
                     PARTNER_ID,
                     ORDER_DATE,
                     QUANTITY)

                    VALUES

                    (@FORMAT_ID,
                     @PARTNER_ID,
                     @ORDER_DATE,
                     @QUANTITY)",
                    con);

                cmd.Parameters.AddWithValue(
                    "@FORMAT_ID",
                    cmbFormat.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@PARTNER_ID",
                    cmbPartner.SelectedValue);

                // الوقت الحالي تلقائي
                cmd.Parameters.AddWithValue(
                    "@ORDER_DATE",
                    DateTime.Now);

                cmd.Parameters.AddWithValue(
                    "@QUANTITY",
                    numQuantity.Value);

                cmd.ExecuteNonQuery();

                con.Close();

                LoadOrders();

                ClearFields();

                MessageBox.Show(
                    "Order Processed Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================================
        // VALIDATION
        // =========================================

        private bool ValidateInputs()
        {
            if (cmbPartner.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Select Retail Partner");

                return false;
            }

            if (cmbFormat.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Select Format");

                return false;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show(
                    "Quantity must be greater than 0");

                return false;
            }

            return true;
        }

        // =========================================
        // CLEAR
        // =========================================

        private void ClearFields()
        {
            txtOrderID.Clear();

            cmbPartner.SelectedIndex = -1;

            cmbFormat.SelectedIndex = -1;

            numQuantity.Value = 1;

            lblRetailPrice.Text = "0.00";

            lblTotalPrice.Text = "0.00";
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
