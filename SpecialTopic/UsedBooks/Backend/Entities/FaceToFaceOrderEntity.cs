using System;

namespace SpecialTopic.UsedBooks.Backend.Entities
{
    public class FaceToFaceOrderEntity
    {
        public int OrderID { get; set; }
        public byte OrderStatus { get; set; }
        public int BookID { get; set; }
        public decimal SalePrice { get; set; }

        public Guid BuyerID { get; set; }
        public string BuyerName { get; set; }
        public string BuyerContactPhone { get; set; }

        public Guid SellerID { get; set; }
        public string SellerName { get; set; }
        public string SellerContactPhone { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? BuyerConfirmedAt { get; set; }
        public DateTime? SellerConfirmedAt { get; set; }
        public DateTime Deadline { get; set; }
    }
}
