using System;
using System.Threading;
using System.Threading.Tasks;
class Home
{
    static async Task Main()
    {
        await Window();
        await Door();
    }
    static async Task Window()
    {
        Thread.Sleep(2000);
        await Task.Delay(1000);
        Console.WriteLine("Wood and Grills");
    }
    static async Task Door()
    {
        await Task.Delay(3000);
        Console.WriteLine("Wood and polish");
    }
}