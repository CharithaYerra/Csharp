using System;
using System.Linq;

namespace ExtensionMethodsNamespace
{
    public static class StringExtensions
    {
        // Extension method to count vowels
        public static int VowelCount(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return input.ToLower().Count(c => vowels.Contains(c));
        }
    }

    class Program
    {
        static void Main()
        {
            string str = "Extension Methods Are Useful";
            Console.WriteLine($"Vowels: {str.VowelCount()}"); // Output: Vowels: 10

            string str2 = "C# is awesome!";
            Console.WriteLine($"Vowels: {str2.VowelCount()}"); // Output: Vowels: 5
        }
    }
}
