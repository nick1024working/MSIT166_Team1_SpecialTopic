using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Repositories;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.UsedBooks.Backend.Services
{
    public class UserService
    {
        private string _connString;
        private UserRepository _userRepository;

        public UserService(string connString)
        {
            _connString = connString;
            _userRepository = new UserRepository();
        }

        /// <summary>
        /// 取得一筆隨機使用者UID
        /// </summary>
        public Result<Guid> GetRandomUserId()
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var result = _userRepository.GetRandomUserId(conn, null);
                    return Result<Guid>.Success(result);
                }
            }
            catch (Exception ex)
            {
                return Result<Guid>.Failure(ex.Message);
            }
        }

        public Result<Guid> GetUserIdByPhone(string phone)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    var result = _userRepository.GetUserIdByPhone(phone, conn, null);
                    return Result<Guid>.Success(result);
                }
            }
            catch (Exception ex)
            {
                return Result<Guid>.Failure(ex.Message);
            }
        }
    }
}
