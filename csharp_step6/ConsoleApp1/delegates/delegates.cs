using AnonymousMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDelegate_Void_Example
{

    public delegate void KitchenSection(string order);

    public class Restaurant
    {
        public void MainCourseSection(string order)
        {
            Console.WriteLine($"Main Course Chef is preparing: {order}"); // Main course section
        }

        public void DessertSection(string order)
        {
            Console.WriteLine($"Dessert Chef is preparing: {order}"); // Dessert section
        }

        public void DrinksSection(string order)
        {
            Console.WriteLine($"Drinks Section is preparing: {order}");// Drinks section
        }

    }


    class ExecuteRestaurant
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            //restaurant.MainCourseSection("Pasta");


            // "Waiter" acts as the delegate that routes orders
            KitchenSection waiter;// Create delegate object not assigned to any method

            Console.WriteLine("Customer places order for Pasta...");
            waiter = restaurant.MainCourseSection;


            //RestaurantTask taskOrder = delegate (string orderName)
            //{
            //    Console.WriteLine("Waiter: Taking order for " + orderName);
            //};



            waiter("Pasta"); // Call the delegate
                             // Here the delegate calls the MainCourseSection method and passes the order as parameter
                             // The MainCourseSection method is then executed
                             // Here waiter is a delegate that points to the MainCourseSection method

            Console.WriteLine("\nCustomer places order for Ice Cream...");
            waiter = restaurant.DessertSection;
            waiter("IceCream");
            // Call the delegate
            // Here the delegate calls the DessertSection method and passes the order as parameter
            // The DessertSection method is then executed
            // Here waiter is a delegate that points to the DessertSection method


            Console.WriteLine("\nCustomer places order for a Mojito...");
            waiter = restaurant.DrinksSection;  // Route to drinks section
            waiter("Mojito");   // Call the delegate
                                // Here the delegate calls the DrinksSection method and passes the order as parameter
                                // The DrinksSection method is then executed
                                // Here waiter is a delegate that points to the DrinksSection method





        }
    }

}