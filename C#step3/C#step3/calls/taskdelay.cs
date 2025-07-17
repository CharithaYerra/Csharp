using System;
using System.Threading;
using System.Threading.Tasks;


//Reliance Oil --> Share point
namespace TaskDelayNamespace
{

    //Asp.netCore -> APIs every api is the async call
    class TaskDelayCls
    {
        static async Task Method1()
        {
            Console.WriteLine("Printinig");
            await Task.Delay(10000);
            Console.WriteLine("Method 1");
        }

        static async Task Method2()
        {
            await Task.Delay(5000);
            Console.WriteLine("Method 2");
        }

        //5 or 10 or 15
        static async Task Main()
        {
            await TaskDelayCls.Method1();   // wait upto get the response
            Console.WriteLine("MEthod1 is completed");


            //wen i am calling
            await TaskDelayCls.Method2();// wait upto get the response
            Console.WriteLine("Method2 is completed");
        }



        //Caller
        //static void Main()
        //{
        //    Task task1 =  TaskDelayCls.Method1();
        //    Task task2 =  TaskDelayCls.Method2();
        //    task1.Wait();
        //    task2.Wait();

        //    //Console.ReadLine();

        //}


        //Prining
        //Method2
        //MEthod;





    }
}