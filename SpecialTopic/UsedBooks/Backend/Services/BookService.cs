using SpecialTopic.UsedBooks.Backend.DTOs;
using System.Collections.Generic;
using SpecialTopic.UsedBooks.Backend.Repositories;
using SpecialTopic.UsedBooks.Backend.Utilities;
using System.Data.SqlClient;
using System;
using System.Linq;
using System.IO;

namespace SpecialTopic.UsedBooks.Backend.Services
{
    public class BookService
    {
        private string _connString;
        private string _defaultImagePath;
        private BookRepository _BookRepository;

        public BookService(string connString)
        {
            _connString = connString;
            _defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsedBooks", "Frontend", "Assets", "BookImages", "default.jpg");
            _BookRepository = new BookRepository();
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
                    var dtos = entities.Select(e => new BookCardDto
                    {
                        BookID = e.BookID,
                        BookName = string.IsNullOrWhiteSpace(e.BookName) ? "無書名" : e.BookName,
                        SalePrice = e.SalePrice,
                        Authors = string.IsNullOrWhiteSpace(e.Authors) ? "未知作者" : e.Authors,
                        Description = string.IsNullOrWhiteSpace(e.Description) ? "（無描述）" : e.Description,
                        ImagePath = ImagePathHelper.GetFullImagePath(e.ImagePath)
                    }).ToList();
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
                    var dtos = entities.Select(e => new BookCardDto
                    {
                        BookID = e.BookID,
                        BookName = string.IsNullOrWhiteSpace(e.BookName) ? "無書名" : e.BookName,
                        SalePrice = e.SalePrice,
                        Authors = string.IsNullOrWhiteSpace(e.Authors) ? "未知作者" : e.Authors,
                        Description = string.IsNullOrWhiteSpace(e.Description) ? "（無描述）" : e.Description,
                        ImagePath = ImagePathHelper.GetFullImagePath(e.ImagePath)
                    }).ToList();
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
