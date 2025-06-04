using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SpecialTopic.UsedBooks.Backend.Entities;

namespace SpecialTopic.UsedBooks.Backend.Repositories
{
    /// <summary>
    /// 負責從 [SaleTags] 資料表查詢所有書籍促銷標籤（TagID, TagName）。
    /// </summary>
    public class SaleTagRepository
    {
        public List<SaleTagEntity> GetAllSaleTags(SqlConnection conn, SqlTransaction tran)
        {
            string sqlString = @"SELECT TagID, TagName FROM [dbo].[SaleTags]";
            var result = conn.Query<SaleTagEntity>(sqlString, transaction: tran).ToList();
            return result;
        }
    }
}
