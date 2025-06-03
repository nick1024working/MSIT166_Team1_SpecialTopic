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

                    dgvPurchased.ReadOnly = false;
                    dgvPurchased.Columns["ebookName"].ReadOnly = false;
                    dgvPurchased.Columns["actualprice"].ReadOnly = false;
                    dgvPurchased.Columns["eBookPosition"].ReadOnly = false;

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
            if (dgvPurchased.CurrentRow == null)
            {
                MessageBox.Show("請先選取一本電子書！");
                return;
            }

            try
            {
                // 從目前列抓取 eBookPosition 欄位（存放 PDF 相對路徑）
                string relativePath = dgvPurchased.CurrentRow.Cells["eBookPosition"].Value.ToString();

                // 組合完整路徑（相對於執行資料夾）
                string fullPath = Path.Combine(Application.StartupPath, relativePath);

                if (!File.Exists(fullPath))
                {
                    MessageBox.Show("找不到檔案：\n" + fullPath);
                    return;
                }

                // 使用預設程式開啟 PDF
                System.Diagnostics.Process.Start(fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("開啟書籍失敗：" + ex.Message);
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

        private void dgvPurchased_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 若是點在標題列，忽略
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // 確認是否是點在 eBookPosition 欄
            if (dgvPurchased.Columns[e.ColumnIndex].Name == "eBookPosition")
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "請選擇 PDF 電子書";
                    ofd.Filter = "PDF 檔案 (*.pdf)|*.pdf";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string fullPath = ofd.FileName;

                        // 將絕對路徑轉為相對於專案的路徑（以 /eBookFiles 為根）
                        string basePath = Application.StartupPath;
                        //string relativePath = Path.GetRelativePath(basePath, fullPath);
                        // 使用自訂方法轉換相對路徑
                        string relativePath = ToRelativePath(fullPath, basePath);

                        // 寫入欄位
                        dgvPurchased.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = relativePath;
                    }
                }
            }
        }

        /// <summary>
        /// 將絕對路徑 fullPath 轉換成以 basePath 為根的相對路徑
        /// </summary>
        /// <param name="fullPath">完整檔案路徑，例如 C:\專案\bin\Debug\eBookFiles\mybook.pdf</param>
        /// <param name="basePath">基準資料夾路徑，例如 Application.StartupPath</param>
        /// <returns>回傳相對路徑，例如 eBookFiles\mybook.pdf</returns>
        private string ToRelativePath(string fullPath, string basePath)
        {
            // 將完整路徑轉換為 Uri（統一資源識別碼）
            Uri pathUri = new Uri(fullPath);

            // 為了保證正確處理相對路徑，basePath 必須以斜線結尾，否則 Uri 判斷會錯誤
            if (!basePath.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                basePath += Path.DirectorySeparatorChar;
            }

            // 將 basePath 也轉為 Uri
            Uri baseUri = new Uri(basePath);

            // 使用 Uri 的 MakeRelativeUri 方法產生相對路徑 URI（用 / 分隔）
            Uri relativeUri = baseUri.MakeRelativeUri(pathUri);

            // 將 URI 編碼的結果解碼（例如空格變回空格）
            // 並將 / 改為 Windows 用的 \ 分隔符
            string relativePath = Uri.UnescapeDataString(relativeUri.ToString())
                                        .Replace('/', Path.DirectorySeparatorChar);

            return relativePath;
        }

        private void SavePurchasedBooks()
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                conn.Open(); // 開啟資料庫連線

                foreach (DataGridViewRow row in dgvPurchased.Rows)
                {
                    // 跳過 DataGridView 的空白新增列
                    if (row.IsNewRow) continue;

                    // 取得書名與價格與相對路徑
                    string bookName = row.Cells["ebookName"].Value?.ToString() ?? "";
                    string position = row.Cells["eBookPosition"].Value?.ToString() ?? "";
                    string uidText = row.Cells["UID"].Value?.ToString() ?? "";
                    string priceText = row.Cells["actualprice"].Value?.ToString() ?? "";

                    // 資料基本檢查
                    if (string.IsNullOrWhiteSpace(bookName) || string.IsNullOrWhiteSpace(uidText)) continue;

                    decimal actualPrice = decimal.TryParse(priceText, out decimal ap) ? ap : 0m;
                    Guid uid = Guid.Parse(uidText);  // 使用者 ID 為 uniqueidentifier 型別

                    // 嘗試查出 ebookID
                    long ebookID = GetEbookIDByName(bookName);
                    if (ebookID <= 0) continue; // 找不到對應電子書則略過

                    // 查詢是否已存在
                    string checkSql = @"SELECT COUNT(*) FROM ebookPurchased WHERE UID = @uid AND ebookID = @eid";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@uid", uid);
                        checkCmd.Parameters.AddWithValue("@eid", ebookID);

                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            // 更新
                            string updateSql = @"
                        UPDATE ebookPurchased 
                        SET ebookName = @name, actualprice = @price, eBookPosition = @path 
                        WHERE UID = @uid AND ebookID = @eid";
                            using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@name", bookName);
                                updateCmd.Parameters.AddWithValue("@price", actualPrice);
                                updateCmd.Parameters.AddWithValue("@path", position);
                                updateCmd.Parameters.AddWithValue("@uid", uid);
                                updateCmd.Parameters.AddWithValue("@eid", ebookID);

                                updateCmd.ExecuteNonQuery(); // 執行更新
                            }
                        }
                        else
                        {
                            // 新增
                            string insertSql = @"
                        INSERT INTO ebookPurchased (UID, ebookName, ebookID, actualprice, eBookPosition) 
                        VALUES (@uid, @name, @eid, @price, @path)";
                            using (SqlCommand insertCmd = new SqlCommand(insertSql, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@uid", uid);
                                insertCmd.Parameters.AddWithValue("@name", bookName);
                                insertCmd.Parameters.AddWithValue("@eid", ebookID);
                                insertCmd.Parameters.AddWithValue("@price", actualPrice);
                                insertCmd.Parameters.AddWithValue("@path", position);

                                insertCmd.ExecuteNonQuery(); // 執行新增
                            }
                        }
                    }
                }

                MessageBox.Show("已購買書籍資料已成功儲存！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 根據書名從 eBookMainTable 中查出對應的 ebookID（若找不到回傳 -1）
        /// </summary>
        private long GetEbookIDByName(string bookName)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                string sql = "SELECT ebookID FROM eBookMainTable WHERE ebookName = @name";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", bookName);
                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    // 如果有查到結果，轉型為 long 回傳；否則回傳 -1 表示找不到
                    return result != null ? Convert.ToInt64(result) : -1;
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SavePurchasedBooks(); // 實際儲存變更
            MessageBox.Show("變更已儲存！");
            LoadPurchasedBooks(""); // 重新載入資料，確保畫面更新
        }
    }
}

