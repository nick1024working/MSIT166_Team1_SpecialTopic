using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Frontend.Views.Forms
{
    public partial class UserUpdateBookForm : Form
    {
        // 會使用的 Service
        private UserService _userService;
        private BookService _bookService;
        private TopicService _bookTopicService;

        // 在 flpDropZone 內拖曳排序用
        private PictureBox _draggedPictureBox;
        // 在 flpDropZone 內限制數量
        private const int MaxImageCount = 6;

        private BookDto _dto;

        public UserUpdateBookForm(BookDto dto, string connString)
        {
            // 建構服務
            _userService = new UserService(connString);
            _bookService = new BookService(connString);
            _bookTopicService = new TopicService(connString);

            _dto = dto;
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            txtBookName.Text = _dto.BookName;
            numSalePrice.Value = _dto.SalePrice;

            // combobox 通常要先確保值存在於 Items 中才可設定 SelectedItem 或 SelectedValue
            if (cboBookCondition.Items.Contains(_dto.BookCondition))
                cboBookCondition.SelectedItem = _dto.BookCondition;
            else
                cboBookCondition.SelectedIndex = -1;

            txtDescription.Text = _dto.Description;
            txtISBN.Text = _dto.ISBN;

            if (cboLanguage.Items.Contains(_dto.Language))
                cboLanguage.SelectedItem = _dto.Language;
            else
                cboLanguage.SelectedIndex = -1;

            txtAuthors.Text = _dto.Authors;
            txtPublisher.Text = _dto.Publisher;
            dtpPublicationDate.Value = DateTime.Parse(_dto.PublicationDate);

            chkIsActive.Checked = _dto.IsActive;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = _bookService.DeleteBookWithFilesByBookId(_dto.BookID);
            if (result.IsSuccess)
            {
                MessageBox.Show($"書籍刪除成功！");
            }
            else
            {
                MessageBox.Show($"發生錯誤：{result.ErrorMessage}");
            }
        }
    }
}
