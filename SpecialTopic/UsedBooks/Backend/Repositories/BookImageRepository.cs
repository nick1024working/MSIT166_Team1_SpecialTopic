using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using Dapper;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class BookImageRepository
    {
        /// <summary>
        /// 產生 BookImage
        /// </summary>
        public Unit CreateBookImage(BookImageEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                INSERT INTO [dbo].[UsedBookImages]
                       ([BookID], [ImagePath], [ImageIndex], [UploadedAt])
                 VALUES
                       (@BookID ,@ImagePath ,@ImageIndex ,@UploadedAt)";
            var result = conn.Execute(sqlString, entity, transaction: tran);
            return Unit.Value;
        }

        public List<string> GetImagePathsByBookId(int BookID, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                SELECT [ImagePath]
                FROM [dbo].[UsedBookImages]
                WHERE [BookID] = @BookID";
            var result = conn.Query<string>(sqlString, new { BookID }, transaction: tran).ToList();
            return result;
        }
    }
}
