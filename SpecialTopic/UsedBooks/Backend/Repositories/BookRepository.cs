using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class BookRepository
    {
        // TODO: 此處有 ORDER BY，但名稱看不出來
        public List<BookCardEntity> GetAllBookCards(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0
                ORDER BY b.CreatedAt DESC;";
            var result = conn.Query<BookCardEntity>(sqlString, transaction: tran).ToList();
            return result;
        }

        public List<BookCardEntity> GetBookCardsByTagId(int tagId, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
                FROM [dbo].[UsedBooks] AS b
                JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0
                JOIN [dbo].[UsedBookSaleTags] AS st ON b.BookID = st.BookID
                WHERE st.TagID = @tagId
                ORDER BY b.CreatedAt DESC;";
            var result = conn.Query<BookCardEntity>(sqlString, param: new { tagId }, transaction: tran).ToList();
            return result;
        }

        //public List<BookCardEntity> GetBookCardsByTopicId(int topicId, SqlConnection conn, SqlTransaction tran);
        //string sqlStringByTopic = @"
        //SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
        //FROM [dbo].[UsedBooks] AS b
        //JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0
        //JOIN [dbo].[UsedBookTopics] AS bt ON b.BookID = bt.BookID
        //WHERE bt.TopicID = @topicId
        //ORDER BY b.CreatedAt DESC;";

        //public List<BookCardEntity> GetBookCardsByKeyword(string keyword, SqlConnection conn, SqlTransaction tran);
        //string sqlStringByKeyword = @"
        //SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
        //FROM [dbo].[UsedBooks] AS b
        //JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0
        //WHERE b.BookName LIKE '%' + @keyword + '%' OR b.Authors LIKE '%' + @keyword + '%'
        //ORDER BY b.CreatedAt DESC;";


        //public List<BookCardEntity> GetBookCardsByUserId(Guid userId, SqlConnection conn, SqlTransaction tran);
        //string sqlStringByUid = @"
        //SELECT b.[BookID], [BookName], [SalePrice], [Authors], [Description], [ImagePath]
        //FROM [dbo].[UsedBooks] AS b
        //JOIN [dbo].[UsedBookImages] AS i ON b.BookID = i.BookID AND i.ImageIndex = 0
        //WHERE b.UID = @uid
        //ORDER BY b.CreatedAt DESC;";

    }
}