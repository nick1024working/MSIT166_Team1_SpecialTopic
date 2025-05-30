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
        public void ImportFromExcel_old(string excelPath, string pdfSourceFolder)
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
        // 主函式：從 Excel 匯入電子書資訊，並處理 PDF 複製與封面擷取
        public void ImportFromExcel(string excelPath, string pdfSourceFolder)
        {
            //string connectionString = "your-connection-string"; // 請填入實際的 SQL Server 連線字串
            string connectionString = "Data Source = MSITxx - 00; Initial Catalog = TeamA_Project; Integrated Security = True";

            // 指定 PDF 要複製到的專案內資料夾
            string destFolder = Path.Combine(Application.StartupPath, "eBookFiles");
            Directory.CreateDirectory(destFolder); // 如果資料夾不存在則建立

            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                var sheet = package.Workbook.Worksheets[0]; // 使用第一個工作表
                int row = 2; // 從第2列開始（第1列是標題）

                while (sheet.Cells[row, 1].Value != null) // 若A欄有檔名就繼續讀取
                {
                    // ================== Excel 欄位讀取 =====================
                    string fileName = sheet.Cells[row, 1].Text.Trim(); // PDF檔案名稱
                    string ebookName = sheet.Cells[row, 2].Text.Trim(); // 書名，與檔名不同時仍正確存入
                    string class1 = sheet.Cells[row, 3].Text.Trim();
                    string class2 = sheet.Cells[row, 4].Text.Trim();
                    string author = sheet.Cells[row, 5].Text.Trim();
                    string publisher = sheet.Cells[row, 6].Text.Trim();
                    DateTime publishedDate = DateTime.Parse(sheet.Cells[row, 7].Text.Trim());
                    string translator = sheet.Cells[row, 8].Text.Trim();
                    string language = sheet.Cells[row, 9].Text.Trim();
                    string isbn = sheet.Cells[row, 10].Text.Trim();
                    string eisbn = sheet.Cells[row, 11].Text.Trim();
                    string country = sheet.Cells[row, 12].Text.Trim();
                    int cEpisode = int.Parse(sheet.Cells[row, 13].Text.Trim());
                    int totalEpisode = int.Parse(sheet.Cells[row, 14].Text.Trim());
                    string ext = sheet.Cells[row, 15].Text.Trim();
                    string label1 = sheet.Cells[row, 16].Text.Trim();
                    string label2 = sheet.Cells[row, 17].Text.Trim();
                    string label3 = sheet.Cells[row, 18].Text.Trim();
                    string label4 = sheet.Cells[row, 19].Text.Trim();
                    string label5 = sheet.Cells[row, 20].Text.Trim();
                    decimal fixedPrice = decimal.Parse(sheet.Cells[row, 21].Text.Trim());
                    decimal? actualPrice = decimal.TryParse(sheet.Cells[row, 22].Text.Trim(), out var act) ? act : (decimal?)null;
                    decimal? discount = decimal.TryParse(sheet.Cells[row, 23].Text.Trim(), out var disc) ? disc : (decimal?)null;
                    string purchaseCountry = sheet.Cells[row, 24].Text.Trim();
                    string description = sheet.Cells[row, 25].Text.Trim();
                    byte maturityRating = byte.Parse(sheet.Cells[row, 26].Text.Trim());

                    // 自動隨機銷量/閱覽數產生（供測試）
                    Random rnd = new Random();
                    long weeksales = rnd.Next(10, 100);
                    long monthsales = rnd.Next(100, 300);
                    long totalsales = rnd.Next(300, 800);
                    long weekviews = rnd.Next(50, 150);
                    long monthviews = rnd.Next(200, 600);
                    long totalviews = rnd.Next(600, 2000);

                    // 複製 PDF 檔案並取得相對路徑
                    string sourcePath = Path.Combine(pdfSourceFolder, fileName);
                    string destPath = Path.Combine(destFolder, fileName);
                    File.Copy(sourcePath, destPath, true);
                    string relativePath = $"eBookFiles\\{fileName}";

                    // 擷取封面圖，存實體圖並轉為 byte[] 備存資料庫 cover1
                    byte[] coverBytes = ExtractCoverImage(sourcePath, out string imageFilePath);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // 檢查是否已存在相同書名與作者（避免重複）
                        using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM eBookMainTable WHERE ebookName = @name AND author = @auth", conn))
                        {
                            checkCmd.Parameters.AddWithValue("@name", ebookName);
                            checkCmd.Parameters.AddWithValue("@auth", author);
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                // 若已存在，可跳過或更新，這裡選擇跳過
                                row++;
                                continue;
                            }
                        }

                        // ============ 插入資料庫 ============
                        using (SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO eBookMainTable (
                            ebookName, eBookClass1, eBookClass2, eBookType, author, publisher, publishedDate,
                            translator, language, ISBN, EISBN, publishedCountry, cEpisode, TotalEpisode,
                            eBookPosition, eBookDataType, eBookLabel1, eBookLabel2, eBookLabel3, eBookLabel4, eBookLabel5,
                            cover1, fixedPrice, actualPrice, couponcode, discount, purchaseCountry, bookDescription,
                            weeksales, monthsales, totalsales, weekviews, monthviews, totalviews, maturityRating
                        ) VALUES (
                            @name, @cls1, @cls2, '單本', @auth, @pub, @date,
                            @trans, @lang, @isbn, @eisbn, @country, @cepi, @tepi,
                            @pos, @ext, @l1, @l2, @l3, @l4, @l5,
                            @cover, @fix, @act, NULL, @disc, @purch, @desc,
                            @ws, @ms, @ts, @wv, @mv, @tv, @rate
                        )", conn))
                        {
                            cmd.Parameters.AddWithValue("@name", ebookName);
                            cmd.Parameters.AddWithValue("@cls1", class1);
                            cmd.Parameters.AddWithValue("@cls2", class2);
                            cmd.Parameters.AddWithValue("@auth", author);
                            cmd.Parameters.AddWithValue("@pub", publisher);
                            cmd.Parameters.AddWithValue("@date", publishedDate);
                            cmd.Parameters.AddWithValue("@trans", translator);
                            cmd.Parameters.AddWithValue("@lang", language);
                            cmd.Parameters.AddWithValue("@isbn", isbn);
                            cmd.Parameters.AddWithValue("@eisbn", eisbn);
                            cmd.Parameters.AddWithValue("@country", country);
                            cmd.Parameters.AddWithValue("@cepi", cEpisode);
                            cmd.Parameters.AddWithValue("@tepi", totalEpisode);
                            cmd.Parameters.AddWithValue("@pos", relativePath);
                            cmd.Parameters.AddWithValue("@ext", ext);
                            cmd.Parameters.AddWithValue("@l1", label1);
                            cmd.Parameters.AddWithValue("@l2", label2);
                            cmd.Parameters.AddWithValue("@l3", label3);
                            cmd.Parameters.AddWithValue("@l4", label4);
                            cmd.Parameters.AddWithValue("@l5", label5);
                            cmd.Parameters.AddWithValue("@cover", coverBytes);
                            cmd.Parameters.AddWithValue("@fix", fixedPrice);
                            cmd.Parameters.AddWithValue("@act", actualPrice.HasValue ? (object)actualPrice.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@disc", discount.HasValue ? (object)discount.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@purch", purchaseCountry);
                            cmd.Parameters.AddWithValue("@desc", description);
                            cmd.Parameters.AddWithValue("@ws", weeksales);
                            cmd.Parameters.AddWithValue("@ms", monthsales);
                            cmd.Parameters.AddWithValue("@ts", totalsales);
                            cmd.Parameters.AddWithValue("@wv", weekviews);
                            cmd.Parameters.AddWithValue("@mv", monthviews);
                            cmd.Parameters.AddWithValue("@tv", totalviews);
                            cmd.Parameters.AddWithValue("@rate", maturityRating);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    row++; // 下一列
                }
            }
        }

        // 解析 PDF 並擷取第1頁轉為圖檔與 byte[]
        private byte[] ExtractCoverImage(string pdfPath, out string imageFilePath)
        {
            string imageFolder = Path.Combine(Application.StartupPath, "eBookFiles", "Covers");
            Directory.CreateDirectory(imageFolder);
            string fileNameNoExt = Path.GetFileNameWithoutExtension(pdfPath);
            imageFilePath = Path.Combine(imageFolder, fileNameNoExt + ".jpg");

            using (var doc = PdfDocument.Load(pdfPath))
            using (var image = doc.Render(0, 300, 300, true))
            using (var ms = new MemoryStream())
            {
                image.Save(imageFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
