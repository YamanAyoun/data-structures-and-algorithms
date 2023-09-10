using System;

namespace Sorting_Movie
{
    public class Program
    {

        public class Movie
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public List<string> Genres { get; set; }


        }

        public static List<Movie> SortedByYear(List<Movie> movie)
        {
            for (int i = 0; i < movie.Count - 1; i++)
            {
                for (int j = 0; j < movie.Count - i - 1; j++)
                {
                    if (movie[j].Year < movie[j + 1].Year)
                    {
                        
                        Movie temp = movie[j];
                        movie[j] = movie[j + 1];
                        movie[j + 1] = temp;
                    }
                }
            }
            return movie;
        }
        
        public static List<Movie> SortedByTitle(List<Movie> movies)
        {
            
            var sortedMovies = movies.OrderBy(movie => movie.Title).ToList();
            return sortedMovies;
        }

        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "Super Man", Year = 2012, Genres = new List<string> { "Action", "Crime", "Drama" } },
            new Movie { Title = "The Avengers", Year = 2013, Genres = new List<string> { "Action", "Crime", "Drama" } },
            new Movie { Title = "A Bat Man", Year = 2010, Genres = new List<string> { "Action", "Crime", "Drama" } }
        };

            List<Movie> sortedByYear = SortedByYear(new List<Movie>(movies));
            Console.WriteLine("Sorted by Year:");
            foreach (Movie movie in sortedByYear)
            {
                Console.WriteLine($"{movie.Title} ({movie.Year})");
            }

            }
        
    } 
    }