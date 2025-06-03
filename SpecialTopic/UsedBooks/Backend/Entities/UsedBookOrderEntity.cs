using System;

namespace SpecialTopic.UsedBooks.Backend.Entities
{
    public class UsedBookOrderEntity
    {
        public int OrderID {  get; set; }
        public int BookID { get; set; }
        public Guid BuyerID { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte OrderStatus { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Amount { get; set; }
        public byte PaymentFlowType { get; set; }
        public string BuyerContactPhone { get; set; }
        public string SellerContactPhone { get; set; }
    }
}