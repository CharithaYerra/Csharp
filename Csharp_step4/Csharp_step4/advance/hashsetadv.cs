using System;
using System.Collections.Generic;

class RobotHashSetExample
{
    // Method to demonstrate HashSet operations
    public static void ManageRobotTasks()
    {
        HashSet<string> tasks = new HashSet<string>();

        // Adding tasks
        tasks.Add("Start");
        tasks.Add("ScanArea");
        tasks.Add("MoveForward");
        tasks.Add("ScanArea"); // Duplicate - will not be added
        tasks.Add("PickItem");
        tasks.Add("MoveForward"); // Duplicate - will not be added

        Console.WriteLine(" Tasks assigned to robot:");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }

        // Check if task exists
        string checkTask = "PickItem";
        Console.WriteLine($"\n Task '{checkTask}' exists: {tasks.Contains(checkTask)}");

        // Remove a task
        tasks.Remove("Start");
        Console.WriteLine("\n After removing 'Start':");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }

        // Union with another set
        var extraTasks = new HashSet<string> { "ChargeBattery", "Shutdown", "MoveForward" };
        tasks.UnionWith(extraTasks);
        Console.WriteLine("\n After merging extra tasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    static void Main(string[] args)
    {
        ManageRobotTasks();
    }
}
