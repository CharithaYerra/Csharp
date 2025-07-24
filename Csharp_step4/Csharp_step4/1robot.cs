using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Namespace 
namespace RobotControlSystem
{
   //Abstraction: Base class that defines common properties and behavior
    public abstract class RobotBase
    {
        // Name of the robots (shared by all )
        public string Name { get; set; }

        // Current battery level
        public int PowerLevel { get; set; }

        // Constructor to initialize name (default = 100)
        public RobotBase(string name, int powerLevel = 100)
        {
            Name = name;
            PowerLevel = powerLevel;
        }

        // Abstract method forces child classes to define their specific task
        public abstract void PerformTask();
    }

    //  Interface: Defines a contract for commandable robots
    public interface ICommandable
    {
        // Every commandable robot must implement this method under interface
        void ExecuteCommand(string command);
    }

    // Inheritance + Interface + Polymorphism usage
    // DeliveryRobot inherits from RobotBase and implements ICommandable
    //way of getting a inheritance, interface
    public class DeliveryRobot : RobotBase, ICommandable
    {
        // Constructor passes name to base class
        public DeliveryRobot(string name) : base(name) { }

        // Specific task implementation for delivery robots to performing task
        public override void PerformTask()
        {
            Console.WriteLine($"{Name} is delivering a package.");
        }

        // Execute a custom command that is in the interface
        public void ExecuteCommand(string command)
        {
            Console.WriteLine($"{Name} executes command: {command}");
        }

        // Async method simulating a delivery task 
        public async Task<string> DeliverAsync(string location)
        {
            await Task.Delay(5000); // Simulates delay of dellivary
            return $"{Name} delivered to {location}.";
        }
    }

    //  Another concrete robot class: CleaningRobot
    //Inherits from the robot base class same as delivary robot 
    //just performs different task
    public class CleaningRobot : RobotBase, ICommandable
    {
        public CleaningRobot(string name) : base(name) { }

        
        public override void PerformTask()
        {
            Console.WriteLine($"{Name} is cleaning the area.");
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine($"{Name} received cleaning command: {command}");
        }

        public async Task<string> CleanAsync(string area)
        {
            await Task.Delay(7000); // Simulate longer cleaning task
            //take time to clean
            return $"{Name} cleaned {area}.";
        }
    }

    // Extension methods: Add new methods to RobotBase without modifying it
    public static class RobotExtensions
    {
        // Check if robot needs a recharge (battery < 30%)
        public static bool NeedsRecharge(this RobotBase robot)
        {
            return robot.PowerLevel < 30;
        }

        // Return battery status using a tuple (string message, int level)
        public static (string status, int level) GetBatteryStatus(this RobotBase robot)
        {
            return ($"{robot.Name} battery status", robot.PowerLevel);
        }
    }

    //  Main program
    class Program
    {
        // Entry point: async because we use async methods like DeliverAsync
        static async Task Main(string[] args)
        {
            // Create an array of robots (using base type for polymorphism)
            RobotBase[] robots = new RobotBase[]
            {
                new DeliveryRobot("GB-1") { PowerLevel = 80 },   // Good battery
                new CleaningRobot("LB-1") { PowerLevel = 25 }    // Low battery
            };

            // List to store robots that support command execution (interface)
            List<ICommandable> commandables = new List<ICommandable>();

            // Dictionary for fast lookup of robots by name
            Dictionary<string, RobotBase> robotDirectory = new Dictionary<string, RobotBase>();

            // Loop through each robot and perform tasks
            foreach (var robot in robots)
            {
                // Call the robot’s specific task 
                robot.PerformTask();

                // Check if robot supports commands
                if (robot is ICommandable cmd)
                {
                    // Execute command and store in commandable list of interface type
                    cmd.ExecuteCommand("Start");
                    commandables.Add(cmd);
                }

                // Add robot to dictionary by name
                robotDirectory[robot.Name] = robot;

                // Use extension method to check for low battery
                if (robot.NeedsRecharge())
                {
                    Console.WriteLine($"{robot.Name} needs recharge.");
                }

                // Use another extension method to get and print battery info
                var status = robot.GetBatteryStatus();
                Console.WriteLine($"{status.status}: {status.level}%");
            }

            // Create two new robots to demonstrate async task execution
            DeliveryRobot d1 = new DeliveryRobot("GB-2");
            CleaningRobot c1 = new CleaningRobot("LB-2");

            // Start both async methods without waiting immediately
            Task<string> task1 = d1.DeliverAsync("Building A");
            Task<string> task2 = c1.CleanAsync("Room 101");

            // Await both tasks in parallel using Task.WhenAll
            string[] results = await Task.WhenAll(task1, task2);

            // Print the result of each task
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            // Demonstrate tuple unpacking
            var (msg, level) = d1.GetBatteryStatus();
            Console.WriteLine($"Tuple: {msg}, Level: {level}%");

            Console.WriteLine("\n--- All robots processed ---");
        }
    }
}
