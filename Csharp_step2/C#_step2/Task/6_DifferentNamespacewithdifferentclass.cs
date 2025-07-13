using System;
using StudentApp.Usage; // Importing the correct namespace

///////////////////////////
// Namespace: Core Logic
///////////////////////////
namespace StudentApp.Usage
{
    // Class 1: Represents student data
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Marks { get; set; }
    }

    // Class 2: Contains logic for students
    public class StudentHelper
    {
        // Method to calculate grade based on marks
        public string GetGrade(double marks)
        {
            if (marks >= 90) return "A";
            else if (marks >= 75) return "B";
            else if (marks >= 60) return "C";
            else if (marks >= 40) return "D";
            else return "F";
        }

        // Method to print student info
        public void PrintStudentDetails(Student student)
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Marks: {student.Marks}");
            Console.WriteLine($"Grade: {GetGrade(student.Marks)}");
        }
    }
}

///////////////////////////
// Namespace: Main Entry
///////////////////////////
namespace StudentDetilas
{
    // Main program class
    class Program
    {
        static void Main()
        {
            // Creating student object
            Student student = new Student
            {
                Name = "Divya",
                Age = 20,
                Marks = 87.5
            };

            // Creating helper object
            StudentHelper helper = new StudentHelper();

            // Display student details
            helper.PrintStudentDetails(student);
        }
    }
}
