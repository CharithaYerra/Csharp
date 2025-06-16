using System;



class DatatypesUsage
{
    static void Main()

    {
        // byte short ushort int uint long ulong float decimal double
        //bool char string
        Console.ReadKey();

        Console.WriteLine("Let us collect the information of the user");
        Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();
        Console.WriteLine("Enter your age:");
        byte age = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Enter your gender (M/F):");
        char gender = Console.ReadLine()[0];


        Console.Write("Enter your birth year (2000): ");
        int birthYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Are you a student? (true/false)");
        bool isStudent = Convert.ToBoolean(Console.ReadLine());


        Console.WriteLine("Enter your AparID:");
        long aparId = Convert.ToInt64(Console.ReadLine());


        Console.WriteLine("Enter your monthly salary:");
        short salary = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter any loans you have in thousands (with - sign):");
        short loans = Convert.ToInt16(Console.ReadLine());


        Console.Write("Enter your bank balance (use decimal ): ");
        decimal bankBalance = Convert.ToDecimal(Console.ReadLine());



        DisplayInformation(name, age, gender, birthYear, isStudent, aparId, salary, loans, bankBalance);



    }
    static void DisplayInformation(string name,
    byte age,
    char gender,
    int birthYear,
    bool isStudent,
    long aparId,
    short salary,
    short loans,
    decimal bankBalance) {
        Console.WriteLine("\n\n");
        Console.WriteLine("=== Personal Information Summary ===");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Birth Year: {birthYear}");
        Console.WriteLine($"Student: {isStudent}");
        Console.WriteLine($"Aadhaar/ID: {aparId}");
        Console.WriteLine($"Monthly Salary: ₹{salary}");
        Console.WriteLine($"Loan Amount: ₹{loans}");
        Console.WriteLine($"Bank Balance: ₹{bankBalance}");


    }
}