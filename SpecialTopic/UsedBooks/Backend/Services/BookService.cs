using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Repositories;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Services
{

    public class BookService
    {
        private string _connString;
        private BookRepository _bookRepository;

        public BookService(string connString)
        {
            _connString = connString;
            _bookRepository = new BookRepository();
        }


        /// <summary>
        /// 根據促銷標籤 ID 查詢書籍清單
        /// </summary>
        /// <remarks>價格、時間已轉成 string</remarks>
        public Result<List<BookWithSaleTagDto>> GetBookBySaleTagId(int tagId)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _bookRepository.GetBookBySaleTagId(tagId, conn, null);
                    var dtos = entities.Select(e => new BookWithSaleTagDto
                    {
                        BookID = e.BookID,
                        BookName = e.BookName,
                        CreatedAt = e.CreatedAt.ToString("yyyy-MM-dd"),
                        SalePrice = (int)e.SalePrice
                    }).ToList();
                    return Result<List<BookWithSaleTagDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookWithSaleTagDto>>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 把 Entity 轉完整 dto（給後台或編輯用途）
        /// </summary>
        /// <remarks>價格、時間已轉成 string</remarks>
        private BookDto MappingBookEntityToDto(BookEntity e)
        {
            return new BookDto
            {
                BookID = e.BookID,
                UID = e.UID,
                BookName = e.BookName,
                SalePrice = (int)e.SalePrice,
                BookCondition = e.BookCondition,
                Description = e.Description,
                CreatedAt = e.CreatedAt.ToString("yyyy-MM-dd"),
                ISBN = e.ISBN,
                Language = e.Language,
                Authors = e.Authors,
                Publisher = e.Publisher,
                PublicationDate = e.PublicationDate?.ToString("yyyy-MM-dd") ?? "",
                ViewCount = e.ViewCount,
                IsActive = e.IsActive,
                IsSold = e.IsSold,
                Slug = e.Slug,
            };
        }


        /// <summary>
        /// 把 Entity 轉公開的 dto（前台用）
        /// </summary>
        /// <remarks>價格、時間已轉成 string，補足缺漏欄位文字</remarks>
        private BookPublicDto MappingBookEntityToPublicDto(BookEntity e)
        {
            return new BookPublicDto
            {
                BookName = string.IsNullOrWhiteSpace(e.BookName) ? "無書名" : e.BookName,
                SalePrice = (int)e.SalePrice,
                BookCondition = string.IsNullOrWhiteSpace(e.BookCondition) ? "未知" : e.BookCondition,
                Description = string.IsNullOrWhiteSpace(e.Description) ? "（無描述）" : e.Description,
                CreatedAt = e.CreatedAt.ToString("yyyy-MM-dd"),
                ISBN = string.IsNullOrWhiteSpace(e.ISBN) ? "無ISBN" : e.ISBN,
                Language = string.IsNullOrWhiteSpace(e.Language) ? "未知語言" : e.Language,
                Authors = string.IsNullOrWhiteSpace(e.Authors) ? "未知作者" : e.Authors,
                Publisher = string.IsNullOrWhiteSpace(e.Publisher) ? "未知出版社" : e.Publisher,
                PublicationDate = e.PublicationDate?.ToString("yyyy-MM-dd") ?? "無出版日期",
                ViewCount = e.ViewCount
            };
        }

        /// <summary>
        /// 使用書本 ID 查詢書本售價，轉成int
        /// </summary>
        public Result<int> GetBookSalePriceByBookId(int bookId)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var result = _bookRepository.GetBookSalePriceByBookId(bookId, conn, null);
                    return Result<int>.Success((int)result);
                }
            }
            catch (Exception ex)
            {
                return Result<int>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 取得一筆隨機 BookID
        /// </summary>
        public Result<int> GetRandomBookId()
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var result = _bookRepository.GetRandomBookId(conn, null);
                    return Result<int>.Success(result);
                }
            }
            catch (Exception ex)
            {
                return Result<int>.Failure(ex.Message);
            }
        }

        /// /// <summary>
        /// 從資料庫取得所有書籍主要資料，轉完整 dto（給Admin用）。
        /// </summary>
        /// <returns>
        /// 包裝於 Result 物件中的 BookDto 清單；如發生例外，Result 物件將包含錯誤訊息。
        /// </returns>
        public Result<List<BookDto>> GetAllBooks()
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _bookRepository.GetAllBooks(conn, null);
                    var dtos = entities.Select(MappingBookEntityToDto).ToList();
                    return Result<List<BookDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookDto>>.Failure(ex.Message);
            }
        }

        /// /// <summary>
        /// 從資料庫取得所有書籍主要資料，轉公開 dto（只有公開資訊）。
        /// </summary>
        /// <returns>
        /// 包裝於 Result 物件中的 BookPublicDto 清單；如發生例外，Result 物件將包含錯誤訊息。
        /// </returns>
        public Result<List<BookPublicDto>> GetAllPublicBooks()
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _bookRepository.GetAllBooks(conn, null);
                    var dtos = entities.Select(MappingBookEntityToPublicDto).ToList();
                    return Result<List<BookPublicDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookPublicDto>>.Failure(ex.Message);
            }
        }

        /// /// <summary>
        /// 使用 keyword 從資料庫取得所有書籍主要資料，轉完整 dto（給Admin用）。
        /// </summary>
        /// <returns>
        /// 包裝於 Result 物件中的 BookDto 清單；如發生例外，Result 物件將包含錯誤訊息。
        /// </returns>
        public Result<List<BookDto>> GetBookByKeyword(string keyword)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var entities = _bookRepository.GetBookByKeyword(keyword, conn, null);
                    var dtos = entities.Select(MappingBookEntityToDto).ToList();
                    return Result<List<BookDto>>.Success(dtos);
                }
            }
            catch (Exception ex)
            {
                return Result<List<BookDto>>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 使用書本 ID 刪除書本
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public Result<Unit> DeleteBookById(int id)
        //{
        //    try
        //    {
        //        using (var conn = new SqlConnection(_connString))
        //        {
        //            conn.Open();
        //            var enity
        //            var result = _bookRepository.DeleteBookById(id);
        //            return Result<Unit>.Success(result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Result<Unit>.Failure(ex.Message);
        //    }
        //}
    }
}
