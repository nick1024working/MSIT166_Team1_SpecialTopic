namespace SpecialTopic.UsedBooks.Backend.Utilities
{
    /// <summary>
    /// 佔位型別，表示沒有實際值，相當於函式式編程裡的 Unit。
    /// </summary>
    public sealed class Unit
    {
        public static readonly Unit Value = new Unit();

        private Unit() { }
    }
}