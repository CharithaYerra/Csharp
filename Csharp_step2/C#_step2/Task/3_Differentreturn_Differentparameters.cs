using System;

class DifferentReturnsWithDifferentParameters
{
    // 1. Returns int
    public int Add(int a, int b)
    {
        return a + b;
    }

    // 2. Returns string
    public string Greet(string name)
    {
        return $"Hello, {name}!";
    }

    // 3. Returns bool
    public bool IsAdult(int age)
    {
        return age >= 18;
    }

    // 4. Returns double
    public double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // 5. Returns char
    public char GetFirstLetter(string word)
    {
        return string.IsNullOrEmpty(word) ? '?' : word[0];
    }

    // 6. Returns DateTime
    public DateTime GetFutureDate(int daysFromNow)
    {
        return DateTime.Now.AddDays(daysFromNow);
    }

    // 7. Returns float
    public float ConvertToFahrenheit(float celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // ✅ 8. Returns a simple string with even numbers
    public string GetEvenNumbers(int max)
    {
        string result = "";
        for (int i = 1; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                result += i + " ";
            }
        }
        return result.Trim();  // Remove trailing space
    }

    // 9. Returns string array
    public string[] GetSubjects()
    {
        return new string[] { "Math", "Science", "English" };
    }

    // 10. Returns custom object
    public StudentDetails CreateStudent(string name, int age, string course)
    {
        return new StudentDetails
        {
            Name = name,
            Age = age,
            Course = course
        };
    }

}

// Custom class for method 10
class StudentDetails
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }
}

// Program entry point
class DifferentReturnWithDifferentParametersProgram
{
    static void Main()
    {
        var obj = new DifferentReturnsWithDifferentParameters();

        Console.WriteLine("1. Add: " + obj.Add(10, 20));
        Console.WriteLine("2. Greet: " + obj.Greet("Divya"));
        Console.WriteLine("3. Is Adult: " + obj.IsAdult(17));
        Console.WriteLine("4. Area of Circle: " + obj.CalculateArea(3.5));
        Console.WriteLine("5. First Letter: " + obj.GetFirstLetter("Apple"));
        Console.WriteLine("6. Future Date: " + obj.GetFutureDate(5));
        Console.WriteLine("7. Temperature in Fahrenheit: " + obj.ConvertToFahrenheit(25f));
        Console.WriteLine("8. Even Numbers: " + obj.GetEvenNumbers(10));
        Console.WriteLine("9. Subjects: " + string.Join(", ", obj.GetSubjects()));

        var student = obj.CreateStudent("Ravi", 21, "C#");
        Console.WriteLine($"10. Student Info: {student.Name}, {student.Age}, {student.Course}");
    }
}
