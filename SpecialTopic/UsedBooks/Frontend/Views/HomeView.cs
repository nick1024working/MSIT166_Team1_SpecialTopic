using System;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Views
{
    /// <summary>
    /// 主畫面，來不及完成，直接轉跳ProductListingPageView
    /// </summary>
    public partial class HomeView : UserControl, ISwitchableView
    {
        public event EventHandler<ViewType> RequestSwitchView;

        public HomeView()
        {
            InitializeComponent();
        }

        // 覆寫 OnHandleCreated，等畫面建立完再切換
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (!DesignMode)
            {
                RequestSwitchView?.Invoke(this, ViewType.ProductListingPageView);
            }
        }
    }
}
