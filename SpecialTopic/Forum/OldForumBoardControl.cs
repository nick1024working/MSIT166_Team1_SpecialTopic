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
using SpecialTopic.Forum;

namespace SpecialTopic
{
    public partial class OldForumBoardControl : UserControl
    {
        public OldForumBoardControl()
        {
            InitializeComponent();
            this.Load += ForumBoardControl_Load;
        }
        private string connString = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True"; // ← 實際連線字串
        private List<Post> GetPostsFromDatabase()
        {
            List<Post> posts = new List<Post>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"
            SELECT PostID, Title, Content, ViewCount, LikeCount, CommentCount
            FROM ForumPosts
            WHERE IsDeleted = 0
            ORDER BY CreatedAt DESC"; // 加入 IsDeleted 條件

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Post p = new Post
                    {
                        PostID = (int)reader["PostID"],
                        Title = reader["Title"].ToString(),
                        Content = reader["Content"].ToString(),
                        ViewCount = (int)reader["ViewCount"],
                        LikeCount = (int)reader["LikeCount"],
                        CommentCount = (int)reader["CommentCount"]
                    };
                    posts.Add(p);
                }

                reader.Close();
            }

            return posts;
        }
    
        public class Post
        {
            public int PostID { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public int ViewCount { get; set; }
            public int LikeCount { get; set; }
            public int CommentCount { get; set; }
        }
        private void LoadPosts(List<Post> posts)
        {
            flowPosts.Controls.Clear();

            foreach (var post in posts)
            {
                Panel panel = new Panel();
                panel.Width = 600;
                panel.Height = 80;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Tag = post.PostID;
                panel.Cursor = Cursors.Hand; // 讓 Panel 看起來可點擊
                panel.Click += Panel_Click;

                Label lblTitle = new Label();
                lblTitle.Text = post.Title;
                lblTitle.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
                lblTitle.AutoSize = true;
                lblTitle.Location = new Point(10, 10);
                lblTitle.Cursor = Cursors.Hand;
                lblTitle.Click += (s, e) => Panel_Click(panel, EventArgs.Empty);

                Label lblSummary = new Label();
                lblSummary.Text = post.Content.Length > 40 ? post.Content.Substring(0, 40) + "..." : post.Content;
                lblSummary.AutoSize = true;
                lblSummary.Location = new Point(10, 35);
                lblSummary.Cursor = Cursors.Hand;
                lblSummary.Click += (s, e) => Panel_Click(panel, EventArgs.Empty);

                Label lblMeta = new Label();
                lblMeta.Text = $"👍{post.LikeCount} 💬{post.CommentCount} 👁{post.ViewCount}";
                lblMeta.AutoSize = true;
                lblMeta.Location = new Point(450, 55);
                lblMeta.ForeColor = Color.Gray;
                lblMeta.Cursor = Cursors.Hand;
                lblMeta.Click += (s, e) => Panel_Click(panel, EventArgs.Empty);

                panel.Controls.Add(lblTitle);
                panel.Controls.Add(lblSummary);
                panel.Controls.Add(lblMeta);

                flowPosts.Controls.Add(panel);
            }
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            int postID = (int)panel.Tag;

            FrmPostDetail frm = new FrmPostDetail(postID);
            frm.Show();
        }
        private void ForumBoardControl_Load(object sender, EventArgs e)
        {
            var posts = GetPostsFromDatabase();
            LoadPosts(posts);
        }
    }
}
