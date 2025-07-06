using System;

class Bank
{
    string accountNumber;
    decimal balance;

    void ShowBank(string accountNumber, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        Console.WriteLine($"The account no is {this.accountNumber} and balance is {this.balance}");
    }

    void Deposit(decimal amount)
    {
        balance += amount;
    }

    void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    void PrintBalance()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Balance: {balance:C}");
    }

    static void myMethod()
    {
        Bank myAccount = new Bank();
        myAccount.ShowBank("1234567890", 4000);

        myAccount.PrintBalance();

        myAccount.Deposit(500);
        myAccount.PrintBalance();

        myAccount.Withdraw(200);
        myAccount.PrintBalance();

        myAccount.Withdraw(2000);
        myAccount.PrintBalance();
    }

    void myMethod1()
    {
        ShowBank("9876543210", 3000);

        PrintBalance();

        Deposit(500);
        PrintBalance();

        Withdraw(200);
        PrintBalance();

        Withdraw(2000);
        PrintBalance();
    }

    static void Main()
    {
        myMethod();

        Bank bank1 = new Bank();
        bank1.myMethod1();
    }
}
