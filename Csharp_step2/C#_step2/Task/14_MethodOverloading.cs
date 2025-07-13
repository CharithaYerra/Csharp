//Example on Method Overloading – Real time example
///<summary>
///Method Overloading means defining multiple
///methods with the same name in the same class, but with different parameters.
///Same method name

//Different parameter types, order, or number of parameters

//Happens within the same class

//Return type can be same or different, but return type alone does not differentiate overloads

//</summary>

using System;

class PaymentProcessor
{
    // Payment via UPI
    public void MakePayment(string upiId)
    {
        Console.WriteLine($"Payment successful using UPI ID: {upiId}");
    }

    // Payment via card
    public void MakePayment(string cardNumber, string cvv, string expiry)
    {
        Console.WriteLine($"Payment successful using Card: {cardNumber} (Exp: {expiry})");
    }

    

    // Payment via Cash
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Cash payment of ₹{amount} received.");
    }
}

class PaymentApp
{
    static void Main()
    {
        PaymentProcessor processor = new PaymentProcessor();

        // Real-time usage
        processor.MakePayment("divya@upi");                             // UPI

        processor.MakePayment("1234-5678-9012-3456", "123", "12/25");   // Card
        
        processor.MakePayment(1000);                                    // Cash
    }
}
