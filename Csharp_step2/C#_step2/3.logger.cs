using System;

namespace StudentAttendanceTracker
{
    // 🔹 Static class to track total number of attendance logs
    public static class AttendanceLogger
    {
        private static int totalAttendanceCount = 0;

        // Static method to log a message and increase global count
        public static void LogAttendance(string studentName)
        {
            Console.WriteLine($"[Attendance] {studentName} marked present.");
            totalAttendanceCount++;
        }

        // Static method to return global count
        public static int GetTotalCount()
        {
            return totalAttendanceCount;
        }
    }

    // 🔹 Non-static class to track attendance per student
    public class Student
    {
        private string name;
        private int individualAttendance = 0;

        public Student(string name)
        {
            this.name = name;
        }

        // Non-static method to mark attendance
        public void MarkPresent()
        {
            individualAttendance++;
            AttendanceLogger.LogAttendance(name); // Uses static logger
        }

        // Non-static method to display student's personal attendance count
        public void ShowAttendance()
        {
            Console.WriteLine($"{name}'s personal attendance count: {individualAttendance}");
        }
    }

    // 🔹 Main Program
    class Program
    {
        static void Main()
        {
            // Create student objects
            Student student1 = new Student("Alice");
            Student student2 = new Student("Bob");

            // Mark attendance
            student1.MarkPresent(); // Alice: +1
            student2.MarkPresent(); // Bob: +1
            student1.MarkPresent(); // Alice: +1 again

            Console.WriteLine();

            // Show personal attendance
            student1.ShowAttendance(); // Should be 2
            student2.ShowAttendance(); // Should be 1

            Console.WriteLine();

            // Show total global attendance
            Console.WriteLine($"Total attendance logged (all students): {AttendanceLogger.GetTotalCount()}");
        }
    }
}
