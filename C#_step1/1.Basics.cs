using System;
 class Program
    {
        static void Main()
        {
        Console.WriteLine("This is main method ");
        Console.WriteLine("please provide your name:");
        string name=Console.ReadLine();
        Console.WriteLine("Please state your qualifications");
        string qualifications=Console.ReadLine();
        Console.WriteLine("What are your intrests");
        string interest = Console.ReadLine();



        greeting();
        study(qualifications);
        intrestsOfuser(interest,name);

        Console.WriteLine("This is end of main method ");
        
        }
        static void greeting()
    {
        Console.WriteLine( "Welcome to CodeWorld! Let’s build something great together.");

    }
    static void study(string qualifications)
    {
        Console.WriteLine("your qualifications are : " + qualifications);
    }
    static void intrestsOfuser(string interest,string name)
    {
        Console.WriteLine(name + ", it's awesome that you're interested in "+ interest);

    }
    }

