using System.ComponentModel;
using System;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Frontend.Shared;
using System.Globalization;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    public partial class AdminTopicManager : UserControl
    {

        // 會使用的 Service
        private TopicService _bookTopicService;
        private BookService _bookService;

        private SortableBindingList<TopicDto> _sortableList;

        public AdminTopicManager(string connString)
        {
            // 建構服務
            _bookTopicService = new TopicService(connString);
            _bookService = new BookService(connString);

            InitializeComponent();

            // 顯示資料
            LoadDgvTopics();
        }

        private void LoadDgvTopics()
        {
            var result = _bookTopicService.GetAllTopics();
            if (result.IsSuccess)
            {
                _sortableList = new SortableBindingList<TopicDto>(result.Value);
                dgvMain.DataSource = _sortableList;

                dgvMain.AutoGenerateColumns = true;
                dgvMain.AllowUserToAddRows = false;
                dgvMain.ReadOnly = true;
                dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMain.MultiSelect = false;
                dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                MessageBox.Show("提取資料失敗");
            }
        }

        /// <summary>
        /// ChatGPT 生成，支援點擊欄位自動排序
        /// </summary>
        private void dgvMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvMain.Columns[e.ColumnIndex].DataPropertyName;
            PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(TopicDto))[columnName];

            ListSortDirection direction = ListSortDirection.Ascending;
            if (dgvMain.Tag is Tuple<string, ListSortDirection> lastSort &&
                lastSort.Item1 == columnName && lastSort.Item2 == ListSortDirection.Ascending)
            {
                direction = ListSortDirection.Descending;
            }

            _sortableList.ApplySort(prop, direction);
            dgvMain.Tag = Tuple.Create(columnName, direction);
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbCreate.Text))
            {
                var dto = new CreateTopicDto { TopicName =txbCreate.Text };
                var result = _bookTopicService.CreateTopic(dto);
                if (result.IsSuccess)
                {
                    MessageBox.Show($"新增成功!\n名稱 = {txbCreate.Text}\nID = {result.Value}");
                    LoadDgvTopics();
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

            var result = _bookTopicService.DeleteTopicById(id);
            if (result.IsSuccess)
            {
                MessageBox.Show("刪除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvTopics();
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
                MessageBox.Show("請輸入正確主題 ID !");
                return;
            }

            if (!int.TryParse(txbSetTagId.Text.Trim(), out int tagId))
            {
                MessageBox.Show("請輸入有效的整數主題 ID！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var dto = new CreateBookTopicDto
            {
                BookID = bookId,
                TopicID = tagId
            };
            var result = _bookService.CreateBookTopicRelation(dto);
            if (result.IsSuccess)
            {
                MessageBox.Show($"書本ID{bookId}設定主題{tagId}成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvTopics();
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }
    }
}