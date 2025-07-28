using System;

class ArrayExampleAdvance
{
    // Method 1: Accept array as parameter and print it
    public static void PrintArray(int[] numbers)
    {
        Console.WriteLine("Array Elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Method 2: Return an array from a method
    public static string[] GetDaysOfWeek()
    {
        return new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
    }

    // Method 3: Modify array elements
    public static void DoubleValues(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= 2;
        }
    }

    static void Main()
    {
        // Example 1: Passing array to a method
        int[] numbers = { 1, 2, 3, 4, 5 };
        PrintArray(numbers);  // Output: 1 2 3 4 5

        // Example 2: Getting array from method
        string[] days = GetDaysOfWeek();
        Console.WriteLine("Days:");
        foreach (string day in days)
        {
            Console.WriteLine(day);
        }

        // Example 3: Modify array using method
        DoubleValues(numbers);
        Console.WriteLine("After Doubling:");
        PrintArray(numbers);  // Output: 2 4 6 8 10
    }
}
