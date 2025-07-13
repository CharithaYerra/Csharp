using System;

// Importing custom namespaces so we can directly use Book and LibraryOperations
using LibraryApp.Models;
using LibraryApp.Operations;

//////////////////////////////
// Namespace for Book class
//////////////////////////////
namespace LibraryApp.Models
{
    public class Book
    {
        public string Title { get; set; }        // Book title
        public string Author { get; set; }       // Author of the book
        public int YearPublished { get; set; }   // Year of publication
    }
}

//////////////////////////////////////////
// Namespace for operations on Book class
//////////////////////////////////////////
namespace LibraryApp.Operations
{
    public class LibraryOperations
    {
        // This method displays book details
        public void DisplayBookInfo(Book book)
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Year Published: {book.YearPublished}");
        }
    }
}


// Main Program Namespace

namespace LibraryApp
{
    class Program
    {
        static void Main()
        {
            // Creating and initializing a book object
            Book myBook = new Book
            {
                Title = "C# Basics",
                Author = "John Smith",
                YearPublished = 2022
            };

            // Creating an object for LibraryOperations
            LibraryOperations libOps = new LibraryOperations();

            // Calling method to display book information
            libOps.DisplayBookInfo(myBook);
        }
    }
}
