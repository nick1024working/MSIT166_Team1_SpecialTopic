using System;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class CreateFaceToFaceOrderDto
    {
        public int BookID { get; set; }
        public Guid BuyerID { get; set; }
        public PaymentFlowType PaymentFlowType { get; set; }
        public string BuyerContactPhone { get; set; }
    }
}
