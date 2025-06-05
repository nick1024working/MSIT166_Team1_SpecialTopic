using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    public partial class AdminBookManager : UserControl
    {
        // 會使用的 Service
        private BookService _bookService;

        private SortableBindingList<BookDto> _sortableList;

        public AdminBookManager(string connString)
        {
            // 建構服務
            _bookService = new BookService(connString);

            InitializeComponent();

            // 預設上下架狀態
            cbxIsActiveStatus.SelectedIndex = 0;

            // 先不顯示資料 lazy load
        }

        /// <summary>
        /// 載入所有書籍資料
        /// </summary>
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            var result = _bookService.GetAllBooks();
            if (result.IsSuccess)
            {
                RenewDgvMainDataSource(result.Value);
            }
            else
            {
                MessageBox.Show("提取資料失敗");
            }
        }

        /// <summary>
        /// 將指定清單重新綁定至 dgvMain，並套用格式設定
        /// </summary>
        private void RenewDgvMainDataSource(List<BookDto> books)
        {
            _sortableList = new SortableBindingList<BookDto>(books);
            dgvMain.DataSource = _sortableList;

            dgvMain.AutoGenerateColumns = true;
            dgvMain.AllowUserToAddRows = false;
            dgvMain.ReadOnly = true;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.MultiSelect = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// 點擊欄位排序
        /// </summary>
        private void dgvMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvMain.Columns[e.ColumnIndex].DataPropertyName;
            PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(BookDto))[columnName];

            var direction = ListSortDirection.Ascending;
            if (dgvMain.Tag is Tuple<string, ListSortDirection> lastSort &&
                lastSort.Item1 == columnName && lastSort.Item2 == ListSortDirection.Ascending)
            {
                direction = ListSortDirection.Descending;
            }

            _sortableList.ApplySort(prop, direction);
            dgvMain.Tag = Tuple.Create(columnName, direction);
        }

        /// <summary>
        /// 查詢
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                MessageBox.Show("請輸入正確!");
                return;
            }

            var result = _bookService.GetBookByIdAndNameKeyword(txbSearch.Text);
            if (result.IsSuccess)
            {
                RenewDgvMainDataSource(result.Value);
            }
            else
            {
                MessageBox.Show("查無結果");
            }

        }

        /// <summary>
        /// 更改上下架
        /// </summary>
        private void btnIsActive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbIsActiveId.Text))
            {
                MessageBox.Show("請輸入正確!");
                return;
            }

            if (!int.TryParse(txbIsActiveId.Text.Trim(), out int id))
            {
                MessageBox.Show("請輸入有效的整數 ID！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new BookIsActiveDto
            {
                BookID = id,
                IsActive = cbxIsActiveStatus.SelectedText == "上架" ? true : false
            }; 
            var result = _bookService.UpdateBookIsActive(dto);
            if (result.IsSuccess)
            {
                MessageBox.Show($"{cbxIsActiveStatus.SelectedText}成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }

        /// <summary>
        /// 刪除
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbDelete.Text))
            {
                MessageBox.Show("請輸入正確!");
                return;
            }

            if (!int.TryParse(txbDelete.Text.Trim(), out int id))
            {
                MessageBox.Show("請輸入有效的整數 ID！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _bookService.DeleteBookWithFilesByBookId(id);
            if (result.IsSuccess)
            {
                MessageBox.Show($"刪除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }
    }
}
