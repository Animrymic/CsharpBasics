using Class09.BaseExercise.Models;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            Cinema cinema1 = new Cinema("Cineplexx", 5, GetMovies());
            Cinema cinema2 = new Cinema("Millennium", 3, GetMovies());

            List<Cinema> cinemas = new List<Cinema>();
            cinemas.Add(cinema1);
            cinemas.Add(cinema2);

            Console.WriteLine("Choose a cinema:");
            for (int i = 0; i < cinemas.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + cinemas[i].Name);
            }

            int cinemaChoice;
            bool validCinema = int.TryParse(Console.ReadLine(), out cinemaChoice);

            if (!validCinema || cinemaChoice < 1 || cinemaChoice > cinemas.Count)
                throw new Exception("Invalid cinema selection!");

            Cinema selectedCinema = cinemas[cinemaChoice - 1];

            Console.WriteLine("\n1. All movies");
            Console.WriteLine("2. By genre");

            int option;
            bool validOption = int.TryParse(Console.ReadLine(), out option);

            if (!validOption)
                throw new Exception("Invalid option!");

            if (option == 1)
            {
                ShowMovies(selectedCinema.ListOfMovies);

                int movieChoice;
                bool validMovie = int.TryParse(Console.ReadLine(), out movieChoice);

                if (!validMovie || movieChoice < 1 || movieChoice > selectedCinema.ListOfMovies.Count)
                    throw new Exception("Invalid movie selection!");

                selectedCinema.MoviePlaying(selectedCinema.ListOfMovies[movieChoice - 1]);
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter genre (Comedy, Horror, Action, Drama, SciFi):");

                string inputGenre = Console.ReadLine();

                Genre genre;
                bool validGenre = Enum.TryParse<Genre>(inputGenre, true, out genre);

                if (!validGenre)
                    throw new Exception("Invalid genre!");

                List<Movie> filteredMovies = selectedCinema.ListOfMovies
                    .Where(m => m.Genre == genre)
                    .ToList();

                if (filteredMovies.Count == 0)
                    throw new Exception("No movies found!");

                ShowMovies(filteredMovies);

                int movieChoice;
                bool validMovie = int.TryParse(Console.ReadLine(), out movieChoice);

                if (!validMovie || movieChoice < 1 || movieChoice > filteredMovies.Count)
                    throw new Exception("Invalid movie selection!");

                selectedCinema.MoviePlaying(filteredMovies[movieChoice - 1]);
            }
            else
            {
                throw new Exception("Invalid option!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ShowMovies(List<Movie> movies)
    {
        Console.WriteLine("\nMovies:");
        for (int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine(
                (i + 1) + ". " +
                movies[i].Title + " (" + movies[i].Genre + ")" +
                " | Rating: " + movies[i].Rating +
                " | Price: $" + movies[i].TicketPrice
            );
        }

        Console.Write("Choose a movie: ");
    }

    static List<Movie> GetMovies()
    {
        List<Movie> movies = new List<Movie>();

        movies.Add(new Movie("Inception", Genre.SciFi, 5));
        movies.Add(new Movie("Titanic", Genre.Drama, 4));
        movies.Add(new Movie("The Conjuring", Genre.Horror, 5));
        movies.Add(new Movie("Hangover", Genre.Comedy, 3));
        movies.Add(new Movie("Avengers", Genre.Action, 5));
        movies.Add(new Movie("Interstellar", Genre.SciFi, 5));
        movies.Add(new Movie("Joker", Genre.Drama, 4));
        movies.Add(new Movie("It", Genre.Horror, 4));
        movies.Add(new Movie("Deadpool", Genre.Action, 4));
        movies.Add(new Movie("Superbad", Genre.Comedy, 3));

        return movies;
    }
}