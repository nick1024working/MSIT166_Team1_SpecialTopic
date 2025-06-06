using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Frontend.Components;
using SpecialTopic.UsedBooks.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SpecialTopic.UsedBooks.Frontend.Views.Body
{
    public partial class PLPBody : UserControl
    {
        // 會使用的 連線字串
        private string _connString;

        // 會使用的 Service
        private TopicService _bookTopicService;
        private SaleTagService _saleTagService;
        private BookCardService _bookCardService;

        public PLPBody(ProductListingPageView parent, string connString)
        {
            // 建構服務
            // HACK:沒有DI，直接讀App.config
            _connString = connString;
            _bookTopicService = new TopicService(_connString);
            _saleTagService = new SaleTagService(_connString);
            _bookCardService = new BookCardService(_connString);

            InitializeComponent();

            // 訂閱父 ViewChanging 事件
            parent.ViewChanging += (s, e) => flpMain.Controls.Clear();

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
            RefreshData();
        }



        #region UI Data Loaders

        public void RefreshData()
        {
            // 載入左側欄的主題列表
            LoadSideBarTopics();

            // 載入左側欄的促銷標籤列表
            LoadSideBarSaleTags();

            // 載入body
            LoadContentAreaBookCardsDefaultWithTopCount(10);
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

            // 預設取消選取，後綁定事件
            lbxTopics.SelectedIndex = -1;
            lbxTopics.SelectedIndexChanged += lbxTopics_SelectedIndexChanged;

            // 根據項目數自動調整 Height
            int itemHeight = lbxTopics.ItemHeight;
            lbxTopics.Height = itemHeight * lbxTopics.Items.Count + 4; // +4 是些微邊距
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

            // 預設取消選取，後綁定事件
            lbxSaleTags.SelectedIndex = -1;
            lbxSaleTags.SelectedIndexChanged += lbxSaleTags_SelectedIndexChanged;

            // 根據項目數自動調整 Height
            int itemHeight = lbxSaleTags.ItemHeight;
            lbxSaleTags.Height = itemHeight * lbxSaleTags.Items.Count + 4; // +4 是些微邊距
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

        #endregion



        /// <summary>
        /// 預設載入
        /// </summary>
        public void LoadContentAreaBookCardsDefaultWithTopCount(int topCount)
        {
            var result = _bookCardService.GetAllBookCards();
            if (result.IsSuccess)
            {
                var top10 = result.Value.Take(topCount).ToList();
                LoadContentAreaBookCards(top10);
            }
            else
            {
                MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
            }
        }

        /// <summary>
        /// 使用關鍵字查詢並載入
        /// </summary>
        public void LoadContentAreaBookCardsByKeyWord(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                var result = _bookCardService.GetBookCardsByKeyword(keyword);
                if (result.IsSuccess)
                {
                    LoadContentAreaBookCards(result.Value);
                }
                else
                {
                    MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
                }
            }
        }



        #region Event Bindings

        /// <summary>
        /// 選取 Sidebar 中的主題，更新 ContentArea 中的 BookCard
        /// </summary>
        private void lbxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTopics.SelectedItem is TopicDto dto)
            {
                // 取消另一個lbx選取
                lbxSaleTags.SelectedIndex = -1;

                var result = _bookCardService.GetBookCardsByTopicId(dto.TopicID);
                if (result.IsSuccess)
                {
                    LoadContentAreaBookCards(result.Value);
                }
                else
                {
                    MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
                }

            }
        }

        /// <summary>
        /// 選取 Sidebar 中的促銷標籤，更新 ContentArea 中的 BookCard
        /// </summary>
        private void lbxSaleTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSaleTags.SelectedItem is SaleTagDto dto)
            {
                // 取消另一個lbx選取
                lbxTopics.SelectedIndex = -1;

                var result = _bookCardService.GetBookCardsByTagId(dto.TagID);
                if (result.IsSuccess)
                {
                    LoadContentAreaBookCards(result.Value);
                }
                else
                {
                    MessageBox.Show($"發生錯誤: {result.ErrorMessage}");
                }

            }
        }

        #endregion

    }
}
