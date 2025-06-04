using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    public partial class UserBookManager : UserControl
    {
        // 會使用的 Service
        private UserService _userService;
        private BookService _bookService;

        // 在 flpDropZone 內拖曳排序用
        private PictureBox _draggedPictureBox;
        // 在 flpDropZone 內限制數量
        private const int MaxImageCount = 6;

        public UserBookManager(string connString)
        {

            // 建構服務
            _userService = new UserService(connString);
            _bookService = new BookService(connString);

            InitializeComponent();
            InitDropZone();
        }

        /// <summary>
        /// 釋放資源
        /// </summary>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            ClearFlpDropZone();
        }

        private void ClearFlpDropZone()
        {
            foreach (Control ctrl in flpDropZone.Controls)
            {
                if (ctrl is PictureBox pb)
                {
                    pb.Image?.Dispose();
                    pb.Image = null;
                }
            }
            flpDropZone.Controls.Clear(); // 可選：清空容器
        }


        #region DropZone代碼

        private void InitDropZone()
        {
            flpDropZone.AllowDrop = true;
            flpDropZone.DragEnter += flpDropZone_DragEnter;
            flpDropZone.DragDrop += flpDropZone_DragDrop;
        }

        private void flpDropZone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void flpDropZone_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            int currentCount = flpDropZone.Controls.Count;

            foreach (var file in files)
            {
                if (currentCount >= MaxImageCount)
                {
                    MessageBox.Show($"最多只能上傳 {MaxImageCount} 張圖片！");
                    break;
                }

                var ext = Path.GetExtension(file).ToLower();
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    CreatePictureBox(file);
                }
            }
        }


        private void CreatePictureBox(string imagePath)
        {
            var pb = new PictureBox
            {
                Image = ImageHelper.LoadImageToMemoryWithResize(imagePath, 210, 315),   // HACK: 呼叫後端方法
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 210,
                Height = 315,
                Margin = new Padding(5), 
                Tag = Path.GetExtension(imagePath).ToLower() // 取得副檔名
            };

            // 拖曳起點
            pb.MouseDown += (s, e) =>
            {
                _draggedPictureBox = (PictureBox)s;
                DoDragDrop(_draggedPictureBox, DragDropEffects.Move);
            };

            // 接受拖曳進來
            pb.AllowDrop = true;

            pb.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(typeof(PictureBox)))
                    e.Effect = DragDropEffects.Move;
            };

            pb.DragDrop += (s, e) =>
            {
                var target = (PictureBox)s;
                if (_draggedPictureBox != null && target != _draggedPictureBox)
                {
                    int targetIndex = flpDropZone.Controls.GetChildIndex(target);
                    flpDropZone.Controls.SetChildIndex(_draggedPictureBox, targetIndex);
                    flpDropZone.Invalidate();
                }
            };

            flpDropZone.Controls.Add(pb);
        }

        /// <summary>
        /// 取得flpDropZone中有序圖片 List<CreateBookImageDto>
        /// </summary>
        private List<CreateBookImageDto> GetCurrentImageList()
        {
            var result = new List<CreateBookImageDto>();
            for (int i = 0; i < flpDropZone.Controls.Count; ++i)
            {
                if (flpDropZone.Controls[i] is PictureBox pb && pb.Image != null)
                {
                    result.Add(new CreateBookImageDto
                    {
                        BookImage = pb.Image,
                        Ext = pb.Tag as string ?? ".jpg", // 預設副檔名
                        ImageIndex = i
                    });
                }
            }
            return result;
        }

        #endregion



        private bool ValidateBookForm()
        {
            // 書名不得為空
            if (string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                MessageBox.Show("請輸入書名！");
                return false;
            }

            // 價格必須大於 0（假設最小值不能是 0）
            if (numSalePrice.Value <= 0)
            {
                MessageBox.Show("價格必須大於 0！");
                return false;
            }

            // 出版日不得為未來
            if (dtpPublicationDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("出版日不能是未來！");
                return false;
            }

            // 若都通過
            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateBookForm())
            {
                return;
            }

            var bookDto = new CreateBookDto
            {
                BookName = txtBookName.Text.Trim(),
                SalePrice = numSalePrice.Value,
                BookCondition = cboBookCondition.SelectedItem?.ToString() ?? string.Empty,
                Description = txtDescription.Text.Trim(),
                ISBN = txtISBN.Text.Trim(),
                Language = cboLanguage.SelectedItem?.ToString() ?? string.Empty,
                Authors = txtAuthors.Text.Trim(),
                Publisher = txtPublisher.Text.Trim(),
                PublicationDate = dtpPublicationDate.Value,
                IsActive = chkIsActive.Checked
            };

            try
            {
                bookDto.UID = _userService.GetRandomUserId().Value;     // HACK: 隨機
            }
            catch
            {
                MessageBox.Show("無法使用隨機UID");
                return;
            }

            var result = _bookService.CreateBook(bookDto, GetCurrentImageList());

            if (result.IsSuccess)
            {
                MessageBox.Show($"書籍新增成功！\nBookId = {result.Value}");

                // 清空圖片
                ClearFlpDropZone();

                // 清空輸入欄位
                txtBookName.Clear();
                numSalePrice.Value = numSalePrice.Minimum;
                cboBookCondition.SelectedIndex = -1;
                txtDescription.Clear();
                txtISBN.Clear();
                cboLanguage.SelectedIndex = -1;
                txtAuthors.Clear();
                txtPublisher.Clear();
                dtpPublicationDate.Value = DateTime.Today;
                chkIsActive.Checked = true;
            }
            else
            {
                MessageBox.Show($"發生錯誤：{result.ErrorMessage}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 清空圖片
            ClearFlpDropZone();
        }
    }
}
