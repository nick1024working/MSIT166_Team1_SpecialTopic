using System;

namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class CreateBookDto
    {
        public string BookName { get; set; }
        public decimal SalePrice { get; set; }
        public string BookCondition { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Authors { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
