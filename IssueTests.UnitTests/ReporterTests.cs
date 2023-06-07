using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newspaper.Models;

namespace NewspaperTests.UnitTests
{
    public class ReporterTests
    {
        [Fact]

        public void Reporter_IsCreatedWithCorrectPropertyValues()
        {
            var reporter1 = new Reporter() { Name = "Skylar Sandler", Speciality = "Arts", Articles = new List<Article>() };

            Assert.Equal("Skylar Sandler", reporter1.Name);
            Assert.Equal("Arts", reporter1.Speciality);
            Assert.Empty(reporter1.Articles);
        }

    }
}
