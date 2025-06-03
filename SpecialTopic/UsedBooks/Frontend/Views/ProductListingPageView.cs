using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Backend.Utilities;
using SpecialTopic.UsedBooks.Frontend.Components;
using SpecialTopic.UsedBooks.Frontend.Shared;
using SpecialTopic.UsedBooks.Frontend.Views;

namespace SpecialTopic.UsedBooks.Views
{
    public partial class ProductListingPageView : UserControl, ISwitchableView
    {
        // 給 父View(在此服務內稱作UsedBookControl) 訂閱的切換事件
        public event EventHandler<ViewType> RequestSwitchView;

        // 以下是會使用的 Service
        private TopicService _bookTopicService;
        private SaleTagService _saleTagService;
        private BookCardService _bookService;


        /// <summary>
        /// 用於建立商品列表頁面的視圖控制項。
        /// 在建構子中完成服務初始化與畫面元件初始化，
        /// 資料載入則延後至 OnHandleCreated，以確保 UI 控件已生成完成。
        /// </summary>
        public ProductListingPageView()
        {
            // 建構服務
            // HACK:沒有DI，直接讀App.config
            string _connString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            _bookTopicService = new TopicService(_connString);
            _saleTagService = new SaleTagService(_connString);
            _bookService = new BookCardService(_connString);

            // 建構畫面元件
            InitializeComponent();

            // 初始化資料
            // 資料顯示與UI有關，UI與控件是否生成有關，此處我們用額外OnHandleCreated()控制
        }

        /// <summary>
        /// 當控制項的 Handle 第一次建立時觸發。
        /// 此時 UI 控件大小與佈局皆已完成，
        /// 因此在此呼叫 LoadData() 確保初次載入的畫面排版正常。
        /// </summary>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
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
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }

        /// <summary>
        /// 將書籍卡片資料載入主顯示區 (ContentArea)，並配置對應 UI 控制項。
        /// </summary>
        /// <param name="bookCards">書籍卡片資料列表 (List of BookCardDto)</param>
        private void LoadContentAreaBookCards(List<BookCardDto> bookCards)
        {
            flpMain.Controls.Clear();

            const int CardsPerRow = 4;     // 每行卡片數
            const int WidthAdjustment = 10; // 寬度調整值，用於預留間距

            foreach (var card in bookCards)
            {
                var newBookCardControl = new BookCardControl();
                newBookCardControl.SetData(card);

                // 計算寬度：主容器寬度 / 每行數量 - 調整值
                newBookCardControl.Width = flpMain.Size.Width / CardsPerRow - WidthAdjustment;
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

        /// <summary>
        /// 點擊logo，回到服務 HomeView。
        /// </summary>
        private void pbxLogo_Click(object sender, EventArgs e)
        {
            RequestSwitchView?.Invoke(this, ViewType.HomeView);
        }

        /// <summary>
        /// 選取 Sidebar 中的主題，更新 ContentArea 中的 BookCard
        /// </summary>
        private void lbxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTopics.SelectedItem is TopicDto dto)
            {
                var result = _bookService.GetBookCardsByTopicId(dto.TopicID);
                if (result.IsSuccess)
                {
                    LoadContentAreaBookCards(result.Value);
                }
                else
                {
                    MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
                }

            }
            else
            {
                MessageBox.Show("請先選擇有效的主題！");
            }
        }

        /// <summary>
        /// 選取 Sidebar 中的促銷標籤，更新 ContentArea 中的 BookCard
        /// </summary>
        private void lbxSaleTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSaleTags.SelectedItem is SaleTagDto dto)
            {
                var result = _bookService.GetBookCardsByTagId(dto.TagID);
                if (result.IsSuccess)
                {
                    LoadContentAreaBookCards(result.Value);
                }
                else
                {
                    MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
                }

            }
            else
            {
                MessageBox.Show("請先選擇有效的促銷標籤！");
            }
        }

        #endregion

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            var newForm = new CreateOrderForm();
            newForm.Show();
        }
    }
}
