using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Linq;

namespace SpecialTopic.Forum
{
    public partial class FrmCommentDetail : Form
    {
        private int? _commentID = null;
        private string connStr = ConfigurationManager.ConnectionStrings["SpecialTopic.Properties.Settings.TeamA_ProjectConnectionString"].ConnectionString;

        public FrmCommentDetail(int? commentID = null)
        {
            InitializeComponent();
            _commentID = commentID;
            this.Load += FrmCommentDetail_Load;
        }

        private void FrmCommentDetail_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            if (_commentID.HasValue)
            {
                LoadComment();
                this.Text = "編輯評論";
            }
            else
            {
                this.Text = "新增評論";
            }
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    // 載入 PostID 下拉選單，包含 ForumPosts 和 PostComments 中的 PostID
                    string postSql = "SELECT PostID, Title FROM ForumPosts WHERE IsDeleted = 0 " +
                                    "UNION " +
                                    "SELECT DISTINCT pc.PostID, '未知標題 (PostID: ' + CAST(pc.PostID AS VARCHAR) + ')' AS Title " +
                                    "FROM PostComments pc " +
                                    "WHERE pc.IsDeleted = 0 AND pc.PostID NOT IN (SELECT PostID FROM ForumPosts WHERE IsDeleted = 0)";
                    SqlDataAdapter postAdapter = new SqlDataAdapter(postSql, conn);
                    DataTable postDt = new DataTable();
                    postAdapter.Fill(postDt);

                    // 動態生成顯示格式 "PostID - Title"
                    DataTable formattedPostDt = new DataTable();
                    formattedPostDt.Columns.Add("Display", typeof(string));
                    formattedPostDt.Columns.Add("PostID", typeof(int));
                    foreach (DataRow row in postDt.Rows)
                    {
                        formattedPostDt.Rows.Add($"{row["PostID"]} - {row["Title"]}", row["PostID"]);
                    }
                    cmbPostID.DataSource = formattedPostDt;
                    cmbPostID.DisplayMember = "Display";
                    cmbPostID.ValueMember = "PostID";
                    cmbPostID.SelectedIndex = -1; // 預設不選中

                    // 載入 ParentCommentID 下拉選單
                    string commentSql = "SELECT CommentID, Content FROM PostComments WHERE IsDeleted = 0";
                    SqlDataAdapter commentAdapter = new SqlDataAdapter(commentSql, conn);
                    DataTable commentDt = new DataTable();
                    commentAdapter.Fill(commentDt);

                    // 動態生成顯示格式 "CommentID - Content"，並添加 "無父評論"
                    DataTable formattedCommentDt = new DataTable();
                    formattedCommentDt.Columns.Add("Display", typeof(string));
                    formattedCommentDt.Columns.Add("CommentID", typeof(int));
                    formattedCommentDt.Rows.Add("0 - 無父評論", DBNull.Value); // 無父評論對應 NULL
                    foreach (DataRow row in commentDt.Rows)
                    {
                        if (row["CommentID"] != DBNull.Value)
                            formattedCommentDt.Rows.Add($"{row["CommentID"]} - {row["Content"]}", row["CommentID"]);
                    }
                    cmbParentCommentID.DataSource = formattedCommentDt;
                    cmbParentCommentID.DisplayMember = "Display";
                    cmbParentCommentID.ValueMember = "CommentID";
                    cmbParentCommentID.SelectedIndex = 0; // 預設選擇 "無父評論"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入下拉選單失敗：{ex.Message}", "錯誤");
            }
        }

        private void LoadComment()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "SELECT PostID, ParentCommentID, UID, Content FROM PostComments WHERE CommentID = @CommentID AND IsDeleted = 0";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@CommentID", _commentID);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // 設置 PostID
                        int postID = reader.GetInt32(reader.GetOrdinal("PostID"));
                        if (cmbPostID.Items.Cast<DataRowView>().Any(r => (int)r["PostID"] == postID))
                        {
                            cmbPostID.SelectedValue = postID;
                        }
                        else
                        {
                            MessageBox.Show($"PostID {postID} 不在下拉選單中，請檢查數據一致性！", "警告");
                            cmbPostID.SelectedIndex = -1; // 如果無效則不選中
                        }

                        // 設置 ParentCommentID
                        object parentCommentIDValue = reader["ParentCommentID"];
                        if (parentCommentIDValue == DBNull.Value || parentCommentIDValue == null)
                        {
                            cmbParentCommentID.SelectedIndex = 0; // 選擇 "無父評論"
                        }
                        else
                        {
                            int parentCommentID = Convert.ToInt32(parentCommentIDValue);
                            if (cmbParentCommentID.Items.Cast<DataRowView>().Any(r => r["CommentID"] != DBNull.Value && (int)r["CommentID"] == parentCommentID))
                            {
                                cmbParentCommentID.SelectedValue = parentCommentID;
                            }
                            else
                            {
                                cmbParentCommentID.SelectedIndex = 0; // 無效則選擇 "無父評論"
                            }
                        }

                        txtUID.Text = reader["UID"].ToString();
                        txtContent.Text = reader["Content"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("找不到該評論！", "錯誤");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入評論失敗：{ex.Message}", "錯誤");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 驗證輸入
                if (cmbPostID.SelectedValue == null)
                {
                    MessageBox.Show("請選擇文章ID！", "錯誤");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtUID.Text))
                {
                    MessageBox.Show("請輸入用戶ID！", "錯誤");
                    return;
                }
                if (!Guid.TryParse(txtUID.Text, out _))
                {
                    MessageBox.Show("用戶ID格式錯誤，應為有效的 GUID！", "錯誤");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtContent.Text))
                {
                    MessageBox.Show("請輸入評論內容！", "錯誤");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql;
                    SqlCommand cmd;

                    if (_commentID.HasValue)
                    {
                        sql = @"UPDATE PostComments 
                                SET PostID = @PostID, ParentCommentID = @ParentCommentID, UID = @UID, Content = @Content 
                                WHERE CommentID = @CommentID";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@CommentID", _commentID);
                    }
                    else
                    {
                        sql = @"INSERT INTO PostComments (PostID, ParentCommentID, UID, Content, CreatedAt, IsDeleted) 
                                VALUES (@PostID, @ParentCommentID, @UID, @Content, @CreatedAt, 0)";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    }

                    cmd.Parameters.AddWithValue("@PostID", cmbPostID.SelectedValue);
                    cmd.Parameters.AddWithValue("@ParentCommentID", cmbParentCommentID.SelectedValue != DBNull.Value ? cmbParentCommentID.SelectedValue : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UID", Guid.Parse(txtUID.Text));
                    cmd.Parameters.AddWithValue("@Content", txtContent.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("儲存成功！", "成功");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("儲存失敗：沒有影響任何記錄。", "錯誤");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存失敗：{ex.Message}", "錯誤");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}