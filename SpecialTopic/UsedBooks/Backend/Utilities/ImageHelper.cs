using System;
using System.Drawing;
using System.IO;

namespace SpecialTopic.UsedBooks.Backend.Utilities
{
    public static class ImageHelper
    {
        /// <summary>
        /// 相對於 BaseDirectory 的圖片根目錄
        /// </summary>
        public static string DefaultRelativeBookImageFolderPath = Path.Combine("UsedBooks", "Frontend", "Assets", "BookImages");

        /// <summary>
        /// 完整實體路徑
        /// </summary>
        public static string DefaultAbsluteBookImageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            DefaultRelativeBookImageFolderPath);

        /// <summary>
        /// 預設圖片路徑（用於沒上傳時）
        /// </summary>
        public static string DefaultBookImageFilePath = Path.Combine(DefaultAbsluteBookImageFolderPath,"default.jpg");

        /// <summary>
        /// 檢查 imagePath 是否為本機真實圖片路徑，若不存在則回傳 default.jpg。
        /// Cloud 路徑則直接返回。
        /// </summary>
        /// <param name="imagePath">資料庫存的路徑或網址</param>
        /// <returns>安全可用的圖片路徑</returns>
        public static string GetSafeImagePath(string imagePath)
        {
            // 空值處理 → fallback
            if (string.IsNullOrEmpty(imagePath))
                return DefaultBookImageFilePath;

            // 網路圖片直接返回
            if (Uri.IsWellFormedUriString(imagePath, UriKind.Absolute) &&
                (imagePath.StartsWith("http://") || imagePath.StartsWith("https://")))
                return imagePath;

            // 把資料庫存的相對路徑（可能是 "UsedBooks/Frontend/Assets/BookImages/xxx.jpg"）
            // 換成完整硬碟路徑
            string result = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "UsedBooks", "Frontend", "Assets", "BookImages", "default.jpg");

            // local → 組合完整路徑
            var fullLocalPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);

            // 檢查檔案是否存在，不存在則用 default
            return File.Exists(fullLocalPath) ? fullLocalPath : DefaultBookImageFilePath;
        }

        /// <summary>
        /// 從檔案路徑讀取圖片並縮小為指定尺寸（記憶體安全）
        /// </summary>
        public static Image LoadImageToMemoryWithResize(string path, int targetWidth, int targetHeight)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var original = Image.FromStream(fs))
            {
                var resized = new Bitmap(targetWidth, targetHeight);
                using (var g = Graphics.FromImage(resized))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(original, 0, 0, targetWidth, targetHeight);
                }
                return resized;
            }
        }


        /// <summary>
        /// 把指定路徑照片讀進記憶體
        /// </summary>
        public static Image LoadImageToMemory(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                return Image.FromStream(new MemoryStream(ms.ToArray())); // clone
            }
        }
    }
}