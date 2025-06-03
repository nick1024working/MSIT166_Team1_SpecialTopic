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

            if (File.Exists(dto.ImagePath))
            {
                pbxCover.Image = Image.FromFile(dto.ImagePath);
            }
            else
            {
                pbxCover.Image = null;
            }
        }
    }
}
