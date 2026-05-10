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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Activated += Dashboard_Activated;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignBookAuthor form = new AssignBookAuthor();
            form.Show();
        }

       
        private void Dashboard_Activated(object sender, EventArgs e)
        {
            LoadStatistics();
        }
        private void LoadStatistics()
        {
            SqlConnection con = new SqlConnection(
                DatabaseHelper.ConnectionString);

            con.Open();

            // Total Authors
            SqlCommand cmdAuthors =
                new SqlCommand("SELECT COUNT(*) FROM AUTHOR", con);

            lblTotalAuthors.Text =
                cmdAuthors.ExecuteScalar().ToString();

            // Total Books
            SqlCommand cmdBooks =
                new SqlCommand("SELECT COUNT(*) FROM BOOK", con);

            lblTotalBooks.Text =
                cmdBooks.ExecuteScalar().ToString();

            // Total Orders
            SqlCommand cmdOrders =
                new SqlCommand("SELECT COUNT(*) FROM [ORDER]", con);

            lblTotalOrders.Text =
                cmdOrders.ExecuteScalar().ToString();

            // Total Partners
            SqlCommand cmdPartners =
                new SqlCommand("SELECT COUNT(*) FROM RETAILPARTNER", con);

            lblTotalPartners.Text =
                cmdPartners.ExecuteScalar().ToString();

            con.Close();
        }

        private void manageAuth_Click(object sender, EventArgs e)
        {
            Author form = new Author();
            form.Show();
        }

        private void mangeBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
        }

        private void processOrders_Click(object sender, EventArgs e)
        {
            ProcessOrder orders = new ProcessOrder();
            orders.Show();
        }

        private void manageFormats_Click(object sender, EventArgs e)
        {
            Formats formats = new Formats();
                        formats.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to reset the database?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                SqlConnection con =
                    new SqlConnection(DatabaseHelper.ConnectionString);

                con.Open();

                SqlCommand cmd = new SqlCommand(@"

        DELETE FROM AUTHOR_BOOK;
        DELETE FROM [ORDER];
        DELETE FROM FORMAT;
        DELETE FROM RETAILPARTNER;
        DELETE FROM BOOK;
        DELETE FROM AUTHOR;

        DBCC CHECKIDENT ('AUTHOR', RESEED, 0);
        DBCC CHECKIDENT ('FORMAT', RESEED, 0);
        DBCC CHECKIDENT ('RETAILPARTNER', RESEED, 0);
        DBCC CHECKIDENT ('ORDER', RESEED, 0);

        ", con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Database Reset Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void retailPart_Click(object sender, EventArgs e)
        {
            RetailPartners retailPartners = new RetailPartners();
            retailPartners.Show();
        }

        private void royaltyReports_Click(object sender, EventArgs e)
        {
            RoyaltyReport royaltyReport = new RoyaltyReport();
            royaltyReport.Show();
        }

        

       

        private void panel1_Click(object sender, EventArgs e)
        {
            ProcessOrder orders = new ProcessOrder();
            orders.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Author form = new Author();
            form.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            RetailPartners retailPartners = new RetailPartners();
            retailPartners.Show();
        }

        
    }
}
