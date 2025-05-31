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
                loadBook();
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

                string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True;";
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

        private void loadBook()
        {
            // 建立資料表
            DataTable dt = new DataTable();

            // 定義資料庫連線字串
            string connStr = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // 開啟資料庫連線
                conn.Open();

                // 撈出電子書的基本欄位資料（你也可以加入更多欄位）
                string sql = @"
            SELECT ebookID, ebookName, author, eBookClass1, fixedPrice, actualPrice
            FROM eBookMainTable
        ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt); // 把資料填入 dt 資料表
            }

            // 資料繫結到 DataGridView
            dataGridView1.DataSource = dt;

            // 自動調整欄寬
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnOpenSelectedBook_Click(object sender, EventArgs e)
        {
            // 確保目前有選取的行
            if (dataGridView1.CurrentRow != null)
            {
                // 取得目前行的 ebookID 欄位資料
                object idObj = dataGridView1.CurrentRow.Cells["ebookID"].Value;

                // 嘗試轉換為 long 型別
                if (long.TryParse(idObj.ToString(), out long ebookId))
                {
                    // 呼叫你定義的共用函式來開啟電子書
                    GptExampleClass.OpenEbookByID(ebookId);
                }
                else
                {
                    MessageBox.Show("選取的電子書 ID 無效！");
                }
            }
            else
            {
                MessageBox.Show("請先選取一本電子書！");
            }
        }

        private void EBookControl_Load(object sender, EventArgs e)
        {
            loadBook();
        }
    }
}
