using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SpecialTopic.eBook.eBookCode
{
    public class GptExampleClass
    {
        //        第一個範例函式gpt說的使用方式
        //        OpenFileDialog ofd = new OpenFileDialog();
        //if (ofd.ShowDialog() == DialogResult.OK)
        //{
        //    string relativePath = SaveEbookAndGetRelativePath(ofd.FileName);
        //        MessageBox.Show("相對路徑為：" + relativePath);
        //}

        // 此函式將使用者選擇的檔案複製到 Books 資料夾，並回傳相對路徑
        public static string SaveEbookAndGetRelativePath(string sourcePath)
        {
            // 取得使用者選擇檔案的檔名（不含資料夾路徑）
            string fileName = Path.GetFileName(sourcePath);

            // 組出目的資料夾 Books 的完整路徑（位於應用程式執行路徑下）
            string destFolder = Path.Combine(Application.StartupPath, "Books");

            // 如果 Books 資料夾尚未建立，就先建立它
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            // 組出要複製到的完整目的檔案路徑
            string destPath = Path.Combine(destFolder, fileName);

            // 將檔案從來源位置複製到 Books 資料夾，若已存在會覆蓋
            File.Copy(sourcePath, destPath, true);

            // 回傳相對於應用程式的路徑（儲存到資料庫用）
            return Path.Combine("Books", fileName);
        }

        /// <summary>
        /// 將電子書檔案複製到 eBook\eBookFiles 資料夾，並回傳相對路徑（存入資料庫）
        /// </summary>
        /// <param name="sourcePath">原始檔案完整路徑（例如：C:\User\Desktop\abc.pdf）</param>
        /// <returns>相對路徑（例如：eBook\eBookFiles\abc.pdf）</returns>
        public static string SaveEbookToFilesAndGetRelativePath(string sourcePath)
        {
            // 取得檔案名稱（例如從 C:\abc\mybook.pdf 取出 mybook.pdf）
            string fileName = Path.GetFileName(sourcePath);

            // 組出完整目的地資料夾路徑：Application.StartupPath\eBook\eBookFiles
            string destFolder = Path.Combine(Application.StartupPath, "eBook", "eBookFiles");

            // 如果該資料夾尚不存在，就自動建立資料夾（包含多層）
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            // 組出最終複製目的地檔案的完整路徑（包含檔名）
            string destPath = Path.Combine(destFolder, fileName);

            // 將來源檔案複製到目的地路徑，若檔案已存在則強制覆蓋
            File.Copy(sourcePath, destPath, true);

            // 回傳給資料庫使用的相對路徑（不含絕對路徑）
            return Path.Combine("eBook", "eBookFiles", fileName);
        }



        // 此函式會根據資料庫儲存的相對路徑，組成完整路徑後開啟該檔案
        public static void OpenEbookFromRelativePath(string relativePath)
        {
            // 組合出完整檔案路徑
            string fullPath = Path.Combine(Application.StartupPath, relativePath);

            // 確認檔案存在
            if (File.Exists(fullPath))
            {
                // 使用預設應用程式開啟該檔案（例如 PDF 會用 PDF 閱讀器）
                Process.Start(fullPath);
            }
            else
            {
                // 若檔案不存在，顯示錯誤訊息
                MessageBox.Show("找不到電子書：" + fullPath);
            }
        }

        /// <summary>
        /// ✅ 根據電子書的 ebookID，查詢資料庫中的檔案位置並自動開啟
        /// </summary>
        /// <param name="ebookID">電子書的唯一識別碼</param>
        public static void OpenEbookByID(long ebookID)
        {
            try
            {
                // 定義連線字串：請確認與你的資料庫伺服器及資料庫名稱一致
                string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";

                // 儲存查到的電子書相對路徑
                string relativePath = null;

                // 使用 using 自動管理 SqlConnection 的資源釋放
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    // 開啟資料庫連線
                    conn.Open();

                    // SQL 查詢語法：透過 ebookID 抓取 eBookPosition（檔案相對路徑）
                    string sql = "SELECT eBookPosition FROM eBookMainTable WHERE ebookID = @id";

                    // 建立 SqlCommand 並指派參數值
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // 傳入參數 @id 為指定的電子書 ID
                        cmd.Parameters.AddWithValue("@id", ebookID);

                        // 執行查詢，回傳單一值（eBookPosition 欄位內容）
                        object result = cmd.ExecuteScalar();

                        // 若查詢結果不是 null 也不是 DBNull，則轉成字串儲存
                        if (result != null && result != DBNull.Value)
                        {
                            relativePath = result.ToString();
                        }
                    }
                }

                // 若成功取得相對路徑，就呼叫開啟檔案的函式
                if (!string.IsNullOrWhiteSpace(relativePath))
                {
                    OpenEbookFromRelativePath(relativePath); // 開啟該書檔案
                }
                else
                {
                    // 若未找到資料，顯示警告
                    MessageBox.Show("找不到此電子書的檔案路徑（ebookID = " + ebookID + "）", "查無資料", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // 若程式執行過程發生例外，顯示錯誤訊息
                MessageBox.Show("開啟電子書失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 此函式會將指定圖片讀入為 byte[]，並透過 SQL 指令更新到資料表中的 VARBINARY 欄位
        public static void SaveImageToDatabase(string imagePath, long ebookID, SqlConnection conn)
        {
            // 讀取圖片檔案成為二進位資料（byte 陣列）
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            // 撰寫 SQL 指令：將 cover1 欄位更新為此圖片內容
            string sql = "UPDATE eBookMain SET cover1 = @img WHERE ebookID = @id";

            // 使用 using 區塊建立 SqlCommand 並執行
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // 將圖片資料加到參數 @img 中
                cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value = imageBytes;

                // 指定要更新的電子書 ID
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = ebookID;

                // 執行更新指令
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 儲存封面圖片到 eBookCover 資料夾，檔名為 cover_電子書ID.xxx，並回傳相對路徑
        /// </summary>
        /// <param name="sourcePath">圖片原始檔案完整路徑</param>
        /// <param name="ebookID">電子書 ID，用來命名檔案</param>
        /// <returns>儲存到資料庫用的相對路徑</returns>
        public static string SaveCoverImageAndGetRelativePath(string sourcePath, long ebookID)
        {
            // 取得圖片副檔名（如 .jpg、.png）
            string ext = Path.GetExtension(sourcePath);

            // 組成統一命名檔名：例如 cover_1001.jpg
            string fileName = $"cover_{ebookID}{ext}";

            // 目的資料夾：eBook\eBookFiles\eBookCover
            string destFolder = Path.Combine(Application.StartupPath, "eBook", "eBookFiles", "eBookCover");

            // 若資料夾不存在則自動建立
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            // 組出完整目的檔案路徑
            string destPath = Path.Combine(destFolder, fileName);

            // 將圖片複製到目的地，若已存在則覆蓋
            File.Copy(sourcePath, destPath, true);

            // 回傳相對路徑，方便資料庫記錄與讀取
            return Path.Combine("eBook", "eBookFiles", "eBookCover", fileName);
        }


        // 此函式根據 ebookID 從資料庫讀取 cover1 欄位的圖片資料，顯示到 PictureBox 上
        public static void LoadImageFromDatabaseToPictureBox(long ebookID, PictureBox pictureBox, SqlConnection conn)
        {
            // 撰寫 SQL 指令，選出對應電子書的封面圖（cover1）
            string sql = "SELECT cover1 FROM eBookMain WHERE ebookID = @id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // 傳入電子書主鍵參數
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = ebookID;

                // 取得圖片 byte 陣列
                byte[] imageBytes = (byte[])cmd.ExecuteScalar();

                // 如果圖片有資料
                if (imageBytes != null)
                {
                    // 建立 MemoryStream 並讀入圖片
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        // 從記憶體資料建立 Image 並指定給 PictureBox 顯示
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // 若無圖片，則清空 PictureBox
                    pictureBox.Image = null;
                }
            }
        }

        /// <summary>
        /// 將圖片轉為 byte[] 並上傳到資料庫中的 eBookMain.cover1 欄位
        /// </summary>
        /// <param name="imagePath">圖片檔案完整路徑</param>
        /// <param name="ebookID">電子書ID</param>
        /// <param name="conn">已開啟的 SqlConnection 連線物件</param>
        public static void UploadCoverToDatabase(string imagePath, long ebookID, SqlConnection conn)
        {
            // 使用 File.ReadAllBytes 將圖片檔案整個讀進 byte 陣列
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            // SQL 語法：更新指定電子書的 cover1 欄位
            string sql = "UPDATE eBookMain SET cover1 = @img WHERE ebookID = @id";

            // 建立 SQL 指令並附帶參數
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // 傳入圖片資料
                cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value = imageBytes;

                // 傳入電子書主鍵 ID
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = ebookID;

                // 執行更新語法
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// ✅ 根據書名查詢資料庫並開啟電子書
        /// </summary>
        public static void OpenEbookByName(string ebookName)
        {
            try
            {
                string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";
                string relativePath = null;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // 模糊比對書名（可用 LIKE），此處用精確比對（你也可以自行改 LIKE）
                    string sql = "SELECT TOP 1 eBookPosition FROM eBookMainTable WHERE ebookName = @name";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", ebookName);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            relativePath = result.ToString();
                    }
                }

                if (!string.IsNullOrWhiteSpace(relativePath))
                    OpenEbookFromRelativePath(relativePath); // 開書
                else
                    MessageBox.Show("查無名為「" + ebookName + "」的電子書。", "查無結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("書名查詢錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //使用範例（完整流程：電子書＋封面上傳）

        //        // 選擇電子書檔案
        //        OpenFileDialog ofdBook = new OpenFileDialog();
        //        ofdBook.Filter = "電子書 (*.pdf;*.epub;*.txt)|*.pdf;*.epub;*.txt";

        //if (ofdBook.ShowDialog() == DialogResult.OK)
        //{
        //    // 儲存電子書並取得相對路徑
        //    string ebookRelativePath = SaveEbookToFilesAndGetRelativePath(ofdBook.FileName);
        //        MessageBox.Show("電子書已儲存於：" + ebookRelativePath);
        //    // ➜ 可儲存 ebookRelativePath 到資料庫欄位 eBookPosition
        //}

        //// 選擇封面圖檔案
        //OpenFileDialog ofdCover = new OpenFileDialog();
        //ofdCover.Filter = "圖片 (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

        //if (ofdCover.ShowDialog() == DialogResult.OK)
        //{
        //    // 儲存封面圖並取得相對路徑
        //    string coverRelativePath = SaveCoverImageAndGetRelativePath(ofdCover.FileName, 1001);
        //    MessageBox.Show("封面圖已儲存於：" + coverRelativePath);

        //    // 連接資料庫並將封面圖轉為 byte[] 存進 VARBINARY 欄位
        //    using (SqlConnection conn = new SqlConnection("your_connection_string"))
        //    {
        //        conn.Open();
        //        UploadCoverToDatabase(ofdCover.FileName, 1001, conn);
        //    conn.Close();
        //    }
    }







}

