using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SpecialTopic.Forum
{
    public partial class ForumPostComment : UserControl
    {
        private string connString = ConfigurationManager.ConnectionStrings["SpecialTopic.Properties.Settings.TeamA_ProjectConnectionString"].ConnectionString;

        public ForumPostComment()
        {
            InitializeComponent();
            this.Load += ForumPostComment_Load;
        }

        private void ForumPostComment_Load(object sender, EventArgs e)
        {
            LoadComments();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvComments.AutoGenerateColumns = false;
            dgvComments.Columns.Clear();

            dgvComments.Columns.Add("CommentID", "評論ID");
            dgvComments.Columns.Add("PostID", "文章ID");
            dgvComments.Columns.Add("ParentCommentID", "父評論ID");
            dgvComments.Columns.Add("UID", "用戶ID");
            dgvComments.Columns.Add("Content", "內容");
            dgvComments.Columns.Add("CreatedAt", "創建時間");
            dgvComments.Columns.Add("IsDeleted", "已刪除");

            dgvComments.Columns["CommentID"].DataPropertyName = "CommentID";
            dgvComments.Columns["PostID"].DataPropertyName = "PostID";
            dgvComments.Columns["ParentCommentID"].DataPropertyName = "ParentCommentID";
            dgvComments.Columns["UID"].DataPropertyName = "UID";
            dgvComments.Columns["Content"].DataPropertyName = "Content";
            dgvComments.Columns["CreatedAt"].DataPropertyName = "CreatedAt";
            dgvComments.Columns["IsDeleted"].DataPropertyName = "IsDeleted";

            // 設置欄位寬度
            dgvComments.Columns["CommentID"].Width = 80;       // 評論ID，數字，較窄即可
            dgvComments.Columns["PostID"].Width = 80;         // 文章ID，數字，較窄即可
            dgvComments.Columns["ParentCommentID"].Width = 80; // 父評論ID，數字或 NULL，較窄即可
            dgvComments.Columns["UID"].Width = 380;           // 用戶ID，GUID 格式，較長
            dgvComments.Columns["Content"].Width = 360;       // 內容，較長文字，設置更寬
            dgvComments.Columns["CreatedAt"].Width = 240;     // 創建時間，日期格式，適中寬度
            dgvComments.Columns["IsDeleted"].Visible = false; // 已隱藏

            // 啟用水平滾動條（如果欄位總寬度超出範圍）
            dgvComments.ScrollBars = ScrollBars.Both;

            // 可選：啟用自動調整模式
            // dgvComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void LoadComments()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string sql = "SELECT CommentID, PostID, ParentCommentID, UID, Content, CreatedAt, IsDeleted FROM PostComments WHERE IsDeleted = 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 確保 ParentCommentID 欄位允許 NULL
                    if (dt.Columns.Contains("ParentCommentID"))
                    {
                        dt.Columns["ParentCommentID"].AllowDBNull = true;
                    }

                    dgvComments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入評論失敗：{ex.Message}", "錯誤");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadComments();
        }

        private void dgvComments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int commentID = Convert.ToInt32(dgvComments.Rows[e.RowIndex].Cells["CommentID"].Value);
                FrmCommentDetail detailForm = new FrmCommentDetail(commentID);
                if (detailForm.ShowDialog() == DialogResult.OK)
                {
                    LoadComments();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCommentDetail frm = new FrmCommentDetail();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadComments();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvComments.CurrentRow == null)
            {
                MessageBox.Show("請選擇一則評論！", "警告");
                return;
            }

            int commentID = (int)dgvComments.CurrentRow.Cells["CommentID"].Value;
            FrmCommentDetail frm = new FrmCommentDetail(commentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadComments();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvComments.CurrentRow == null)
            {
                MessageBox.Show("請選擇一則評論！", "警告");
                return;
            }

            int commentID = (int)dgvComments.CurrentRow.Cells["CommentID"].Value;

            var result = MessageBox.Show("確定要標記此評論為已刪除？", "刪除確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        string updateSql = "UPDATE PostComments SET IsDeleted = 1 WHERE CommentID = @CommentID";
                        SqlCommand updateCmd = new SqlCommand(updateSql, conn);
                        updateCmd.Parameters.AddWithValue("@CommentID", commentID);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadComments();
                            MessageBox.Show("評論已標記為已刪除。", "成功");
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchComments();
            }
        }

        private void SearchComments()
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("請輸入搜尋關鍵字！", "警告");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string sql = @"SELECT CommentID, PostID, ParentCommentID, UID, Content, CreatedAt, IsDeleted 
                                   FROM PostComments 
                                   WHERE IsDeleted = 0 AND (Content LIKE @kw OR UID LIKE @kw)";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 確保 ParentCommentID 欄位允許 NULL
                    if (dt.Columns.Contains("ParentCommentID"))
                    {
                        dt.Columns["ParentCommentID"].AllowDBNull = true;
                    }

                    dgvComments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜尋失敗：{ex.Message}", "錯誤");
            }
        }
    }
}