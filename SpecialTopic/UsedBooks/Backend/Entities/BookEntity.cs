using System;

namespace SpecialTopic.UsedBooks.Backend.Entities
{
    public class BookEntity
    {
        public int BookID { get; set; }
        public Guid UID { get; set; }
        public string BookName { get; set; }
        public decimal SalePrice { get; set; }
        public string BookCondition { get; set; } 
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Authors { get; set; }
        public string Publisher { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int ViewCount { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsSold { get; set; } = false;
        public string Slug { get; set; } = string.Empty;
    }
}