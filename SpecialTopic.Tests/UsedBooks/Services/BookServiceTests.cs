using SpecialTopic.UsedBooks.Backend.DTOs;
using SpecialTopic.UsedBooks.Backend.Services;
using SpecialTopic.UsedBooks.Backend.Utilities;

namespace SpecialTopic.Tests.UsedBooks.Services
{
    [TestClass]
    public class BookServiceTests
    {
        private string _connString = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";

        /// <summary>
        /// 為所有Result<List<BookCardDto>>，訂立共同的驗證方法。
        /// </summary>
        private void AssertBookCardList(Result<List<BookCardDto>> result)
        {

            Assert.IsTrue(result.IsSuccess, "IsSuccess 必須為 true");
            if (result.IsSuccess && result.Value.Count > 0)
            {
                foreach (var item in result.Value)
                {
                    Assert.IsTrue(item.BookID > 0, "BookID 應大於 0");
                    Assert.IsFalse(string.IsNullOrWhiteSpace(item.BookName), "BookName 不應為空");
                    Assert.IsTrue(item.SalePrice > 0.0M, "SalePrice 應大於 0");
                    Assert.IsFalse(string.IsNullOrWhiteSpace(item.ImagePath), "ImagePath 不應為空");

                    // TODO: 建議抽象化檔案系統，這裡暫時保留直接檢查
                    //Assert.IsTrue(File.Exists(item.ImagePath), $"檔案不存在：{item.ImagePath}");
                }
            }

        }

        [TestMethod]
        public void GetAllBookCards()
        {
            // Arrange
            var service = new BookService(_connString);
            var result = service.GetAllBookCards();

            // Assert
            AssertBookCardList(result);
        }
    }

}

