using System;

class Product
{
    string productName;
    double price;
    int quantity;

    // Method with parameters (sets data)
    public void SetDetails(string nameInput, string priceInput, string quantityInput)
    {
        productName = nameInput.Trim().ToUpper(); //  Trim() & ToUpper()
        price = Convert.ToDouble(priceInput);     // string to double
        quantity = Convert.ToInt32(quantityInput); // string to int
    }

    // Method with no parameters (displays info)
    public void ShowProduct()
    {
        Console.WriteLine($"\nProduct: {productName}");
        Console.WriteLine($"Price: ₹{price}");
        Console.WriteLine($"Quantity: {quantity}");
    }

    // Method with return value (total cost)
    public double CalculateBill()
    {
        return Math.Round(price * quantity, 2); //  Math.Round
    }

    // Method with parameter and return value
    public string DiscountMessage(double total)
    {
        if (total >= 1000)
            return "You got a 10% discount!";
        else if (total >= 500)
            return "You got a 5% discount!";
        else
            return "No discount available.";
    }
}

class ProductManager
{
    static void Main()
    {
        Product product = new Product();

        // Input from user
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product price: ");
        string price = Console.ReadLine();

        Console.Write("Enter quantity: ");
        string qty = Console.ReadLine();

        // Set details
        product.SetDetails(name, price, qty);

        // Show product info
        product.ShowProduct();

        // Calculate bill and display
        double totalAmount = product.CalculateBill();
        Console.WriteLine($"\nTotal Bill: ₹{totalAmount}");

        // Show discount message
        string discount = product.DiscountMessage(totalAmount);
        Console.WriteLine($"Discount Info: {discount}");
    }
}
