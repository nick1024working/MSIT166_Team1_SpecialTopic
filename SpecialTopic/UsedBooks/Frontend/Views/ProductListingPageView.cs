using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Frontend.Shared;
using SpecialTopic.UsedBooks.Frontend.Views;
using SpecialTopic.UsedBooks.Frontend.Views.Body;
using SpecialTopic.UsedBooks.Frontend.Views.Forms;

namespace SpecialTopic.UsedBooks.Views
{
    public partial class ProductListingPageView : UserControl, ISwitchableView
    {
        // 給 父View(在此服務內稱作UsedBookControl) 訂閱的切換事件
        public event EventHandler<ViewType> RequestSwitchView;

        // 會使用的 連線字串
        private string _connString;

        // 會使用的 Service
        private TopicService _bookTopicService;
        private SaleTagService _saleTagService;
        private BookCardService _bookCardService;

        // 會在 pnlBody 載入的控制項，將用 header bar 點擊切換
        private readonly PLPBody _plpBody;
        private readonly UserCenterBody _userCenterBody;
        private readonly AdminCenterBody _adminCenterBody;

        /// <summary>
        /// 清除並載入 pnlBody
        /// </summary>
        private void ShowControl(UserControl control)
        {
            pnlBody.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(control);
        }

        /// <summary>
        /// 在建構子中完成服務初始化與畫面元件初始化，
        /// 資料載入則延後至 OnHandleCreated，以確保 UI 控件已生成完成。
        /// </summary>
        public ProductListingPageView()
        {
            // 建構服務
            // HACK:沒有DI，直接讀App.config
            _connString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            _bookTopicService = new TopicService(_connString);
            _saleTagService = new SaleTagService(_connString);
            _bookCardService = new BookCardService(_connString);

            _plpBody = new PLPBody(_connString);
            _userCenterBody = new UserCenterBody(_connString);
            _adminCenterBody = new AdminCenterBody(_connString);

        // 建構畫面元件
        InitializeComponent();

            // 初始化資料
            LoadData();
        }


        #region UI Loaders

        /// <summary>
        /// 這是初始化
        /// </summary>
        private void LoadData()
        {
            // 載入header的logo
            LoadHeaderLogo();

            // 載入主要區域
            // 此處切換pnlBody，內部畫面交由_plpBody自行處理
            ShowControl(_plpBody);
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

        #endregion


        #region Header Events

        /// <summary>
        /// 點擊logo，回到服務 HomeView。
        /// </summary>
        private void pbxLogo_Click(object sender, EventArgs e)
        {
            RequestSwitchView?.Invoke(this, ViewType.HomeView);
        }

        /// <summary>
        /// 使用搜尋框中關鍵字查詢
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txbSearch.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                // 此處切換pnlBody，並搜尋
                ShowControl(_plpBody);
                _plpBody.LoadContentAreaBookCardsByKeyWord(keyword);
            }
            
        }

        /// <summary>
        /// 搜尋框按下Enter後使用搜尋框中關鍵字查詢
        /// </summary>
        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 防止嗶聲或預設行為
                btnSearch.PerformClick();
            }
        }

        /// <summary>
        /// 按下管理員中心按鈕，切換pnlBbody
        /// </summary>
        private void btnAdminCenter_Click(object sender, EventArgs e)
        {
            ShowControl(_adminCenterBody);
        }

        /// <summary>
        /// 按下會員中心按鈕，切換pnlBbody
        /// </summary>
        /// 
        private void btnUserCenter_Click(object sender, EventArgs e)
        {
            ShowControl(_userCenterBody);
        }

        /// <summary>
        /// 按下新增訂單按鈕，彈出新增訂單視窗
        /// </summary>
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            var newForm = new CreateOrderForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            newForm.Show();
        }

        #endregion

    }
}
