using System;


// Interface 

interface IVehicle
{
    // Method that must be implemented by all vehicles
    void Start();
    void Stop();
}

// Class 1: Car implements IVehicle

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car is starting with key ignition.");
    }

    public void Stop()
    {
        Console.WriteLine("Car has stopped using brake.");
    }
}

// Class 2: Bike implements IVehicle

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike is starting with self start.");
    }

    public void Stop()
    {
        Console.WriteLine("Bike has stopped using disc brake.");
    }
}


// Main Program
class InterfaceWithMultipleClassesExample
{
    static void Main()
    {
        // Create Car object and call methods
        IVehicle car = new Car();
        Console.WriteLine("Car Operations:");
        car.Start();
        car.Stop();

        Console.WriteLine(); // Just for space between outputs

        // Create Bike object and call methods
        IVehicle bike = new Bike();
        Console.WriteLine("Bike Operations:");
        bike.Start();
        bike.Stop();
    }
}
