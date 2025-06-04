using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using Dapper;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class BookRepository
    {

        

        /// <summary>
        /// 使用促銷標籤 ID 查詢書本 BookWithSaleTagEntity
        /// </summary>
        public List<BookWithSaleTagEntity> GetBookBySaleTagId(int TagID, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT b.BookID, b.BookName, b.CreatedAt, b.SalePrice
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[UsedBookSaleTags] AS st
                    ON b.BookID = st.BookID
                WHERE st.TagID = @TagID;";
            return conn.Query<BookWithSaleTagEntity>(sqlString, new { TagID }, transaction: tran).ToList();
        }

        /// <summary>
        /// 使用書本 ID 查詢書本售價
        /// </summary>
        public decimal GetBookSalePriceByBookId(int bookId, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT SalePrice
                FROM [dbo].[UsedBooks]
                WHERE BookID = @bookId;";
            return conn.QuerySingle<decimal>(sqlString, new { bookId }, transaction: tran);
        }

        public int GetRandomBookId(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT TOP 1 BookID
                FROM [dbo].[UsedBooks]
                ORDER BY NEWID();";
            return conn.QuerySingle<int>(sqlString, transaction: tran);
        }

        /// <summary>
        /// 返回所有書籍資料
        /// </summary>
        public List<BookEntity> GetAllBooks(SqlConnection conn, SqlTransaction tran)
        {
            const string sqlString = @"
                SELECT [BookID], [UID], [BookName], [SalePrice], [BookCondition],
                       [Description], [CreatedAt], [ISBN], [Language], [Authors],
                       [Publisher], [PublicationDate], [ViewCount], [IsActive],
                       [IsSold], [Slug]
                FROM [dbo].[UsedBooks];";
            var result = conn.Query<BookEntity>(sqlString, transaction: tran).ToList();
            return result;
        }

        // TODO: 未測試
        public List<BookEntity> GetBookByKeyword(string keyword, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT *
                FROM [dbo].[UsedBooks]
                WHERE BookName LIKE @keyword OR Authors LIKE @keyword;";
            var result = conn.Query<BookEntity>(sqlString, param: new { keyword = $"%{keyword}%" }, transaction: tran).ToList();
            return result;
        }
    }
}