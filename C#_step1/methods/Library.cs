using System;

class Library
{
    static void Main()
    {
        string[] books = { "Harry Potter", "C# Basics", "The Alchemist", "The Hobbit" };
        bool[] isAvailable = { true, false, true, true };

        ShowBooks(books, isAvailable);

        Console.Write("\nEnter the book you want to issue: ");
        string bookToIssue = Console.ReadLine();

        if (IsBookAvailable(books, isAvailable, bookToIssue))
        {
            IssueBook(books, isAvailable, bookToIssue);
        }
        else
        {
            Console.WriteLine("Either the book is not available or not in the list.");
        }

        ShowBooks(books, isAvailable);
    }

    static void ShowBooks(string[] books, bool[] isAvailable)
    {
        Console.WriteLine("\n Available Books:");
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i]} - {(isAvailable[i] ? "Available" : "Issued")}");
        }
    }

    static bool IsBookAvailable(string[] books, bool[] isAvailable, string bookName)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].ToLower().Equals(bookName.ToLower()))
            {
                return isAvailable[i];
            }
        }
        return false;
    }

    static void IssueBook(string[] books, bool[] isAvailable, string bookName)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].ToLower().Equals(bookName.ToLower()))
            {
                if (isAvailable[i])
                {
                    isAvailable[i] = false;
                    Console.WriteLine($" '{bookName}' has been issued to you.");
                }
                else
                {
                    Console.WriteLine($" '{bookName}' is already issued.");
                }
                return;
            }
        }
        Console.WriteLine($" '{bookName}' not found in the library.");
    }

    
}
