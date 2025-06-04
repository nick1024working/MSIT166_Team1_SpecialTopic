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
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Frontend.Views.ContentArea
{
    public partial class AdminOrderManager : UserControl
    {
        // 會使用的 Service
        private OrderService _orderService;

        //private SortableBindingList<OrderDto> _sortableList;

        public AdminOrderManager(string connString)
        {
            // 建構服務
            _orderService = new OrderService(connString);

            InitializeComponent();

            // 先不顯示資料 lazy load
        }

        ///// <summary>
        ///// 載入所有訂單資料
        ///// </summary>
        //private void btnLoadAll_Click(object sender, EventArgs e)
        //{
        //    var result = _orderService.GetAllOrders();
        //    if (result.IsSuccess)
        //    {
        //        RenewDgvMainDataSource(result.Value);
        //    }
        //    else
        //    {
        //        MessageBox.Show("提取資料失敗");
        //    }
        //}

        ///// <summary>
        ///// 將指定清單重新綁定至 dgvMain，並套用格式設定
        ///// </summary>
        //private void RenewDgvMainDataSource(List<OrderDto> orders)
        //{
        //    _sortableList = new SortableBindingList<OrderDto>(orders);
        //    dgvMain.DataSource = _sortableList;

        //    dgvMain.AutoGenerateColumns = true;
        //    dgvMain.AllowUserToAddRows = false;
        //    dgvMain.ReadOnly = true;
        //    dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvMain.MultiSelect = false;
        //    dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //}

        ///// <summary>
        ///// 點擊欄位排序
        ///// </summary>
        //private void dgvMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    string columnName = dgvMain.Columns[e.ColumnIndex].DataPropertyName;
        //    PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(BookDto))[columnName];

        //    var direction = ListSortDirection.Ascending;
        //    if (dgvMain.Tag is Tuple<string, ListSortDirection> lastSort &&
        //        lastSort.Item1 == columnName && lastSort.Item2 == ListSortDirection.Ascending)
        //    {
        //        direction = ListSortDirection.Descending;
        //    }

        //    _sortableList.ApplySort(prop, direction);
        //    dgvMain.Tag = Tuple.Create(columnName, direction);
        //}

    }
}
