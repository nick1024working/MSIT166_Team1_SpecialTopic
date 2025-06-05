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
using System.Xml.Linq;

namespace SpecialTopic
{
    public partial class FundControl : UserControl
    {
        string connectionString = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True;";
        public FundControl()
        {
            InitializeComponent();
            LoadProjects();
            LoadPlans();
            LoadCategories();
            LoadProjectsToComboBox();
            LoadCategoryToComboBox();
            LoadCategoriesToComboBox();
            LoadProjectsToComboBoxForSearch();
            LoadProjectsToComboBoxbyImage();
            LoadImages();
            LoadProjectToSearchComboBox();
        }

        //======================募資分類管理======================
        private void donateCategoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.donateCategoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);

        }
        // 讀取
        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT donateCategories_id, name FROM donateCategories";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable CategoriesDt = new DataTable();
                da.Fill(CategoriesDt);
                dataGridView1.DataSource = CategoriesDt;
            }
        }

        // 新增
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入類別名稱！");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO donateCategories (name) VALUES (@name)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("新增成功！");
                LoadCategories();
                LoadCategoryToComboBox();   // 重新載入下拉式選單 <== 關鍵
                LoadCategoriesToComboBox();
            }
        }

        // 更新
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請選擇要更新的資料！");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE donateCategories SET name = @name WHERE donateCategories_id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("更新成功！");
                LoadCategories();
                LoadCategoryToComboBox();
                LoadCategoriesToComboBox();
            }
        }

        // 刪除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("請選擇要刪除的資料！");
                return;
            }

            var confirm = MessageBox.Show("確定要刪除這筆資料嗎？", "確認刪除", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM donateCategories WHERE donateCategories_id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("刪除成功！");
                LoadCategories();
                LoadCategoryToComboBox();
                LoadCategoriesToComboBox();
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        // DataGridView 點選帶入資料
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["donateCategories_id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
            }
        }

        //======================募資項目管理======================
        private void LoadProjects()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM donateProjects";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable ProjectDt = new DataTable();
                da.Fill(ProjectDt);
                dataGridView2.DataSource = ProjectDt;
                if (dataGridView2.Columns.Contains("donateProject_id"))
                {
                    dataGridView2.Columns["donateProject_id"].Visible = false;
                }
            }
        }
        private void PjCreate_Click(object sender, EventArgs e)
        {
            int categoryId;
            decimal targetAmount, currentAmount;

            // 嘗試轉換金額
            if (!decimal.TryParse(txtTargetAmount.Text, out targetAmount) ||
                !decimal.TryParse(txtCurrentAmount.Text, out currentAmount))
            {
                MessageBox.Show("請輸入正確的金額！");
                return;
            }

            try
            {
                categoryId = Convert.ToInt32(dnCtComboBoxforPj.SelectedValue);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO donateProjects 
                    (donateCategories_id, title, description, target_amount, current_amount, start_date, end_date)
                    VALUES (@categoryId, @title, @description, @targetAmount, @currentAmount, @startDate, @endDate)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@targetAmount", targetAmount);
                    cmd.Parameters.AddWithValue("@currentAmount", currentAmount);
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("新增成功！");
                    LoadProjects();            // 重新載入 DataGridView
                    LoadProjectsToComboBox();  // 如果其他頁面要更新 ComboBox
                    ReloadProjectComboBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗：" + ex.Message);
            }
        }

        private void PjUpdate_Click(object sender, EventArgs e)
        {
            int projectId, categoryId;
            decimal targetAmount, currentAmount;

            if (!int.TryParse(txtProjectId.Text, out projectId) ||
                !int.TryParse(dnCtComboBoxforPj.Text, out categoryId) ||
                !decimal.TryParse(txtTargetAmount.Text, out targetAmount) ||
                !decimal.TryParse(txtCurrentAmount.Text, out currentAmount))
            {
                MessageBox.Show("請選擇要修改的資料並輸入正確數字！");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE donateProjects SET 
                       donateCategories_id = @categoryId,
                       title = @title,
                       description = @description,
                       target_amount = @targetAmount,
                       current_amount = @currentAmount,
                       start_date = @startDate,
                       end_date = @endDate
                       WHERE donateProject_id = @projectId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@targetAmount", targetAmount);
                cmd.Parameters.AddWithValue("@currentAmount", currentAmount);
                cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value);
                cmd.Parameters.AddWithValue("@projectId", projectId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("更新成功！");
                LoadProjects();
                LoadProjectsToComboBox();
                ReloadProjectComboBoxes();
            }
        }

        private void PjDelete_Click(object sender, EventArgs e)
        {
            int projectId;
            if (!int.TryParse(txtProjectId.Text, out projectId))
            {
                MessageBox.Show("請選擇要刪除的資料！");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM donateProjects WHERE donateProject_id = @projectId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@projectId", projectId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("刪除成功！");
                LoadProjects();
                LoadProjectsToComboBox();
                ReloadProjectComboBoxes();
            }
        }
        private void LoadCategoriesToComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT donateCategories_id, name FROM donateCategories";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dnCtComboBoxforPj.DataSource = dt;
                dnCtComboBoxforPj.DisplayMember = "name";  // 顯示名稱
                dnCtComboBoxforPj.ValueMember = "donateCategories_id"; // 實際使用的值
            }
        }
        private void LoadCategoryToComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT DISTINCT donateCategories_id, name FROM donateCategories";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxCategory.DataSource = dt;
                comboBoxCategory.DisplayMember = "name";
                comboBoxCategory.ValueMember = "donateCategories_id";
            }
        }
        private void CategoriesSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇分類！");
                return;
            }

            int categoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM donateProjects WHERE donateCategories_id = @categoryId";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@categoryId", categoryId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txtProjectId.Text = row.Cells["donateProject_id"].Value.ToString();
                dnCtComboBoxforPj.Text = row.Cells["donateCategories_id"].Value.ToString();
                txtTitle.Text = row.Cells["title"].Value.ToString();
                txtDescription.Text = row.Cells["description"].Value.ToString();
                txtTargetAmount.Text = row.Cells["target_amount"].Value.ToString();
                txtCurrentAmount.Text = row.Cells["current_amount"].Value.ToString();
                dtpStartDate.Value = Convert.ToDateTime(row.Cells["start_date"].Value);
                dtpEndDate.Value = Convert.ToDateTime(row.Cells["end_date"].Value);
            }
        }
        private void btnProject_Click(object sender, EventArgs e)
        {
            LoadProjects();
        }
        //======================募資方案管理======================
        private void LoadProjectsToComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT donateProject_id, title FROM donateProjects";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxProject.DataSource = dt;
                comboBoxProject.DisplayMember = "title";
                comboBoxProject.ValueMember = "donateProject_id";
            }
        }
        private void PlCreate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO donatePlans (donateProject_id, title, price, description)
                       VALUES (@projectId, @title, @price, @description)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@projectId", comboBoxProject.SelectedValue);
                cmd.Parameters.AddWithValue("@title", titleTextBox.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("新增成功！");
                LoadPlans();
                LoadProjectsToComboBoxForSearch();
            }
        }

        private void PlUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlanId.Text))
            {
                MessageBox.Show("請選擇要更新的資料");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE donatePlans
                       SET donateProject_id = @projectId, title = @title, price = @price, description = @description
                       WHERE donatePlan_id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@projectId", (int)comboBoxProject.SelectedValue);
                cmd.Parameters.AddWithValue("@title", titleTextBox.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtPlanId.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("更新成功！");
                LoadPlans();
                LoadProjectsToComboBoxForSearch();
            }
        }

        private void PlDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlanId.Text))
            {
                MessageBox.Show("請選擇要刪除的資料");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM donatePlans WHERE donatePlan_id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtPlanId.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("刪除成功！");
                LoadPlans();
                LoadProjectsToComboBoxForSearch();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPlanId.Text = dataGridView3.Rows[e.RowIndex].Cells["donatePlan_id"].Value.ToString();
                titleTextBox.Text = dataGridView3.Rows[e.RowIndex].Cells["title"].Value.ToString();
                txtPrice.Text = dataGridView3.Rows[e.RowIndex].Cells["price"].Value.ToString();
                descriptionTextBox.Text = dataGridView3.Rows[e.RowIndex].Cells["description"].Value.ToString();

                // 如果 comboBox 是以文字顯示項目名稱
                int projectId = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["donateProject_id"].Value);
                comboBoxProject.SelectedValue = projectId;
            }
        }
        private void LoadPlans()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM donatePlans ORDER BY donateProject_id";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView3.AutoGenerateColumns = true; // ✅ 確保自動產生欄位
                dataGridView3.DataSource = dt;
                if (dataGridView3.Columns.Contains("donatePlan_id"))
                {
                    dataGridView3.Columns["donatePlan_id"].Visible = false;
                }
            }

            // 避免重複綁定 CellClick 事件（這應該只需綁定一次）
            dataGridView3.CellClick -= dataGridView3_CellContentClick;
            dataGridView3.CellClick += dataGridView3_CellContentClick;
        }
        private void btnPlans_Click(object sender, EventArgs e)
        {
            LoadPlans();
        }

        private void LoadProjectsToComboBoxForSearch()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT donateProject_id, title FROM donateProjects";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CBSearchProject.DataSource = dt;
                CBSearchProject.DisplayMember = "title";
                CBSearchProject.ValueMember = "donateProject_id";
            }
        }
        private void btnSearchByProject_Click(object sender, EventArgs e)
        {
            if (CBSearchProject.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇募資項目！");
                return;
            }

            int projectId = Convert.ToInt32(CBSearchProject.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM donatePlans WHERE donateProject_id = @projectId";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@projectId", projectId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView5.DataSource = dt;
            }
        }



        //======================募資圖片管理======================
        private void LoadProjectsToComboBoxbyImage()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT donateProject_id, title FROM donateProjects";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                donateProject_idComboBox.DataSource = dt;
                donateProject_idComboBox.DisplayMember = "title";
                donateProject_idComboBox.ValueMember = "donateProject_id";
            }
        }
        private void LoadImages()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM donateImages";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView6.DataSource = dt;
                dataGridView6.CellClick += dataGridView6_CellContentClick;
                //linkLabel1.LinkClicked += linkLabel1_LinkClicked;
                dataGridView6.Columns["donateProject_id"].Visible = false;
            }
        }
        private void btnCreateImage_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO donateImages (donateProject_id, donateImage_url, is_main)
                       VALUES (@projectId, @url, @isMain)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@projectId", donateProject_idComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@url", donateImage_urlTextBox.Text);
                cmd.Parameters.AddWithValue("@isMain", is_mainCheckBox.Checked);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("新增成功！");
                LoadImages();
            }
        }
        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(image_idTextBox.Text)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE donateImages 
               SET donateProject_id = @projectId, donateImage_url = @url, is_main = @isMain
               WHERE image_id = @imageId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@projectId", donateProject_idComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@url", donateImage_urlTextBox.Text);
                cmd.Parameters.AddWithValue("@isMain", is_mainCheckBox.Checked);
                cmd.Parameters.AddWithValue("@imageId", int.Parse(image_idTextBox.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("更新成功！");
                LoadImages();
            }
        }
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(image_idTextBox.Text)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM donateImages WHERE image_id = @imageId;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imageId", int.Parse(image_idTextBox.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("刪除成功！");
                LoadImages();
            }
        }
        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView6.Rows[e.RowIndex];
                image_idTextBox.Text = row.Cells["donateImage_id"].Value.ToString();
                donateProject_idComboBox.SelectedValue = row.Cells["donateProject_id"].Value;
                donateImage_urlTextBox.Text = row.Cells["donateImage_url"].Value.ToString();
                is_mainCheckBox.Checked = (bool)row.Cells["is_main"].Value;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "選擇圖片";
            openFileDialog.Filter = "圖片檔 (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                donateImage_urlTextBox.Text = openFileDialog.FileName;
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }
        private void LoadProjectToSearchComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT donateProject_id, title FROM donateProjects";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                donateProject_idComboBox1.DataSource = dt;
                donateProject_idComboBox1.DisplayMember = "title";
                donateProject_idComboBox1.ValueMember = "donateProject_id";
            }
        }
        private void btnSearchByProjectImg_Click(object sender, EventArgs e)
        {
            if (donateProject_idComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇一個募款項目！");
                return;
            }

            int projectId = Convert.ToInt32(donateProject_idComboBox1.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM donateImages WHERE donateProject_id = @projectId";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@projectId", projectId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView7.DataSource = dt;
            }
        }
        public void ReloadProjectComboBoxes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT donateProject_id, title FROM donateProjects";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                donateProject_idComboBox.DataSource = dt.Copy();
                donateProject_idComboBox.DisplayMember = "title";
                donateProject_idComboBox.ValueMember = "donateProject_id";

                donateProject_idComboBox1.DataSource = dt.Copy();
                donateProject_idComboBox1.DisplayMember = "title";
                donateProject_idComboBox1.ValueMember = "donateProject_id";
            }
        }
        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string imageUrl = dataGridView6.Rows[e.RowIndex].Cells["donateImage_url"].Value.ToString();

                try
                {
                    pictureBox2.Load(imageUrl); // 可載入 URL 或檔案路徑
                }
                catch (Exception ex)
                {
                    MessageBox.Show("載入圖片失敗：" + ex.Message);
                    pictureBox2.Image = null;
                }
            }
        }

        //======================切換頁面即時更新ComboBox======================
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1) // 募資分類頁
            {
                LoadCategories(); // 重新載入分類
            }
            else if (tabControl1.SelectedTab == tabPage2) // 募資項目頁
            {
                LoadProjects(); // 重新載入募資項目資料表
                LoadCategoryToComboBox(); // 重新載入分類的下拉選單
            }
            else if (tabControl1.SelectedTab == tabPage3) // 募資方案頁
            {
                LoadPlans(); // 重新載入方案資料表
                LoadProjectsToComboBox(); // 重新載入募資項目下拉選單
                LoadProjectsToComboBoxForSearch();
            }
            else if (tabControl1.SelectedTab == tabPage4) // 募資項目頁
            {
                LoadProjects(); // 重新載入募資項目資料表
                LoadProjectToSearchComboBox();
            }
        }


    }
}
