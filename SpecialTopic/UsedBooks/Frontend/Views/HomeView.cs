using System;
using System.Windows.Forms;
using SpecialTopic.UsedBooks.Frontend.Shared;

namespace SpecialTopic.UsedBooks.Views
{
    public partial class HomeView : UserControl, ISwitchableView
    {
        public event EventHandler<ViewType> RequestSwitchView;

        public HomeView()
        {
            InitializeComponent();
        }

        private void btnSwitchToPLP_Click(object sender, System.EventArgs e)
        {
            RequestSwitchView?.Invoke(this, ViewType.ProductListingPageView);
        }
    }
}
