using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class OrderStatusDto
    {
        public int OrderID { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}