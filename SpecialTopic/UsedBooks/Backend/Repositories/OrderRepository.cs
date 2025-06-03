using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class OrderRepository
    {
        private int createOrder(OrderDto dto, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                INSERT INTO [dbo].[UsedBookOrders]
                    ([BookID], [BuyerID], [CreatedAt], [OrderStatus], [SalePrice], [Discount],
                    [Amount], [PaymentFlowType], [BuyerContactPhone], [SellerContactPhone])
                VALUES
                    (@BookID, @BuyerID, @CreatedAt, @OrderStatus, @SalePrice, @Discount,
                    @Amount, @PaymentFlowType, @BuyerContactPhone, @SellerContactPhone);
                SELECT CAST(SCOPE_IDENTITY AS INT);";

            var entity = new UsedBookOrderEntity
            {
                BookID = dto.BookID,
                BuyerID = dto.BuyerID,
                CreatedAt = DateTime.Now,
                OrderStatus = (byte)OrderStatus.Pending,
                SalePrice = dto.SalePrice,
                Discount = dto.Discount,
                Amount = dto.Amount,
                PaymentFlowType = (byte)dto.PaymentFlowType,
                BuyerContactPhone = dto.BuyerContactPhone,
                SellerContactPhone = dto.SellerContactPhone
            };

            return conn.QuerySingle<int>(sqlString, entity, transaction: tran);
        }

        private void createFaceToFaceStatus(int orderId, CreateFaceToFaceStatusDto dto, SqlConnection conn, SqlTransaction tran)
        {
            var entity = new OrderFaceToFaceStatusEntity
            {
                OrderID = orderId,
                BuyerConfirmedAt = dto.BuyerConfirmedAt,
                SellerConfirmedAt = dto.SellerConfirmedAt,
                Deadline = dto.Deadline
            };

            string sqlString = @"
                INSERT INTO [dbo].[OrderFaceToFaceStatuses]
                    ([OrderID], [BuyerConfirmedAt], [SellerConfirmedAt], [Deadline])
                VALUES
                    (@OrderID, @BuyerConfirmedAt, @SellerConfirmedAt, @Deadline);";
            conn.Execute(sqlString, entity, transaction: tran);
        }
    }
}
