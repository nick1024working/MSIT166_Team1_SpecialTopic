using System;

namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class CreateFaceToFaceStatusDto
    {
        public int OrderID { get; set; }
        public DateTime? BuyerConfirmedAt { get; set; }
        public DateTime? SellerConfirmedAt { get; set; }
        public DateTime Deadline { get; set; }
    }
}