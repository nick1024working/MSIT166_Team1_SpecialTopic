using System.IO;
using System;

namespace SpecialTopic.UsedBooks.Backend.Utilities
{
    public static class ImagePathHelper
    {
        public static string GetFullImagePath(string dbPath)
        {
            if (string.IsNullOrWhiteSpace(dbPath))
            {
                // 預設圖檔路徑
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsedBooks", "Frontend", "Assets", "BookImages", "default.jpg");
            }

            // 把資料庫存的相對路徑（可能是 "UsedBooks/Frontend/Assets/BookImages/xxx.jpg"）
            // 換成完整硬碟路徑
            var fixedPath = dbPath.Replace("/", "\\"); // 保險換成 Windows 路徑格式
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fixedPath);
        }
    }
}
