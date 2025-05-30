// 匯入必要的命名空間與外部套件
// EPPlus: 用於讀取 Excel 檔案
// PdfiumViewer: 用於擷取 PDF 檔案的封面圖

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml; // 引入 EPPlus 用於 Excel 讀取
using PdfiumViewer;  // 引入 PdfiumViewer 用於 PDF 頁面渲染


namespace SpecialTopic.eBook.eBookCode
{
    public class gptEbookImporter
    {
        // 主函式：從 Excel 匯入資料，將 PDF 檔案複製、擷取封面並寫入資料庫
        public void ImportFromExcel(string excelPath, string pdfSourceFolder)
        {
            //string connectionString = "your-connection-string"; // 替換為實際資料庫連線字串
            string connectionString = "Data Source = MSITxx - 00; Initial Catalog = TeamA_Project; Integrated Security = True";

            // 設定專案內的 eBookFiles 資料夾路徑，儲存複製過來的 PDF 檔案
            string destFolder = Path.Combine(Application.StartupPath, "eBookFiles");
            Directory.CreateDirectory(destFolder); // 若資料夾不存在則建立

            // 使用 EPPlus 開啟 Excel 檔案
            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                var sheet = package.Workbook.Worksheets[0]; // 讀取第一個工作表
                int row = 2; // 從第 2 列開始（跳過標題列）

                // 逐列讀取直到遇到空白
                while (sheet.Cells[row, 1].Value != null)
                {
                    // 從 Excel 中讀取對應欄位的內容
                    string fileName = sheet.Cells[row, 1].Text.Trim();
                    string ebookName = sheet.Cells[row, 2].Text.Trim();
                    string class1 = sheet.Cells[row, 3].Text.Trim();
                    string class2 = sheet.Cells[row, 4].Text.Trim();
                    string author = sheet.Cells[row, 5].Text.Trim();
                    string publisher = sheet.Cells[row, 6].Text.Trim();
                    DateTime publishedDate = DateTime.Parse(sheet.Cells[row, 7].Text.Trim());
                    decimal fixedPrice = decimal.Parse(sheet.Cells[row, 8].Text.Trim());
                    string description = sheet.Cells[row, 9].Text.Trim();

                    // 找到 PDF 檔案來源與目的地位置，並複製過來
                    string sourcePath = Path.Combine(pdfSourceFolder, fileName);
                    string destPath = Path.Combine(destFolder, fileName);
                    File.Copy(sourcePath, destPath, true); // 若重複則覆蓋

                    // 產生相對路徑存進資料庫
                    string relativePath = $"eBookFiles\\{fileName}";

                    // 擷取封面圖像（第 1 頁），轉為 byte 陣列
                    byte[] coverBytes = ExtractCoverImage(sourcePath);

                    // 寫入資料庫：新增一筆電子書資料
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO eBookMainTable
                    (ebookName, eBookClass1, eBookClass2, author, publisher, publishedDate,
                     fixedPrice, bookDescription, eBookPosition, eBookDataType, cover1)
                    VALUES
                    (@ebookName, @class1, @class2, @auth, @pub, @pubDate,
                     @price, @desc, @pos, @type, @cover1)", conn))
                    {
                        // 設定 SQL 參數（避免 SQL injection）
                        cmd.Parameters.AddWithValue("@ebookName", ebookName);
                        cmd.Parameters.AddWithValue("@class1", class1);
                        cmd.Parameters.AddWithValue("@class2", class2);
                        cmd.Parameters.AddWithValue("@auth", author);
                        cmd.Parameters.AddWithValue("@pub", publisher);
                        cmd.Parameters.AddWithValue("@pubDate", publishedDate);
                        cmd.Parameters.AddWithValue("@price", fixedPrice);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@pos", relativePath);
                        cmd.Parameters.AddWithValue("@type", Path.GetExtension(fileName).TrimStart('.').ToUpper());
                        cmd.Parameters.AddWithValue("@cover1", coverBytes);

                        // 執行 SQL 寫入動作
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    row++; // 讀下一列
                }
            }
        }

        // 擷取 PDF 第 1 頁作為封面圖，轉為 byte[] 儲存
        private byte[] ExtractCoverImage(string pdfPath)
        {
            using (var doc = PdfDocument.Load(pdfPath)) // 開啟 PDF
            using (var image = doc.Render(0, 300, 300, true)) // 渲染第 0 頁，解析度 300 dpi
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // 存成 PNG 格式
                return ms.ToArray(); // 轉為 byte 陣列回傳
            }
        }

