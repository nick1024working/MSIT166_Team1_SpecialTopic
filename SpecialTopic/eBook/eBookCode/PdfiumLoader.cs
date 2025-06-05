//using System;
//using System.IO;
//using System.Runtime.InteropServices;

//namespace SpecialTopic.eBook.eBookCode
//{
//    /// <summary>
//    /// 這個類別負責根據目前執行環境 (x86/x64)，自動載入對應版本的 pdfium.dll
//    /// </summary>
//    public static class PdfiumLoader
//    {
//        // 引入 Windows API 的 LoadLibrary 方法
//        [DllImport("kernel32", SetLastError = true)]
//        private static extern IntPtr LoadLibrary(string lpFileName);

//        /// <summary>
//        /// 根據執行平台 (x64 or x86)，載入對應的 pdfium.dll
//        /// </summary>
//        public static void LoadCorrectPdfium()
//        {
//            // ✅ 1. 判斷執行環境是 64 位元還是 32 位元（AnyCPU 可用）
//            string archFolder = Environment.Is64BitProcess ? "x64" : "x86";

//            // ✅ 2. 組合出完整的 pdfium.dll 路徑
//            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, archFolder, "pdfium.dll");

//            // ✅ 3. 檢查該檔案是否存在，若無 → 拋出錯誤
//            if (!File.Exists(dllPath))
//            {
//                throw new FileNotFoundException($"❌ 找不到對應平台的 pdfium.dll：{dllPath}");
//            }

//            // ✅ 4. 使用 Windows API 嘗試載入 pdfium.dll
//            IntPtr handle = LoadLibrary(dllPath);

//            // ✅ 5. 載入失敗 → 拋出錯誤 + 系統錯誤碼
//            if (handle == IntPtr.Zero)
//            {
//                int error = Marshal.GetLastWin32Error();
//                throw new Exception($"❌ 無法載入 pdfium.dll（{dllPath}），錯誤碼：{error}");
//            }

//            // ✅ 6. 成功載入 → 可以呼叫 PDFium 相關函式
//        }
//    }
//}


// ✅ PdfiumLoader.cs
// 功能：自動根據平台載入對應的 pdfium.dll，支援 AnyCPU，避免 x86 / x64 混亂
//using System;
//using System.IO;
//using System.Runtime.InteropServices;

//namespace SpecialTopic.eBook.eBookCode
//{
//    public static class PdfiumLoader
//    {
//        [DllImport("kernel32", SetLastError = true)]
//        private static extern IntPtr LoadLibrary(string lpFileName);

//        public static void LoadCorrectPdfium()
//        {
//            string archFolder = Environment.Is64BitProcess ? "x64" : "x86";
//            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, archFolder, "pdfium.dll");

//            if (!File.Exists(dllPath))
//            {
//                throw new FileNotFoundException($"❌ 找不到 pdfium.dll：{dllPath}");
//            }

//            IntPtr handle = LoadLibrary(dllPath);
//            if (handle == IntPtr.Zero)
//            {
//                int errCode = Marshal.GetLastWin32Error();
//                throw new Exception($"❌ 無法載入 pdfium.dll（錯誤碼：{errCode}）");
//            }
//        }
//    }
//}

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SpecialTopic.eBook.eBookCode
{
    public static class PdfiumLoader
    {
        [DllImport("kernel32", SetLastError = true)]
        private static extern IntPtr LoadLibrary(string dllToLoad);

        public static void LoadCorrectPdfium()
        {
            // 根據目前是 x64 或 x86，載入對應資料夾裡的 pdfium.dll
            string arch = Environment.Is64BitProcess ? "x64" : "x86";
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dllPath = Path.Combine(basePath, arch, "pdfium.dll");

            if (!File.Exists(dllPath))
            {
                throw new FileNotFoundException($"❌ 找不到 pdfium.dll：{dllPath}");
            }

            IntPtr handle = LoadLibrary(dllPath);

            if (handle == IntPtr.Zero)
            {
                int error = Marshal.GetLastWin32Error();
                throw new Exception($"❌ 載入 pdfium.dll 失敗，錯誤碼：{error}");
            }
        }
    }
}


