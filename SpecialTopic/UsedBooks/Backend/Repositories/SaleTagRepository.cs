using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    public class SaleTagRepository
    {

        /// <summary>
        /// 負責從 [SaleTags] 資料表查詢所有書籍促銷標籤（TagID, TagName）。
        /// </summary>
        public List<SaleTagEntity> GetAllSaleTags(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT TagID, TagName FROM [dbo].[SaleTags]";
            var result = conn.Query<SaleTagEntity>(sqlString, transaction: tran).ToList();
            return result;
        }

        public int CreateSaleTag(SaleTagEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                INSERT INTO [dbo].[SaleTags] ([TagName])
                OUTPUT INSERTED.TagID
                VALUES (@TagName);";
            var result = conn.QuerySingle<int>(sqlString, entity, transaction: tran);
            return result;
        }

        public Unit DeleteSaleTagById(SaleTagEntity entity, SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"
                DELETE [dbo].[SaleTags]
                WHERE [TagID] = @TagID;";
            conn.Execute(sqlString, entity, transaction: tran);
            return Unit.Value;
        }
    }
}
