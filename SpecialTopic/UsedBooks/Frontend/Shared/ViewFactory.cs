using System.Collections.Generic;
using System.Windows.Forms;
using System;
using SpecialTopic.UsedBooks.Views;

namespace SpecialTopic.UsedBooks.Frontend.Shared
{
    /// <summary>
    /// 根據 ViewType，創造對應的 View instance。
    /// </summary>
    public static class ViewFactory
    {
        /// <summary>
        /// ViewType 對應的建構工廠。
        /// </summary>
        /// <remarks>
        /// 注意：使用 Func 而不是 Type，
        /// 若value使用Type，在需要時用 Activator.CreateInstance() 生成例項，
        /// 此時是使用反射，並且無法輕易控制 constructor（只能無參數）。
        /// </remarks>
        /// <example>
        /// <code>
        /// UserControl instance = ViewCreators[ViewType.MainView](); 
        /// </code>
        /// </example>
        private static readonly Dictionary<ViewType, Func<UserControl>> ViewCreators = new Dictionary<ViewType, Func<UserControl>>()
        {
            { ViewType.HomeView, () => new HomeView() },
            { ViewType.ProductListingPageView, () => new ProductListingPageView() }
        };


        /// <summary>
        /// 根據 ViewType 產生對應的 UserControl 實例。
        /// </summary>
        /// /// <example>
        /// <code>
        /// UserControl instance = CreateView(ViewType.MainView); 
        /// </code>
        /// </example>
        public static UserControl CreateView(ViewType viewType)
        {
            if (ViewCreators.TryGetValue(viewType, out var creator))
            {
                return creator();
            }
            throw new NotSupportedException($"Unsupported ViewType: {viewType}");
        }
    }

}
