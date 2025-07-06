using System;

namespace StaticAndNonStaticInstatiate
{
    // -------------------------------------
    // Static class
    // -------------------------------------
    // - Cannot be instantiated (no 'new')
    // - Can only contain static members
    // - Used for utility/helper methods
    public static class StaticClass
    {
        public static void PrintMessage()
        {
            Console.WriteLine("This is a static class method.");
        }
    }

    // -------------------------------------
    // Non-static class
    // -------------------------------------
    // - Can be instantiated using 'new'
    // - Can have both static and non-static methods
    public class NonStaticClass
    {
        // Non-static method (needs object to call)
        public void PrintMessage()
        {
            Console.WriteLine("This is a non-static class method.");
        }

        // Static method (can be called directly using class name)
        public static void PrintMessage2()
        {
            Console.WriteLine("This is a non-static class method and Static Method");
        }
    }

    // -------------------------------------
    // Main program class
    // -------------------------------------
    public class Program
    {
        public static void Main()
        {
            // Call static method from static class
            StaticClass.PrintMessage();  // ✅ No need to create object

            // Create an object of the non-static class
            NonStaticClass nonStaticClass = new NonStaticClass();

            // Call non-static method using object
            nonStaticClass.PrintMessage();  // ✅ Needs object

            // Call static method using class name directly
            NonStaticClass.PrintMessage2(); // ✅ No object needed
        }
    }
}
