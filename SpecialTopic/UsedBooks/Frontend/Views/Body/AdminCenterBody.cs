using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialTopic.UsedBooks.Frontend.Views.Body
{
    public partial class AdminCenterBody : UserControl
    {
        public AdminCenterBody()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 選取 Sidebar 中的功能，更新 ContentArea 中的畫面
        /// </summary>
        private void lbxFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxFunctions.SelectedItem.ToString() == "管理訂單")
            {
                MessageBox.Show("OK");
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理主題")
            {
                MessageBox.Show("OK");
            }
            else if (lbxFunctions.SelectedItem.ToString() == "管理標籤")
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("請先選擇有效的主題！");
            }
        }
    }
}
