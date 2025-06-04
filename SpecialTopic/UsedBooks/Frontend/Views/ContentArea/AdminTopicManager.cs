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

        private SortableBindingList<TopicDto> _sortableList;

        public AdminTopicManager(string connString)
        {
            // 建構服務
            _bookTopicService = new TopicService(connString);

            InitializeComponent();

            // 顯示資料
            GetTopicsToDgv();
        }

        private void GetTopicsToDgv()
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
                    GetTopicsToDgv();
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
                GetTopicsToDgv();
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }
    }
}