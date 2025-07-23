using System;
using System.Collections;

class LibraryHashTableExample
{
    public static void TrackBooks()
    {
        // Create a hashtable to store book titles and their status
        Hashtable bookStatus = new Hashtable();

        // Add books with availability status
        bookStatus.Add("The Alchemist", "Available");
        bookStatus.Add("1984", "Checked Out");
        bookStatus.Add("C# Basics", "Available");
        bookStatus.Add("Data Structures", "Reserved");

        // Access a book status
        Console.WriteLine($"📖 Status of '1984': {bookStatus["1984"]}");

        // Update a book's status
        bookStatus["1984"] = "Available";

        // Remove a book
        bookStatus.Remove("C# Basics");

        // Display all books and their statuses
        Console.WriteLine("\n📚 Current Library Book Status:");
        foreach (DictionaryEntry entry in bookStatus)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Check if a book exists
        if (bookStatus.ContainsKey("The Alchemist"))
        {
            Console.WriteLine("\n✅ 'The Alchemist' is in the catalog.");
        }

        // Check if any book is Reserved
        if (bookStatus.ContainsValue("Reserved"))
        {
            Console.WriteLine("📌 A book is currently reserved.");
        }
    }

    static void Main(string[] args)
    {
        TrackBooks();
    }
}
