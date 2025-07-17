using System;

namespace OnlineCoursePlatform
{
    //base class
    class User
    {
        //field set
        public string Name { get; set; }
        public virtual double MonthlyFee { get; set; }

        //virtual method to override in derived class
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
    //derived class
    class PremiumUser : User
    {
        public int ExtraCourses { get; set; }

        // Premium users get 20% off if they take 3+ extra courses
        public override double CalculateAnnualFee()
        {
            double AnnualfeeS = MonthlyFee * 12;

            if (ExtraCourses >= 3)
                return AnnualfeeS * 0.80;
            else
                return AnnualfeeS;
        }
    }
    //start point
    class Program
    {
        static void Main()
        {
            User user = new PremiumUser()
            {
                //assiging values to properties
                Name = "Kiran",
                MonthlyFee = 1500,
                ExtraCourses = 2
            };

            //methods are being called
            double annualFee = user.CalculateAnnualFee();   
            string category = user.GetUserCategory();        

            //printing output
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Annual Fee: ₹{annualFee}");
            Console.WriteLine($"Category: {category}");
        }
    }
}
