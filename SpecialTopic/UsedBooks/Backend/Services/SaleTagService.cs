using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Repositories;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Services
{
    public class SaleTagService
    {
        private string _connString;
        private SaleTagRepository _saleTagRepository;

        public SaleTagService(string connString)
        {
            _connString = connString;
            _saleTagRepository = new SaleTagRepository();
        }

        /// <summary>
        /// 從資料庫取得所有書籍促銷標籤，包含 TagID 與 TagName。
        /// </summary>
        /// <returns>
        /// 包裝於 Result 物件中的 TagDto 清單；如發生例外，Result 物件將包含錯誤訊息。
        /// </returns>
        public Result<List<SaleTagDto>> GetAllSaleTags()
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _saleTagRepository.GetAllSaleTags(conn, null);
                    var dtos = entities.Select(e => new SaleTagDto
                    {
                        TagID = e.TagID,
                        TagName = e.TagName
                    }).ToList();
                    return Result<List<SaleTagDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<SaleTagDto>>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 用 dto 建立促銷標籤
        /// </summary>
        public Result<int> CreateSaleTag(CreateSaleTagDto dto)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entity = new SaleTagEntity { TagName = dto.TagName };
                    int newTopicId = _saleTagRepository.CreateSaleTag(entity, conn, null);
                    return Result<int>.Success(newTopicId);
                }
            }
            catch (Exception ex)
            {
                return Result<int>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 使用促銷標籤 ID 刪除促銷標籤
        /// </summary>
        public Result<Unit> DeleteSaleTagById(int id)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entity = new SaleTagEntity { TagID = id };
                    var result = _saleTagRepository.DeleteSaleTagById(entity, conn, null);
                    return Result<Unit>.Success(result);
                }
            }
            catch (Exception ex)
            {
                return Result<Unit>.Failure(ex.Message);
            }
        }
    }
}
