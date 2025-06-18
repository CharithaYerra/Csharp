using System;
using System.Linq;
using System.Runtime.InteropServices;

class Palindrome
    {

    static void Main()
    {
        Console.WriteLine(" Polydrome Checker "); ;

        Console.WriteLine("\n Enter a string to check if it is a palidrome or not:");
        string input = Console.ReadLine();
       
        string spaceCleaned= input.Replace(" ", "");
        string lowered = spaceCleaned.ToLower();

        ReverseMethod(input,lowered);



       
    }
    static void ReverseMethod(string original,string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        printMessage(original, input, charArray);
    }
    static void printMessage(string original,string input, char[] Array)
    {
        string reversed = Array.ToString();
        if (input==reversed)
        {
            Console.WriteLine("{0} is a palindrome", original);

        }
        else
        {
            Console.WriteLine("{0} is not a palindrome", original);
        }
    }

    
    }







