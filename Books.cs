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
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

            // Genre ComboBox
            cmbGenre.Items.Add("Fantasy");
            cmbGenre.Items.Add("Horror");
            cmbGenre.Items.Add("Romance");
            cmbGenre.Items.Add("Drama");
            cmbGenre.Items.Add("Science Fiction");

            // Target Age Group ComboBox
            cmbTargetAge.Items.Add("Kids");
            cmbTargetAge.Items.Add("Teens");
            cmbTargetAge.Items.Add("Adults");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Show_Data_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM BOOK",
                    connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO BOOK (ISBN, TITLE, GENRE, TARGETAGEGROUP) VALUES (@ISBN, @TITLE, @GENRE, @TARGETAGEGROUP)",
                    connection);

                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@TITLE", txtTitle.Text);
                cmd.Parameters.AddWithValue("@GENRE", cmbGenre.Text);
                cmd.Parameters.AddWithValue("@TARGETAGEGROUP", cmbTargetAge.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO BOOK (ISBN, TITLE, GENRE, TARGETAGEGROUP) VALUES (@ISBN, @TITLE, @GENRE, @TARGETAGEGROUP)",
                    connection);

                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@TITLE", txtTitle.Text);
                cmd.Parameters.AddWithValue("@GENRE", cmbGenre.Text);
                cmd.Parameters.AddWithValue("@TARGETAGEGROUP", cmbTargetAge.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Inserted Successfully");
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
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE BOOK SET TITLE = @TITLE, GENRE = @GENRE, TARGETAGEGROUP = @TARGETAGEGROUP WHERE ISBN = @ISBN",
                    connection);

                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@TITLE", txtTitle.Text);
                cmd.Parameters.AddWithValue("@GENRE", cmbGenre.Text);
                cmd.Parameters.AddWithValue("@TARGETAGEGROUP", cmbTargetAge.Text);

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
                    "DELETE FROM BOOK WHERE ISBN = @ISBN",
                    connection);

                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE BOOK SET TITLE = @TITLE, GENRE = @GENRE, TARGETAGEGROUP = @TARGETAGEGROUP WHERE ISBN = @ISBN",
                    connection);

                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@TITLE", txtTitle.Text);
                cmd.Parameters.AddWithValue("@GENRE", cmbGenre.Text);
                cmd.Parameters.AddWithValue("@TARGETAGEGROUP", cmbTargetAge.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Updated Successfully");
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

                txtISBN.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                cmbGenre.Text = row.Cells[2].Value.ToString();
                cmbTargetAge.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
