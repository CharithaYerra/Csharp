using System;

class BankAccountOperations
{
    static void Main()
    {
        // ----------------- REF Example -----------------
        double balance = 1000;
        Console.WriteLine($"[Before REF] Balance: {balance}");
        AddBonus(ref balance);
        Console.WriteLine($"[After REF] Balance with bonus: {balance}");

        // ----------------- OUT Example -----------------
        string customerName;
        int accountId;
        GetCustomerDetails(out customerName, out accountId);
        Console.WriteLine($"\n[OUT] Customer: {customerName}, Account ID: {accountId}");

        // ----------------- TryParse Example -----------------
        string userInput = "5000.75"; // try with "abc" to test failure
        bool success = TryConvertToAmount(userInput, out double amount);
        if (success)
        {
            Console.WriteLine($"\n[TryParse] Successfully converted to amount: ₹{amount}");
        }
        else
        {
            Console.WriteLine("\n[TryParse] Invalid input. Conversion failed.");
        }
    }

    // ----------------- REF -----------------
    static void AddBonus(ref double balance)
    {
        balance += 250; // bonus amount
    }

    // ----------------- OUT -----------------
    static void GetCustomerDetails(out string name, out int id)
    {
        name = "Divya";
        id = 10101;
    }

    // ----------------- TryParse -----------------
    static bool TryConvertToAmount(string input, out double amount)
    {
        bool result = double.TryParse(input, out amount);
        return result;
    }
}
