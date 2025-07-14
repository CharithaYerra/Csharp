using System;

namespace OnlineCoursePlatform
{
    class User
    {
        public string Name { get; set; }
        public virtual double MonthlyFee { get; set; }

        public virtual double CalculateAnnualFee()
        {
            return MonthlyFee * 12;
        }

        public string GetUserCategory()
        {
            double annualFee = CalculateAnnualFee();

            if (annualFee >= 20000)
                return "Gold Member";
            else if (annualFee >= 10000)
                return "Silver Member";
            else
                return "Basic Member";
        }
    }

    class PremiumUser : User
    {
        public int ExtraCourses { get; set; }

        // Premium users get 20% off if they take 3+ extra courses
        public override double CalculateAnnualFee()
        {
            double baseAnnual = MonthlyFee * 12;

            if (ExtraCourses >= 3)
                return baseAnnual * 0.80;
            else
                return baseAnnual;
        }
    }

    class Program
    {
        static void Main()
        {
            User user = new PremiumUser()
            {
                Name = "Kiran",
                MonthlyFee = 1500,
                ExtraCourses = 2
            };

            double annualFee = user.CalculateAnnualFee();   
            string category = user.GetUserCategory();        

            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Annual Fee: ₹{annualFee}");
            Console.WriteLine($"Category: {category}");
        }
    }
}
