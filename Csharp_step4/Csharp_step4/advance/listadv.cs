using System;
using System.Collections.Generic;

class StudentManager
{
    static void Main(string[] args)
    {
        // Step 1: Call a method that returns a list and store it
        List<string> studentList = GetStudents();

        // Step 2: Display the returned list
        Console.WriteLine("Initial Student List:");
        PrintList(studentList);

        // Step 3: Pass list to a method that adds more students
        AddMoreStudents(studentList);

        // Step 4: Display the updated list
        Console.WriteLine("\nUpdated Student List:");
        PrintList(studentList);

        // Step 5: Pass list to search method
        SearchStudent(studentList, "Raj");
    }

    // Returns a List<string>
    static List<string> GetStudents()
    {
        return new List<string> { "Anu", "Ravi", "Sita" };
    }

    // Accepts a List<string> and modifies it
    static void AddMoreStudents(List<string> students)
    {
        students.Add("Raj");
        students.Add("Priya");
    }

    // Accepts a List<string> and displays each item
    static void PrintList(List<string> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine("- " + student);
        }
    }

    // Accepts a List<string> and a name, checks if student exists
    static void SearchStudent(List<string> students, string name)
    {
        if (students.Contains(name))
            Console.WriteLine($"\n Student '{name}' found.");
        else
            Console.WriteLine($"\n Student '{name}' not found.");
    }
}
