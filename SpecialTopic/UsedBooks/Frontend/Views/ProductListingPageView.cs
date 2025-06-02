using System;
using System.Configuration;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Views
{
    public partial class ProductListingPageView : UserControl, ISwitchableView
    {
        // 給 父View(在此服務內稱作UsedBookControl) 訂閱的切換事件
        public event EventHandler<ViewType> RequestSwitchView;

        // 以下是會使用的 Service
        private BookTopicService _bookTopicService;

        public ProductListingPageView()
        {
            InitializeComponent();
            //splitContainer1.AutoSize = true;

            // HACK:沒有DI，直接讀App.config
            string _connString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            _bookTopicService = new BookTopicService(_connString);

            LoadingData();
        }

        private void LoadingData()
        {
            // 初始化左側欄的主題列表
            LoadingSideBarTopics();

            // 初始化左側欄的促銷標籤列表

            // 初始化
        }

        private void LoadingSideBarTopics()
        {
            // 獲取資料
            var result = _bookTopicService.GetAllTopics();
            if (!result.IsSuccess)
            {
                MessageBox.Show($"主題列表讀取失敗: {result.ErrorMessage}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (result.Value == null)
            {
                MessageBox.Show("主題列表為空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 更新資料
            lbxTopics.Items.Clear();
            lbxTopics.DataSource = result.Value;
            lbxTopics.DisplayMember = "TopicName";   // UI 層說明用 Name 當顯示文字
            lbxTopics.ValueMember = "TopicId";       // UI 層說明用 Id 當值（例如選擇後取出）
        }

        private void btnSwitchToMain_Click(object sender, EventArgs e)
        {
            RequestSwitchView?.Invoke(this, ViewType.HomeView);
        }
    }
}
