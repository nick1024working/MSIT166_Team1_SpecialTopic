using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class TopicRepository
    {

        /// <summary>
        /// 負責從 [UsedBookTopics] 資料表查詢所有書籍主題（TopicID, TopicName）。
        /// </summary>
        public List<BookTopicEntity> GetAllTopics(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT TopicID, TopicName FROM [dbo].[BookTopics]";
            var result = conn.Query<BookTopicEntity>(sqlString, transaction: tran).ToList();
            return result;
        }

        public int CreateTopic(BookTopicEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                INSERT INTO [dbo].[BookTopics] ([TopicName])
                OUTPUT INSERTED.TopicID
                VALUES (@TopicName);";
            var result = conn.QuerySingle<int>(sqlString, entity, transaction: tran);
            return result;
        }

        public Unit DeleteTopicById(BookTopicEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                DELETE [dbo].[BookTopics]
                WHERE [TopicID] = @TopicID;";
            conn.Execute(sqlString, entity, transaction: tran);
            return Unit.Value;
        }
    }
}
