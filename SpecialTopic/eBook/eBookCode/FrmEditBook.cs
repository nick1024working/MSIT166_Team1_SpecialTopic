using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialTopic.eBook.eBookCode
{
    public partial class FrmEditBook : Form
    {
        private long _selectedEbookID; // 👉 加在這裡！

        public FrmEditBook()
        {
            InitializeComponent();
        }
        public FrmEditBook(long ebookID)
        {
            InitializeComponent();
            _selectedEbookID = ebookID;
        }

        private void eBookMainTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eBookMainTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);

        }

        private void eBookMainTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //this.Validate();
            //this.eBookMainTableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);

            this.Validate(); // 確保 TextBox 中內容會被寫入 BindingSource

            // 嘗試取得目前的資料列
            if (eBookMainTableBindingSource.Current is DataRowView row)
            {
                // 驗證必要欄位（不可為 null）
                List<string> errors = new List<string>();

                // 檢查 publishedDate 欄位
                if (string.IsNullOrWhiteSpace(txtPublishedDateOverride.Text))
                {
                    // 使用 DateTimePicker 的值
                    row["publishedDate"] = publishedDateDateTimePicker.Value.Date;
                }
                else
                {
                    // 嘗試解析 txtPublishedDateOverride 的內容
                    if (DateTime.TryParse(txtPublishedDateOverride.Text.Trim(), out DateTime overrideDate))
                    {
                        row["publishedDate"] = overrideDate.Date;
                    }
                    else
                    {
                        MessageBox.Show("❌ 請輸入正確的日期格式（yyyy-MM-dd）", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                void CheckRequired(string fieldName, string fieldDisplayName)
                {
                    if (row[fieldName] == DBNull.Value || string.IsNullOrWhiteSpace(row[fieldName]?.ToString()))
                        errors.Add($"【{fieldDisplayName}】不可空白");
                }

                CheckRequired("ebookName", "電子書名稱");
                CheckRequired("eBookClass1", "主要分類");
                CheckRequired("eBookClass2", "次要分類");
                CheckRequired("author", "作者");
                CheckRequired("cEpisode", "本書目前集數");
                CheckRequired("TotalEpisode", "系列書總集數");
                CheckRequired("eBookPosition", "電子書檔案路徑");
                CheckRequired("eBookDataType", "電子書檔案格式");
                CheckRequired("fixedPrice", "定價");
                CheckRequired("weeksales", "周銷量");
                CheckRequired("monthsales", "月銷量");
                CheckRequired("totalsales", "總銷量");
                CheckRequired("weekviews", "周閱覽數");
                CheckRequired("monthviews", "月閱覽數");
                CheckRequired("totalviews", "總閱覽數");
                CheckRequired("maturityRating", "分級");
                CheckRequired("isAvailable", "是否上架");

                // 如果有錯誤就提示，並中止儲存
                if (errors.Count > 0)
                {
                    string allErrors = string.Join("\n", errors);
                    MessageBox.Show($"❌ 儲存失敗，請補齊以下欄位：\n{allErrors}", "資料不完整", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    this.eBookMainTableBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);
                    MessageBox.Show("✅ 電子書資料儲存成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ 儲存失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private bool ValidateCurrentEBookRow()
        {
            if (eBookMainTableBindingSource.Current == null) return false;

            DataRowView row = (DataRowView)eBookMainTableBindingSource.Current;

            List<string> errors = new List<string>();

            // ✅ 檢查所有不允許為 NULL 的欄位
            if (string.IsNullOrWhiteSpace(row["ebookName"]?.ToString()))
                errors.Add("書名不能為空");
            if (string.IsNullOrWhiteSpace(row["author"]?.ToString()))
                errors.Add("作者不能為空");
            if (string.IsNullOrWhiteSpace(row["eBookClass1"]?.ToString()))
                errors.Add("主分類不能為空");
            if (string.IsNullOrWhiteSpace(row["eBookPosition"]?.ToString()))
                errors.Add("檔案路徑不能為空");

            // ✅ 可選：檢查金額是否為正數
            if (!decimal.TryParse(row["fixedPrice"]?.ToString(), out decimal fixedPrice) || fixedPrice < 0)
                errors.Add("定價格式錯誤或為負數");
            if (!decimal.TryParse(row["actualPrice"]?.ToString(), out decimal actualPrice) || actualPrice < 0)
                errors.Add("實售價格式錯誤或為負數");

            if (errors.Count > 0)
            {
                string msg = "⚠ 無法儲存，請修正以下錯誤：\n\n" + string.Join("\n", errors);
                MessageBox.Show(msg, "資料驗證失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void FrmEditBook_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'teamA_ProjectDataSet.eBookMainTable' 資料表。您可以視需要進行移動或移除。
            this.eBookMainTableTableAdapter.Fill(this.teamA_ProjectDataSet.eBookMainTable);



            // 👉 加上這段：讓 BindingSource 自動跳到 ebookID 對應的那一筆
            foreach (DataRowView row in eBookMainTableBindingSource)
            {
                if (row["ebookID"] != DBNull.Value && Convert.ToInt64(row["ebookID"]) == _selectedEbookID)
                {
                    eBookMainTableBindingSource.Position = eBookMainTableBindingSource.IndexOf(row);
                    break;
                }
            }

            decimal price;
            if (decimal.TryParse(fixedPriceTextBox.Text, out price))
                fixedPriceTextBox.Text = price.ToString("0");
            if (decimal.TryParse(actualPriceTextBox.Text, out price))
                actualPriceTextBox.Text = price.ToString("0");
            if (decimal.TryParse(discountTextBox.Text, out price))
                discountTextBox.Text = price.ToString("0");

        }

        private void cover1PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover1PictureBox.Image = Image.FromFile(ofd.FileName);

                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }


        }

        private void cover2PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover2PictureBox.Image = Image.FromFile(ofd.FileName);

                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }
        }

        private void cover3PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover3PictureBox.Image = Image.FromFile(ofd.FileName);

                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }
        }

        private void cover4PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover4PictureBox.Image = Image.FromFile(ofd.FileName);
                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }
        }

        private void cover5PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover5PictureBox.Image = Image.FromFile(ofd.FileName);

                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }

        }

        private void cover6PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover6PictureBox.Image = Image.FromFile(ofd.FileName);

                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }
        }

        private void cover7PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover7PictureBox.Image = Image.FromFile(ofd.FileName);

                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }
        }

        private void cover8PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover8PictureBox.Image = Image.FromFile(ofd.FileName);

                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }
        }

        private void cover9PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇封面圖片";
                ofd.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 將圖片載入 PictureBox 顯示
                    cover9PictureBox.Image = Image.FromFile(ofd.FileName);

                    // 把圖片存成 byte[] 並塞回 BindingSource（寫入 DataSet）
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                    DataRowView currentRow = (DataRowView)eBookMainTableBindingSource.Current;
                    currentRow["cover1"] = imgBytes;
                }
            }
        }

        private void eBookPositionTextBox_DoubleClick(object sender, EventArgs e)
        {
            // 建立檔案選擇視窗
            OpenFileDialog ofd = new OpenFileDialog();

            // 設定可接受的檔案類型（只顯示 PDF）
            ofd.Filter = "PDF 檔案 (*.pdf)|*.pdf";

            // 設定初始資料夾，例如專案根目錄
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // 取得使用者選的絕對檔案路徑
                string selectedFullPath = ofd.FileName;

                // 目標相對資料夾（專案執行資料夾下的 eBookFiles）
                string relativeFolder = "eBookFiles";
                string destFolder = Path.Combine(Application.StartupPath, relativeFolder);

                // 確保目標資料夾存在
                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }

                // 檔名部分（ex: book1.pdf）
                string fileName = Path.GetFileName(selectedFullPath);

                // 複製檔案到目標資料夾
                string destPath = Path.Combine(destFolder, fileName);

                // ✅ 新增：判斷來源與目標路徑是否相同（避免無謂複製或死循環）
                bool isSamePath = string.Equals(
                    Path.GetFullPath(selectedFullPath),
                    Path.GetFullPath(destPath),
                    StringComparison.OrdinalIgnoreCase);

                // 如果不是相同路徑，就執行複製（避免複製自己到自己造成異常）
                if (!isSamePath)
                {
                    File.Copy(selectedFullPath, destPath, true); // 覆蓋已存在的
                }

                // 相對路徑存入 TextBox，例如：eBookFiles\book1.pdf
                string relativePath = Path.Combine(relativeFolder, fileName);
                eBookPositionTextBox.Text = relativePath;
            }
        }
    }



}