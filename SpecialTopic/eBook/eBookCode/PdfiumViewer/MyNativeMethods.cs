using System;

using System.IO;

using System.Runtime.InteropServices;



namespace SpecialTopic.eBook.eBookCode.PdfiumViewer
{
    public static class MyNativeMethods
    {
        
        /// <summary>
        /// 精簡版 NativeMethods，用來根據平台載入 pdfium.dll。
        /// 僅支援 AnyCPU 模式，不相依於 PdfiumViewer 原始複雜結構。
        /// </summary>
        
            [DllImport("kernel32", SetLastError = true)]
            private static extern IntPtr LoadLibrary(string lpFileName);

            /// <summary>
            /// 根據目前平台載入對應的 pdfium.dll
            /// </summary>
            public static void LoadPdfium()
            {
                // 判斷目前是否為 64 位元行程
                string architecture = Environment.Is64BitProcess ? "x64" : "x86";

                // 預期檔案放在 bin\x86 或 bin\x64 資料夾
                string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, architecture, "pdfium.dll");

                if (!File.Exists(dllPath))
                {
                    throw new FileNotFoundException($"❌ 找不到對應平台的 pdfium.dll：{dllPath}");
                }

                // 載入 pdfium.dll
                IntPtr result = LoadLibrary(dllPath);

                if (result == IntPtr.Zero)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Exception($"❌ 載入 pdfium.dll 失敗。錯誤碼：{errorCode}");
                }
            }
        }
    }
