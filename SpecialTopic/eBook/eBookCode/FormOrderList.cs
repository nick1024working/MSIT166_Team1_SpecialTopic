using OfficeOpenXml.Style;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpecialTopic.eBook.eBookCode
{
    public partial class FormOrderList : Form
    {
        public FormOrderList()
        {
            InitializeComponent();
        }



        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;
            // 避免選到空白新增列或無效資料
            var cellValue = dgvOrders.CurrentRow.Cells["OrderID"].Value;
            if (cellValue == null || cellValue == DBNull.Value)
                return;

            // 安全轉型 OrderID 後載入訂單明細
            long orderId = Convert.ToInt64(cellValue);
            LoadOrderDetails(orderId);

            //long orderId = Convert.ToInt64(dgvOrders.CurrentRow.Cells["OrderID"].Value);
            //LoadOrderDetails(orderId); // 如果還沒寫這函式可以先註解起來
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 點關閉按鈕就關掉視窗
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            LoadOrders(); // 載入訂單資料
            LoadUserUIDs(); // 載入會員清單至 cmbUsers
        }

        private void LoadOrders()
        {
            string connStr = GlobalConfig.ConnStr; // 改成你實際的連線字串變數

            //    string sql = @"
            //SELECT 
            //    m.OrderID,
            //    m.UID,
            //    m.OrderDateTime,
            //    s.StatusName,
            //    m.TotalAmount,
            //    m.CurrencyCode
            //FROM eBookOrderMain m
            //JOIN OrderStatuses s ON m.OrderStatusID = s.OrderStatusID
            //ORDER BY m.OrderDateTime DESC";

            //            SELECT
            //    m.OrderID,                  --訂單編號（主鍵）
            //    m.UID,                      --該訂單屬於哪個會員的唯一識別碼
            //    m.OrderDateTime,           --下單的時間（建立時間）
            //    s.StatusName,              --從訂單狀態表 JOIN 出來的狀態名稱（如「已付款」、「待出貨」等）
            //    m.TotalAmount,             --訂單總金額
            //    m.CurrencyCode-- 幣別（例如 TWD, USD）
            //FROM eBookOrderMain m
            //JOIN OrderStatuses s ON m.OrderStatusID = s.OrderStatusID
            //-- ↑ JOIN：將訂單狀態 ID 對應到狀態名稱，轉換數字為文字
            //ORDER BY m.OrderDateTime DESC
            //-- ↓ 根據下單時間遞減排序（新訂單排最上面）

            // 2. 撰寫 SQL 查詢語句：JOIN OrderStatuses 與 [Users]，顯示姓名與計算實付金額
            string sql = @"
            SELECT 
                m.OrderID,
                u.Name AS UserName,                        -- 顯示會員名稱
                m.OrderDateTime,
                s.StatusName,
                m.TotalAmount,
                m.TotalDiscountAmount,
                m.CurrencyCode
            FROM eBookOrderMain m
            JOIN OrderStatuses s ON m.OrderStatusID = s.OrderStatusID
            LEFT JOIN [Users] u ON m.UID = u.UID
            ORDER BY m.OrderDateTime DESC, m.OrderID DESC
        ";

            //            SELECT
            //    m.OrderID,                                           --訂單編號，從主檔 eBookOrderMain 取出
            //    u.Name AS UserName,                                  --會員名稱，從 User 資料表中 UID 對應取得
            //    m.OrderDateTime,                                     --訂單建立時間
            //    s.StatusName,                                        --訂單狀態名稱，例如：待付款、已完成等
            //    m.TotalAmount,                                       --訂單總金額（原始價格合計）
            //    m.TotalDiscountAmount,                               --訂單總折扣金額（可為 NULL）
            //    (m.TotalAmount - ISNULL(m.TotalDiscountAmount, 0)) AS ActualPaid,
            //                                                         --計算實付金額：總金額 - 折扣金額（若為 NULL 視為 0）
            //    m.CurrencyCode-- 幣別代碼，例如 'TWD', 'USD'
            //FROM
            //    eBookOrderMain m-- 從訂單主檔取資料，並取別名 m
            //JOIN
            //    OrderStatuses s ON m.OrderStatusID = s.OrderStatusID-- 關聯訂單狀態表，取得對應的狀態名稱
            //LEFT JOIN
            //    [Users] u ON m.UID = u.UID-- 左連接 Users 表，取得 UID 對應的會員名稱（若無對應也保留主表資料）
            //ORDER BY
            //    m.OrderDateTime DESC, m.OrderID DESC                                  --按下單時間由新到舊排序，補上第二排序根據OrderID



            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrders.DataSource = dt;
            }
        }

        //private void LoadOrderDetails(long orderId)
        //{
        //    string connStr = GlobalConfig.ConnStr;

        //    string sql = @"
        //SELECT 
        //    od.OrderItemID,
        //    od.ItemNameSnapshot,
        //    od.Quantity,
        //    od.UnitPriceAtPurchase,
        //    od.DiscountAmount,
        //    (od.Quantity * od.UnitPriceAtPurchase - ISNULL(od.DiscountAmount, 0)) AS LineTotal
        //FROM eBookOrderDetail od
        //WHERE od.OrderID = @orderId";

        //    //            SELECT
        //    //    od.OrderItemID,                    --明細編號（主鍵）
        //    //    od.ItemNameSnapshot,              --商品名稱快照（當時購買時的書名）
        //    //    od.Quantity,                      --數量，通常為 1（電子書）
        //    //    od.UnitPriceAtPurchase,           --單價（當時購買價格）
        //    //    od.DiscountAmount,                --折扣金額（可為 NULL）
        //    //    (od.Quantity * od.UnitPriceAtPurchase - ISNULL(od.DiscountAmount, 0)) AS LineTotal
        //    //    -- ↑ 計算明細小計（數量 × 單價 - 折扣），ISNULL 可避免 NULL 導致運算錯誤
        //    //FROM eBookOrderDetail od
        //    //WHERE od.OrderID = @orderId
        //    //-- ↑ 根據傳入的 OrderID（你在程式中用參數傳入）查出該筆訂單的所有商品


        //    using (SqlConnection conn = new SqlConnection(connStr))
        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //    {
        //        cmd.Parameters.AddWithValue("@orderId", orderId);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dgvOrderDetails.DataSource = dt;
        //    }
        //}

        private void LoadOrderDetails(long orderId)
        {
            // 建立 SQL Server 連線物件，連線字串由 GlobalConfig 管理
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                // 建立 SQL 查詢：撈取該訂單的所有明細項目
                string sql = @"
            SELECT 
                od.OrderItemID AS [明細編號],                           -- 訂單明細識別碼
                od.ItemNameSnapshot AS [商品名稱],                      -- 購買當下的商品名稱快照
                od.Quantity AS [數量],                                   -- 購買數量
                od.UnitPriceAtPurchase AS [單價],                        -- 當時購買價格
                od.DiscountAmount AS [折扣],                             -- 折扣金額（可能為 NULL）
                (od.Quantity * od.UnitPriceAtPurchase - ISNULL(od.DiscountAmount, 0)) AS [小計]
                                                                    -- 計算每筆明細的小計（數量×單價-折扣）
            FROM eBookOrderDetail od
            WHERE od.OrderID = @orderId";                             // 根據訂單編號查詢

                // 使用 SqlCommand 和 DataAdapter 執行查詢
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // 設定查詢參數 @orderId
                    cmd.Parameters.AddWithValue("@orderId", orderId);

                    // 用 DataTable 存查詢結果
                    DataTable dt = new DataTable();
                    da.Fill(dt); // 執行查詢並填入資料表

                    // 資料綁定至 DataGridView 顯示
                    dgvOrderDetails.DataSource = dt;

                    // ====== 加總所有小計欄位以顯示總實付金額 ======
                    decimal total = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        // 嘗試從「小計」欄讀出金額，若不是空值則累加
                        if (row["小計"] != DBNull.Value)
                        {
                            total += Convert.ToDecimal(row["小計"]);
                        }
                    }

                    // 顯示總金額至畫面上的 Label
                    //lblTotalDetail.Text = $"本訂單實付總金額：{total:C}";  // :C 格式為貨幣（會顯示 $）
                    //                                              // 在 LoadOrderDetails() 最後加入比對邏輯
                    //                                              // 確認目前有選取行
                    //if (dgvOrders.CurrentRow != null)
                    //{
                    //    // 從當前選取列中抓出 TotalAmount 欄位值，轉為 decimal
                    //    decimal orderTotalAmount = Convert.ToDecimal(dgvOrders.CurrentRow.Cells["TotalAmount"].Value);

                    //    // 與明細加總金額 total 做比對
                    //    if (total != orderTotalAmount)
                    //    {
                    //        lblTotalDetail.Text += " ⚠️ 明細金額與訂單總額不符";
                    //        lblTotalDetail.ForeColor = Color.Red;
                    //    }
                    //    else
                    //    {
                    //        lblTotalDetail.ForeColor = Color.Black;
                    //    }
                    //}

                    lblTotalDetail.Text = $"本訂單實付總金額：{total:C}";

                    if (dgvOrders.CurrentRow != null)
                    {
                        decimal orderActualPaid = Convert.ToDecimal(dgvOrders.CurrentRow.Cells["TotalAmount"].Value);

                        if (total != orderActualPaid)
                        {
                            lblTotalDetail.Text += $" ⚠️ 明細加總 ({total:C}) 與訂單實付 ({orderActualPaid:C}) 不一致";
                            lblTotalDetail.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblTotalDetail.ForeColor = Color.Black;
                        }
                    }



                }
            }
        }



        private void LoadUserUIDs()
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand("SELECT UID, Name FROM Users", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Dictionary<string, Guid> userDict = new Dictionary<string, Guid>();

                    while (reader.Read())
                    {
                        string name = reader.GetString(1);
                        Guid uid = reader.GetGuid(0);
                        string display = $"{name} ({uid.ToString().Substring(0, 8)})";
                        userDict[display] = uid;
                    }

                    comboBoxUID.DataSource = new BindingSource(userDict, null);
                    comboBoxUID.DisplayMember = "Key"; // 顯示名稱
                    comboBoxUID.ValueMember = "Value"; // 實際值為 UID
                }
            }
        }






        /// <summary>
        /// 將畫面上的訂單主檔欄位（總金額、折扣、狀態）儲存回資料庫。
        /// </summary>
        private void SaveOrderChanges()
        {
            if (dgvOrders.CurrentRow == null) return;

            // 從目前選取的列抓取資料
            long orderId = Convert.ToInt64(dgvOrders.CurrentRow.Cells["OrderID"].Value);
            decimal newTotal = Convert.ToDecimal(dgvOrders.CurrentRow.Cells["TotalAmount"].Value);
            decimal newDiscount = Convert.ToDecimal(dgvOrders.CurrentRow.Cells["TotalDiscountAmount"].Value);
            string statusName = dgvOrders.CurrentRow.Cells["StatusName"].Value.ToString();
            int newStatusID = GetStatusIDFromName(statusName); // 呼叫對應函式查狀態 ID

            // 撰寫 SQL 指令：更新訂單主檔中的欄位
            string sql = @"
        UPDATE eBookOrderMain 
        SET 
            TotalAmount = @total,                    -- 更新總金額
            TotalDiscountAmount = @discount,         -- 更新折扣金額
            OrderStatusID = @status                  -- 更新訂單狀態（需用狀態 ID 對應）
        WHERE 
            OrderID = @orderId";       //--條件：指定哪一筆訂單更新

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // 加入 SQL 參數
                cmd.Parameters.AddWithValue("@total", newTotal);
                cmd.Parameters.AddWithValue("@discount", newDiscount);
                cmd.Parameters.AddWithValue("@status", newStatusID);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                conn.Open();
                cmd.ExecuteNonQuery(); // 執行更新
            }
        }


        ///// <summary>
        ///// 將所有訂單明細的變更（數量、單價、折扣）儲存回資料庫。
        ///// </summary>
        //private void SaveDetailChanges()
        //{
        //    foreach (DataGridViewRow row in dgvOrderDetails.Rows)
        //    {
        //        if (row.IsNewRow) continue; // 若是新行或空白行則跳過

        //        // 抓出每筆明細的欄位資料
        //        long detailId = Convert.ToInt64(row.Cells["明細編號"].Value); // eBookOrderDetail 主鍵
        //        int qty = Convert.ToInt32(row.Cells["數量"].Value);         // 購買數量
        //        decimal price = Convert.ToDecimal(row.Cells["單價"].Value); // 單價
        //        decimal discount = Convert.ToDecimal(row.Cells["折扣"].Value); // 折扣金額

        //        // 撰寫 SQL：更新對應的欄位
        //        string sql = @"
        //    UPDATE eBookOrderDetail 
        //    SET 
        //        Quantity = @qty,                              -- 數量
        //        UnitPriceAtPurchase = @price,                 -- 單價
        //        DiscountAmount = @discount                    -- 折扣金額
        //    WHERE 
        //        OrderItemID = @id";                            // 指定哪一筆明細

        //        using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
        //        using (SqlCommand cmd = new SqlCommand(sql, conn))
        //        {
        //            // 加入參數
        //            cmd.Parameters.AddWithValue("@qty", qty);
        //            cmd.Parameters.AddWithValue("@price", price);
        //            cmd.Parameters.AddWithValue("@discount", discount);
        //            cmd.Parameters.AddWithValue("@id", detailId);

        //            conn.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        /// <summary>
        /// 確保 dgvOrderDetails 有包含 eBookID 欄位，若沒有則動態新增（不顯示）
        /// </summary>
        private void EnsureEbookIDColumn()
        {
            // 如果欄位不存在就加上
            if (!dgvOrderDetails.Columns.Contains("eBookID"))
            {
                var col = new DataGridViewTextBoxColumn();
                col.Name = "eBookID";             // 內部識別名稱（程式用）
                col.HeaderText = "eBookID";       // 表頭顯示文字（可隱藏）
                col.Visible = false;              // 不顯示在畫面上（作為隱藏欄位）
                dgvOrderDetails.Columns.Add(col); // 加入欄位
            }
        }

        private void SaveDetailChanges()
        {
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                // 如果是空白新列，直接跳過
                if (row.IsNewRow) continue;

                // 判斷這筆是否有 "明細編號"（即是否為資料庫中的舊資料）
                bool isNew = row.Cells["明細編號"].Value == null || row.Cells["明細編號"].Value == DBNull.Value;

                // 取得欄位值
                string itemName = row.Cells["商品名稱"].Value?.ToString() ?? "";
                int qty = Convert.ToInt32(row.Cells["數量"].Value);
                decimal price = Convert.ToDecimal(row.Cells["單價"].Value);
                decimal discount = Convert.ToDecimal(row.Cells["折扣"].Value);

                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    if (isNew)
                    {
                        // INSERT 新資料
                        //INSERT INTO eBookOrderDetail (OrderID, ItemNameSnapshot, Quantity, UnitPriceAtPurchase, DiscountAmount)
                        //VALUES (@orderId, @name, @qty, @price, @discount)";
                        cmd.CommandText = @"                    
                        INSERT INTO eBookOrderDetail(OrderID,eBookID, ItemNameSnapshot, Quantity, UnitPriceAtPurchase, DiscountAmount, ItemTypeID)
VALUES(@orderId,@ebookID, @name, @qty, @price, @discount, @itemType)";

                        //string itemName = row.Cells["商品名稱"].Value?.ToString() ?? "";

                        // 嘗試自動抓對應的電子書 ID
                        long ebookID = 0;
                        if (row.Cells["eBookID"].Value == null || row.Cells["eBookID"].Value == DBNull.Value)
                        {
                            ebookID = GetEbookIDByName(itemName); // 自動從書名補上
                        }
                        else
                        {
                            ebookID = Convert.ToInt64(row.Cells["eBookID"].Value); // 使用使用者提供的值
                        }

                        cmd.Parameters.AddWithValue("@ebookID", ebookID);
                        cmd.Parameters.AddWithValue("@orderId", GetSelectedOrderID());
                        cmd.Parameters.AddWithValue("@itemType", 3); // 整本電子書

                    }
                    else
                    {
                        // UPDATE 原資料
                        cmd.CommandText = @"
                    UPDATE eBookOrderDetail
                    SET ItemNameSnapshot = @name,
                        Quantity = @qty,
                        UnitPriceAtPurchase = @price,
                        DiscountAmount = @discount
                    WHERE OrderItemID = @id";

                        cmd.Parameters.AddWithValue("@id", Convert.ToInt64(row.Cells["明細編號"].Value));
                    }

                    // 共用參數
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@discount", discount);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // 重新載入明細並更新金額標籤
                    LoadOrderDetails(GetSelectedOrderID()); // 重新抓取該筆訂單的明細資料

                    //  UpdateTotalSummaryLabel();              // 再次計算總金額與更新底下顯示的紅字label

                }
            }
        }


        private long GetSelectedOrderID()
        {
            if (dgvOrders.CurrentRow == null) return 0;
            return Convert.ToInt64(dgvOrders.CurrentRow.Cells["OrderID"].Value);
        }

        /// <summary>
        /// 根據書名查詢 eBookMainTable 並取得對應的 eBookID（第一筆符合者）
        /// </summary>
        /// <param name="bookName">書名（可部分或完整）</param>
        /// <returns>eBookID，若找不到則回傳 0</returns>
        private long GetEbookIDByName(string bookName)
        {
            string sql = "SELECT TOP 1 ebookID FROM eBookMainTable WHERE ebookName LIKE @name";

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", "%" + bookName + "%");
                conn.Open();

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt64(result) : 0;
            }
        }




        /// <summary>
        /// 根據訂單狀態名稱，查詢 OrderStatuses 資料表並取得對應的 OrderStatusID。
        /// </summary>
        /// <param name="statusName">狀態名稱（例如：「已完成」）</param>
        /// <returns>對應的狀態 ID，若找不到回傳 0</returns>
        private int GetStatusIDFromName(string statusName)
        {
            string sql = "SELECT OrderStatusID FROM OrderStatuses WHERE StatusName = @name";

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", statusName);
                conn.Open();
                object result = cmd.ExecuteScalar(); // 只取第一筆第一欄

                // 若找到資料則轉換為 int，否則回傳 0（代表找不到）
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureEbookIDColumn();      // ← 呼叫檢查並補上欄位
                SaveOrderChanges();      // 儲存主檔
                SaveDetailChanges();     // 儲存明細
                MessageBox.Show("儲存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message);
            }
        }

        private void btnDSOD_Click(object sender, EventArgs e)
        {
            // 1. 檢查是否有選中明細行
            if (dgvOrderDetails.CurrentRow == null)
            {
                MessageBox.Show("請先選取一筆明細資料再刪除！");
                return;
            }

            // 2. 取得該行的明細 ID（即 OrderItemID）
            object idValue = dgvOrderDetails.CurrentRow.Cells["明細編號"].Value;
            if (idValue == null || idValue == DBNull.Value)
            {
                MessageBox.Show("無效的明細資料，無法刪除。");
                return;
            }

            long detailId = Convert.ToInt64(idValue);

            // 3. 彈出確認視窗
            var result = MessageBox.Show("確定要刪除這筆訂單明細嗎？", "確認刪除", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            // 4. 執行 SQL 刪除指令
            string sql = "DELETE FROM eBookOrderDetail WHERE OrderItemID = @id";

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", detailId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            // 5. 重新載入訂單明細（避免畫面沒更新）
            LoadOrderDetails(GetSelectedOrderID());
            MessageBox.Show("刪除成功！");
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //    // 檢查是否有選擇 UID（會員）
            //    if (comboBoxUID.SelectedItem == null)
            //    {
            //        MessageBox.Show("請先選擇一位會員 (UID)！");
            //        return;
            //    }

            //    // 取得選取的 UID
            //    Guid selectedUID = (Guid)comboBoxUID.SelectedValue;

            //    // 取得狀態欄位的文字（你可以改成從 TextBox、ComboBox 或 DataGridView 中取值）
            //    string statusText; // = "待付款"; // TODO：你可改成 textboxStatus.Text 或 dgvOrders.CurrentRow.Cells["StatusName"].Value.ToString()
            //    statusText = dgvOrders.CurrentRow.Cells["StatusName"].Value.ToString();

            //    // 將狀態文字轉換成對應的 OrderStatusID
            //    int orderStatusId = GetOrderStatusIdByName(statusText);
            //    if (orderStatusId == -1)
            //    {
            //        MessageBox.Show($"❌ 無效的訂單狀態名稱：「{statusText}」。請使用「待付款」「已完成」「已取消」", "錯誤");
            //        return;
            //    }

            //    using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            //    {
            //        string sql = @"
            //INSERT INTO eBookOrderMain
            //    (UID, OrderDateTime, OrderStatusID, TotalAmount, CurrencyCode, CreatedDate, LastModifiedDate)
            //VALUES
            //    (@uid, GETDATE(), @statusId, 0, 'TWD', GETDATE(), GETDATE());
            //SELECT SCOPE_IDENTITY();";

            //        using (SqlCommand cmd = new SqlCommand(sql, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@uid", selectedUID);
            //            cmd.Parameters.AddWithValue("@statusId", orderStatusId);

            //            conn.Open();
            //            long newOrderId = Convert.ToInt64(cmd.ExecuteScalar());
            //            conn.Close();

            //            MessageBox.Show($"✅ 成功新增訂單，編號為 {newOrderId}", "新增成功");
            //            LoadOrders();
            //        }
            //    }


            // 1️⃣ 檢查 ComboBox 是否有選擇會員 UID
            if (comboBoxUID.SelectedItem == null)
            {
                MessageBox.Show("請先選擇一位會員 (UID)！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ 從 comboBox 取得選中的 UID 值（型別為 Guid）
            Guid selectedUID = (Guid)comboBoxUID.SelectedValue;

            // 3️⃣ 嘗試從目前 DataGridView 的空白列讀取 TotalAmount 與 TotalDiscountAmount
            decimal totalAmount = 0;
            decimal totalDiscount = 0;
            string statusName = "待付款"; // 預設值，如果你有輸入欄位也可從那邊取

            try
            {
                // 🔍 找到目前選取的列
                var row = dgvOrders.CurrentRow;

                if (row != null)
                {
                    // 取得使用者輸入的金額
                    totalAmount = Convert.ToDecimal(row.Cells["TotalAmount"].Value ?? 0);
                    totalDiscount = Convert.ToDecimal(row.Cells["TotalDiscountAmount"].Value ?? 0);
                    statusName = row.Cells["StatusName"].Value?.ToString() ?? "待付款";
                }
            }
            catch
            {
                MessageBox.Show("請先選取一列，並填寫金額與狀態！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4️⃣ 將狀態名稱（如：待付款）轉換成狀態 ID（如：1）
            int orderStatusID = GetOrderStatusIdByName(statusName);
            if (orderStatusID == -1)
            {
                MessageBox.Show("找不到對應的訂單狀態！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5️⃣ 寫入資料庫
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnStr))
            {
                string sql = @"
INSERT INTO eBookOrderMain
(UID, OrderDateTime, OrderStatusID, TotalAmount, TotalDiscountAmount, CurrencyCode, CreatedDate, LastModifiedDate)
VALUES
(@uid, GETDATE(), @statusId, @totalAmount, @totalDiscount, 'TWD', GETDATE(), GETDATE());
SELECT SCOPE_IDENTITY(); -- 回傳新插入的訂單編號";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", selectedUID);
                    cmd.Parameters.AddWithValue("@statusId", orderStatusID);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@totalDiscount", totalDiscount);

                    conn.Open();
                    long newOrderId = Convert.ToInt64(cmd.ExecuteScalar());
                    conn.Close();

                    MessageBox.Show($"✅ 成功新增訂單，編號為 {newOrderId}", "成功");

                    LoadOrders(); // 重新載入訂單
                }
            }

        }

        /// <summary>
        /// 根據狀態名稱（中文）對應 OrderStatusID
        /// </summary>
        private int GetOrderStatusIdByName(string status)
        {
            switch (status.Trim())
            {
                case "待付款": return 1;
                case "已完成": return 2;
                case "已取消": return 3;
                default: return -1; // 未知狀態
            }
        }


    }
}
