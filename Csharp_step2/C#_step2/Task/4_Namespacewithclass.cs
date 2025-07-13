using System;

namespace StudentApp
{
    // Student class with basic properties
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public double Marks { get; set; }
    }

    // Operations on student data
    class StudentOperations
    {
        //grades of studetns are determind here
        public string GetGrade(double marks)
        {
            if (marks >= 90) return "A";
            else if (marks >= 75) return "B";
            else if (marks >= 60) return "C";
            else if (marks >= 40) return "D";
            else return "F";
        }

        public void PrintStudentDetails(Student student)
        {
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Course: {student.Course}");
            Console.WriteLine($"Marks: {student.Marks}");
            Console.WriteLine($"Grade: {GetGrade(student.Marks)}");
        }
    }

    // Main program
    class UsageofNamespace
    {
        static void Main()
        {
            Student student = new Student
            {
                Name = "Divya",
                Age = 20,
                Course = "C# Programming",
                Marks = 85
            };

            StudentOperations ops = new StudentOperations();
            ops.PrintStudentDetails(student);
        }
    }
}
