using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SpecialTopic.Forum
{
    public partial class FrmPostDetail : Form
    {
        private int? _postID = null;
        private string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";
        private Guid? _uid = null;
        private string _loginPhone; // 儲存手機號碼

        public FrmPostDetail(int? postID = null, Guid? uid = null, string loginPhone = null)
        {
            InitializeComponent();
            _postID = postID;
            _uid = uid;
            _loginPhone = loginPhone;
            this.Load += FrmPostDetail_Load;
        }

        private void FrmPostDetail_Load(object sender, EventArgs e)
        {
            LoadCategoriesAndFilters();

            // 如果沒有提供 UID，但有手機號碼，則查詢 UID
            if (_uid == null && !string.IsNullOrEmpty(_loginPhone))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "SELECT UID FROM Users WHERE Phone = @Phone";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Phone", _loginPhone);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            _uid = (Guid)result;
                        }
                        else
                        {
                            MessageBox.Show("錯誤：找不到對應的用戶 UID", "錯誤");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"載入 UID 失敗：{ex.Message}", "錯誤");
                }
            }

            if (_postID.HasValue)
            {
                LoadPost();
                this.Text = "編輯文章";
                EnableControls(true); // 編輯模式
            }
            else
            {
                this.Text = "新增文章";
                EnableControls(false); // 新增模式
            }
        }

        private void LoadCategoriesAndFilters()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string categorySql = "SELECT PostCategoryID, PostCategoryName FROM PostCategory";
                    SqlDataAdapter categoryAdapter = new SqlDataAdapter(categorySql, conn);
                    DataTable categoryDt = new DataTable();
                    categoryAdapter.Fill(categoryDt);
                    cmbCategory.DataSource = categoryDt;
                    cmbCategory.DisplayMember = "PostCategoryName";
                    cmbCategory.ValueMember = "PostCategoryID";

                    string filterSql = "SELECT PostFilterID, FilterName FROM PostFilter";
                    SqlDataAdapter filterAdapter = new SqlDataAdapter(filterSql, conn);
                    DataTable filterDt = new DataTable();
                    filterAdapter.Fill(filterDt);
                    cmbFilter.DataSource = filterDt;
                    cmbFilter.DisplayMember = "FilterName";
                    cmbFilter.ValueMember = "PostFilterID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加載分類和過濾器失敗：{ex.Message}", "錯誤");
            }
        }

        private void LoadPost()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = @"SELECT Title, Content, UID, CreatedAt, ViewCount, PostCategoryID, FilterID 
                                   FROM ForumPosts WHERE PostID = @PostID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@PostID", _postID);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtTitle.Text = reader["Title"].ToString();
                        txtContent.Text = reader["Content"].ToString();
                        lblAuthor.Text = "作者：" + reader["UID"].ToString();
                        lblDate.Text = "發表於：" + Convert.ToDateTime(reader["CreatedAt"]).ToString("yyyy-MM-dd HH:mm");
                        lblViews.Text = "瀏覽數：" + reader["ViewCount"].ToString();
                        cmbCategory.SelectedValue = reader["PostCategoryID"];
                        cmbFilter.SelectedValue = reader["FilterID"];
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入文章失敗：{ex.Message}", "錯誤");
            }
        }

        private void EnableControls(bool isEdit)
        {
            // 無論新增或編輯模式，輸入元件都可見且可編輯
            txtTitle.Visible = true;
            txtContent.ReadOnly = false;
            cmbCategory.Visible = true;
            cmbFilter.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            // 只讀資訊在編輯模式下顯示
            lblTitle.Visible = isEdit;
            lblAuthor.Visible = isEdit;
            lblDate.Visible = isEdit;
            lblViews.Visible = isEdit;

            if (!isEdit)
            {
                // 新增時清空內容
                txtTitle.Text = "";
                txtContent.Text = "";
                cmbCategory.SelectedIndex = -1;
                cmbFilter.SelectedIndex = -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("已進入 btnSave_Click 方法", "調試");

                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("請輸入標題！", "錯誤");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtContent.Text))
                {
                    MessageBox.Show("請輸入內容！", "錯誤");
                    return;
                }
                if (cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show($"請選擇分類！分類值為：{cmbCategory.SelectedValue}", "錯誤");
                    return;
                }
                if (cmbFilter.SelectedValue == null)
                {
                    MessageBox.Show($"請選擇過濾器！過濾器值為：{cmbFilter.SelectedValue}", "錯誤");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql;
                    SqlCommand cmd;
                    int rowsAffected;

                    if (_postID.HasValue)
                    {
                        sql = @"UPDATE ForumPosts 
                                SET Title = @Title, Content = @Content, PostCategoryID = @PostCategoryID, FilterID = @FilterID 
                                WHERE PostID = @PostID";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@PostID", _postID);
                    }
                    else
                    {
                        sql = @"INSERT INTO ForumPosts (UID, Title, Content, PostCategoryID, FilterID, CreatedAt, ViewCount, LikeCount, CommentCount, IsDeleted) 
                                VALUES (@UID, @Title, @Content, @PostCategoryID, @FilterID, @CreatedAt, 0, 0, 0, 0)";
                        cmd = new SqlCommand(sql, conn);
                        if (_uid == null)
                        {
                            MessageBox.Show("錯誤：找不到登入者的 UID，無法新增文章。", "錯誤");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@UID", _uid.Value); // 使用查詢到的 UID
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    }

                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Content", txtContent.Text);
                    cmd.Parameters.AddWithValue("@PostCategoryID", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@FilterID", cmbFilter.SelectedValue);

                    rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"受影響的行數：{rowsAffected}");

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