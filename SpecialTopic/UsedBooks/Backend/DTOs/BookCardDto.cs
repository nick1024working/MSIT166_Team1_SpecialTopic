namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class BookCardDto
    {
        public int BookID { get; set; }
        public string BookName { get; set; } = string.Empty;
        public decimal SalePrice { get; set; }
        public string Authors { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
    }
}