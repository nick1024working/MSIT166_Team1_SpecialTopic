using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Frontend.Shared;
using SpecialTopic.UsedBooks.Backend.Utilities;
using SpecialTopic.UsedBooks.Frontend.Views.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    public partial class UserBookManager : UserControl
    {
        // HACK: 避開DI
        private string _connString;

        // 會使用的 Service
        private BookService _bookService;

        private Guid _userId;

        private SortableBindingList<BookDto> _sortableList;

        /// <summary>
        /// 給該使用者書籍 ComboBox 做的類別
        /// </summary>
        internal class ComboBoxItem<T>
        {
            public T Value { get; set; }
            public string Text { get; set; }
        }

        public UserBookManager(string connString)
        {
            // HACK: 避開DI
            _connString = connString;

            // 建構服務
            _bookService = new BookService(connString);

            InitializeComponent();

            LoadData();
        }

        void LoadData()
        {
            // 取得 UID
            if (AppSession.Current.UID.HasValue)
            {
                _userId = AppSession.Current.UID.Value;
            }
            else
            {
                MessageBox.Show("尚未登入，無法執行此操作。");
                return;
            }

            // 查詢書籍列表
            var result = _bookService.GetBooksByUserId(_userId);
            if (result.IsSuccess)
            {
                // 載入 dgv
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var dto = dgvMain.CurrentRow?.DataBoundItem as BookDto;
            if (dto != null)
            {
                var updateBookForm = new UserUpdateBookForm(dto, _connString);
                updateBookForm.Show();
            }
            else
            {
                MessageBox.Show("無法取得資料！");
            }
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            lblBookName.Text = dgvMain.CurrentRow.Cells["BookName"].Value?.ToString();
        }
    }
}
