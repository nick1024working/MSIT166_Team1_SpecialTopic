using System.Collections.Generic;
using System.ComponentModel;

namespace SpecialTopic.UsedBooks.Backend.Utilities
{
    public enum PaymentFlowType
    {
        [Description("面交")]
        FaceToFace = 0,

        [Description("平台代管")]
        PlatformEscrow = 1,
    }

    /// <summary>
    /// 取得 PaymentFlowType 的顯示名稱
    /// </summary>
    public static class PaymentFlowTypeExtensions
    {
        private static readonly Dictionary<PaymentFlowType, string> _displayNames = new Dictionary<PaymentFlowType, string>
        {
            { PaymentFlowType.FaceToFace, "面交" },
            { PaymentFlowType.PlatformEscrow, "平台代管" },
        };

        public static string GetDisplayName(this PaymentFlowType flowType)
        {
            return _displayNames.TryGetValue(flowType, out var name) ? name : flowType.ToString();
        }
    }
}