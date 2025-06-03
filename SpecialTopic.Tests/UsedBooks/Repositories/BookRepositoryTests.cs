using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Repositories;
using System.Data.SqlClient;

namespace SpecialTopic.Tests.UsedBooks.Repositories
{
    [TestClass]
    public class BookRepositoryTests
    {
        private string _connString = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";

        /// <summary>
        /// 為所有List<BookCardEntity>查詢，訂立共同的驗證方法。
        /// </summary>
        private void AssertBookCardList(List<BookCardEntity> result)
        {
            Assert.IsNotNull(result, "回傳結果不應為 null");

            if (result.Count > 0)
            {
                var first = result.First();
                Assert.IsTrue(first.BookID > 0, "BookID 應大於 0");
                Assert.IsFalse(string.IsNullOrWhiteSpace(first.BookName), "BookName 不應為空");
                Assert.IsTrue(first.SalePrice > 0.0M, "SalePrice 應大於 0");
                Assert.IsFalse(string.IsNullOrWhiteSpace(first.ImagePath), "ImagePath 不應為空");
            }
        }

        [TestMethod]
        public void GetAllBookCards_ShouldReturnListOfBookCards()
        {
            // Arrange
            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    var repo = new BookRepository();
                    var result = repo.GetAllBookCards(conn, tran);
                    AssertBookCardList(result);
                    tran.Rollback();
                }
            }
        }

        [TestMethod]
        public void GetBookCardsByTagId_ShouldReturnListOfBookCards()
        {
            int tagId = 1;

            // Arrange
            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    var repo = new BookRepository();
                    var result = repo.GetBookCardsByTagId(tagId, conn, tran);
                    AssertBookCardList(result);
                    tran.Rollback();
                }
            }
        }
    }
}
