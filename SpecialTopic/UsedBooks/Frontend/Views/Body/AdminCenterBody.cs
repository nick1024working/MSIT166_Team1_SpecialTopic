using System;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Frontend.Views.ContentArea;

namespace SpecialTopic.UsedBooks.Frontend.Views.Body
{
    public partial class AdminCenterBody : UserControl
    {

        // 會在 pnlContentArea 載入的控制項，將用 sidebar 點擊切換
        private readonly AdminBookManager _adminBookManager;
        private readonly AdminOrderManager _adminOrderManager;
        private readonly AdminTopicManager _adminTopicManager;
        private readonly AdminTagManager _adminTagManager;

        public AdminCenterBody(string connString)
        {
            // 幫控制項注入服務
            _adminBookManager = new AdminBookManager(connString);
            _adminOrderManager = new AdminOrderManager(connString);
            _adminTopicManager = new AdminTopicManager(connString);
            _adminTagManager = new AdminTagManager(connString);

            InitializeComponent();
        }

        /// <summary>
        /// 把 pnlContentArea 切換傳入的 UserControl
        /// </summary>
        /// <param name="control"></param>
        private void ShowControl(UserControl control)
        {
            pnlContentArea.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContentArea.Controls.Add(control);
        }

        /// <summary>
        /// 選取 Sidebar 中的功能，更新 ContentArea 中的畫面
        /// </summary>
        private void lbxFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxFunctions.SelectedItem.ToString() == "管理書本")
            {
                ShowControl(_adminBookManager);
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理訂單")
            {
                ShowControl(_adminOrderManager);
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理主題")
            {
                ShowControl(_adminTopicManager);
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理標籤")
            {
                ShowControl(_adminTagManager);
            }
            else
            {
                MessageBox.Show("請先選擇有效的主題！");
            }
        }
    }
}
