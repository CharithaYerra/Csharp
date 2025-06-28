using System;

class RestaurantOrder
{

    static void Main()
    {
        string[] menuItems = { "Burger", "Pizza", "Coffee", "Fries" };
        double[] prices = { 120.0, 250.0, 80.0, 100.0 };
        ShowMenu(menuItems,prices);

        int[] quantities = new int[menuItems.Length];

        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.Write($"Enter quantity for {menuItems[i]}: ");
            quantities[i] = int.Parse(Console.ReadLine());
        }

        PrintBill(quantities,menuItems,prices);
    }

    static void ShowMenu(string[] menuItems, double[] prices)
    {
        
        Console.WriteLine(" Menu:");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]} - {prices[i]}");
        }
        
    }

    static double CalculateBill(int[] qty, double[] prices)
    {
        double total = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            total += qty[i] * prices[i];
        }
        return total;
    }

    static void PrintBill(int[] qty, string[] menuItems, double[] prices)
    {
        Console.WriteLine("\n Bill Summary:");
        for (int i = 0; i < menuItems.Length; i++)
        {
            if (qty[i] > 0)
            {
                Console.WriteLine($"{menuItems[i]} x {qty[i]} = {qty[i] * prices[i]}");
            }
        }
        Console.WriteLine("Total: ₹" + CalculateBill(qty,prices));
    }

    
}
