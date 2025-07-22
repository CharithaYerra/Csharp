using System;

namespace step4 { 
class SimpleTupleExample
{
    static void Main()
    {
        // 1. Create a tuple with 3 values
        var person = ("Divya", 22, "Hyderabad");

        // 2. Access values using Item1, Item2, Item3
        Console.WriteLine("Name: " + person.Item1);
        Console.WriteLine("Age: " + person.Item2);
        Console.WriteLine("City: " + person.Item3);

        // 3. Deconstruct the tuple into separate variables
        var (name, age, city) = person;
        Console.WriteLine($"Deconstructed: {name}, {age}, {city}");
    }
}
}