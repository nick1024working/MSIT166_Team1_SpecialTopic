using System;
using System.Collections.Generic;

namespace SpecialTopic.UsedBooks.Frontend.Shared
{
    public class AppSession
    {
        // Singleton 實例
        private static AppSession _current;
        public static AppSession Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new AppSession();
                }
                return _current;
            }
        }

        // 私有建構子避免外部 new
        private AppSession() { }

        // 登入資訊
        public string Phone { get; set; }
        public Guid? UID { get; set; }

        // 購物暫存資料
        public List<int> ShoppingCartBookIDs { get; } = new List<int>();
    }
}
