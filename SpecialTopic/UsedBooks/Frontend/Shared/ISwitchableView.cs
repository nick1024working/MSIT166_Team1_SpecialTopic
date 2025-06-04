using System;

namespace SpecialTopic.UsedBooks.Frontend.Shared
{
    /// <summary>
    /// 給View用的切換事件
    /// </summary>
    /// <remarks>
    /// 統一介面，讓View可以被父View(在此服務內稱作UsedBookControl)訂閱切換事件
    /// 當事件被觸發，將呼叫父View訂閱時傳入的delegate(ViewType)
    /// </remarks>
    /// TODO: 此處只傳 ViewType，如果未來要切換到需要帶資料的頁面（例如 ProductDetailView(productId)），建議擴展。
    public interface ISwitchableView
    {
        event EventHandler<ViewType> RequestSwitchView;
    }
}