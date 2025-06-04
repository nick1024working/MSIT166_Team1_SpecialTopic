using SpecialTopic.eBook.eBookCode;
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

namespace SpecialTopic
{
    public partial class EBookControl : UserControl
    {
        public EBookControl()
        {
            InitializeComponent();
            InitializePurchasedBooksButton();
        }

        //private Button btnPurchasedBooks;

        private void InitializePurchasedBooksButton()
        {
            //this.btnPurchasedBooks = new Button();
            this.btnPurchasedBooks.Text = "已購電子書";
            this.btnPurchasedBooks.AutoSize = true;
            //this.btnPurchasedBooks.Location = new Point(20, 20); // 可視需要調整位置
            this.btnPurchasedBooks.Click += BtnPurchasedBooks_Click;
            this.Controls.Add(btnPurchasedBooks);
        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            // 1. 讓使用者選 Excel 檔
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel 檔案 (*.xlsx)|*.xlsx";
            ofd.Title = "請選擇匯入用 Excel 檔案";
            if (ofd.ShowDialog() != DialogResult.OK)
                return; // 使用者取消
            string excelPath = ofd.FileName;

            // 2. 讓使用者選 PDF 原始資料夾
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "請選擇原始 PDF 電子書資料夾";
            if (fbd.ShowDialog() != DialogResult.OK)
                return; // 使用者取消
            string pdfSourceFolder = fbd.SelectedPath;

            gptEbookImporter gEImp= new gptEbookImporter();
            try
            {
                // 3. 呼叫匯入函式
                gEImp.ImportFromExcel(excelPath, pdfSourceFolder);
                MessageBox.Show("匯入成功！");
                loadBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show("匯入失敗：" + ex.Message);
            }
        }

        private void BtnPurchasedBooks_Click(object sender, EventArgs e)
        {
            // 建立並顯示已購電子書的表單
            FormPurchasedBooks form = new FormPurchasedBooks();
            form.ShowDialog(); // 使用 ShowDialog() 可防止同時開多個
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 假設你要開啟 ebookID = 1001 的書，或之後從 DataGridView 選取也可改寫成動態
                long ebookID = 1;

                string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";
                string relativePath = null;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT eBookPosition FROM eBookMainTable WHERE ebookID = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", ebookID);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        relativePath = result.ToString();
                    }
                }

                if (!string.IsNullOrWhiteSpace(relativePath))
                {
                    // 開啟電子書
                    GptExampleClass.OpenEbookFromRelativePath(relativePath);
                }
                else
                {
                    MessageBox.Show("查無指定電子書的檔案路徑！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message);
            }
        }

        private void LoadBookWithFilter(string keyword)
        {
            // 建立一個空的資料表物件，用來裝查詢結果
            DataTable dt = new DataTable();

            // 從全域設定檔取得資料庫連接字串（你之前已定義 GlobalConfig.ConnStr）
            string connStr = GlobalConfig.ConnStr;

            // 使用 using 區塊建立與 SQL Server 的連線，連線用完會自動關閉與釋放資源
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // 開啟資料庫連線
                conn.Open();

                // 定義 SQL 查詢語法（注意：若 keyword 為空就不要加 WHERE 條件）
                string sql;
                SqlCommand cmd;

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    // 若 keyword 為空，則撈出所有電子書（不加條件）
                    sql = @"
                SELECT ebookID, ebookName, author, fixedPrice, actualPrice, maturityRating, cover1
                FROM eBookMainTable
            ";

                    // 建立 SqlCommand 並傳入 SQL 語法與資料庫連線物件
                    cmd = new SqlCommand(sql, conn);
                }
                else
                {
                    // 若有關鍵字，則加上 WHERE 書名模糊查詢條件
                    sql = @"
                SELECT ebookID, ebookName, author, fixedPrice, actualPrice, maturityRating, cover1
                FROM eBookMainTable
                WHERE ebookName LIKE @kw
            ";

                    // 建立 SqlCommand
                    cmd = new SqlCommand(sql, conn);

                    // 加入參數並使用模糊查詢 %關鍵字%
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                }

