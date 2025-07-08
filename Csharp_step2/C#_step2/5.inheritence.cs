using System;

namespace Family
{
    // Base class: Father
    class Father
    {
        // Static field shared by all members
        public static string FamilyName = "Sharma";

        // Property for father's name
        public string Name { get; set; }

        // Default constructor (no parameters)
        public Father()
        {
            Name = "Default Dad";
        }

        // Parameterized constructor
        public Father(string name)
        {
            Name = name;
        }

        // Method to display father's name
        public void ShowFather()
        {
            Console.WriteLine($"Father: {Name} {FamilyName}");
        }
    }

    // Derived class: Child inherits from Father
    class Child : Father
    {
        // Property for child's name
        public string ChildName { get; set; }

        // Constructor: uses base() to call Father's constructor
        public Child(string childName, string fatherName) : base(fatherName)
        {
            ChildName = childName;
        }

        // Method that returns a list of friends
        public string[] Friends()
        {
            return new string[] { "Anu", "Raj" };
        }

        // Method to display child's name
        public void ShowChild()
        {
            Console.WriteLine($"Child: {ChildName} {FamilyName}");
        }
    }

    class UsageofInheritance
    {
        static void Main()
        {
            // Creating object of Child and passing child + father names
            Child child = new Child("Ravi", "Kumar");

            // Calling inherited and own methods
            child.ShowFather();   // Method from Father class
            child.ShowChild();    // Method from Child class

            // Displaying friends
            Console.WriteLine("Friends:");
            foreach (string f in child.Friends())
                Console.WriteLine($"- {f}");
        }
    }
}
