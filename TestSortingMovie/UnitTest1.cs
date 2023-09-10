using static Sorting_Movie.Program;

namespace TestSortingMovie
{
    public class UnitTest1
    {
        [Fact]
        public void TestSortedByYear()
        {
            // Arrange
            List<Movie> movies = new List<Movie>
            {
                new Movie { Title = "Super Man", Year = 1994, Genres = new List<string> { "Action", "Crime", "Drama" } },
                new Movie { Title = "The Avengers", Year = 1994, Genres = new List<string> { "Action", "Crime", "Drama" } },
                new Movie { Title = "A Bat Man", Year = 2010, Genres = new List<string> { "Action", "Crime", "Drama" } }
            };

            // Act
            List<Movie> sortedByYear = SortedByYear(new List<Movie>(movies));

            // Assert
            Assert.Equal("A Bat Man", sortedByYear[0].Title);
            Assert.Equal("Super Man", sortedByYear[1].Title);
            Assert.Equal("The Avengers", sortedByYear[2].Title);
        }
    }
}