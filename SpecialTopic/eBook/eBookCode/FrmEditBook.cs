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
            this.Validate();
            this.eBookMainTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamA_ProjectDataSet);

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
    }



}