using System;

namespace StaticVsNonStaticExample
{
    // -------------------------------------
    // Static Class: Utility calculator
    // -------------------------------------
    // Only has static methods — cannot create an object of this class
    static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    // -------------------------------------
    // Non-Static Class: Represents a person
    // -------------------------------------
    class Person
    {
        // Fields (non-static)
        string name;
        int age;

        // Non-static method (needs object)
        public void SetDetails(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Static method (belongs to class, not object)
        public static void Greet()
        {
            Console.WriteLine("Hello! I am a person.");
        }
    }

    // -------------------------------------
    // Main Class
    // -------------------------------------
    class Program
    {
        static void Main()
        {
            // 🔹 Call static methods from static class
            int result1 = Calculator.Add(5, 10);
            int result2 = Calculator.Multiply(3, 4);

            Console.WriteLine($"Sum: {result1}");
            Console.WriteLine($"Product: {result2}");

            Console.WriteLine();

            // 🔹 Call static method from non-static class
            Person.Greet(); // No object needed

            // 🔹 Create an object of the non-static class
            Person person1 = new Person();
            person1.SetDetails("Alice", 25); // Setting data
            person1.ShowDetails();           // Displaying data

            Console.WriteLine();

            Person person2 = new Person();
            person2.SetDetails("Bob", 30);
            person2.ShowDetails();
        }
    }
}
