using System;

class MovieDetails
{
    // Fields to hold movie data
    string movieTitle;
    string director;
    string language;
    string releaseDate;
    int durationMinutes;

    // Constructor to assign values from user input
    public MovieDetails(string title, string director, string language, string releaseDate, int duration)
    {
        this.movieTitle = title;
        this.director = director;
        this.language = language;
        this.releaseDate = releaseDate;
        this.durationMinutes = duration;

        // Print assigned values
        Console.WriteLine("\n--- Movie Details Entered ---");
        Console.WriteLine($"Title: {this.movieTitle}");
        Console.WriteLine($"Director: {this.director}");
        Console.WriteLine($"Language: {this.language}");
        Console.WriteLine($"Release Date: {this.releaseDate}");
        Console.WriteLine($"Duration: {this.durationMinutes} minutes");
    }

    // Main method – program starts here
    static void Main()
    {
        Console.WriteLine("Enter Movie Details Below:");

        // Ask the user to input values
        Console.Write("Enter movie title: ");
        string title = Console.ReadLine();

        Console.Write("Enter director's name: ");
        string director = Console.ReadLine();

        Console.Write("Enter language: ");
        string language = Console.ReadLine();

        Console.Write("Enter release date (e.g. Jan-01-2024): ");
        string releaseDate = Console.ReadLine();

        Console.Write("Enter duration in minutes: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        // Create object using user input
        MovieDetails movie = new MovieDetails(title, director, language, releaseDate, duration);
    }
}
