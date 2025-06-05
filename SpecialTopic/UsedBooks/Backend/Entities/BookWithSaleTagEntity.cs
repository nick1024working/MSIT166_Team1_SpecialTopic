using System;

namespace SpecialTopic.UsedBooks.Backend.Entities
{
    public class BookWithSaleTagEntity
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal SalePrice { get; set; }
    }
}
