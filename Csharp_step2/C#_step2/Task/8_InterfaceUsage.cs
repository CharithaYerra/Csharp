using System;
//  An interface in C# defines a **contract** — a set of method/property signatures.
//  It does NOT contain implementation.

// Create Interface
interface IShape
{
    // Method signature without implementation
    double CalculateArea();
    double CalculatePerimeter();
}

// Implement Interface in Class
class Rectangle : IShape
{
    // Properties of the rectangle
    public double Length { get; set; }
    public double Width { get; set; }

    // Implement CalculateArea from IShape
    public double CalculateArea()
    {
        return Length * Width;
    }

    // Implement CalculatePerimeter from IShape
    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

// Main Program
class InterfaceProgram
{
    static void Main()
    {
        // Create rectangle object
        Rectangle rect = new Rectangle
        {
            Length = 10,
            Width = 5
        };

        // Call methods from interface

        // Print basic dimensions of the rectangle
        Console.WriteLine("Rectangle Details:");
        Console.WriteLine($"Length: {rect.Length}");
        Console.WriteLine($"Width: {rect.Width}");
        Console.WriteLine($"Area: {rect.CalculateArea()}");
        Console.WriteLine($"Perimeter: {rect.CalculatePerimeter()}");
    }
}
