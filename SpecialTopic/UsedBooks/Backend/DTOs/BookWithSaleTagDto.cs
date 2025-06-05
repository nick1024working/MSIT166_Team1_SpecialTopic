namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class BookWithSaleTagDto
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string CreatedAt { get; set; }
        public int SalePrice { get; set; }
    }
}
