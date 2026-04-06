
namespace Class09.BaseExercise.Models;

public enum Genre
{
    Comedy,
    Horror,
    Action,
    Drama,
    SciFi
}
public class Movie
{
    public string Title { get; set; }
    public Genre Genre { get; set; }
    public int Rating { get; set; }
    public double TicketPrice { get; set; }

    public Movie(string title, Genre genre, int rating)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new Exception("Title cannot be empty!");

            if (rating < 1 || rating > 5)
                throw new Exception("Rating must be between 1 and 5!");

            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * Rating;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating movie: {ex.Message}");
            throw; 
        }
    }
}
