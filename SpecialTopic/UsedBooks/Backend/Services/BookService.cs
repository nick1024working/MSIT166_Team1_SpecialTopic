using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
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

        public Result<decimal> GetBookSalePriceByBookId(int bookId)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var result = _bookRepository.GetBookSalePriceByBookId(bookId, conn, null);
                    return Result<decimal>.Success(result);
                }
            }
            catch (Exception ex)
            {
                return Result<decimal>.Failure(ex.Message);
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
    }
}
