using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SpecialTopic.UsedBooks.Backend.Entities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    /// <summary>
    /// 此類負責所有 BookCard 查詢
    /// </summary>
    public class BookCardRepository
    {
        // TODO: 此處有 ORDER BY，但名稱看不出來
        public List<BookCardEntity> GetAllBookCards(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0 AND b.IsActive = 1
                ORDER BY b.CreatedAt DESC;";
            var result = conn.Query<BookCardEntity>(sqlString, transaction: tran).ToList();
            return result;
        }

        public List<BookCardEntity> GetBookCardsByTagId(int tagId, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0 AND b.IsActive = 1
                JOIN [dbo].[UsedBookSaleTags] AS st ON b.BookID = st.BookID
                WHERE st.TagID = @tagId
                ORDER BY b.CreatedAt DESC;";
            var result = conn.Query<BookCardEntity>(sqlString, param: new { tagId }, transaction: tran).ToList();
            return result;
        }

        public List<BookCardEntity> GetBookCardsByTopicId(int topicId, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0 AND b.IsActive = 1
                JOIN [dbo].[UsedBookTopics] AS bt ON b.BookID = bt.BookID
                WHERE bt.TopicID = @topicId
                ORDER BY b.CreatedAt DESC;";
            var result = conn.Query<BookCardEntity>(sqlString, param: new { topicId }, transaction: tran).ToList();
            return result;
        }

        public List<BookCardEntity> GetBookCardsByKeyword(string keyword, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0 AND b.IsActive = 1
                WHERE b.BookName LIKE @keyword OR b.Authors LIKE @keyword
                ORDER BY b.CreatedAt DESC;";
            var result = conn.Query<BookCardEntity>(sqlString, param: new { keyword = $"%{keyword}%" }, transaction: tran).ToList();
            return result;
        }

        // TODO: 未測試
        public List<BookCardEntity> GetBookCardsByUserId(Guid userId, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0 AND b.IsActive = 1
                WHERE b.UID = @uid
                ORDER BY b.CreatedAt DESC;";
            var result = conn.Query<BookCardEntity>(sqlString, param: new { uid = userId }, transaction: tran).ToList();
            return result;
        }
    }
}