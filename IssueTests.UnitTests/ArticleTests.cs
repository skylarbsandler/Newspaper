using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newspaper.Models;

namespace NewspaperTests.UnitTests
{
    public class ArticleTests
    {
        [Fact]
        public void Article_IsCreatedWithCorrectPropertyValues()
        {
            var reporter1 = new Reporter() { Name = "Skylar Sandler", Speciality = "Arts", Articles = new List<Article>() };
            var issue1 = new Issue() { IssueDate = DateTime.Parse("2023-06-06"), Articles = new List<Article>() };

            var article1 = new Article() { Title = "June 7th News", Content = "Arts of the Day", Reporter = reporter1, Issue = issue1};

            Assert.Equal("June 7th News", article1.Title);
            Assert.Equal("Arts of the Day", article1.Content);
            Assert.Equal("Skylar Sandler", article1.Reporter.Name);
            Assert.Equal(DateTime.Parse("2023-06-06"), article1.Issue.IssueDate);
        }
    }
}
