using SpecialTopic.UsedBooks.Backend.DTOs;
using System.Collections.Generic;
using SpecialTopic.UsedBooks.Backend.Repositories;
using SpecialTopic.UsedBooks.Backend.Utilities;
using System.Data.SqlClient;
using System;
using System.Linq;
using System.IO;
using SpecialTopic.UsedBooks.Backend.Entities;

namespace SpecialTopic.UsedBooks.Backend.Services
{
    /// <summary>
    /// 專門處理 BookCard 的查詢服務
    /// </summary>
    /// <remarks>
    /// 並非一般 Book 的CRUD。
    /// </remarks>
    public class BookCardService
    {
        private string _connString;
        private BookCardRepository _BookRepository;

        public BookCardService(string connString)
        {
            _connString = connString;
            _BookRepository = new BookCardRepository();
        }

        /// <summary>
        /// 轉換 BookCardEntity 至 BookCardDto。
        /// </summary>
        /// <param name="e">BookCardEntity</param>
        /// <returns>BookCardDto</returns>
        private BookCardDto MappingBookCardEntityToDto(BookCardEntity e)
        {
            return new BookCardDto
            {
                BookID = e.BookID,
                BookName = string.IsNullOrWhiteSpace(e.BookName) ? "無書名" : e.BookName,
                SalePrice = (int)e.SalePrice,
                Authors = string.IsNullOrWhiteSpace(e.Authors) ? "未知作者" : e.Authors,
                Description = string.IsNullOrWhiteSpace(e.Description) ? "（無描述）" : e.Description,
                ImagePath = ImageHelper.GetSafeImagePath(e.ImagePath)
            };
        }

        /// <summary>
        /// 從資料庫取得所有書籍主要資料+主圖片，
        /// 包含 BookID, BookName, SalePrice, Authors, Description, ImagePath。
        /// </summary>
        /// <returns>
        /// 包裝於 Result 物件中的 BookCardDto 清單；如發生例外，Result 物件將包含錯誤訊息。
        /// </returns>
        public Result<List<BookCardDto>> GetAllBookCards()
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _BookRepository.GetAllBookCards(conn, null);
                    var dtos = entities.Select(MappingBookCardEntityToDto).ToList();
                    return Result<List<BookCardDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookCardDto>>.Failure(ex.Message);
            }
        }

        public Result<List<BookCardDto>> GetBookCardsByTagId(int tagId)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _BookRepository.GetBookCardsByTagId(tagId, conn, null);
                    var dtos = entities.Select(MappingBookCardEntityToDto).ToList();
                    return Result<List<BookCardDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookCardDto>>.Failure(ex.Message);
            }
        }

        public Result<List<BookCardDto>> GetBookCardsByTopicId(int topicId)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _BookRepository.GetBookCardsByTopicId(topicId, conn, null);
                    var dtos = entities.Select(MappingBookCardEntityToDto).ToList();
                    return Result<List<BookCardDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookCardDto>>.Failure(ex.Message);
            }
        }


        public Result<List<BookCardDto>> GetBookCardsByKeyword(string keyword)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _BookRepository.GetBookCardsByKeyword(keyword, conn, null);
                    var dtos = entities.Select(MappingBookCardEntityToDto).ToList();
                    return Result<List<BookCardDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookCardDto>>.Failure(ex.Message);
            }
        }


        public Result<List<BookCardDto>> GetBookCardsByUserId(Guid userId)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _BookRepository.GetBookCardsByUserId(userId, conn, null);
                    var dtos = entities.Select(MappingBookCardEntityToDto).ToList();
                    return Result<List<BookCardDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookCardDto>>.Failure(ex.Message);
            }
        }
    }
}
