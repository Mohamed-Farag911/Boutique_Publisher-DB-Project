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
    public partial class RoyaltyReport : Form
    {
        public RoyaltyReport()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            LoadRoyaltyReport();
        }



        private void dgvRoyalty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoyaltyReport_Load(object sender, EventArgs e)
        {
            LoadRoyaltyReport();
            dgvRoyalty.AutoSizeColumnsMode =
             DataGridViewAutoSizeColumnsMode.Fill;

            dgvRoyalty.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRoyalty.ReadOnly = true;

            dgvRoyalty.RowHeadersVisible = false;
        }
        private void LoadRoyaltyReport()
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(
                        DatabaseHelper.ConnectionString);

                string query = @"

        SELECT

            A.AUTHOR_ID,
            A.NAME AS AuthorName,
            B.TITLE AS BookTitle,
            A.ROYALTY_PERCENTAGE,
            SUM(O.QUANTITY) AS TotalQuantitySold,
            SUM(F.RETAIL_PRICE * O.QUANTITY)
            AS TotalSales,
            SUM(F.RETAIL_PRICE * O.QUANTITY) * (ISNULL(A.ROYALTY_PERCENTAGE, 0) / 100.0) AS RoyaltyAmount

        FROM AUTHOR A
                 INNER JOIN AUTHOR_BOOK AB
                 ON A.AUTHOR_ID = AB.AUTHOR_ID
        INNER JOIN BOOK B
                 ON AB.ISBN = B.ISBN
        INNER JOIN FORMAT F
                 ON B.ISBN = F.ISBN

        INNER JOIN [ORDER] O
            ON F.FORMAT_ID = O.FORMAT_ID

        GROUP BY
            A.AUTHOR_ID,
            A.NAME,
            B.TITLE,
            A.ROYALTY_PERCENTAGE
        ORDER BY RoyaltyAmount DESC";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvRoyalty.Columns.Clear();

                dgvRoyalty.DataSource = dt;

                dgvRoyalty.Columns[0].HeaderText =
                    "Author ID";

                dgvRoyalty.Columns[1].HeaderText =
                    "Author Name";

                dgvRoyalty.Columns[2].HeaderText =
                    "Book Title";

                dgvRoyalty.Columns[3].HeaderText =
                    "Royalty %";

                dgvRoyalty.Columns[4].HeaderText =
                    "Quantity Sold";

                dgvRoyalty.Columns[5].HeaderText =
                    "Total Sales";

                dgvRoyalty.Columns[6].HeaderText =
                    "Royalty Amount";

                CalculateTotals(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalculateTotals(DataTable dt)
        {
            decimal totalRevenue = 0;

            decimal totalRoyalties = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["TotalSales"] != DBNull.Value)
                    totalRevenue += Convert.ToDecimal(row["TotalSales"]);

                if (row["RoyaltyAmount"] != DBNull.Value)
                    totalRoyalties += Convert.ToDecimal(row["RoyaltyAmount"]);
            }

            lblTotalRevenue.Text =
                totalRevenue.ToString("0.00");

            lblTotalRoyalties.Text =
                totalRoyalties.ToString("0.00");
        }
    }
}
