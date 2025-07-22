using System;
using System.Collections.Generic;

namespace step4
{
    class ListExample
    {
        static void Main()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");

            fruits.Remove("Banana");

            Console.WriteLine("List contents:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine($"First item: {fruits[0]}");
        }
    }
}
