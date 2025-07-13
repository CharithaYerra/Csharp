using System;

///////////////////////////
// Base Class: Human
///////////////////////////
class Human
{
    public string FullName { get; set; }
    public int Age { get; set; }

    // Method to display basic info
    public void ShowBasicInfo()
    {
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Age: {Age}");
    }
}

///////////////////////////
// Derived Class: EmployeeDetails
///////////////////////////
class EmployeeDetails : Human // Inherits from Human
{
    public string Department { get; set; }
    public double Salary { get; set; }

    // Method specific to Employee
    public void ShowJobInfo()
    {
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: ₹{Salary}");
    }
}

///////////////////////////
// Main Program Class
///////////////////////////
class InheritanceExampleProgram
{
    static void Main()
    {
        // Create an object of the derived class
        EmployeeDetails emp = new EmployeeDetails();

        // Set properties from base class (Human)
        emp.FullName = "Divya Charitha";
        emp.Age = 25;

        // Set properties from derived class (EmployeeDetails)
        emp.Department = "Software Development";
        emp.Salary = 60000;

        // Display both base and derived class info
        Console.WriteLine("Employee Information:");
        emp.ShowBasicInfo();   // From base class
        emp.ShowJobInfo();     // From derived class
    }
}
