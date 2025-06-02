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

            long orderId = Convert.ToInt64(dgvOrders.CurrentRow.Cells["OrderID"].Value);
            LoadOrderDetails(orderId); // 如果還沒寫這函式可以先註解起來
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 點關閉按鈕就關掉視窗
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            LoadOrders(); // 載入訂單資料
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
                (m.TotalAmount - ISNULL(m.TotalDiscountAmount, 0)) AS ActualPaid,
                m.CurrencyCode
            FROM eBookOrderMain m
            JOIN OrderStatuses s ON m.OrderStatusID = s.OrderStatusID
            LEFT JOIN [Users] u ON m.UID = u.UID
            ORDER BY m.OrderDateTime DESC
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
            //    m.OrderDateTime DESC                                  --按下單時間由新到舊排序



            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrders.DataSource = dt;
            }
        }

        private void LoadOrderDetails(long orderId)
        {
            string connStr = GlobalConfig.ConnStr;

            string sql = @"
        SELECT 
            od.OrderItemID,
            od.ItemNameSnapshot,
            od.Quantity,
            od.UnitPriceAtPurchase,
            od.DiscountAmount,
            (od.Quantity * od.UnitPriceAtPurchase - ISNULL(od.DiscountAmount, 0)) AS LineTotal
        FROM eBookOrderDetail od
        WHERE od.OrderID = @orderId";

            //            SELECT
            //    od.OrderItemID,                    --明細編號（主鍵）
            //    od.ItemNameSnapshot,              --商品名稱快照（當時購買時的書名）
            //    od.Quantity,                      --數量，通常為 1（電子書）
            //    od.UnitPriceAtPurchase,           --單價（當時購買價格）
            //    od.DiscountAmount,                --折扣金額（可為 NULL）
            //    (od.Quantity * od.UnitPriceAtPurchase - ISNULL(od.DiscountAmount, 0)) AS LineTotal
            //    -- ↑ 計算明細小計（數量 × 單價 - 折扣），ISNULL 可避免 NULL 導致運算錯誤
            //FROM eBookOrderDetail od
            //WHERE od.OrderID = @orderId
            //-- ↑ 根據傳入的 OrderID（你在程式中用參數傳入）查出該筆訂單的所有商品


            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@orderId", orderId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrderDetails.DataSource = dt;
            }
        }

    }
}
