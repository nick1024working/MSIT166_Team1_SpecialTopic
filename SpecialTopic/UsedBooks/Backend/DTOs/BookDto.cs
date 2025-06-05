using System;

namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class BookDto
    {
        public int BookID { get; set; }
        public Guid UID { get; set; }
        public string BookName { get; set; }
        public int SalePrice { get; set; }
        public string BookCondition { get; set; }
        public string Description { get; set; }
        public string CreatedAt { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Authors { get; set; }
        public string Publisher { get; set; }
        public string PublicationDate { get; set; }
        public int ViewCount { get; set; }
        public bool IsActive { get; set; }
        public bool IsSold { get; set; }
        public string Slug { get; set; }
    }
}
