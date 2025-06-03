using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Frontend.Components;
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Views
{
    public partial class ProductListingPageView : UserControl, ISwitchableView
    {
        // 給 父View(在此服務內稱作UsedBookControl) 訂閱的切換事件
        public event EventHandler<ViewType> RequestSwitchView;

        // 以下是會使用的 Service
        private TopicService _bookTopicService;
        private SaleTagService _saleTagService;
        private BookService _bookService;

        public ProductListingPageView()
        {
            // 建構服務
            // HACK:沒有DI，直接讀App.config
            string _connString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            _bookTopicService = new TopicService(_connString);
            _saleTagService = new SaleTagService(_connString);
            _bookService = new BookService(_connString);

            // 建構畫面元件
            InitializeComponent();

            // 初始化資料
            LoadData();
        }


        #region UI Loaders
        private void LoadData()
        {

            // 載入header的logo
            LoadHeaderLogo();

            // 載入左側欄的主題列表
            LoadSideBarTopics();

            // 載入左側欄的促銷標籤列表
            LoadSideBarSaleTags();

            // 載入主要區域
            // HACK: 相對於上面三個方法依賴資料但只有一次，
            // 部分載入!
            // 此處每次查詢都會重用這個方法。
            var result = _bookService.GetAllBookCards();
            if (result.IsSuccess)
            {
                var top10 = result.Value.Take(10).ToList();
                LoadContentAreaBookCards(top10);
            }
            else
            {
                MessageBox.Show("載入失敗");
            }
        }

        /// <summary>
        /// 把資料載入ContentArea，同時設置UI。
        /// </summary>
        /// <param name="bookCards"></param>
        private void LoadContentAreaBookCards(List<BookCardDto> bookCards)
        {
            int cardsPerRow = 6;
            var contentAreaWidth = flpMain.Size.Width;

            flpMain.Controls.Clear();
            foreach (var card in bookCards)
            {
                var newBookCardControl = new BookCardControl();
                newBookCardControl.SetData(card);

                newBookCardControl.Width = contentAreaWidth / cardsPerRow;
                newBookCardControl.Height = newBookCardControl.Width /2;
                newBookCardControl.Margin = new Padding(2);     // 避免緊貼在一起

                flpMain.Controls.Add(newBookCardControl);
            }
        }

        private void LoadHeaderLogo()
        {
            // 取得執行目錄（bin/Debug 或 bin/Release）
            string basePath = Application.StartupPath;

            // 拼接專案內的相對路徑
            string imagePath = Path.Combine(basePath, "UsedBooks", "Frontend", "Assets", "Logos", "logo.png");

            // 載入圖片到 PictureBox
            if (File.Exists(imagePath))
            {
                pbxLogo.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("找不到圖片：" + imagePath);
            }
        }

        private void LoadSideBarTopics()
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
            lbxTopics.ValueMember = "TopicID";       // UI 層說明用 Id 當值（例如選擇後取出）
        }

        private void LoadSideBarSaleTags()
        {
            // 獲取資料
            var result = _saleTagService.GetAllSaleTags();
            if (!result.IsSuccess)
            {
                MessageBox.Show($"促銷標籤列表讀取失敗: {result.ErrorMessage}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (result.Value == null)
            {
                MessageBox.Show("促銷標籤列表為空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 更新資料
            lbxSaleTags.Items.Clear();
            lbxSaleTags.DataSource = result.Value;
            lbxSaleTags.DisplayMember = "TagName";   // UI 層說明用 Name 當顯示文字
            lbxSaleTags.ValueMember = "TagID";       // UI 層說明用 Id 當值（例如選擇後取出）
        }
        #endregion

        #region Event Bindings
        private void pbxLogo_Click(object sender, EventArgs e)
        {
            RequestSwitchView?.Invoke(this, ViewType.HomeView);
        }

        private void lbxSaleTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tagId = lbxSaleTags.SelectedItem.;
            LoadContentAreaBookCards(top10);
        }
        #endregion

    }
}
