using System;
using System.Data.SqlClient;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Repositories;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Services
{
    public class OrderService
    {
        private string _connString;
        private OrderRepository _orderRepository;
        private BookRepository _bookRepository;
        private UserRepository _userRepository;

        public OrderService(string connString)
        {
            _connString = connString;
            _orderRepository = new OrderRepository();
            _bookRepository = new BookRepository();
            _userRepository = new UserRepository();
        }

        /// <summary>
        /// 建立一筆面交訂單
        /// </summary>
        public Result<int> CreateFaceToFaceOrder(CreateFaceToFaceOrderDto dto)
        {
            // 建立 CREATE 查詢用 entity
            var orderEntity = new UsedBookOrderEntity
            {
                BookID = dto.BookID,
                BuyerID = dto.BuyerID,
                CreatedAt = DateTime.Now,
                OrderStatus = (byte)OrderStatus.Pending,
                Discount = 0.0M,
                PaymentFlowType = (byte)dto.PaymentFlowType,
                BuyerContactPhone = dto.BuyerContactPhone
            };

            var statusEntity = new OrderFaceToFaceStatusEntity
            {
                Deadline = orderEntity.CreatedAt.AddDays(7)
            };

            // 開始查詢與交易
            // HACK: 不分別對四個查詢做錯誤處理
            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        orderEntity.SalePrice = _bookRepository.GetBookSalePriceByBookId(orderEntity.BookID, conn, tran);
                        orderEntity.Amount = orderEntity.SalePrice - orderEntity.Discount;
                        orderEntity.SellerContactPhone = _userRepository.GetOwnerPhoneByBookId(orderEntity.BookID, conn, tran);

                        int newOrderId = _orderRepository.CreateOrder(orderEntity, conn, tran);
                        statusEntity.OrderID = newOrderId;

                        _orderRepository.CreateFaceToFaceStatus(statusEntity, conn, tran);

                        tran.Commit();
                        return Result<int>.Success(newOrderId);
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        // HACK: 如果是內部錯誤或資料庫錯誤，這可能包含敏感訊息。
                        return Result<int>.Failure(ex.Message);
                    }
                }
            }
        }
    }
}
