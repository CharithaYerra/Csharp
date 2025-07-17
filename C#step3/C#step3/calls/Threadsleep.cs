using System;
using System.Threading;

namespace ThreadSleepNamespace
{
    class ThreadSleepClass
    {
        static void Main()
        {
            Console.WriteLine("Start");
            Thread.Sleep(5000);  // 5 Secs
            Console.WriteLine("End");
            Thread.Sleep(7000);
            Console.WriteLine("Again End....");
        }
    }
}