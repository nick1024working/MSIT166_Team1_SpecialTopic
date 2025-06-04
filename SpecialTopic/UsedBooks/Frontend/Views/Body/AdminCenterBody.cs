using System;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Frontend.Views.ContentArea;

namespace SpecialTopic.UsedBooks.Frontend.Views.Body
{
    public partial class AdminCenterBody : UserControl
    {

        // 會在 pnlContentArea 載入的控制項，將用 sidebar 點擊切換
        private readonly AdminBookManager bookManager;
        private readonly AdminOrderManager orderManager;
        private readonly AdminTopicManager topicManager;
        private readonly AdminTagManager tagManager;

        public AdminCenterBody(string connString)
        {
            // 幫控制項注入服務
            bookManager = new AdminBookManager(connString);
            orderManager = new AdminOrderManager(connString);
            topicManager = new AdminTopicManager(connString);
            tagManager = new AdminTagManager(connString);

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
                ShowControl(bookManager);
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理訂單")
            {
                ShowControl(orderManager);
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理主題")
            {
                ShowControl(topicManager);
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理標籤")
            {
                ShowControl(tagManager);
            }
            else
            {
                MessageBox.Show("請先選擇有效的主題！");
            }
        }
    }
}
