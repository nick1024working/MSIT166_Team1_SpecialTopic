using System;

namespace SpecialTopic.UsedBooks.Backend.Entities
{
    public class OrderFaceToFaceStatusEntity
    {
        public int FaceToFaceID { get; set; }
        public int OrderID { get; set; }
        public DateTime? BuyerConfirmedAt { get; set; }
        public DateTime? SellerConfirmedAt { get; set; }
        public DateTime Deadline { get; set; }
    }
}
