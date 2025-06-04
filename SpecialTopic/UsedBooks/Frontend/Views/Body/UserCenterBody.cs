using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Frontend.Views.ContentArea;

namespace SpecialTopic.UsedBooks.Frontend.Views.Body
{
    public partial class UserCenterBody : UserControl
    {
        // 會在 pnlContentArea 載入的控制項，將用 sidebar 點擊切換
        private readonly UserBookManager _userBookManager;


        public UserCenterBody(string connString)
        {
            // 幫控制項注入服務
            _userBookManager = new UserBookManager(connString);

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
                ShowControl(_userBookManager);
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理訂單")
            {
                //ShowControl(orderManager);
            }
            else if (lbxFunctions.SelectedItem.ToString() == "追蹤清單")
            {
                //ShowControl(topicManager);
            }
            else
            {
                MessageBox.Show("請先選擇有效的主題！");
            }
        }
    }
}
