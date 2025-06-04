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

namespace SpecialTopic
{
    public partial class FrmPostDetail : Form
    {
        private int _postID;

        public FrmPostDetail(int postID)
        {
            InitializeComponent();
            _postID = postID;
            LoadPost();
        }

    

    private void LoadPost()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True"))
            {
                string sql = "SELECT Title, Content, UID, CreatedAt, ViewCount FROM ForumPosts WHERE PostID = @PostID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PostID", _postID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblTitle.Text = reader["Title"].ToString();
                    txtContent.Text = reader["Content"].ToString();
                    lblAuthor.Text = "作者：" + reader["UID"].ToString();
                    lblDate.Text = "發表於：" + Convert.ToDateTime(reader["CreatedAt"]).ToString("yyyy-MM-dd HH:mm");
                    lblViews.Text = "瀏覽數：" + reader["ViewCount"].ToString();
                }
            }
        }
    }
}
