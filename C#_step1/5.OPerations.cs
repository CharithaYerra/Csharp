using System;
 class Operations


    {
    static void Main()
    
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int product = num1 * num2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");

        int a = 10, b = 20;

        Console.WriteLine($"a == b: {a == b}");
        Console.WriteLine($"a != b: {a != b}");
        Console.WriteLine($"a < b && b > 15: {(a < b && b > 15)}");


        Console.Write("Enter your age: ");
        byte age = Convert.ToByte(Console.ReadLine());

        Console.WriteLine($"You entered age: {age}");


        // Implicit Conversion
        int num = 100;
        double d = num; // no data loss
        Console.WriteLine($"Implicit: int {num} => double {d}");

        // Explicit Conversion
        double pi = 3.14;
        int approx = (int)pi; // data loss
        Console.WriteLine($"Explicit: double {pi} => int {approx}");


        //Age calculator
        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int currentAge = currentYear - birthYear;

        Console.WriteLine($"You are {currentAge} years old.");


        //Even or Odd Number Checker
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine($"{number} is Even.");
        else
            Console.WriteLine($"{number} is Odd.");


        //Grade Caluculations

        Console.Write("Enter your score (0-100): ");
        int score = int.Parse(Console.ReadLine());

        string grade;

        if (score >= 90)
            grade = "A+";
        else if (score >= 75)
            grade = "B+";
        else if (score >= 60)
            grade = "C-";
        
        else
            grade = "F";

        Console.WriteLine($"Your grade is: {grade}");
    }
    }



