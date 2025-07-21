using System;
using System.Threading.Tasks;

namespace ParkingSystem
{
    // Abstraction
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }

        public Vehicle(string brand, string plate)
        {
            Brand = brand;
            NumberPlate = plate;
        }

        public abstract string GetStatus(); // Overriding
        public void Enter() => Console.WriteLine($"{Brand} with plate {NumberPlate} entered.");
    }

    public class Car : Vehicle
    {
        public Car(string brand, string plate) : base(brand, plate) { }
        public override string GetStatus() => $"Car {Brand} with plate {NumberPlate} is parked.";
    }

    public class Bike : Vehicle
    {
        public Bike(string brand, string plate) : base(brand, plate) { }
        public override string GetStatus() => $"Bike {Brand} with plate {NumberPlate} is parked.";
    }

    // Extension method
    public static class VehicleExtensions
    {
        public static bool IsVIP(this Vehicle vehicle, string prefix)
        {
            return vehicle.NumberPlate.StartsWith(prefix);
        }
    }

    // Async / Await
    public class SensorGate
    {
        public async Task<string> ScanVehicleAsync(Vehicle vehicle)
        {
            await Task.Delay(1000); // simulate scan delay
            return $"Sensor scanned {vehicle.Brand} - {vehicle.NumberPlate}";
        }
    }

    // Entry Point
    class Program
    {
        static async Task Main()
        {
            Vehicle car = new Car("Hondai", "KA01AB1234");
            Vehicle bike = new Bike("Yamaha", "KA05XY7890");

            car.Enter();
            bike.Enter();

            Console.WriteLine(car.GetStatus());
            Console.WriteLine(bike.GetStatus());

            SensorGate gate = new SensorGate();
            string response = await gate.ScanVehicleAsync(car);
            Console.WriteLine(response);

            Console.WriteLine("Is VIP: " + car.IsVIP("KA01"));
        }
    }
}
