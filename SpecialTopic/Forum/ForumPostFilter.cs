using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SpecialTopic.Forum
{
    public partial class ForumPostFilter : UserControl
    {
        private string connString = ConfigurationManager.ConnectionStrings["SpecialTopic.Properties.Settings.TeamA_ProjectConnectionString"].ConnectionString;
        private bool isEditMode = false;
        private int? editingID = null;

        public ForumPostFilter()
        {
            InitializeComponent();

            this.Load += ForumPostFilter_Load;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnRefresh.Click += BtnRefresh_Click;
            dgvPostFilters.SelectionChanged += DgvPostFilters_SelectionChanged;
        }

        private void ForumPostFilter_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadPostFilters();
            ResetForm();
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string sql = "SELECT PostCategoryID, PostCategoryName FROM PostCategory";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "PostCategoryName";
                    cmbCategory.ValueMember = "PostCategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入分類失敗：" + ex.Message);
            }
        }

        private void LoadPostFilters()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string sql = @"
                        SELECT f.PostFilterID, f.FilterName, f.PostCategoryID, c.PostCategoryName
                        FROM PostFilter f
                        JOIN PostCategory c ON f.PostCategoryID = c.PostCategoryID
                        ORDER BY f.PostFilterID";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPostFilters.DataSource = dt;
                    dgvPostFilters.Columns["PostCategoryID"].Visible = false;

                    // 設置欄位寬度
                    dgvPostFilters.Columns["PostFilterID"].Width = 160; // 設置 PostFilterID 寬度
                    dgvPostFilters.Columns["FilterName"].Width = 200; // 設置 FilterName 寬度
                    dgvPostFilters.Columns["PostCategoryName"].Width = 250; // 設置 PostCategoryName 寬度，確保顯示完整

                    // 可選：啟用自動調整模式
                    // dgvPostFilters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入資料失敗：" + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            isEditMode = false;
            editingID = null;
            txtFilterName.Clear();
            cmbCategory.SelectedIndex = -1;
            UpdateStatus("新增模式");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPostFilters.CurrentRow == null) return;

            isEditMode = true;
            editingID = Convert.ToInt32(dgvPostFilters.CurrentRow.Cells["PostFilterID"].Value);
            txtFilterName.Text = dgvPostFilters.CurrentRow.Cells["FilterName"].Value.ToString();
            cmbCategory.SelectedValue = dgvPostFilters.CurrentRow.Cells["PostCategoryID"].Value;
            UpdateStatus("編輯模式", editingID);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPostFilters.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvPostFilters.CurrentRow.Cells["PostFilterID"].Value);
            if (MessageBox.Show("確定要刪除嗎？", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        string sql = "DELETE FROM PostFilter WHERE PostFilterID = @ID";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadPostFilters();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("刪除失敗：" + ex.Message);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterName.Text))
            {
                MessageBox.Show("請輸入篩選名稱");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd;

                    if (isEditMode && editingID.HasValue)
                    {
                        cmd = new SqlCommand("UPDATE PostFilter SET FilterName = @Name, PostCategoryID = @CategoryID WHERE PostFilterID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", editingID);
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO PostFilter (FilterName, PostCategoryID) VALUES (@Name, @CategoryID)", conn);
                    }

                    cmd.Parameters.AddWithValue("@Name", txtFilterName.Text.Trim());
                    cmd.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue);
                    cmd.ExecuteNonQuery();
                }
                LoadPostFilters();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadPostFilters();
        }

        private void DgvPostFilters_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPostFilters.CurrentRow != null)
            {
                txtFilterName.Text = dgvPostFilters.CurrentRow.Cells["FilterName"].Value.ToString();
                cmbCategory.SelectedValue = dgvPostFilters.CurrentRow.Cells["PostCategoryID"].Value;
                UpdateStatus("檢視模式", Convert.ToInt32(dgvPostFilters.CurrentRow.Cells["PostFilterID"].Value));
            }
        }

        private void ResetForm()
        {
            txtFilterName.Clear();
            cmbCategory.SelectedIndex = -1;
            editingID = null;
            isEditMode = false;
            UpdateStatus("待機");
        }

        private void UpdateStatus(string mode, int? id = null)
        {
            lblMode.Text = mode;
            //lblID.Text = id.HasValue ? $"ID: {id}" : "";
        }
    }
}