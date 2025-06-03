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
        /// ���Ҧ�Result<List<BookCardDto>>�A�q�ߦ@�P�����Ҥ�k�C
        /// </summary>
        private void AssertBookCardList(Result<List<BookCardDto>> result)
        {

            Assert.IsTrue(result.IsSuccess, "IsSuccess ������ true");
            if (result.IsSuccess && result.Value.Count > 0)
            {
                foreach (var item in result.Value)
                {
                    Assert.IsTrue(item.BookID > 0, "BookID ���j�� 0");
                    Assert.IsFalse(string.IsNullOrWhiteSpace(item.BookName), "BookName ��������");
                    Assert.IsTrue(item.SalePrice > 0.0M, "SalePrice ���j�� 0");
                    Assert.IsFalse(string.IsNullOrWhiteSpace(item.ImagePath), "ImagePath ��������");

                    // TODO: ��ĳ��H���ɮרt�ΡA�o�̼ȮɫO�d�����ˬd
                    //Assert.IsTrue(File.Exists(item.ImagePath), $"�ɮפ��s�b�G{item.ImagePath}");
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

