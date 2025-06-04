using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
        private BookImageRepository _bookImageRepository;

        public BookService(string connString)
        {
            _connString = connString;
            _bookRepository = new BookRepository();
            _bookImageRepository = new BookImageRepository();
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
        /// 把 dto 轉 entity
        /// </summary>
        public BookEntity MappingBookDtoToEntity(CreateBookDto dto)
        {
            return new BookEntity
            {
                UID = dto.UID,
                BookName = dto.BookName?.Trim(),
                SalePrice = dto.SalePrice,
                BookCondition = dto.BookCondition?.Trim(),
                Description = dto.Description?.Trim(),
                ISBN = dto.ISBN?.Trim(),
                Language = dto.Language?.Trim(),
                Authors = dto.Authors?.Trim(),
                Publisher = dto.Publisher?.Trim(),
                PublicationDate = dto.PublicationDate,
                CreatedAt = DateTime.Now,                               // 系統填入
                ViewCount = 0,                                          // 預設為 0
                IsActive = dto.IsActive,
                IsSold = false,                                         // 預設未售出
                Slug = Guid.NewGuid().ToString("N").Substring(0, 8)     //使用 GUID 後 8 碼
            };
        }

        /// <summary>
        /// 把 entity 轉完整 dto（給後台或編輯用途）
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
        /// 新增完整書本(文字+圖片清單)至 DB。
        /// </summary>
        public Result<int> CreateBook(CreateBookDto bookDto, List<CreateBookImageDto> bookImageDtos)
        {
            var bookEntity = MappingBookDtoToEntity(bookDto);

            // 開始查詢與交易
            // HACK: 不分別對查詢做錯誤處理
            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 儲存書本資料
                        int newBookId = _bookRepository.CreateBook(bookEntity, conn, tran);

                        // 確保位置存在
                        Directory.CreateDirectory(ImageHelper.DefaultAbsluteBookImageFolderPath);

                        foreach (var bookImageDto in bookImageDtos)
                        {
                            // 每張圖產生唯一檔名
                            string fileName = $"{Guid.NewGuid():N}{bookImageDto.Ext}";
                            string absolutePath = Path.Combine(ImageHelper.DefaultAbsluteBookImageFolderPath, fileName);
                            string relativePath = Path.Combine(ImageHelper.DefaultRelativeBookImageFolderPath, fileName);

                            // 副檔名對應格式
                            var format = GetImageFormatFromExtension(bookImageDto.Ext);
                            bookImageDto.BookImage.Save(absolutePath, format);

                            var bookImageEntity = new BookImageEntity
                            {
                                BookID = newBookId, // 建立主從關聯
                                ImagePath = relativePath,
                                ImageIndex = bookImageDto.ImageIndex,
                                UploadedAt = DateTime.Now
                            };
                            _bookImageRepository.CreateBookImage(bookImageEntity, conn, tran);
                        }
                        tran.Commit();
                        return Result<int>.Success(newBookId);
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        // HACK: 如果是內部錯誤或資料庫錯誤，這可能包含敏感訊息。
                        return Result<int>.Failure(ex.Message);
                    }
                }
            }
        }

        private ImageFormat GetImageFormatFromExtension(string ext)
        {
            ext = ext.ToLower(); // 確保小寫
            switch (ext)
            {
                case ".jpg":
                case ".jpeg":
                    return ImageFormat.Jpeg;

                case ".png":
                    return ImageFormat.Png;

                case ".bmp":
                    return ImageFormat.Bmp;

                case ".gif":
                    return ImageFormat.Gif;

                default:
                    return ImageFormat.Jpeg; // 預設使用 JPEG
            }
        }


        /// <summary>
        /// 新增書本文字資料至 DB。
        /// </summary>
        public Result<int> CreateBook(CreateBookDto dto)
        {
            var entity = MappingBookDtoToEntity(dto);
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var result = _bookRepository.CreateBook(entity, conn, null);
                    return Result<int>.Success(result);
                }
            }
            catch (Exception ex)
            {
                return Result<int>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 更改書本上下架狀態
        /// </summary>
        public Result<Unit> UpdateBookIsActive(BookIsActiveDto dto)
        {
            var entity = new BookIsActiveEntity
            {
                BookID = dto.BookID,
                IsActive = dto.IsActive
            };
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var result = _bookRepository.UpdateBookIsActive(entity, conn, null);
                    return Result<Unit>.Success(result);
                }
            }
            catch (Exception ex)
            {
                return Result<Unit>.Failure(ex.Message);
            }
        }

        /// <summary>
        /// 使用書本 ID 刪除書本，並清除 local 檔案（實體圖片）
        /// </summary>
        /// <remarks>需搭配資料庫 FK ON DELETE CASCADE</remarks>
        public Result<Unit> DeleteBookWithFilesByBookId(int id)
        {
            var imagePaths = new List<string>();

            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        imagePaths = _bookImageRepository.GetImagePathsByBookId(id, conn, tran);
                        _bookRepository.DeleteBookByBookId(id, conn, tran);
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        return Result<Unit>.Failure(ex.Message);
                    }
                }

            }
            
            // 刪除圖片實體檔案（不含在交易，不占用連線時間）
            foreach (var path in imagePaths)
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
