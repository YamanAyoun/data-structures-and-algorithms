# Code Challenge: Class 28

## Sorting Movie
write functions which sort domain objects. Your functions will receive an array of Movie objects. Each Movie object has a title (string), a year (number), 
and a list of genres (array of strings). One function will sort the movies by most recent year first. One function will sort the movies, 
alphabetical by title, but will ignore any leading “A”s, “An”s, or “The”s.

## Code

```
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
```
