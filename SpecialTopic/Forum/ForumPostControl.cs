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

namespace SpecialTopic.Forum
{
    public partial class ForumPostControl : UserControl
    {
        private string connString = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";

        public ForumPostControl()
        {
            InitializeComponent();
            this.Load += ForumPostControl_Load;
        }

        private void ForumPostControl_Load(object sender, EventArgs e)
        {
            LoadPosts();
        }

        private void LoadPosts()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "SELECT PostID, UID, Title, CreatedAt, ViewCount, LikeCount, CommentCount FROM ForumPosts";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPosts.DataSource = dt;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPosts();
        }
    }
    
}
