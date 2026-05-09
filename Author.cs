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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boutiquePublisherDBDataSet.AUTHOR' table. You can move, or remove it, as needed.
            
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Show_Data_Click(object sender, EventArgs e)
        {
            this.aUTHORTableAdapter.Fill(this.boutiquePublisherDBDataSet.AUTHOR);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO AUTHOR (NAME) VALUES (@NAME);" ,
                    connection);

                cmd.Parameters.AddWithValue("@NAME", txtName.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Inserted Successfully");
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
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE AUTHOR SET NAME = @NAME WHERE AUTHOR_ID = @ID",
                    connection);

                cmd.Parameters.AddWithValue("@NAME", txtName.Text);
                cmd.Parameters.AddWithValue("@ID", A_ID.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Updated Successfully");
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
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM AUTHOR WHERE AUTHOR_ID = @ID",
                    connection);

                cmd.Parameters.AddWithValue("@ID", A_ID.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Deleted Successfully");
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
                txtRoyal.Text = row.Cells[3].Value.ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
