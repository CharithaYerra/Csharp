using System;


class Recursiveswitchloop
{

    static string[] cart = new string[5];
    static int cartIndex = 0;

    static void Main()
    {
        ShowMenu();
        AddToCart();
        ShowCart();


    }
    static void ShowMenu()
    {
        Console.WriteLine("\nAvailable Items:");
        Console.WriteLine("1. Apple");
        Console.WriteLine("2. Banana");
        Console.WriteLine("3. Orange");
        Console.WriteLine("4. Exit");
    }
    static void AddToCart()
    {
        if (cartIndex >= cart.Length)
        {
            Console.WriteLine("Cart is full.");
            return;
        }

        Console.Write("Enter item (1-Apple, 2-Banana, 3-Orange, 4-Exit): ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine(cartIndex);
                cart[cartIndex++] = "Apple";//we are using postfix increment here
                Console.WriteLine("Apple added.");
                break;
            case "2":
                cart[cartIndex++] = "Banana";
                Console.WriteLine("Banana added.");
                break;
            case "3":
                cart[cartIndex++] = "Orange";
                Console.WriteLine("Orange added.");
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Invalid.");
                break;
        }

        AddToCart(); // Recursive call
    }

    static void ShowCart()
    {
        Console.WriteLine("\nItems in cart:");
        for (int i = 0; i < cartIndex; i++)
        {
            Console.WriteLine("- " + i);

            Console.WriteLine("- " + cart[i]);
        }
    }
    


}
