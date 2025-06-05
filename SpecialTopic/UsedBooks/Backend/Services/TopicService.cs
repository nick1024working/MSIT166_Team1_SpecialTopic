using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Repositories;
using SpecialTopic.UsedBooks.Backend.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SpecialTopic.UsedBooks.Backend.Services
{
    public class TopicService
    {
        private string _connString;
        private TopicRepository _bookTopicRepository;

        public TopicService(string connString)
        {
            _connString = connString;
            _bookTopicRepository = new TopicRepository();
        }

        /// <summary>
        /// 從資料庫取得所有書籍主題，包含 TopicID 與 TopicName。
        /// </summary>
        /// <returns>
        /// 包裝於 Result 物件中的 TopicDto 清單；如發生例外，Result 物件將包含錯誤訊息。
        /// </returns>
        public Result<List<TopicDto>> GetAllTopics()
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _bookTopicRepository.GetAllTopics(conn, null);
                    var dtos = entities.Select(e => new TopicDto
                        {
                            TopicID = e.TopicID,
                            TopicName = e.TopicName
                    }).ToList();
                    return Result<List<TopicDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<TopicDto>>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 用 dto 建立主題
        /// </summary>
        public Result<int> CreateTopic(CreateTopicDto dto)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entity = new BookTopicEntity { TopicName = dto.TopicName };
                    int newTopicId = _bookTopicRepository.CreateTopic(entity, conn, null);
                    return Result<int>.Success(newTopicId);
                }
            }
            catch (Exception ex)
            {
                return Result<int>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 使用主題 ID 刪除主題
        /// </summary>
        public Result<Unit> DeleteTopicById(int id)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entity = new BookTopicEntity { TopicID = id };
                    var result = _bookTopicRepository.DeleteTopicById(entity, conn, null);
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
