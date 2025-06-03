using System.Data.SqlClient;
using Dapper;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class BookRepository
    {
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
    }
}