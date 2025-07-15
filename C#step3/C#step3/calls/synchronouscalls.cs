using System;
using System.Threading;

namespace SynchronousKitchen
{
    class KitchenTasks
    {
        public static void BoilRice()
        {
            var start = DateTime.Now;
            Thread.Sleep(3000); // Simulating 3 sec task
            var end = DateTime.Now;
            var elapsed = end - start;
            Console.WriteLine($"Boiled Rice - Time taken: {elapsed.TotalSeconds} seconds");
        }

        public static void FryVegetables()
        {
            var start = DateTime.Now;
            Thread.Sleep(4000); // Simulating 4 sec task
            var end = DateTime.Now;
            var elapsed = end - start;
            Console.WriteLine($"Fried Vegetables - Time taken: {elapsed.TotalSeconds} seconds");
        }

        public static void MakeSalad()
        {
            var start = DateTime.Now;
            Thread.Sleep(2000); // Simulating 2 sec task
            var end = DateTime.Now;
            var elapsed = end - start;
            Console.WriteLine($" Prepared Salad - Time taken: {elapsed.TotalSeconds} seconds");
        }
    }

    class Chef
    {
        public static void CookMeal()
        {
            Console.WriteLine("👨‍🍳 Cooking Meal Step-by-Step (Synchronous):");

            var mealStart = DateTime.Now;

            KitchenTasks.BoilRice();
            KitchenTasks.FryVegetables();
            KitchenTasks.MakeSalad();

            var mealEnd = DateTime.Now;
            var totalTime = mealEnd - mealStart;

            Console.WriteLine($"\n🍽️ Meal is ready! Total time: {totalTime.TotalSeconds} seconds");
        }
    }

    class Program
    {
        static void Main()
        {
            Chef.CookMeal();
        }
    }
}
