namespace SpecialTopic.UsedBooks.Backend.Entities
{
    public class BookCardEntity
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public decimal SalePrice { get; set; }
        public string Authors { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}