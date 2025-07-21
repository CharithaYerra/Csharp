using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroneSystem
{
    // Interface for logging
    interface ILogger
    {
        Task<string> LogAsync();
    }

    // Abstract class - all drones have ID and On/Off status
    abstract class Drone : ILogger
    {
        public string Id { get; set; }
        public bool IsOn { get; set; }

        public Drone(string id)
        {
            Id = id;
            IsOn = true;
        }

        public abstract Task<string> StartAsync(); // Do the job
        public abstract Task<string> LogAsync();   // Log the job
    }

    // Drone for delivering packages
    class DeliveryDrone : Drone
    {
        public string Location { get; set; }

        // Main constructor
        public DeliveryDrone(string id, string location) : base(id)
        {
            Location = location;
        }

        // Overloaded constructor with default location
        public DeliveryDrone(string id) : this(id, "Unknown")
        {
        }

        public override async Task<string> StartAsync()
        {
            await Task.Delay(500);
            return $" DeliveryDrone {Id} is delivering to {Location}";
        }

        public override async Task<string> LogAsync()
        {
            await Task.Delay(100);
            return $" Logged: DeliveryDrone {Id} sent to {Location}";
        }
    }

    // Drone for patrolling areas
    class PatrolDrone : Drone
    {
        public int RangeKm { get; set; }

        public PatrolDrone(string id, int rangeKm) : base(id)
        {
            RangeKm = rangeKm;
        }

        public override async Task<string> StartAsync()
        {
            await Task.Delay(400);
            return $" PatrolDrone {Id} is watching {RangeKm} km";
        }

        public override async Task<string> LogAsync()
        {
            await Task.Delay(100);
            return $" Logged: PatrolDrone {Id} patrols {RangeKm} km";
        }
    }

    // Extension methods for a list of drones
    static class DroneHelpers
    {
        // Get only active drones
        public static List<Drone> GetActive(this List<Drone> drones)
        {
            return drones.Where(d => d.IsOn).ToList();
        }

        // Print all drone IDs
        public static void ShowIds(this List<Drone> drones)
        {
            foreach (var drone in drones)
            {
                Console.WriteLine($"🛰️ Drone: {drone.Id}");
            }
        }
    }

    class Program
    {
        static async Task Main()
        {
            // Create some drones
            List<Drone> drones = new List<Drone>
            {
                new DeliveryDrone("D1", "City Center"),
                new DeliveryDrone("D2"),
                new PatrolDrone("P1", 15),
                new PatrolDrone("P2", 25)
            };

            // Turn off one drone
            drones[1].IsOn = false;

            Console.WriteLine("All drones:");
            drones.ShowIds();

            Console.WriteLine("\n Active drones:");
            var activeDrones = drones.GetActive();
            activeDrones.ShowIds();

            Console.WriteLine("\nStarting missions...");
            var missionTasks = activeDrones.Select(d => d.StartAsync()).ToArray();
            string[] missionResults = await Task.WhenAll(missionTasks);

            foreach (var result in missionResults)
                Console.WriteLine(result);

            Console.WriteLine("\nLogging missions...");
            var logTasks = activeDrones.Select(d => d.LogAsync()).ToArray();
            string[] logResults = await Task.WhenAll(logTasks);

            foreach (var log in logResults)
                Console.WriteLine(log);

            Console.WriteLine("\n All drone work completed.");
        }
    }
}
