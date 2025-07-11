using System;

namespace GreetingProgram
{
    class Greeting
    {
        /// <summary>
        /// This method takes an array of names and returns greetings in uppercase.
        /// </summary>
        static string[] CreateGreetings(string[] names)
        {
            string[] greetings = new string[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                greetings[i] = $"Hello, {names[i].ToUpper()}!";
            }

            return greetings;
        }

        static void Main()
        {
            // Input names array
            string[] names = { "divya", "rahul", "anita" };

            // Call the method and get greeting messages
            string[] results = CreateGreetings(names);

            // Print each message
            foreach (string msg in results)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
