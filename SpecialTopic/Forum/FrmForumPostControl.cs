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
    public partial class FrmForumPostControl : Form
    {
        public FrmForumPostControl()
        {
            InitializeComponent();
        }

        private void forumPostsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.forumPostsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);

        }

        private void FrmForumPostControl_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'teamA_ProjectDataSet.ForumPosts' 資料表。您可以視需要進行移動或移除。
            this.forumPostsTableAdapter.Fill(this.teamA_ProjectDataSet.ForumPosts);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("請輸入搜尋關鍵字！");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT PostID, UID, Title, CreatedAt, ViewCount, LikeCount, CommentCount 
                       FROM ForumPosts
                       WHERE Title LIKE @kw OR UID LIKE @kw";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPosts.DataSource = dt;
            }

        }
    }
}
