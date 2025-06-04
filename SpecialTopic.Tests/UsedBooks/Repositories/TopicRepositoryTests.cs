using SpecialTopic.UsedBooks.Backend.Entities;
using SpecialTopic.UsedBooks.Backend.Repositories;
using System.Data.SqlClient;

namespace SpecialTopic.Tests.UsedBooks.Repositories
{
    [TestClass]
    public sealed class TopicRepositoryTests
    {
        private string _connString = "Data Source=.;Initial Catalog=TeamA_Project;Integrated Security=True";

        // NOTE: 此測試僅作為 Repository 冒煙測試用，不屬於核心單元測試
        [TestMethod]
        public void GetAllTopics_ShouldReturnListOfTopics()
        {
            // Arrange
            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction()) {

                    var repo = new TopicRepository();

                    // Act
                    var result = repo.GetAllTopics(conn, tran);

                    // Assert
                    Assert.IsNotNull(result);

                    tran.Rollback();
                }
            }
        }
    }
}
