using System;

class Employee
{
    string employeeName;
    double baseSalary;

    // Non-static method with parameters (set details)
    public void SetDetails(string nameInput, string salaryInput)
    {
        employeeName = nameInput.ToUpper(); // Built-in: ToUpper()
        baseSalary = Convert.ToDouble(salaryInput); // Convert string to double
    }

    // Non-static method to show employee info
    public void ShowInfo()
    {
        Console.WriteLine($"\nEmployee Name: {employeeName}");
        Console.WriteLine($"Base Salary: ₹{baseSalary}");
    }

    // Static method with parameters and return value
    public static double CalculateBonus(double salary)
    {
        return Math.Round(salary * 0.20, 2); // 20% bonus
    }

    // Static method with parameter and return value
    public static string BonusMessage(double bonus)
    {
        if (bonus >= 10000)
            return "High Bonus Eligible!";
        else if (bonus >= 5000)
            return "Moderate Bonus Eligible!";
        else
            return "Low Bonus or No Bonus.";
    }
}

class EmployeeBonus
{
    static void Main()
    {
        Employee emp = new Employee();

        // Take user input
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Enter base salary: ");
        string salary = Console.ReadLine();

        // Set and display employee info
        emp.SetDetails(name, salary);
        emp.ShowInfo();

        // Call static method to calculate bonus
        double bonus = Employee.CalculateBonus(Convert.ToDouble(salary));
        Console.WriteLine($"\nCalculated Bonus: ₹{bonus}");

        // Call static method to get bonus message
        string message = Employee.BonusMessage(bonus);
        Console.WriteLine($"Bonus Message: {message}");
    }
}
