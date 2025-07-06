using System;

// This class stores information about a book using fields and constructors
class BookDetails
{
    // ------------------------------
    // Instance fields (not static)
    // These store book data for each object
    // ------------------------------
    string bookTitle = "Unknown Title";
    string author = "Unknown Author";
    string genre = "Not specified";
    string publishedDate = "N/A";
    int pages = 0;

    // ------------------------------
    // Default Constructor (no parameters)
    // Called automatically when you create an object with: new BookDetails()
    // ------------------------------
    public BookDetails()
    {
        Console.WriteLine("Default Book object created");

        // Assign values to fields using 'this' to refer to current object
        this.bookTitle = "C# Programming";
        this.author = "John Doe";
        this.genre = "Education";
        this.publishedDate = "Jan-01-2020";
        this.pages = 350;

        // Print the field values
        Console.WriteLine(this.bookTitle);
        Console.WriteLine(this.author);
        Console.WriteLine(this.genre);
        Console.WriteLine(this.publishedDate);
        Console.WriteLine($"{this.pages} pages");
    }

    // ------------------------------
    // Parameterized Constructor
    // Allows the programmer to pass values at the time of object creation
    // ------------------------------
    public BookDetails(string bookTitle, string author, string genre, string publishedDate, int pages)
    {
        Console.WriteLine("Custom Book object created");

        // Use the parameters to assign values to the object's fields
        this.bookTitle = bookTitle;
        this.author = author;
        this.genre = genre;
        this.publishedDate = publishedDate;
        this.pages = pages;

        // Print the field values
        Console.WriteLine(this.bookTitle);
        Console.WriteLine(this.author);
        Console.WriteLine(this.genre);
        Console.WriteLine(this.publishedDate);
        Console.WriteLine($"{this.pages} pages");
    }

    // ------------------------------
    // Main method (entry point of the program)
    // This method is automatically called when you run the program
    // ------------------------------
    static void Main()
    {
        // Create a BookDetails object using the default constructor
        // This will use the hardcoded values inside the default constructor
        BookDetails defaultBook = new BookDetails();

        Console.WriteLine(); // Add a blank line to separate output

        // Create a BookDetails object using the parameterized constructor
        // This will pass custom values at the time of object creation
        BookDetails customBook = new BookDetails(
            "Harry Potter and the Sorcerer's Stone",  // bookTitle
            "J.K. Rowling",                           // author
            "Fantasy",                                // genre
            "June-26-1997",                           // publishedDate
            309                                       // pages
        );
    }
}
