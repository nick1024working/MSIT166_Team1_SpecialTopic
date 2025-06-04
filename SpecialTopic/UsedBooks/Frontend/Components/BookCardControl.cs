using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;

namespace SpecialTopic.UsedBooks.Frontend.Components
{
    public partial class BookCardControl : UserControl
    {
        public BookCardControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 使用 BookCardDto 設置資料
        /// </summary>
        public void SetData(BookCardDto dto)
        {
            lblTitle.Text = dto.BookName;
            lblAuthors.Text = dto.Authors;
            lblDescription.Text = dto.Description;
            lblPrice.Text = dto.SalePrice.ToString();

            Image image = null;
            string imagePathToLoad = dto.ImagePath;

            // 網路圖片
            if (Uri.IsWellFormedUriString(imagePathToLoad, UriKind.Absolute) &&
                (imagePathToLoad.StartsWith("http://") || imagePathToLoad.StartsWith("https://")))
            {
                using (var client = new System.Net.WebClient())
                {
                    var bytes = client.DownloadData(imagePathToLoad);
                    using (var ms = new MemoryStream(bytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }
            }
            // 本機圖片
            else if (File.Exists(imagePathToLoad))
            {
                image = Image.FromFile(imagePathToLoad);
            }

            pbxCover.Image = image;
        }
    }
}
