using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SpecialTopic
{
    public partial class FrmForumSearch : Form
    {
        private string _keyword;

        public FrmForumSearch(string keyword)
        {
            InitializeComponent();
            _keyword = keyword;
            LoadSearchResults();
        }

        private void LoadSearchResults()
        {
            string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"
                    SELECT PostID, Title, Content 
                    FROM ForumPosts 
                    WHERE Title LIKE @kw OR Content LIKE @kw";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + _keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}