using System;

namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class FaceToFaceOrderDto
    {
        public int OrderID { get; set; }
        public string OrderStatus { get; set; }
        public int BookID { get; set; }
        public int SalePrice { get; set; }

        public Guid BuyerID { get; set; }
        public string BuyerName { get; set; }
        public string BuyerContactPhone { get; set; }

        public Guid SellerID { get; set; }
        public string SellerName { get; set; }
        public string SellerContactPhone { get; set; }

        public string CreatedAt { get; set; }

        public string BuyerConfirmedAt { get; set; }
        public string SellerConfirmedAt { get; set; }
        public string Deadline { get; set; }
    }
}
