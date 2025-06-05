using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        /// <summary>
        /// 把 entity 轉完整 dto（給後台或編輯用途）
        /// </summary>
        /// <remarks>價格、時間已轉成 string</remarks>
        private FaceToFaceOrderDto MapFaceToFaceOrderEntityToDto(FaceToFaceOrderEntity entity)
        {
            return new FaceToFaceOrderDto
            {
                OrderID = entity.OrderID,
                OrderStatus = ((OrderStatus)entity.OrderStatus).ToString(),
                BookID = entity.BookID,
                SalePrice = (int)entity.SalePrice,

                BuyerID = entity.BuyerID,
                BuyerName = entity.BuyerName,
                BuyerContactPhone = entity.BuyerContactPhone,

                SellerID = entity.SellerID,
                SellerName = entity.SellerName,
                SellerContactPhone = entity.SellerContactPhone,

                CreatedAt = entity.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"),

                BuyerConfirmedAt = entity.BuyerConfirmedAt?.ToString("yyyy-MM-dd HH:mm:ss") ?? "",
                SellerConfirmedAt = entity.SellerConfirmedAt?.ToString("yyyy-MM-dd HH:mm:ss") ?? "",
                Deadline = entity.Deadline.ToString("yyyy-MM-dd HH:mm:ss")
            };
        }

        public Result<List<FaceToFaceOrderDto>> GetAllFaceToFaceOrders()
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entity = _orderRepository.GetAllFaceToFaceOrders(conn, null);
                    var dtos = entity.Select(MapFaceToFaceOrderEntityToDto).ToList();
                    return Result<List<FaceToFaceOrderDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<FaceToFaceOrderDto>>.Failure(ex.Message);
            }
        }

        public Result<Unit> UpdateOrderStatus(OrderStatusDto dto)
        {
            var entity = new OrderStatusEntity
            {
                OrderID = dto.OrderID,
                OrderStatus = (byte)dto.OrderStatus  // 明確轉為 byte
            };
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var result = _orderRepository.UpdateOrderStatus(entity, conn, null);
                    return Result<Unit>.Success(result);
                }
            }
            catch (Exception ex)
            {
                return Result<Unit>.Failure(ex.Message);
            }
        }
    }
}
