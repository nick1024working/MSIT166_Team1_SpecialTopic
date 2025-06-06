using System.Configuration;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Frontend.Shared;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpecialTopic
{
    /// <summary>
    /// 負責 "二手書C2C買賣服務" 的主畫面顯示與切換
    /// </summary>
    /// <remarks>
    /// 此項目的designer.cs中有private Panel mainPanel，Dock = Fill，
    /// Views將被this.SwitchTo() 加入畫面。
    /// </remarks>
    public partial class UsedBookControl : UserControl
    {

        public UsedBookControl(string userPhone)
        {
            Login(userPhone);

            InitializeComponent();
            SwitchTo(ViewType.HomeView);
        }

        /// <summary>
        /// 登入會員至 AppSession
        /// </summary>
        private void Login(string userPhone)
        {
            AppSession.Current.Phone = userPhone;
            string connString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            var result = (new UserService(connString)).GetUserIdByPhone(userPhone);
            if (result.IsSuccess)
            {
                AppSession.Current.UID = result.Value;
            }
        }

        private void SwitchTo(ViewType viewType)
        {
            UserControl newView = ViewFactory.CreateView(viewType);

            // 檢查是否支援切換事件
            if (newView is ISwitchableView switchableView)
            {
                switchableView.RequestSwitchView += (s, v) => SwitchTo(v);
            }
            // NOTE: 雖然簡單，但有幾個潛在問題：
            // 如果之後要 unsubscribe（退訂），你沒辦法對應到 lambda。
            // 測試或除錯時，call stack 會直接指到匿名方法，不好追蹤。

            mainPanel.Controls.Clear();
            newView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(newView);
        }
    }
}
