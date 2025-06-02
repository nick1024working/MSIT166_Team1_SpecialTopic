using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Repositories;
using System.Data.SqlClient;

namespace SpecialTopic.Tests.UsedBooks.Repositories
{
    [TestClass]
    public sealed class BookTopicRepositoryTests
    {
        private string _connString = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";

        [TestMethod]
        public void GetAllTopics_ShouldReturnListOfTopics()
        {
            // Arrange
            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction()) {

                    var repo = new BookTopicRepository();

                    // Act
                    var result = repo.GetAllTopics(conn, tran);

                    // Assert
                    Assert.IsNotNull(result);
                    Assert.IsInstanceOfType(result, typeof(List<BookTopicEntity>));
                    Assert.IsTrue(result.Count >= 0); // 允許空表，但至少能查出結果

                    tran.Commit(); // or tran.Rollback(); 視情況決定
                }
            }
        }
    }
}
