using System;
using System.Collections.Generic;
namespace step4
{
    class DictionaryExample
    {
        static void Main()
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals["India"] = "New Delhi";
            capitals["USA"] = "Washington D.C.";
            capitals["Japan"] = "Tokyo";

            Console.WriteLine("Country Capitals:");
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            Console.WriteLine("Capital of Japan: " + capitals["Japan"]);
        }
    }
}