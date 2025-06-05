using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        public Unit CreateFaceToFaceStatus(OrderFaceToFaceStatusEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            // TODO: 改 OUTPUT INSERTED.OrderID 
            string sqlString = @"
                INSERT INTO [dbo].[OrderFaceToFaceStatuses]
                    ([OrderID], [BuyerConfirmedAt], [SellerConfirmedAt], [Deadline])
                VALUES
                    (@OrderID, @BuyerConfirmedAt, @SellerConfirmedAt, @Deadline);";
            conn.Execute(sqlString, entity, transaction: tran);
            return Unit.Value;
        }

        /// <summary>
        /// 取得完整面交資料 給Admin用
        /// </summary>
        public List<FaceToFaceOrderEntity> GetAllFaceToFaceOrders(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT o.OrderID, o.OrderStatus, b.BookID, o.SalePrice,
	                o.BuyerID, u1.Name AS BuyerName, o.BuyerContactPhone,
	                u2.UID AS SellerID, u2.Name AS SellerName, o.SellerContactPhone,
	                o.CreatedAt, f.BuyerConfirmedAt, f.SellerConfirmedAt, f.Deadline
                FROM [dbo].[UsedBookOrders] AS o
                JOIN [dbo].[Users] AS u1
	                ON o.BuyerID = u1.UID
                JOIN [dbo].[OrderFaceToFaceStatuses] AS f
	                ON o.OrderID = f.OrderID
                JOIN [dbo].[UsedBooks] AS b
	                ON o.BookID = b.BookID
                JOIN [dbo].[Users] AS u2
	                ON b.UID = u2.UID
                ORDER BY o.CreatedAt DESC;";
            return conn.Query<FaceToFaceOrderEntity>(sqlString, transaction: tran).ToList();
        }

        public Unit UpdateOrderStatus(OrderStatusEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                UPDATE [dbo].[UsedBookOrders]
                SET [OrderStatus] = @OrderStatus
                WHERE OrderID = @OrderID;";
            conn.Execute(sqlString, entity, transaction: tran);
            return Unit.Value;
        }
    }
}
