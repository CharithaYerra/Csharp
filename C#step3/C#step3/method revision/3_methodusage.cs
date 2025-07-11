using System;

namespace ProductInventory
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }

    class ProductOperations
    {
        // Return a single product
        public static Product GetProduct()
        {
            return new Product()
            {
                Name = "Laptop",
                Price = 60000,
                Quantity = 10
            };
        }

        // Update quantity of a single product
        public static Product Restock(Product product, int additionalQty)
        {
            product.Quantity += additionalQty;
            return product;
        }

        // Return multiple products
        public static Product[] GetAllProducts()
        {
            return new Product[]
            {
                new Product(){ Name = "Laptop", Price = 60000, Quantity = 10 },
                new Product(){ Name = "Mouse", Price = 700, Quantity = 50 },
                new Product(){ Name = "Keyboard", Price = 1200, Quantity = 30 }
            };
        }

        // Apply discount to all product prices
        public static Product[] ApplyDiscount(Product[] products, double discountPercent)
        {
            foreach (var product in products)
            {
                product.Price = product.Price - (product.Price * discountPercent / 100);
            }

            return products;
        }
    }

    class Products
    {
        static void Main()
        {
            // Get one product
            var singleProduct = ProductOperations.GetProduct();
            Console.WriteLine($"Single Product: {singleProduct.Name}, ₹{singleProduct.Price}, Qty: {singleProduct.Quantity}");

            // Restock that product
            ProductOperations.Restock(singleProduct, 5);
            Console.WriteLine($"After Restocking: {singleProduct.Name}, Qty: {singleProduct.Quantity}");

            // Get all products
            var products = ProductOperations.GetAllProducts();
            Console.WriteLine("\nProduct List Before Discount:");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}, Qty: {p.Quantity}");
            }

            // Apply 10% discount
            ProductOperations.ApplyDiscount(products, 10);

            Console.WriteLine("\nProduct List After 10% Discount:");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price:F2}, Qty: {p.Quantity}");
            }
        }
    }
}
