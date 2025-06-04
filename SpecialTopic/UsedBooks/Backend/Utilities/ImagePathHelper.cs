using System;
using System.IO;

namespace SpecialTopic.UsedBooks.Backend.Utilities
{
    public static class ImagePathHelper
    {
        private static string DefaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "UsedBooks", "Frontend", "Assets", "BookImages", "default.jpg");

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
            {
                return null;
            }

            // 網路圖片直接返回
            if (Uri.IsWellFormedUriString(imagePath, UriKind.Absolute) &&
                (imagePath.StartsWith("http://") || imagePath.StartsWith("https://")))
            {
                return imagePath;
            }

            // 把資料庫存的相對路徑（可能是 "UsedBooks/Frontend/Assets/BookImages/xxx.jpg"）
            // 換成完整硬碟路徑
            string result = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "UsedBooks", "Frontend", "Assets", "BookImages", "default.jpg");

            // local → 組合完整路徑
            var fullLocalPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);

            // 檢查檔案是否存在，不存在則用 default
            return File.Exists(fullLocalPath) ? fullLocalPath : DefaultImagePath;
        }
    }
}