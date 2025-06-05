using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Frontend.Views.Forms
{
    public partial class CreateOrderForm : Form
    {

        private UserService _userService;
        private BookService _bookService;
        private OrderService _orderService;

        /// <summary>
        /// 給訂單付款(交易)方式ComboBox做的類別
        /// </summary>
        private class ComboBoxItem<T>
        {
            public T Value { get; set; }
            public string Text { get; set; }
        }

        public CreateOrderForm()
        {
            // 建構服務
            // HACK:沒有DI，直接讀App.config
            string _connString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            _userService = new UserService(_connString);
            _bookService = new BookService(_connString);
            _orderService = new OrderService(_connString);

            InitializeComponent();

            // 載入隨機買家ID
            LoadRandomUserId();

            // 載入隨機書本ID
            LoadRandomBookId();

            // 載入書本售價
            LoadBookSalePrice();

            // 載入付款(交易)方式
            LoadPaymentFlowOptions();
        }

        private void LoadRandomUserId()
        {
            var result = _userService.GetRandomUserId();
            if (result.IsSuccess)
            {
                lblBuyerId.Text = result.Value.ToString();
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }

        private void LoadRandomBookId()
        {
            var result = _bookService.GetRandomBookId();
            if (result.IsSuccess)
            {
                lblBookId.Text = result.Value.ToString();
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }

        private void LoadBookSalePrice()
        {
            try
            {
                // HACK: 應該要用TryParse先檢查格式。
                var result = _bookService.GetBookSalePriceByBookId(int.Parse(lblBookId.Text));
                if (result.IsSuccess)
                {
                    lblSalePrice.Text = result.Value.ToString();
                }
                else
                {
                    MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查無價格");
            }
        }

        private void LoadPaymentFlowOptions()
        {
            var options = new List<object>();
            foreach (PaymentFlowType val in Enum.GetValues(typeof(PaymentFlowType)))
            {
                options.Add(new ComboBoxItem<PaymentFlowType> { Value = val, Text = PaymentFlowTypeExtensions.GetDisplayName(val) });
            }

            cbxOrderStatus.DataSource = options;
            cbxOrderStatus.DisplayMember = "Text";
            cbxOrderStatus.ValueMember = "Value";
        }

        private void butCheckout_Click(object sender, EventArgs e)
        {
            if (!(cbxOrderStatus.SelectedItem is ComboBoxItem<PaymentFlowType> selectedItem))
            {
                MessageBox.Show("請選擇取貨方式", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxOrderStatus.Focus();
                return;
            }

            if (selectedItem.Value != PaymentFlowType.FaceToFace)
            {
                MessageBox.Show("目前只支援面交", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxOrderStatus.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txbBuyerPhone.Text))
            {
                MessageBox.Show("聯絡電話為必填欄位", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbBuyerPhone.Focus();
                return;
            }

            try
            {
                var dto = new CreateFaceToFaceOrderDto
                {
                    BookID = int.Parse(lblBookId.Text),
                    BuyerID = Guid.Parse(lblBuyerId.Text),
                    PaymentFlowType = selectedItem.Value,
                    BuyerContactPhone = txbBuyerPhone.Text
                };

                _orderService.CreateFaceToFaceOrder(dto);

                MessageBox.Show("訂單已建立成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"建立訂單時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
