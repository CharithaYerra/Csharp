using System;

class SameReturnDifferentParameters
{
    // 1. No parameters
    public string GetMessage()
    {
        return "No parameters method";
    }

    // 2. One int parameter
    public string GetMessage(int number)
    {
        return $"You entered number: {number}";
    }

    // 3. One string parameter
    public string GetMessage(string name)
    {
        return $"Hello, {name}!";
    }

    // 4. Two int parameters
    public string GetMessage(int a, int b)
    {
        return $"Sum of {a} and {b} is {a + b}";
    }

    // 5. One double parameter
    public string GetMessage(double price)
    {
        return $"Price is ₹{price}";
    }

    // 6. Two string parameters
    public string GetMessage(string first, string last)
    {
        return $"Full name: {first} {last}";
    }

    // 7. One bool parameter
    public string GetMessage(bool isActive)
    {
        return isActive ? "Status: Active" : "Status: Inactive";
    }

    // 8. int and string
    public string GetMessage(int age, string name)
    {
        return $"{name} is {age} years old";
    }

    // 9. string and bool
    public string GetMessage(string item, bool available)
    {
        return available ? $"{item} is available" : $"{item} is not available";
    }

    // 10. char and double
    public string GetMessage(char grade, double percentage)
    {
        return $"You got grade {grade} with {percentage}%";
    }
}

class DifferentParameter
{
    static void Main()
    {
        SameReturnDifferentParameters obj = new SameReturnDifferentParameters();

        Console.WriteLine(obj.GetMessage());
        Console.WriteLine(obj.GetMessage(25));
        Console.WriteLine(obj.GetMessage("Ravi"));
        Console.WriteLine(obj.GetMessage(10, 20));
        Console.WriteLine(obj.GetMessage(199.99));
        Console.WriteLine(obj.GetMessage("Divya", "Charitha"));
        Console.WriteLine(obj.GetMessage(true));
        Console.WriteLine(obj.GetMessage(21, "Arjun"));
        Console.WriteLine(obj.GetMessage("Laptop", false));
        Console.WriteLine(obj.GetMessage('A', 92.5));
    }
}
