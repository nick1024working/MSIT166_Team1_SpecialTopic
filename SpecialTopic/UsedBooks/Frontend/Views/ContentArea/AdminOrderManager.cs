using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Backend.Utilities;
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    public partial class AdminOrderManager : UserControl
    {
        // 會使用的 Service
        private OrderService _orderService;

        // HACK: 目前只支援面交訂單
        private SortableBindingList<FaceToFaceOrderDto> _sortableList;

        public AdminOrderManager(string connString)
        {
            // 建構服務
            _orderService = new OrderService(connString);

            InitializeComponent();

            LoadCbxOrderStatus();
        }

        /// <summary>
        /// 載入訂單狀態enum
        /// </summary>
        private void LoadCbxOrderStatus()
        {
            cbxOrderStatus.DisplayMember = "Text";
            cbxOrderStatus.ValueMember = "Value";

            var items = Enum.GetValues(typeof(OrderStatus))
                .Cast<OrderStatus>()
                .Select(status => new
                {
                    Text = status.ToString(), // 顯示文字
                    Value = (int)status       // 實際值
                })
                .ToList();

            cbxOrderStatus.DataSource = items;
        }

        /// <summary>
        /// 載入所有訂單資料
        /// </summary>
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            var result = _orderService.GetAllFaceToFaceOrders();
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
        private void RenewDgvMainDataSource(List<FaceToFaceOrderDto> orders)
        {
            _sortableList = new SortableBindingList<FaceToFaceOrderDto>(orders);
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

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbChangeStatusId.Text))
            {
                MessageBox.Show("請輸入正確!");
                return;
            }

            if (!int.TryParse(txbChangeStatusId.Text.Trim(), out int id))
            {
                MessageBox.Show("請輸入有效的整數 ID！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new OrderStatusDto
            {
                OrderID = id,
                OrderStatus = (OrderStatus)cbxOrderStatus.SelectedValue  // 明確轉型
            };

            var result = _orderService.UpdateOrderStatus(dto);

            if (result.IsSuccess)
            {
                MessageBox.Show($"訂單設定:{cbxOrderStatus.SelectedText}成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }
    }
}
