using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Extension method to apply discount
public static class PriceExtensions
{
    public static double ApplyDiscount(this double price, double percentage)
    {
        return price - (price * percentage / 100);
    }
}

// Abstraction
abstract class FoodItem
{
    public string Name { get; set; }
    public abstract double GetPrice();
}

// Polymorphism + Overriding
class Pizza : FoodItem
{
    public override double GetPrice()
    {
        return 300;
    }
}

class Burger : FoodItem
{
    public override double GetPrice()
    {
        return 150;
    }
}

// Customer class with constructor and non-static method
class Customer
{
    public string Name { get; set; }
    public List<FoodItem> Cart { get; set; }

    public Customer(string name)
    {
        Name = name;
        Cart = new List<FoodItem>();
    }

    public void AddToCart(FoodItem item)
    {
        Cart.Add(item);
        Console.WriteLine($"{item.Name} added to cart.");
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var item in Cart)
        {
            total += item.GetPrice();
        }

        // Use extension method to apply 10% discount
        return total.ApplyDiscount(10);
    }
}

// Static utility class
static class CurrencyConverter
{
    public static double ConvertToUSD(double inr)
    {
        return inr / 83.0; // Example rate
    }
}

class Program
{
    // Async method simulating placing an order
    public static async Task PlaceOrderAsync(Customer customer)
    {
        Console.WriteLine("Placing order...");
        await Task.Delay(2000); // Simulate delay
        double total = customer.CalculateTotal();
        Console.WriteLine($"Total INR: {total}");
        Console.WriteLine($"Total USD: {CurrencyConverter.ConvertToUSD(total):0.00}");
        Console.WriteLine("Order placed successfully!");
    }

    static async Task Main()
    {
        // Constructor in action
        Customer customer = new Customer("Divya");

        // Polymorphic behavior
        FoodItem item1 = new Pizza { Name = "Veg Pizza" };
        FoodItem item2 = new Burger { Name = "Cheese Burger" };

        customer.AddToCart(item1);
        customer.AddToCart(item2);

        // Async order placement
        await PlaceOrderAsync(customer);
    }
}