                // 建立 SqlDataAdapter 用來執行查詢並填入 DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // 執行查詢並把結果填入 dt 資料表
                adapter.Fill(dt);
            }

            // 把查詢結果顯示到 DataGridView 控制項上
            dataGridView1.DataSource = dt;

            // 設定欄位寬度自動調整成最適合寬度（避免資料被截斷）
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void loadBook()
        {
            // 建立資料表
            DataTable dt = new DataTable();

            // 定義資料庫連線字串
            string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // 開啟資料庫連線
                conn.Open();

                // 撈出電子書的基本欄位資料（你也可以加入更多欄位）
                string sql = @"
            SELECT ebookID, ebookName, author, eBookClass1,eBookLabel1,eBookLabel2,cover1, fixedPrice, actualPrice,monthsales,totalsales,monthviews,totalviews,maturityRating,isAvailable
            FROM eBookMainTable
        ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt); // 把資料填入 dt 資料表
            }

            // 資料繫結到 DataGridView
            dataGridView1.DataSource = dt;

            // 自動調整欄寬
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnOpenSelectedBook_Click(object sender, EventArgs e)
        {
            // 確保目前有選取的行
            if (dataGridView1.CurrentRow != null)
            {
                // 取得目前行的 ebookID 欄位資料
                object idObj = dataGridView1.CurrentRow.Cells["ebookID"].Value;

                // 嘗試轉換為 long 型別
                if (long.TryParse(idObj.ToString(), out long ebookId))
                {
                    // 呼叫你定義的共用函式來開啟電子書
                    GptExampleClass.OpenEbookByID(ebookId);
                }
                else
                {
                    MessageBox.Show("選取的電子書 ID 無效！");
                }
            }
            else
            {
                MessageBox.Show("請先選取一本電子書！");
            }
        }

        private void EBookControl_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 加上錯誤容錯
            dataGridView1.DataError += (s, args) => args.ThrowException = false;
            //InitializePurchasedBooksButton();
            //InitializePurchasedBooksButton();
            loadBook();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // 確保有選擇列
            if (dataGridView1.CurrentRow != null)
            {
                // 取得目前列的 cover1 欄位值
                object coverObj = dataGridView1.CurrentRow.Cells["cover1"].Value;

                // 確保不是 null 且不是 DBNull
                if (coverObj != null && coverObj != DBNull.Value)
                {
                    // 轉成 byte[] 圖片資料
                    byte[] imageData = (byte[])coverObj;

                    // 進一步檢查 imageData 長度是否大於 0
                    if (imageData.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBoxCover.Image = Image.FromStream(ms);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("封面圖片格式錯誤，無法載入。\n" + ex.Message, "圖片錯誤");
                            pictureBoxCover.Image = null;
                        }
                    }
                    else
                    {
                        // 若沒圖片，清除 PictureBox
                        pictureBoxCover.Image = null;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 確保有選擇資料列
            if (dataGridView1.CurrentRow != null)
            {
                // 取得選取列的 ebookID
                long ebookId = Convert.ToInt64(dataGridView1.CurrentRow.Cells["ebookID"].Value);

               
                FrmEditBook editForm = new FrmEditBook(ebookId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 儲存後刷新 DataGridView
                    loadBook(); // 你自己原本的讀取函式
                }
            }
            else
            {
                MessageBox.Show("請先選擇要編輯的書籍！");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim(); // 從輸入框拿到關鍵字
            LoadBookWithFilter(keyword);            // 傳入關鍵字查詢
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            FormOrderList form = new FormOrderList();

            // 設定為子視窗顯示（ShowDialog 可選）
            form.Show(); // 或改成 form.ShowDialog() 若你希望為模態視窗
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadBook();
        }

        private void btnSubscriber_Click(object sender, EventArgs e)
        {
            FormSubscriber subfm = new FormSubscriber();
            subfm.Show();
        }
    }
}
