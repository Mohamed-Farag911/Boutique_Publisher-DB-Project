using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique_Publisher
{
    public static class DatabaseHelper
    {
        public static string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=BoutiquePublisherDB;Integrated Security=True";

        public static DataTable GetTable(string query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
