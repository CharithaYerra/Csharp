using System;

namespace DebuggingDemo
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }

    class DebugDemo
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            int num1 = 5;
            int num2 = 10;

            int resultAdd = calc.Add(num1, num2);
            Console.WriteLine("Addition Result: " + resultAdd);

            num1 = 7;
            int resultMul = calc.Multiply(num1, num2);
            Console.WriteLine("Multiplication Result: " + resultMul);

            Console.WriteLine("Program complete.");
        }
    }
}
