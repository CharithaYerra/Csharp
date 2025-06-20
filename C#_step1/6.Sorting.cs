using System;
 class SortingExample
    {
    static void Main()
    {
        int[] numbers = { 5, 3, 6, 7 };

        Array.Sort(numbers);

        Console.WriteLine("Sorted Array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }


        string[] names = { "diana", "roma", "vlad", "nic", "dizzler", "dripper" };
        Array.Sort(names);
        foreach (string name in names)
        {
            Console.WriteLine(name + " ");
        }



        int[] arr = { 3, 4, 7, 10, 15, 20, 21 };

        int evenCount = 0, oddCount = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine("Total Even numbers: " + evenCount);
        Console.WriteLine("Total Odd numbers: " + oddCount);
    }
}
    

