using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WhenAllExample
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("== 1. Basic WhenAll ==");
            await BasicExample.Run();

            Console.WriteLine("\n== 2. WhenAll with Results ==");
            await WithResults.Run();

            Console.WriteLine("\n== 3. WhenAll with List<Task<T>> ==");
            await WithList.Run();

            Console.WriteLine("\n== 4. WhenAll with Exceptions ==");
            await WithExceptions.Run();

            Console.WriteLine("\n== 5. Mixed Delays ==");
            await MixedDelays.Run();

            Console.WriteLine("\n== 6. WhenAny then WhenAll ==");
            await WhenAnyThenAll.Run();

            Console.WriteLine("\n== 7. Tuple Return ==");
            await TupleReturn.Run();
        }
    }

    // 1. Basic WhenAll: Run two tasks, wait until both finish
    public class BasicExample
    {
        public static async Task Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Task t1 = Task.Delay(5000); // Task runs for 5 seconds
            Task t2 = Task.Delay(3000); // Task runs for 3 seconds

            await Task.WhenAll(t1, t2); // Wait for both to finish

            stopwatch.Stop();
            Console.WriteLine("Basic: All tasks completed");
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalSeconds} s");
        }
    }

    // 2. WhenAll with results: Task<string> returning results
    public class WithResults
    {
        public static async Task Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Task<string> t1 = GetDataAsync("Service 1");
            Task<string> t2 = GetDataAsync("Service 2");

            string[] results = await Task.WhenAll(t1, t2); // collect results

            stopwatch.Stop();
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalSeconds} s");

            foreach (var result in results)
                Console.WriteLine("Result: " + result);
        }

        private static async Task<string> GetDataAsync(string source)
        {
            await Task.Delay(5000); // Simulate work
            return $"Data from {source}";
        }
    }

    // 3. WhenAll with a List<Task<T>>: useful when task count is dynamic
    public class WithList
    {
        public static async Task Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var users = new List<string> { "Siri", "Sonya", "Harini" };

            // Convert each user into a Task<string>
            List<Task<string>> tasks = users.Select(ProcessUserAsync).ToList();

            string[] results = await Task.WhenAll(tasks); // wait for all to complete

            stopwatch.Stop();
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalSeconds} s");

            foreach (var result in results)
                Console.WriteLine("Processed: " + result);
        }

        private static async Task<string> ProcessUserAsync(string user)
        {
            await Task.Delay(3000); // Simulate processing
            return $"User {user}";
        }
    }

    // 4. WhenAll with exception handling using AggregateException
    public class WithExceptions
    {
        public static async Task Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var tasks = new List<Task>
            {
                Task.Run(() => throw new InvalidOperationException("Invalid operation")),
                Task.Run(() => throw new ArgumentNullException("Argument null"))
            };

            try
            {
                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught exceptions:"+ ex);
                
            }

            stopwatch.Stop();
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalSeconds} s");
        }
    }

    // 5. Mixed delays to show how long Task.WhenAll takes with different delays
    public class MixedDelays
    {
        public static async Task Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var t1 = Task.Delay(1000); // 1s
            var t2 = Task.Delay(2000); // 2s
            var t3 = Task.Delay(5000); // 5s

            await Task.WhenAll(t1, t2, t3); // waits for all, so 5s total

            stopwatch.Stop();
            Console.WriteLine("Mixed: All tasks completed");
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalSeconds} s");
        }
    }

    // 6. WhenAny then WhenAll: Wait for first to finish, then all
    public class WhenAnyThenAll
    {
        public static async Task Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var t1 = Task.Delay(4000);
            var t2 = Task.Delay(3000);

            await Task.WhenAny(t1, t2); // Waits until one finishes
            Console.WriteLine("First task completed");

            await Task.WhenAll(t1, t2); // Now wait for both to complete
            Console.WriteLine("Then all tasks completed");

            stopwatch.Stop();
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalSeconds} s");
        }
    }

    // 7. WhenAll + Tuple: Run two tasks and return results as a tuple
    public class TupleReturn
    {
        public static async Task Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var numberTask = GetNumberAsync();
            var messageTask = GetMessageAsync();

            await Task.WhenAll(numberTask, messageTask);

            stopwatch.Stop();
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalSeconds} s");

            (int num, string msg) = (numberTask.Result, messageTask.Result);
            Console.WriteLine($"Tuple: Number={num}, Message={msg}");
        }

        private static Task<int> GetNumberAsync() => Task.FromResult(42);
        private static Task<string> GetMessageAsync() => Task.FromResult("Hello world");
    }
}
