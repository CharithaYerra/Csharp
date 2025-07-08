using System;

namespace InterfaceExample
{
    // First interface
    interface InterfaceA
    {
        int Add(int a, int b);
        string Greet();
    }

    // Second interface
    interface InterfaceB
    {
        string SayGoodbye();
    }

    // Third interface inherits both A and B
    interface InterfaceC : InterfaceA, InterfaceB
    {
        string Info();
    }

    // Class implements InterfaceC (and indirectly A and B)
    class MyClass : InterfaceC
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Greet()
        {
            return "Hello!";
        }

        public string SayGoodbye()
        {
            return "Goodbye!";
        }

        public string Info()
        {
            return "This is MyClass implementing InterfaceC.";
        }
    }

    class Interfaceexample
    {
        static void Main()
        {
            MyClass obj = new MyClass();

            Console.WriteLine("Add(5, 3): " + obj.Add(5, 3));
            Console.WriteLine("Greet(): " + obj.Greet());
            Console.WriteLine("SayGoodbye(): " + obj.SayGoodbye());
            Console.WriteLine("Info(): " + obj.Info());
        }
    }
}
