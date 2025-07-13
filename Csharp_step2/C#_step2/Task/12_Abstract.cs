using System;


// Abstract  Class
abstract class UniversityMember
{
    //  Abstract --must be implemented by derived classes
    public abstract string Name { get; set; }

    // Abstract method ---->must be overridden in derived classes
    public abstract void ShowRole();

    // Non-abstract method -->shared logic
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to Global Tech University!");
    }

    //  Non-abstract property
    public string University => "Global Tech University";
}
// Derived Class: Student
class DegreeStudent : UniversityMember
{
    // Implementing the abstract property
    public override string Name { get; set; }

    // Implementing the abstract method
    public override void ShowRole()
    {
        Console.WriteLine($"{Name} is a student at {University}.");
    }
}

///////////////////////////////
// Program Entry
///////////////////////////////
class AbstractClassExample
{
    static void Main()
    {
        // Create a Student object
        DegreeStudent student = new DegreeStudent
        {
            Name = "Divya"
        };

        // Call non-abstract method from base class
        student.DisplayWelcomeMessage();

        // Call overridden abstract method
        student.ShowRole();
    }
}
