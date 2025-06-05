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
        // HACK: 耦合過深，停止住注入
        private string _connString;

        public UserCenterBody(string connString)
        {
            _connString = connString;

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
                ShowControl(new UserBookManager(_connString));
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
