using System;
 class Discount
    {
    static void Main()
    {
        showName();

        string item = "rice packet";
        double price = 620.20;
        showitemDetails(item, price);


        double discount = getdiscount(price);
        Console.WriteLine($"discount is: {discount}");
        Console.WriteLine($"discount rate = {discount * 100}%");
        Console.WriteLine("enter the quantity");
        int quantity = int.Parse(Console.ReadLine());
        Console.WriteLine($"quantity is: {quantity}");

        double finalPrice = Totalprice(price, discount, quantity);
        Console.WriteLine(finalPrice);
    }

    static void showName()
    {
        Console.WriteLine("Enter shop name");
        string shopName = Console.ReadLine();
        Console.WriteLine($"Welcome to {shopName} shop");
    }

    static void showitemDetails(string item, double price)
    {
        string details = string.Format("item: {0}, price: {1}", item, price);
        Console.WriteLine($"details: {details}");
    }

    static double getdiscount(double price)
    {
        if (price >= 500)
        {
            return 0.10;
        }
        else if (price >= 300)
        {
            return 0.05;
        }
        else
        {
            return 0;
        }
    }

    static double Totalprice(double price, double discount, int quantity)
    {
        return (price - (price * discount)) * quantity;
    }
}

