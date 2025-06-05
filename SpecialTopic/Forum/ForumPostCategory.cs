using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SpecialTopic.Forum
{
    public partial class ForumPostCategory : UserControl
    {
        private string connString = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";

        public ForumPostCategory()
        {
            InitializeComponent();
            this.Load += ForumPostCategory_Load;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
        }

        private void ForumPostCategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "SELECT PostCategoryID, PostCategoryName FROM PostCategory";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCategories.DataSource = dt;

                // 設置欄位寬度
                dgvCategories.Columns["PostCategoryID"].Width = 200; // 設置 PostCategoryID 寬度
                dgvCategories.Columns["PostCategoryName"].Width = 300; // 設置 PostCategoryName 寬度，確保顯示完整

                // 可選：啟用自動調整模式
                // dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("請輸入分類名稱！");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "INSERT INTO PostCategory (PostCategoryName) VALUES (@name)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadCategories();
            txtName.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategories.CurrentRow == null)
                {
                    MessageBox.Show("請選擇一筆要修改的資料");
                    return;
                }

                int id = (int)dgvCategories.CurrentRow.Cells["PostCategoryID"].Value;
                string newName = txtName.Text.Trim();

                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("請輸入新名稱！");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string sql = "UPDATE PostCategory SET PostCategoryName = @name WHERE PostCategoryID = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadCategories();
                txtName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新失敗：{ex.Message}", "錯誤");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategories.CurrentRow == null)
                {
                    MessageBox.Show("請選擇一筆要刪除的資料");
                    return;
                }

                int id = (int)dgvCategories.CurrentRow.Cells["PostCategoryID"].Value;

                DialogResult result = MessageBox.Show("確定要刪除這筆分類嗎？", "確認", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string sql = "DELETE FROM PostCategory WHERE PostCategoryID = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadCategories();
                txtName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗：{ex.Message}", "錯誤");
            }
        }
    }
}