using SpecialTopic.eBook.eBookCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialTopic
{
    public partial class EBookControl : UserControl
    {
        public EBookControl()
        {
            InitializeComponent();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            // 1. 讓使用者選 Excel 檔
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel 檔案 (*.xlsx)|*.xlsx";
            ofd.Title = "請選擇匯入用 Excel 檔案";
            if (ofd.ShowDialog() != DialogResult.OK)
                return; // 使用者取消
            string excelPath = ofd.FileName;

            // 2. 讓使用者選 PDF 原始資料夾
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "請選擇原始 PDF 電子書資料夾";
            if (fbd.ShowDialog() != DialogResult.OK)
                return; // 使用者取消
            string pdfSourceFolder = fbd.SelectedPath;

            gptEbookImporter gEImp= new gptEbookImporter();
            try
            {
                // 3. 呼叫匯入函式
                gEImp.ImportFromExcel(excelPath, pdfSourceFolder);
                MessageBox.Show("匯入成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("匯入失敗：" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 假設你要開啟 ebookID = 1001 的書，或之後從 DataGridView 選取也可改寫成動態
                long ebookID = 1;

                string connStr = "Data Source=DESKTOP-I9APTSS;Initial Catalog=TeamA_Project;Integrated Security=True;";
                string relativePath = null;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT eBookPosition FROM eBookMainTable WHERE ebookID = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", ebookID);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        relativePath = result.ToString();
                    }
                }

                if (!string.IsNullOrWhiteSpace(relativePath))
                {
                    // 開啟電子書
                    GptExampleClass.OpenEbookFromRelativePath(relativePath);
                }
                else
                {
                    MessageBox.Show("查無指定電子書的檔案路徑！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message);
            }
        }
    }
}
