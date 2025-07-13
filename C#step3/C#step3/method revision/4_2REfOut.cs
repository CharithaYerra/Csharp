using System;

class ShoppingCart
{
    static void Main()
    {
        // ------------------- REF EXAMPLE -------------------
        int itemCount = 2;
        Console.WriteLine($"[Before REF] Items in cart: {itemCount}");
        AddFreeItem(ref itemCount);
        Console.WriteLine($"[After REF] Items in cart: {itemCount}");

        // ------------------- OUT EXAMPLE -------------------
        string product;
        double price;
        GetProductDetails(out product, out price);
        Console.WriteLine($"\n[OUT] Product: {product}, Price: ₹{price}");

        // ------------------- TryParse EXAMPLE -------------------
        string userInput = "1500"; // try "abc" to test failure
        bool isValid = TryParseDiscount(userInput, out int discount);
        if (isValid)
        {
            Console.WriteLine($"\n[TryParse] Valid discount: ₹{discount}");
        }
        else
        {
            Console.WriteLine("\n[TryParse] Invalid discount input.");
        }
    }

    // ------------------- REF METHOD -------------------
    static void AddFreeItem(ref int count)
    {
        count += 1; // Free item added to cart
    }

    // ------------------- OUT METHOD -------------------
    static void GetProductDetails(out string name, out double price)
    {
        name = "Bluetooth Headphones";
        price = 2499.99;
    }

    // ------------------- TryParse METHOD -------------------
    static bool TryParseDiscount(string input, out int discountAmount)
    {
        return int.TryParse(input, out discountAmount);
    }
}
