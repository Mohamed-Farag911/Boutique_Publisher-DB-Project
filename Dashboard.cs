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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
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
    }
}
