using System;

namespace ExceptionHandlingExample
{
    class Calculator
    {
        public static void DivideNumbers(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            finally
            {
                Console.WriteLine("DivideNumbers method finished.");
            }
        }

        public static void AccessArrayElement()
        {
            int[] numbers = { 1, 2, 3 };
            try
            {
                Console.WriteLine(numbers[5]); // Invalid index
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("You tried to access an invalid index in the array.");
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            Calculator.DivideNumbers(10, 0); // This will throw DivideByZeroException
            Calculator.AccessArrayElement(); // This will throw IndexOutOfRangeException

            Console.WriteLine("Program completed successfully.");
        }
    }
}
