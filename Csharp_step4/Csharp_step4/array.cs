using System;
namespace Step_4
{
    class ArrayExample
    {
        static void Main()
        {
            int[] marks = new int[3] { 85, 90, 78 };

            Console.WriteLine("Array elements:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Index {i}: {marks[i]}");
            }
        }
    }

}