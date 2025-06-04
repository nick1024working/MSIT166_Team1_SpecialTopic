using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Frontend.Components
{
    public partial class MainViewLayout : UserControl, ISwitchableView
    {
        // 給 父View(在此服務內稱作UsedBookControl) 訂閱的切換事件
        public event EventHandler<ViewType> RequestSwitchView;

        // 以下是會使用的 Service
        //...


        public MainViewLayout()
        {
            // 建構服務
            // HACK:沒有DI，直接讀App.config
            string _connString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

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
            //LoadData();
        }

        #region UI Loaders
        private void LoadData()
        {

            // 載入header的logo
            LoadHeaderLogo();

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

        #region Event Bindings

        /// <summary>
        /// 點擊logo，回到服務 HomeView。
        /// </summary>
        private void pbxLogo_Click(object sender, EventArgs e)
        {
            RequestSwitchView?.Invoke(this, ViewType.HomeView);
        }
        #endregion
    }
}
