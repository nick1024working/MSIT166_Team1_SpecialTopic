using System;
using System.Data.SqlClient;
using Dapper;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class UserRepository
    {
        public Guid GetUserIdByPhone(string phone, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT [UID]
                FROM [dbo].[Users]
                WHERE [Phone] = @phone;";
            return conn.QuerySingle<Guid>(sqlString, new { phone }, transaction: tran);
        }

        public string GetOwnerPhoneByBookId(int bookId, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT Phone
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[Users] AS u
	                ON b.UID = u.UID
                WHERE b.BookID = @bookId;";
            return conn.QuerySingle<string>(sqlString, new { bookId }, transaction: tran);
        }

        public Guid GetRandomUserId(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT TOP 1 UID
                FROM [dbo].[Users]
                ORDER BY NEWID();";
            return conn.QuerySingle<Guid>(sqlString, transaction: tran);
        }
    }
}