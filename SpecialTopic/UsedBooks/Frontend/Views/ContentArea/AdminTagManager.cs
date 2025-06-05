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
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    public partial class AdminTagManager : UserControl
    {
        // 會使用的 Service
        private SaleTagService _saleTagService;
        private BookService _bookService;

        private SortableBindingList<SaleTagDto> _sortableList1;
        private SortableBindingList<BookWithSaleTagDto> _sortableList2;

        public AdminTagManager(string connString)
        {
            // 建構服務
            _saleTagService = new SaleTagService(connString);
            _bookService = new BookService(connString);

            InitializeComponent();

            // 顯示資料
            LoadDgvTags();
        }

        /// <summary>
        /// 把促銷標籤資料載入 dgvTags
        /// </summary>
        private void LoadDgvTags()
        {
            var result = _saleTagService.GetAllSaleTags();
            if (result.IsSuccess)
            {
                _sortableList1 = new SortableBindingList<SaleTagDto>(result.Value);
                dgvTags.DataSource = _sortableList1;

                dgvTags.AutoGenerateColumns = true;
                dgvTags.AllowUserToAddRows = false;
                dgvTags.ReadOnly = true;
                dgvTags.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTags.MultiSelect = false;
                dgvTags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                MessageBox.Show("提取資料失敗");
            }
        }

        /// <summary>
        /// 把促銷標籤資料載入 dgvTags
        /// </summary>
        private void LoadDgvBookTagsByTagId(int tagId)
        {
            var result = _bookService.GetBookBySaleTagId(tagId);
            if (result.IsSuccess)
            {
                _sortableList2 = new SortableBindingList<BookWithSaleTagDto>(result.Value);
                dgvBookTags.DataSource = _sortableList2;

                dgvBookTags.AutoGenerateColumns = true;
                dgvBookTags.AllowUserToAddRows = false;
                dgvBookTags.ReadOnly = true;
                dgvBookTags.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBookTags.MultiSelect = false;
                dgvBookTags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                MessageBox.Show("提取資料失敗");
            }
        }

        /// <summary>
        /// ChatGPT 生成，支援點擊欄位自動排序
        /// </summary>
        private void dgvTags_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvTags.Columns[e.ColumnIndex].DataPropertyName;
            PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(TopicDto))[columnName];

            ListSortDirection direction = ListSortDirection.Ascending;
            if (dgvTags.Tag is Tuple<string, ListSortDirection> lastSort &&
                lastSort.Item1 == columnName && lastSort.Item2 == ListSortDirection.Ascending)
            {
                direction = ListSortDirection.Descending;
            }

            _sortableList1.ApplySort(prop, direction);
            dgvTags.Tag = Tuple.Create(columnName, direction);
        }
        private void dgvBookTags_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvTags.Columns[e.ColumnIndex].DataPropertyName;
            PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(TopicDto))[columnName];

            ListSortDirection direction = ListSortDirection.Ascending;
            if (dgvTags.Tag is Tuple<string, ListSortDirection> lastSort &&
                lastSort.Item1 == columnName && lastSort.Item2 == ListSortDirection.Ascending)
            {
                direction = ListSortDirection.Descending;
            }

            _sortableList2.ApplySort(prop, direction);
            dgvTags.Tag = Tuple.Create(columnName, direction);
        }

        /// <summary>
        /// 新增
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbCreate.Text))
            {
                var dto = new CreateSaleTagDto { TagName = txbCreate.Text };
                var result = _saleTagService.CreateSaleTag(dto);
                if (result.IsSuccess)
                {
                    MessageBox.Show($"新增成功!\n名稱 = {txbCreate.Text}\nID = {result.Value}");
                    LoadDgvTags();
                }
                else
                {
                    MessageBox.Show("無法新增!");
                }
            }
            else
            {
                MessageBox.Show("請輸入正確!");
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

            var result = _saleTagService.DeleteSaleTagById(id);
            if (result.IsSuccess)
            {
                MessageBox.Show("刪除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvTags();
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }

        private void btnSetTagToBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSetBookId.Text))
            {
                MessageBox.Show("請輸入正確書本 ID !");
                return;
            }

            if (!int.TryParse(txbSetBookId.Text.Trim(), out int bookId))
            {
                MessageBox.Show("請輸入有效的整數書本 ID ！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txbSetTagId.Text))
            {
                MessageBox.Show("請輸入正確促銷標籤 ID !");
                return;
            }

            if (!int.TryParse(txbSetTagId.Text.Trim(), out int tagId))
            {
                MessageBox.Show("請輸入有效的整數促銷標籤 ID！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var dto = new CreateBookSaleTagDto
            {
                BookID = bookId,
                TagID = tagId
            };
            var result = _bookService.CreateBookSaleTagRelation(dto);
            if (result.IsSuccess)
            {
                MessageBox.Show($"書本ID{bookId}設定促銷標籤{tagId}成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvTags();
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
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

            if (!int.TryParse(txbSearch.Text.Trim(), out int id))
            {
                MessageBox.Show("請輸入有效的整數 ID！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDgvBookTagsByTagId(id);
        }
    }
}
