namespace Class09.BaseExercise.Models;

public class Cinema
{
    public string Name { get; set; }
    public int Halls { get; set; }
    public List<Movie> ListOfMovies { get; set; }

    public Cinema(string name, int halls, List<Movie> listOfMovies)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new Exception("Cinema name cannot be empty!");

        if (halls <= 0)
            throw new Exception("Cinema must have at least 1 hall!");

        if (listOfMovies == null)
            throw new Exception("Movie list cannot be null!");

        Name = name;
        Halls = halls;
        ListOfMovies = listOfMovies;
    }

    public void MoviePlaying(Movie movie)
    {
        if (movie == null)
            throw new Exception("Movie cannot be null!");

        Console.WriteLine($"Watching {movie.Title}");
    }
}
