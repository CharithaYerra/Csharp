using System;

class User
{
    string name;
    int age;
    double marks;

    // Method with parameters and no return: Set data
    public void SetData(string userName, string ageInput, string marksInput)
    {
        name = userName.ToUpper(); // Using built-in function: ToUpper()
        age = Convert.ToInt32(ageInput); // String to int
        marks = Convert.ToDouble(marksInput); // String to double
    }

    // Method without parameters, no return: Display data
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Name Length: {name.Length}"); // built-in property
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Marks: {marks}");
    }

    // Method without parameters, with return value
    public double GetPercentage()
    {
        return Math.Round((marks / 100) * 100, 2); // Using Math.Round
    }

    // Method with parameters and return value
    public string GradeMessage(double percentage)
    {
        if (percentage >= 90)
            return "Excellent";
        else if (percentage >= 75)
            return "Very Good";
        else if (percentage >= 60)
            return "Good";
        else
            return "Needs Improvement";
    }
}

class Program
{
    static void Main()
    {
        User user1 = new User();

        // Taking string input for conversion
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.Write("Enter your marks (out of 100): ");
        string marks = Console.ReadLine();

        // Set the data
        user1.SetData(name, age, marks);

        Console.WriteLine("\n--- User Info ---");
        user1.DisplayInfo();

        // Call method with return
        double percent = user1.GetPercentage();
        Console.WriteLine($"\nPercentage: {percent}%");

        // Call method with parameter and return
        string grade = user1.GradeMessage(percent);
        Console.WriteLine($"Performance: {grade}");
    }
}
