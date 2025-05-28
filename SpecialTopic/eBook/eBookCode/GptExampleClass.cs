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
        /// 將使用者選擇的電子書檔案複製到「eBook\eBookFiles」資料夾，並回傳相對路徑（儲存至資料庫用）
        /// </summary>
        /// <param name="sourcePath">使用者選取的檔案完整路徑</param>
        /// <returns>相對路徑（例如：eBook\eBookFiles\xxx.pdf）</returns>
        public static string SaveEbookToFilesAndGetRelativePath(string sourcePath)
        {
            // 取得檔名（例如 MyBook.pdf）
            string fileName = Path.GetFileName(sourcePath);

            // 將目的資料夾設定為執行目錄下的 "eBook\eBookFiles"
            string destFolder = Path.Combine(Application.StartupPath, "eBook", "eBookFiles");

            // 若資料夾尚不存在，則建立它（包含上層目錄）
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            // 組出完整儲存目的檔案路徑
            string destPath = Path.Combine(destFolder, fileName);

            // 複製檔案到目的地，若已存在則覆蓋
            File.Copy(sourcePath, destPath, true);

            // 回傳相對路徑（儲存進資料庫，例如：eBook\eBookFiles\MyBook.pdf）
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






    }
}
