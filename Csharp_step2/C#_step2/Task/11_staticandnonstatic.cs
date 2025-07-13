using System;


// Non-Static Class: University

class University
{
    //  Static field  shared by all students
    public static string UniversityName = "Global Tech University";

    //  Static method no need for object to call this
    public static void DisplayUniversityInfo()
    {
        Console.WriteLine($"Welcome to {UniversityName}");
    }

    //  Instance fields: unique for each student
    public string StudentName { get; set; }
    public string Course { get; set; }

    // Instance method: must be called on an object
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine($"Enrolled Course: {Course}");
    }
}


// Main Program

class UniversityExample
{
    static void Main()
    {
        // Call static method (no object needed)
        University.DisplayUniversityInfo();

        Console.WriteLine(); // spacer

        //  Create first student object
        University student1 = new University
        {
            StudentName = "Divya",
            Course = "Computer Science"
        };
        student1.DisplayStudentInfo();

        Console.WriteLine();

        //  Create second student object
        University student2 = new University
        {
            StudentName = "Rahul",
            Course = "Data Science"
        };
        student2.DisplayStudentInfo();

        Console.WriteLine();

        //  Change static field — affects all
        University.UniversityName = "JNTUA University";
        University.DisplayUniversityInfo();
    }
}