        // 主函式：從 Excel 匯入資料，包含 PDF 複製、封面擷取、隨機銷量產生與資料庫寫入
        public void ImportFromExcel_2(string excelPath, string pdfSourceFolder)
        {
            string connectionString = "your-connection-string"; // 請填入實際資料庫連線字串

            // 設定儲存 PDF 的目標資料夾（eBookFiles）
            string destFolder = Path.Combine(Application.StartupPath, "eBookFiles");
            Directory.CreateDirectory(destFolder); // 若無此資料夾則自動建立

            using (var package = new ExcelPackage(new FileInfo(excelPath))) // 開啟 Excel
            {
                var sheet = package.Workbook.Worksheets[0]; // 使用第一個工作表
                int row = 2; // 從第2列開始（第1列是標題）

                while (sheet.Cells[row, 1].Value != null) // 若 A 欄有值就持續讀取
                {
                    // 讀取 Excel 欄位內容
                    string fileName = sheet.Cells[row, 1].Text.Trim(); // PDF 檔名
                    string ebookName = sheet.Cells[row, 2].Text.Trim(); // 書名
                    string class1 = sheet.Cells[row, 3].Text.Trim(); // 主分類
                    string class2 = sheet.Cells[row, 4].Text.Trim(); // 次分類
                    string author = sheet.Cells[row, 5].Text.Trim(); // 作者
                    string publisher = sheet.Cells[row, 6].Text.Trim(); // 出版社
                    DateTime publishedDate = DateTime.Parse(sheet.Cells[row, 7].Text.Trim()); // 出版日
                    decimal fixedPrice = decimal.Parse(sheet.Cells[row, 8].Text.Trim()); // 定價
                    decimal? actualPrice = null;
                    if (decimal.TryParse(sheet.Cells[row, 9].Text.Trim(), out decimal parsedPrice))
                    {
                        actualPrice = parsedPrice;
                    }
                    string language = sheet.Cells[row, 10].Text.Trim(); // 語言
                    string label1 = sheet.Cells[row, 11].Text.Trim(); // 主標籤
                    string description = sheet.Cells[row, 12].Text.Trim(); // 書籍簡介

                    // 複製 PDF 到專案 eBookFiles 內
                    string sourcePath = Path.Combine(pdfSourceFolder, fileName);
                    string destPath = Path.Combine(destFolder, fileName);
                    File.Copy(sourcePath, destPath, true);
                    string relativePath = $"eBookFiles\\{fileName}"; // 相對路徑

                    // 擷取封面圖，存成 byte[] 並存為實體圖片
                    byte[] coverBytes = ExtractCoverImage(sourcePath, out string imageFilePath);

                    // 資料庫寫入電子書資料
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO eBookMainTable (
                        ebookName, eBookClass1, eBookClass2, author, publisher, publishedDate,
                        fixedPrice, actualPrice, language, eBookLabel1, bookDescription,
                        eBookPosition, eBookDataType, cover1,
                        weeksales, monthsales, totalsales,
                        weekviews, monthviews, totalviews, maturityRating
                    )
                    VALUES (
                        @ebookName, @class1, @class2, @auth, @pub, @pubDate,
                        @fixPrice, @actPrice, @lang, @label1, @desc,
                        @pos, @type, @cover1,
                        @ws, @ms, @ts, @wv, @mv, @tv, @rating
                    )", conn))
                    {
                        // 基本欄位對應參數
                        cmd.Parameters.AddWithValue("@ebookName", ebookName);
                        cmd.Parameters.AddWithValue("@class1", class1);
                        cmd.Parameters.AddWithValue("@class2", class2);
                        cmd.Parameters.AddWithValue("@auth", author);
                        cmd.Parameters.AddWithValue("@pub", publisher);
                        cmd.Parameters.AddWithValue("@pubDate", publishedDate);
                        cmd.Parameters.AddWithValue("@fixPrice", fixedPrice);
                        //cmd.Parameters.AddWithValue("@actPrice", (object?)actualPrice ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@actPrice", actualPrice.HasValue ? (object)actualPrice.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@lang", language);
                        cmd.Parameters.AddWithValue("@label1", label1);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@pos", relativePath);
                        cmd.Parameters.AddWithValue("@type", Path.GetExtension(fileName).TrimStart('.').ToUpper()); // 自動抓副檔名
                        cmd.Parameters.AddWithValue("@cover1", coverBytes);

                        // 隨機產生假銷量與閱覽數（方便測試）
                        Random rnd = new Random();
                        cmd.Parameters.AddWithValue("@ws", rnd.Next(10, 100));
                        cmd.Parameters.AddWithValue("@ms", rnd.Next(100, 500));
                        cmd.Parameters.AddWithValue("@ts", rnd.Next(500, 3000));
                        cmd.Parameters.AddWithValue("@wv", rnd.Next(50, 200));
                        cmd.Parameters.AddWithValue("@mv", rnd.Next(300, 900));
                        cmd.Parameters.AddWithValue("@tv", rnd.Next(1000, 5000));
                        cmd.Parameters.AddWithValue("@rating", 0); // 預設 0 = 普遍級

                        // 執行寫入
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    row++; // 處理下一筆資料
                }
            }
        }

        // 從 PDF 擷取第 1 頁並轉為 byte[]，同時也輸出為實體圖片
        private byte[] ExtractCoverImage(string pdfPath, out string imageFilePath)
        {
            string imageFolder = Path.Combine(Application.StartupPath, "eBookFiles", "Covers");
            Directory.CreateDirectory(imageFolder); // 建立 Covers 資料夾

            string fileNameNoExt = Path.GetFileNameWithoutExtension(pdfPath); // 取檔名不含副檔名
            imageFilePath = Path.Combine(imageFolder, fileNameNoExt + ".jpg"); // 輸出實體圖檔路徑

            using (var doc = PdfDocument.Load(pdfPath)) // 載入 PDF
            using (var image = doc.Render(0, 300, 300, true)) // 擷取第 0 頁（第一頁） 解析度 300dpi
            using (var ms = new MemoryStream())
            {
                image.Save(imageFilePath, System.Drawing.Imaging.ImageFormat.Jpeg); // 存成 .jpg 實體圖檔
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);             // 同步轉為 byte[] 傳回資料庫欄位
                return ms.ToArray();
            }
        }
    }
}
