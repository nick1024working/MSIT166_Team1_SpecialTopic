using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace SpecialTopic.eBook.eBookCode
{
    public partial class FormPurchasedBooks : Form
    {
        public FormPurchasedBooks()
        {
            InitializeComponent();
        }

        private void FormPurchasedBooks_Load(object sender, EventArgs e)
        {
            LoadPurchasedBooks(""); // 載入資料
        }

        // 此方法根據傳入的關鍵字 keyword，查詢使用者已購買的電子書資料
        private void LoadPurchasedBooks(string keyword)
        {
            // 建立與資料庫的連線
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                // SQL 查詢指令：
                // 如果 keyword 為空字串，就查詢全部資料；
                // 否則，只查詢 ebookName 包含 keyword 的資料（模糊查詢）
                string sql = @"
            SELECT

                UID,          -- 會員ID
                ebookName,         -- 書名
                actualprice,       -- 實際售價
                eBookPosition      -- 檔案相對路徑
            FROM ebookPurchased
            WHERE (@kw = '' OR ebookName LIKE '%' + @kw + '%')";


                //                該條件的作用：
                //這條 WHERE 條件的目的是：
                //✅ 如果沒輸入關鍵字，查全部書籍；
                //✅ 如果有輸入關鍵字，就查找書名中有該關鍵字的書籍。

                //🧠 拆解說明：
                //區塊 說明
                //@kw 這是從 C# 傳入 SQL 的參數，也就是使用者輸入的「搜尋關鍵字」。
                //@kw = ''    如果關鍵字是空字串（""），代表使用者沒有輸入任何搜尋內容。
                //OR 意思是：只要左邊或右邊條件成立，就會選中該筆資料。
                //ebookName LIKE '%' + @kw + '%'  這是 SQL 中的「模糊比對」語法。代表找出書名中有包含關鍵字的所有資料：
                //‣ % 代表任意多個字元
                //‣ LIKE '%keyword%' 代表「包含 keyword」的字串。
                //🔁 綜合邏輯：	「如果 keyword 是空，就查全部」；「如果 keyword 有值，就模糊比對 ebookName」。

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // 將搜尋關鍵字作為參數加入指令中，防止 SQL Injection
                    cmd.Parameters.AddWithValue("@kw", keyword);

                    // 建立 DataTable 接收查詢結果
                    DataTable dt = new DataTable();

                    // 使用 SqlDataAdapter 將資料填入 DataTable
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt); // 執行查詢並填充資料

                    // 將查詢結果綁定到畫面上的 DataGridView 顯示
                    dgvPurchased.DataSource = dt;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            // 呼叫載入資料函式，並套用關鍵字篩選
            LoadPurchasedBooks(keyword);
        }

        private void btnOpenBook_Click(object sender, EventArgs e)
        {
            // 確認是否有選取資料列
            if (dgvPurchased.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選取一本電子書！");
                return;
            }

            try
            {
                // 從選取的列取得相對路徑（eBookPosition 欄位）
                string relativePath = dgvPurchased.SelectedRows[0].Cells["eBookPosition"].Value.ToString();

                // 組合出完整的實體路徑（專案啟動資料夾 + 相對路徑）
                string fullPath = Path.Combine(Application.StartupPath, relativePath);

                // 檢查檔案是否存在
                if (!File.Exists(fullPath))
                {
                    MessageBox.Show($"找不到檔案：\n{fullPath}");
                    return;
                }

                // 開啟 PDF（你可以用系統預設的方式開啟，也可以自己載入 PDF 控制元件）
                System.Diagnostics.Process.Start(fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("開啟書籍時發生錯誤：" + ex.Message);
            }
        }

        private void btnAddPurchased_Click(object sender, EventArgs e)
        {
            // 1. 讀取使用者輸入的 UID（應該是 GUID 格式）
            string uidText = txtUID.Text.Trim(); // 輸入框 txtUID
            if (!Guid.TryParse(uidText, out Guid uid))
            {
                MessageBox.Show("UID 格式錯誤！");
                return;
            }

            // 2. 讀取輸入的書名
            string ebookName = txtEbookName.Text.Trim(); // 書名輸入框 txtEbookName
            if (string.IsNullOrEmpty(ebookName))
            {
                MessageBox.Show("請輸入書名！");
                return;
            }

            // 3. 讀取實際售價
            if (!decimal.TryParse(txtActualPrice.Text.Trim(), out decimal actualPrice))
            {
                MessageBox.Show("請輸入正確的實際售價！");
                return;
            }

            // 4. 查詢 eBookMainTable 中是否存在該書名
            string sqlSelect = @"
        SELECT ebookID, eBookPosition 
        FROM eBookMainTable 
        WHERE ebookName = @name";

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn))
            {
                cmdSelect.Parameters.AddWithValue("@name", ebookName);
                conn.Open();

                SqlDataReader reader = cmdSelect.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("找不到該書名，請確認書名是否正確！");
                    return;
                }

                // 5. 抓出對應的 ebookID 和檔案路徑
                long ebookID = Convert.ToInt64(reader["ebookID"]);
                string eBookPosition = reader["eBookPosition"].ToString();

                reader.Close(); // 關閉讀取器

                // 6. 準備新增 INSERT 指令
                string sqlInsert = @"
            INSERT INTO ebookPurchased (UID, ebookName, ebookID, actualprice, eBookPosition)
            VALUES (@uid, @name, @eid, @price, @pos)";

                using (SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn))
                {
                    // 加入參數
                    cmdInsert.Parameters.AddWithValue("@uid", uid);
                    cmdInsert.Parameters.AddWithValue("@name", ebookName);
                    cmdInsert.Parameters.AddWithValue("@eid", ebookID);
                    cmdInsert.Parameters.AddWithValue("@price", actualPrice);
                    cmdInsert.Parameters.AddWithValue("@pos", eBookPosition);

                    // 7. 執行新增
                    int rows = cmdInsert.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("成功新增！");
                        LoadPurchasedBooks(""); // 如果你有刷新用的方法
                    }
                    else
                    {
                        MessageBox.Show("新增失敗！");
                    }
                }
            }
        }
    }
}
