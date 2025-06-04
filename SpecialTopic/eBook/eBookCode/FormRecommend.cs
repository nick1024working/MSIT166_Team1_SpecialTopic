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

namespace SpecialTopic.eBook.eBookCode
{
    public partial class FormRecommend : Form
    {
        public FormRecommend()
        {
            InitializeComponent();
            InitEbookCombo();
            LoadRecommendations();
            
        }

        private void FormRecommend_Load(object sender, EventArgs e)
        {

        }

        // 載入推薦資料到 DataGridView
        private void LoadRecommendations()
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                string sql = @"
SELECT r.recommendWID, r.recommendTypeM, r.recommendTypeS, r.ebookID, e.ebookName
FROM ebookRecommend r
JOIN eBookMainTable e ON r.ebookID = e.ebookID";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRecommend.DataSource = dt;

                // 設定欄位標頭（繁體中文）
                dgvRecommend.Columns["recommendWID"].HeaderText = "推薦編號";
                dgvRecommend.Columns["recommendTypeM"].HeaderText = "主推薦類別";
                dgvRecommend.Columns["recommendTypeS"].HeaderText = "次推薦類別";
                dgvRecommend.Columns["ebookID"].HeaderText = "電子書ID";
                dgvRecommend.Columns["ebookName"].HeaderText = "書名";

                dgvRecommend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        // 初始化下拉選單（書名）
        private void InitEbookCombo()
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand("SELECT ebookID, ebookName FROM eBookMainTable", conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, long> bookDict = new Dictionary<string, long>();

                while (reader.Read())
                {
                    long id = reader.GetInt64(0);
                    string name = reader.GetString(1);
                    string display = $"{name} ({id})";
                    bookDict[display] = id;
                }

                comboBook.DataSource = new BindingSource(bookDict, null);
                comboBook.DisplayMember = "Key";
                comboBook.ValueMember = "Value";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string typeM = txtTypeM.Text.Trim();
            string typeS = txtTypeS.Text.Trim();
            if (comboBook.SelectedValue == null)
            {
                MessageBox.Show("請選擇電子書！");
                return;
            }
            long ebookID = (long)comboBook.SelectedValue;

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand(@"
INSERT INTO ebookRecommend (recommendTypeM, recommendTypeS, ebookID)
VALUES (@m, @s, @id)", conn))
            {
                cmd.Parameters.AddWithValue("@m", typeM);
                cmd.Parameters.AddWithValue("@s", string.IsNullOrEmpty(typeS) ? (object)DBNull.Value : typeS);
                cmd.Parameters.AddWithValue("@id", ebookID);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("新增成功！");
                LoadRecommendations();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRecommend.CurrentRow == null)
            {
                MessageBox.Show("請先選擇一筆資料");
                return;
            }
            long id = Convert.ToInt64(dgvRecommend.CurrentRow.Cells["recommendWID"].Value);

            DialogResult result = MessageBox.Show("確定要刪除這筆推薦資料嗎？", "確認", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM ebookRecommend WHERE recommendWID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("刪除成功！");
                LoadRecommendations();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //            string kw = txtSearch.Text.Trim();
            //            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            //            using (SqlCommand cmd = new SqlCommand(@"
            //SELECT r.recommendWID, r.recommendTypeM, r.recommendTypeS, r.ebookID, e.ebookName
            //FROM ebookRecommend r
            //JOIN eBookMainTable e ON r.ebookID = e.ebookID
            //WHERE r.recommendTypeM LIKE @kw OR e.ebookName LIKE @kw", conn))
            //            {
            //                cmd.Parameters.AddWithValue("@kw", "%" + kw + "%");
            //                SqlDataAdapter da = new SqlDataAdapter(cmd);
            //                DataTable dt = new DataTable();
            //                da.Fill(dt);
            //                dgvRecommend.DataSource = dt;
            //            }

            string kw = txtSearch.Text.Trim(); // 使用者輸入的關鍵字

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand(@"
SELECT r.recommendWID, r.recommendTypeM, r.recommendTypeS, r.ebookID, e.ebookName
FROM ebookRecommend r
JOIN eBookMainTable e ON r.ebookID = e.ebookID
WHERE r.recommendTypeM LIKE @kw 
   OR r.recommendTypeS LIKE @kw 
   OR e.ebookName LIKE @kw", conn)) // 👈 三個欄位都模糊搜尋
            {
                // 加入模糊搜尋參數：%關鍵字%
                cmd.Parameters.AddWithValue("@kw", "%" + kw + "%");

                // 執行查詢並填入資料表
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // 顯示到 DataGridView
                dgvRecommend.DataSource = dt;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadRecommendations();
        }
    }
}
