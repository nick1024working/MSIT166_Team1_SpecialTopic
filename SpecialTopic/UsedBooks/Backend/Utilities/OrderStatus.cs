using System.ComponentModel;

namespace SpecialTopic.UsedBooks.Backend.Utilities
{
    public enum OrderStatus
    {
        [Description("待處理")]
        Pending = 0,

        [Description("已完成")]
        Completed = 1,

        [Description("已取消")]
        Canceled = 2,

        [Description("管理員審核中")]
        AdminReview = 3
    }
}