using System;


//(string, int) student = ("siri", 21);
//Console.WriteLine(student.Item1); 
//Console.WriteLine(student.Item2); 

class TupleExample
{
    static void Main(string[] args)
    {
        // 1. Get book info using tuple (return)
        var book = GetBook();

        // 2. Access tuple items using Item1, Item2, Item3
        Console.WriteLine($"Book Details: {book.Item1}, {book.Item2}, ₹{book.Item3}");

        // 3. reconstruction of  the tuple into individual variables
        (string title, string author, double price) = GetBook();
        Console.WriteLine($"Deconstructed: Title: {title}, Author: {author}, Price: ₹{price}");

        // 4. Pass a tuple as parameter
        DisplayBook((title, author, price));
    }

    // Returns a tuple
    static (string, string, double) GetBook()
    {
        string title = "The Powor";
        string author = "Towerk";
        double price = 499.00;
        return (title, author, price);
    }

    // Accepts a tuple as parameter
    static void DisplayBook((string Title, string Author, double Price) book)
    {
        Console.WriteLine("\n Passed as Tuple Parameter:");
        Console.WriteLine($" Title: {book.Title}, Author: {book.Author}, Price: ₹{book.Price}");
    }
}
