using System;
using System.Collections;

namespace step4 { 
class HashtableExample
{
    static void Main()
    {
        Hashtable phoneBook = new Hashtable();
        phoneBook["Alice"] = "1234567890";
        phoneBook["Bob"] = 9876543210; // different type

        Console.WriteLine("Phone Numbers:");
        foreach (DictionaryEntry entry in phoneBook)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }


    }
}
}