using System;
using System.Collections.Generic;

class DifferentReturnTypes
{
    // 1. Returns an integer
    public int GetInt()
    {
        return 100;
    }

    // 2. Returns a string
    public string GetString()
    {
        return "Hello, world!";
    }

    // 3. Returns a boolean
    public bool IsActive()
    {
        return true;
    }

    // 4. Returns a double
    public double GetDouble()
    {
        return 99.99;
    }

    // 5. Returns a float
    public float GetFloat()
    {
        return 23.45f;
    }

    // 6. Returns a char
    public char GetChar()
    {
        return 'A';
    }

    // 7. Returns a DateTime
    public DateTime GetCurrentDateTime()
    {
        return DateTime.Now;
    }

    // 8. Returns an array of integers
    public int[] GetIntArray()
    {
        return new int[] { 1, 2, 3, 4, 5 };
    }

 

    // 9. Returns a custom object (e.g., Student)
    public Student GetStudent()
    {
        return new Student
        {
            Name = "Ravi",
            Age = 22,
            Subject = "C#"
        };
    }
}

// Custom class for return type of method 10
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Subject { get; set; }
}


class ReturnType
{
    static void Main()
    {
        DifferentReturnTypes obj = new DifferentReturnTypes();

        Console.WriteLine("Int: " + obj.GetInt());
        Console.WriteLine("String: " + obj.GetString());
        Console.WriteLine("Bool: " + obj.IsActive());
        Console.WriteLine("Double: " + obj.GetDouble());
        Console.WriteLine("Float: " + obj.GetFloat());
        Console.WriteLine("Char: " + obj.GetChar());
        Console.WriteLine("DateTime: " + obj.GetCurrentDateTime());

        Console.WriteLine("Int Array: " + string.Join(", ", obj.GetIntArray()));

        
        var student = obj.GetStudent();
        Console.WriteLine($"Student: {student.Name}, {student.Age}, {student.Subject}");
    }
}
