using System;
 class UsageofArray
    {
    static void Main()
    {
        int[] numbers = new int[5];  // Fixed size array
        numbers[0] = 10;
        numbers[1] = 20;
        Console.WriteLine("Array Elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


        //Array with constructor
        int[] factorsOf10 = new int[] { 10, 20, 30, 40 };
        //simple form
        int[] NaturalNumberupto5 = { 1, 2, 3, 4, 5 };

        //2D Array
        int[,] matrix = new int[2, 3] {
    {1, 2, 3},
    {4, 5, 6}
};

        ////2D Array with no fixed size
        int[][] Mixed = new int[2][];
        Mixed[0] = new int[] { 1, 2 };
        Mixed[1] = new int[] { 3, 4, 5 };

        for (int i = 0; i < Mixed.Length; i++)
        {
            foreach (int val in Mixed[i])
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }

        //Reading input for array
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You entered:");
        foreach (int val in arr)
        {
            Console.WriteLine(val);
        }

        Console.Write("Enter number to search: ");
        int target = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                Console.WriteLine($"Found at index {i}");
               
                break;
            }
            
        }


        int[] SortingArray = { 5, 6, 8, 2, 1 };

        Console.WriteLine("Orginal Array:");
        foreach (int num in SortingArray)
        {
            Console.Write(num + " ");
        }

        for(int i=0;i< SortingArray.Length;i++)
        {
            for(int j= i+1;j < SortingArray.Length;j++)    
            {
                if (SortingArray[i] > SortingArray[j])
                {
                    int change = SortingArray[i];
                    SortingArray[i] = SortingArray[j];
                    SortingArray[j] = change;
                }
                
            }
        }

        Console.WriteLine("Sorted Array (Ascending):");
        foreach (int num in SortingArray)
        {
            Console.Write(num + " ");
        }

        string sen = "hello array";
        char[] chars = sen.ToCharArray();




    }
}

