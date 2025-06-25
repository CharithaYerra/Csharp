using System;
class UsageofWhile

{
    static void Main()
    {

        string password = "";
        while (password != "1234")
        {
            Console.Write("Enter password: ");
            password = Console.ReadLine();
        }

        Console.WriteLine("Access granted.");


        Console.Write("Enter a number to find its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        int i = 1;

        while (i <= number)
        {
            result *= i;
            i++;
        }

        Console.WriteLine($"Factorial of {number} is: {result}");

       

    }
}



