using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SpecialTopic.Forum
{
    public partial class ForumPostControl : UserControl
    {
        private string connString = ConfigurationManager.ConnectionStrings["SpecialTopic.Properties.Settings.TeamA_ProjectConnectionString"].ConnectionString;

        public ForumPostControl()
        {
            InitializeComponent();
            this.Load += ForumPostControl_Load;
            this.dgvPosts.CellDoubleClick += dgvPosts_CellDoubleClick;
            this.btnAdd.Click += btnAdd_Click;
            this.btnEdit.Click += btnEdit_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnRefresh.Click += btnRefresh_Click;
        }

        private void ForumPostControl_Load(object sender, EventArgs e)
        {
            LoadPosts();
        }

        private void LoadPosts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string sql = "SELECT PostID, UID, Title, CreatedAt, ViewCount, LikeCount, CommentCount FROM ForumPosts WHERE IsDeleted = 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPosts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入文章失敗：{ex.Message}", "錯誤");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPosts();
        }

        private void dgvPosts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int postID = Convert.ToInt32(dgvPosts.Rows[e.RowIndex].Cells["PostID"].Value);
                FrmPostDetail detailForm = new FrmPostDetail(postID);
                detailForm.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("請輸入搜尋關鍵字！");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string sql = @"SELECT PostID, UID, Title, CreatedAt, ViewCount, LikeCount, CommentCount 
                                   FROM ForumPosts
                                   WHERE IsDeleted = 0 AND (Title LIKE @kw OR UID LIKE @kw)";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPosts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜尋失敗：{ex.Message}", "錯誤");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("已進入 btnAdd_Click 方法", "調試");
                // 獲取 Form1 實例
                Form1 mainForm = this.FindForm() as Form1;
                if (mainForm != null && !string.IsNullOrEmpty(mainForm.s))
                {
                    FrmPostDetail frm = new FrmPostDetail(null, null, mainForm.s); // 傳遞手機號碼
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPosts();
                        MessageBox.Show("已重新載入文章列表", "調試");
                    }
                    else
                    {
                        MessageBox.Show("未儲存任何更改", "調試");
                    }
                }
                else
                {
                    MessageBox.Show("錯誤：請先登入", "錯誤");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增失敗：{ex.Message}", "錯誤");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPosts.CurrentRow == null)
            {
                MessageBox.Show("請選擇一篇文章！");
                return;
            }

            int postID = (int)dgvPosts.CurrentRow.Cells["PostID"].Value;
            FrmPostDetail frm = new FrmPostDetail(postID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPosts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPosts.CurrentRow == null)
            {
                MessageBox.Show("請選擇一篇文章！");
                return;
            }

            int postID = (int)dgvPosts.CurrentRow.Cells["PostID"].Value;

            var result = MessageBox.Show("確定要標記此文章為已刪除？", "刪除確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();

                        string updateSql = "UPDATE ForumPosts SET IsDeleted = 1 WHERE PostID = @PostID";
                        SqlCommand updateCmd = new SqlCommand(updateSql, conn);
                        updateCmd.Parameters.AddWithValue("@PostID", postID);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadPosts();
                            MessageBox.Show("文章已標記為已刪除。", "成功");
                        }
                        else
                        {
                            MessageBox.Show("未找到要刪除的記錄。", "警告");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"操作失敗：{ex.Message}", "錯誤");
                }
            }
        }
    }
}