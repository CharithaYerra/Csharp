using System;

namespace MovieNews
{
    public class MovieBudgetManager
    {
        // Static fields
        public static string Producer;
        public static double BaseBudget;

        // Static constructor - runs once before any static or instance member is accessed
        static MovieBudgetManager()
        {
            Producer = "Mr. Nolan";
            BaseBudget = 10000000; // 1 Crore
            Console.WriteLine("Static Constructor: Producer and Base Budget set.");
        }

        // Non-static fields (properties)
        public string Department { get; set; }
        public double DepartmentCost { get; set; }

        // Constructor
        public MovieBudgetManager(string dept, string costInput)
        {
            this.Department = dept.ToUpper(); // Built-in: ToUpper()
            this.DepartmentCost = Convert.ToDouble(costInput); // Data conversion
        }

        // Non-static method
        public void ShowDepartmentInfo()
        {
            Console.WriteLine($"\nDepartment: {this.Department}");
            Console.WriteLine($"Department Cost: ₹{Math.Round(this.DepartmentCost, 2)}"); // Built-in: Math.Round
        }

        // Static method
        public static void ShowBaseInfo()
        {
            Console.WriteLine($"\nProducer: {Producer}");
            Console.WriteLine($"Total Base Budget: ₹{BaseBudget}");
        }

        // Static method with parameter and return value
        public static string CheckBudgetStatus(double deptTotal)
        {
            if (deptTotal > BaseBudget)
                return "Over Budget!";
            else if (deptTotal == BaseBudget)
                return "On Budget.";
            else
                return "Under Budget.";
        }
    }

    class Rules
    {
        static void Main()
        {
            // Static method call
            MovieBudgetManager.ShowBaseInfo();

            // Create object (non-static)
            MovieBudgetManager artDept = new MovieBudgetManager("Art Direction", "2500000");
            artDept.ShowDepartmentInfo();

            MovieBudgetManager soundDept = new MovieBudgetManager("Sound Editing", "2000000");
            soundDept.ShowDepartmentInfo();

            // Calculate combined cost
            double totalSpent = artDept.DepartmentCost + soundDept.DepartmentCost;

            Console.WriteLine($"\nTotal Department Spending: ₹{totalSpent}");

            // Static method with return
            string result = MovieBudgetManager.CheckBudgetStatus(totalSpent);
            Console.WriteLine($"Budget Status: {result}");
        }
    }
}
