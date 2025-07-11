using System;

namespace EmployeeApp
{
    // Model class
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    // Logic and operations class
    class EmployeeOperations
    {
        // Return one employee
        public static Employee GetEmployee()
        {
            return new Employee()
            {
                Name = "Ravi",
                Age = 28,
                Department = "IT",
                Salary = 50000
            };
        }

        // Update department of a given employee
        public static Employee UpdateDepartment(Employee emp)
        {
            emp.Department = emp.Department + " - Support";
            return emp;
        }

        // Return an array of multiple employees
        public static Employee[] GetEmployees()
        {
            return new Employee[]
            {
                new Employee() { Name = "Ravi", Age = 28, Department = "IT", Salary = 50000 },
                new Employee() { Name = "Sita", Age = 30, Department = "HR", Salary = 60000 },
                new Employee() { Name = "Arjun", Age = 35, Department = "Finance", Salary = 55000 }
            };
        }

        // Increase salary of all employees by 10%
        public static Employee[] UpdateSalaries(Employee[] employees)
        {
            foreach (Employee emp in employees)
            {
                emp.Salary = emp.Salary * 1.10;
            }
            return employees;
        }
    }

    // Main Program
    class EmployeeApp
    {
        static void Main()
        {
            // Single employee
            var emp = EmployeeOperations.GetEmployee();
            Console.WriteLine($"Single Employee: {emp.Name}, {emp.Age}, {emp.Department}, ₹{emp.Salary}");

            // Update department
            Employee updatedEmp = EmployeeOperations.UpdateDepartment(emp);
            Console.WriteLine($"After department update: {updatedEmp.Name}, {updatedEmp.Department}");

            // List of employees
            var employeeList = EmployeeOperations.GetEmployees();
            Console.WriteLine("\nAll Employees Before Salary Update:");
            foreach (Employee e in employeeList)
            {
                Console.WriteLine($"{e.Name}, {e.Age}, {e.Department}, ₹{e.Salary}");
            }

            // Update salaries
            EmployeeOperations.UpdateSalaries(employeeList);

            Console.WriteLine("\nAll Employees After Salary Update:");
            foreach (Employee e in employeeList)
            {
                Console.WriteLine($"{e.Name}, {e.Age}, {e.Department}, ₹{e.Salary:F2}");
            }
        }
    }
}
