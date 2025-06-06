using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                    LoadPostImages(_postID.Value);
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
        private void LoadPostImages(int postID)
        {
            flpImages.Controls.Clear();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT ImageID, PostImage, IsMainPic FROM PostImages WHERE PostID = @PostID ORDER BY IsMainPic DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PostID", postID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int imageID = (int)reader["ImageID"];
                    byte[] imageBytes = (byte[])reader["PostImage"];
                    bool isMain = (bool)reader["IsMainPic"];

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromStream(ms);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Width = 150;
                        pb.Height = 150;
                        pb.Margin = new Padding(5);
                        pb.Tag = imageID; // 綁定 ImageID
                        pb.ContextMenuStrip = CreateImageContextMenu(imageID);

                        if (isMain)
                        {
                            pb.BorderStyle = BorderStyle.Fixed3D;
                            pb.BackColor = Color.Gold;
                        }
                        flpImages.Controls.Add(pb);
                    }
                }
            }
        }

        private ContextMenuStrip CreateImageContextMenu(int imageID)
        {
            var menu = new ContextMenuStrip();
            var deleteItem = new ToolStripMenuItem("刪除圖片");
            deleteItem.Click += (s, e) => DeleteImage(imageID);
            menu.Items.Add(deleteItem);
            return menu;
        }

        private void DeleteImage(int imageID)
        {
            var confirm = MessageBox.Show("確定要刪除這張圖片嗎？", "確認", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM PostImages WHERE ImageID = @ImageID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ImageID", imageID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("圖片已刪除！");
                LoadPostImages(_postID.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗：{ex.Message}", "錯誤");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "圖片檔案 (*.jpg;*.png)|*.jpg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    byte[] imageBytes = File.ReadAllBytes(file); // ✅ 正確名稱
                    uploadedImages.Add((imageBytes, false)); // 預設不是主圖

                    int imageIndex = uploadedImages.Count - 1;

                    using (MemoryStream ms = new MemoryStream(imageBytes)) // ✅ 使用 imageBytes
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromStream(ms);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Width = 150;
                        pb.Height = 150;
                        pb.Margin = new Padding(5);
                        pb.Tag = imageIndex; // 記住第幾張圖
                        pb.Click += Pb_Click; // 點擊可選主圖

                        flpImages.Controls.Add(pb);
                    }
                }
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedPb && clickedPb.Tag is int clickedIndex)
            {
                // 將所有圖片都設為 IsMainPic = false，只有被點的設 true
                for (int i = 0; i < uploadedImages.Count; i++)
                {
                    uploadedImages[i] = (uploadedImages[i].ImageData, false);
                }
                uploadedImages[clickedIndex] = (uploadedImages[clickedIndex].ImageData, true);

                // UI：只有主圖加上金色背景和邊框
                foreach (Control ctrl in flpImages.Controls)
                {
                    if (ctrl is PictureBox pb && pb.Tag is int idx)
                    {
                        bool isMain = (idx == clickedIndex);
                        pb.BorderStyle = isMain ? BorderStyle.Fixed3D : BorderStyle.None;
                        pb.BackColor = isMain ? Color.Gold : SystemColors.Control;
                    }
                }
            }
        }
        private void btnSaveImages_Click(object sender, EventArgs e)
        {
            if (!_postID.HasValue)
            {
                MessageBox.Show("請先儲存文章，才能上傳圖片！");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // 確保這篇文章只會有一張主圖
                    string clearMainPicSql = "UPDATE PostImages SET IsMainPic = 0 WHERE PostID = @PostID AND IsMainPic = 1";
                    SqlCommand clearCmd = new SqlCommand(clearMainPicSql, conn);
                    clearCmd.Parameters.AddWithValue("@PostID", _postID.Value);
                    clearCmd.ExecuteNonQuery();
                    foreach (var item in uploadedImages)
                    {
                        string sql = "INSERT INTO PostImages (PostID, PostImage, IsMainPic) VALUES (@PostID, @PostImage, @IsMainPic)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@PostID", _postID.Value);
                        cmd.Parameters.AddWithValue("@PostImage", item.ImageData);
                        cmd.Parameters.AddWithValue("@IsMainPic", item.IsMainPic);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"圖片儲存失敗：{ex.Message}", "錯誤");
                return;
            }
            MessageBox.Show("圖片儲存成功！");
            uploadedImages.Clear();
            LoadPostImages(_postID.Value);
        }
        private List<(byte[] ImageData, bool IsMainPic)> uploadedImages = new List<(byte[], bool)>();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}