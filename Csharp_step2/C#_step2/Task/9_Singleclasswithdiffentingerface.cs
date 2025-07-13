using System;


// Interface 1: Personal Information

interface IPersonDetails
{
    string GetName();
    int GetAge();
}


// Interface 2: Work Information
interface IWorkDetails
{
    string GetDepartment();
    double GetSalary();
}
// Worker implements both interfaces
//
class Worker : IPersonDetails, IWorkDetails
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    // Implement IPersonDetails
    public string GetName()
    {
        return Name;
    }

    public int GetAge()
    {
        return Age;
    }

    // Implement IWorkDetails
    public string GetDepartment()
    {
        return Department;
    }

    public double GetSalary()
    {
        return Salary;
    }
}


// Main Program

class MultipleInterfacesExample
{
    static void Main()
    {
        // Create Worker object and assign values
        Worker worker = new Worker
        {
            Name = "Divya",
            Age = 25,
            Department = "Software",
            Salary = 55000
        };

        // Use interface methods
        Console.WriteLine("Worker Personal Details:");
        Console.WriteLine($"Name: {worker.GetName()}");
        Console.WriteLine($"Age: {worker.GetAge()}");

        Console.WriteLine("\nWorker Work Details:");
        Console.WriteLine($"Department: {worker.GetDepartment()}");
        Console.WriteLine($"Salary: ₹{worker.GetSalary()}");
    }
}
