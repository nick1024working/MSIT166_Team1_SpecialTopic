using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SpecialTopic.UsedBooks.Backend.Entities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    /// <summary>
    /// 負責從 [UsedBookTopics] 資料表查詢所有書籍主題（TopicID, TopicName）。
    /// </summary>
    public class BookTopicRepository
    {
        public List<BookTopicEntity> GetAllTopics(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT TopicID, TopicName FROM [dbo].[BookTopics]";
            var result = conn.Query<BookTopicEntity>(sqlString, transaction: tran).ToList();
            return result;
        }
    }
}
