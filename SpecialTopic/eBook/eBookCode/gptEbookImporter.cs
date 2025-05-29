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
    }
}
