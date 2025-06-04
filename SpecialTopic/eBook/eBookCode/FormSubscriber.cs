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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpecialTopic.eBook.eBookCode
{
    public partial class FormSubscriber : Form
    {
        // 在表單類別裡宣告（全域變數）
        private Dictionary<int, string> subscribeStatusDict = new Dictionary<int, string>()
{
    { 0, "無訂閱" },
    { 1, "月訂閱" },
    { 2, "季訂閱" },
    { 3, "年訂閱" },
    { 4, "學生專案" },
    { 5, "企業訂閱" },
    { 6, "贈送試用" },
    { 7, "自動續訂中" },
    { 8, "已取消續訂" },
    { 9, "到期未續" },
    { 10, "封鎖帳號" },
    { 11, "退款處理中" },
    { 12, "訂閱失敗" }
};

        public FormSubscriber()
        {
            InitializeComponent();
        }

        private void FormSubscriber_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                // 查詢訂閱資料，同時連接會員名稱
                string sql = @"
            SELECT s.UID, u.Name AS UserName, s.subscribeStatus, s.dueTime, s.lastPayTime, s.nextPayTime
            FROM Subscriber s
            LEFT JOIN Users u ON s.UID = u.UID";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt); // 填入資料表
                dgvSubscribers.DataSource = dt; // 綁定資料來源到畫面
            }
            InitComboBoxes();      // 初始化 UID ComboBox
            LoadSubscribers();     // 載入訂閱者資料
        }


        private void InitSubscribeStatusComboBox()
        {
            comboStatus.DataSource = new BindingSource(subscribeStatusDict, null);
            comboStatus.DisplayMember = "Value"; // 顯示中文
            comboStatus.ValueMember = "Key";     // 實際存的值
        }


        // 初始化 ComboBox
        private void InitComboBoxes()
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                // 取得 Users 中的 UID 與名稱
                string sql = "SELECT UID, Name FROM Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboUID.DataSource = dt; // 設定資料來源
                comboUID.ValueMember = "UID"; // 實際值為 UID
                comboUID.DisplayMember = "Name"; // 顯示名稱為使用者姓名
            }

            // 訂閱狀態的代碼與對應文字說明
            comboStatus.DataSource = Enumerable.Range(0, 13)
                .Select(i => new { Value = i, Text = $"{i} - {GetStatusText(i)}" })
                .ToList();
            comboStatus.ValueMember = "Value";
            comboStatus.DisplayMember = "Text";
        }

        //private void LoadSubscribers()
        //{
        //    // 1. 清空現有資料，避免重複加入
        //    if (dgvSubscribers.Rows.Count > 0)
        //    {
        //        //dgvSubscribers.Rows.Clear();
        //        dgvSubscribers.DataSource = null;
        //    }

        //    // 2. 建立連線字串（這裡你應該有設定好的 connStr）
        //    using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
        //    {
        //        conn.Open();

        //        // 3. 查詢 Subscriber 資料（含 JOIN 會員名稱）
        //        string sql = @"
        //    SELECT s.UID, u.Name, s.subscribeStatus, s.dueTime, s.lastPayTime, s.nextPayTime
        //    FROM Subscriber s
        //    JOIN Users u ON s.UID = u.UID";



        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        // 4. 將每筆資料加入 DataGridView
        //        while (reader.Read())
        //        {
        //            int rowIndex = dgvSubscribers.Rows.Add();
        //            dgvSubscribers.Rows[rowIndex].Cells["UID"].Value = reader["UID"];
        //            dgvSubscribers.Rows[rowIndex].Cells["Name"].Value = reader["Name"];
        //            dgvSubscribers.Rows[rowIndex].Cells["subscribeStatus"].Value = reader["subscribeStatus"];
        //            dgvSubscribers.Rows[rowIndex].Cells["dueTime"].Value = reader["dueTime"];
        //            dgvSubscribers.Rows[rowIndex].Cells["lastPayTime"].Value = reader["lastPayTime"];
        //            dgvSubscribers.Rows[rowIndex].Cells["nextPayTime"].Value = reader["nextPayTime"];
        //        }

        //        reader.Close();
        //        conn.Close();
        //    }
        //}


        private void LoadSubscribers()
        {
            // 1. 清空現有資料（綁定新資料前）
            dgvSubscribers.DataSource = null;

            // 2. 建立 SQL 連線
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                conn.Open();

                // 3. SQL：查詢 Subscriber + 會員名稱
                string sql = @"
            SELECT 
                s.UID, 
                u.Name, 
                s.subscribeStatus, 
                s.dueTime, 
                s.lastPayTime, 
                s.nextPayTime
            FROM Subscriber s
            JOIN Users u ON s.UID = u.UID";

                // 4. 使用 DataAdapter 載入資料到 DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // 5. 將訂閱狀態轉成中文顯示（選配）
                dt.Columns.Add("訂閱狀態名稱", typeof(string)); // 新增欄位顯示中文名稱

                Dictionary<int, string> statusDict = new Dictionary<int, string>()
        {
            { 0, "無訂閱" }, { 1, "試訂閱限連載" }, { 2, "試訂閱限單" }, { 3, "試訂閱不限" },
            { 4, "周訂限連載" }, { 5, "周訂限單本" }, { 6, "周訂不限" }, { 7, "月訂連載" },
            { 8, "月訂限單" }, { 9, "月訂不限" }, { 10, "年訂限連載" }, { 11, "年訂限單" }, { 12, "年訂不限" }
        };

                foreach (DataRow row in dt.Rows)
                {
                    int statusCode = Convert.ToInt32(row["subscribeStatus"]);
                    row["訂閱狀態名稱"] = statusDict.ContainsKey(statusCode) ? statusDict[statusCode] : "未知狀態";
                }

                // 6. 綁定顯示
                dgvSubscribers.DataSource = dt;

                // 7. 選配：美化欄位顯示
                dgvSubscribers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                conn.Close();
            }

            if (dgvSubscribers.Columns.Contains("UID")) dgvSubscribers.Columns["UID"].HeaderText = "會員代號";
            if (dgvSubscribers.Columns.Contains("Name")) dgvSubscribers.Columns["Name"].HeaderText = "會員名稱";
            if (dgvSubscribers.Columns.Contains("subscribeStatus")) dgvSubscribers.Columns["subscribeStatus"].HeaderText = "訂閱代碼";
            if (dgvSubscribers.Columns.Contains("dueTime")) dgvSubscribers.Columns["dueTime"].HeaderText = "到期時間";
            if (dgvSubscribers.Columns.Contains("lastPayTime")) dgvSubscribers.Columns["lastPayTime"].HeaderText = "上次繳費";
            if (dgvSubscribers.Columns.Contains("nextPayTime")) dgvSubscribers.Columns["nextPayTime"].HeaderText = "下次繳費";
            if (dgvSubscribers.Columns.Contains("訂閱狀態名稱")) dgvSubscribers.Columns["訂閱狀態名稱"].HeaderText = "訂閱狀態";

        }


        // 對訂閱狀態代碼做文字轉換
        private string GetStatusText(int code)
        {
            switch (code)
            {
                case 0: return "非訂閱";
                case 1: return "試訂閱限連載";
                case 2: return "試訂閱限單本";
                case 3: return "試訂閱不限";
                case 4: return "週訂閱限連載";
                case 5: return "週訂閱限單本";
                case 6: return "週訂閱不限";
                case 7: return "月訂閱限連載";
                case 8: return "月訂閱限單本";
                case 9: return "月訂閱不限";
                case 10: return "年訂閱限連載";
                case 11: return "年訂閱限單本";
                case 12: return "年訂閱不限";
                default: return "未知狀態";  // 這行處理未預期的數值
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid uid = (Guid)comboUID.SelectedValue; // 取得 UID
            int status = (int)comboStatus.SelectedValue; // 取得訂閱狀態
            DateTime? due = dtpDueTime.Checked ? dtpDueTime.Value : (DateTime?)null; // 判斷是否選擇日期
            DateTime? last = dtpLastPayTime.Checked ? dtpLastPayTime.Value : (DateTime?)null;
            DateTime? next = dtpNextPayTime.Checked ? dtpNextPayTime.Value : (DateTime?)null;

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                string sql = @"
            INSERT INTO Subscriber (UID, subscribeStatus, dueTime, lastPayTime, nextPayTime)
            VALUES (@uid, @status, @due, @last, @next)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@due", (object)due ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@last", (object)last ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@next", (object)next ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadSubscribers(); // 重新載入畫面資料
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSubscribers.CurrentRow == null) return;
            Guid uid = (Guid)comboUID.SelectedValue;
            int status = (int)comboStatus.SelectedValue;
            DateTime? due = dtpDueTime.Checked ? dtpDueTime.Value : (DateTime?)null;
            DateTime? last = dtpLastPayTime.Checked ? dtpLastPayTime.Value : (DateTime?)null;
            DateTime? next = dtpNextPayTime.Checked ? dtpNextPayTime.Value : (DateTime?)null;

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                string sql = @"
            UPDATE Subscriber
            SET subscribeStatus = @status,
                dueTime = @due,
                lastPayTime = @last,
                nextPayTime = @next
            WHERE UID = @uid";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@due", (object)due ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@last", (object)last ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@next", (object)next ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadSubscribers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubscribers.CurrentRow == null) return;
            Guid uid = (Guid)dgvSubscribers.CurrentRow.Cells["UID"].Value;

            DialogResult result = MessageBox.Show("確定要刪除這筆訂閱資料嗎？", "確認", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                string sql = "DELETE FROM Subscriber WHERE UID = @uid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", uid);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadSubscribers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                string sql = @"
            SELECT s.UID, u.Name AS UserName, s.subscribeStatus, s.dueTime, s.lastPayTime, s.nextPayTime
            FROM Subscriber s
            LEFT JOIN Users u ON s.UID = u.UID
            WHERE u.Name LIKE '%' + @kw + '%'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", keyword);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSubscribers.DataSource = dt;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";        // 🔄 清空搜尋
            LoadSubscribers(); // ✅ 重新載入訂閱者資料
        }
    }
}
