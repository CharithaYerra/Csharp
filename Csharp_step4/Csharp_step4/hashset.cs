using System;
using System.Collections.Generic;

namespace step4 { 
class HashSetExample
{
    static void Main()
    {
        HashSet<string> colors = new HashSet<string>();
        colors.Add("Red");
        colors.Add("Blue");
        colors.Add("Green");
        colors.Add("Red"); // Duplicate, won't be added

        Console.WriteLine("HashSet contents:");
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        Console.WriteLine("Contains Blue? " + colors.Contains("Blue"));
    }
}
}