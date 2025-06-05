using System;

namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class BookPublicDto
    {
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
    }
}
