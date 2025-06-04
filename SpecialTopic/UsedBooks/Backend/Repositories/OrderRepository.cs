using System;
using System.Data.SqlClient;
using Dapper;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class OrderRepository
    {
        public int CreateOrder(UsedBookOrderEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                INSERT INTO [dbo].[UsedBookOrders]
                    ([BookID], [BuyerID], [CreatedAt], [OrderStatus], [SalePrice], [Discount],
                    [Amount], [PaymentFlowType], [BuyerContactPhone], [SellerContactPhone])
                VALUES
                    (@BookID, @BuyerID, @CreatedAt, @OrderStatus, @SalePrice, @Discount,
                    @Amount, @PaymentFlowType, @BuyerContactPhone, @SellerContactPhone);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";
            return conn.QuerySingle<int>(sqlString, entity, transaction: tran);
        }

        public void CreateFaceToFaceStatus(OrderFaceToFaceStatusEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                INSERT INTO [dbo].[OrderFaceToFaceStatuses]
                    ([OrderID], [BuyerConfirmedAt], [SellerConfirmedAt], [Deadline])
                VALUES
                    (@OrderID, @BuyerConfirmedAt, @SellerConfirmedAt, @Deadline);";
            conn.Execute(sqlString, entity, transaction: tran);
        }
    }
}
