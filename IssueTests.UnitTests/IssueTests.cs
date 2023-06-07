using Newspaper.Models;

namespace IssueTests.UnitTests
{
    public class IssueTests
    {
        [Fact]
        public void Issue_IsCreatedWithCorrectPropertyValues()
        {
            var issue1 = new Issue() { IssueDate = DateTime.Parse("2023-06-06"), Articles = new List<Article>() };

            Assert.Equal(DateTime.Parse("2023-06-06"), issue1.IssueDate);
            Assert.Empty(issue1.Articles);
        }
    }
}