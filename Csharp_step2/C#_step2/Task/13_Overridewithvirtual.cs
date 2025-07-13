using System;


//  Class: CampusPerson

class CampusPerson
{
    public string Name { get; set; }

    //  Virtual Method: Can be overridden
    public virtual void DisplayRole()
    {
        Console.WriteLine($"{Name} is a member of the campus.");
    }

    //  Another virtual method
    public virtual void ShowWelcome()
    {
        Console.WriteLine("Welcome to the Campus!");
    }
}

// Derived Class: CampusStudent

class CampusStudent : CampusPerson
{
    // Override the virtual method from base
    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} is a student on the campus.");
    }

    //  Override another virtual method
    public override void ShowWelcome()
    {
        Console.WriteLine($"Welcome {Name}, explore your campus life!");
    }
}


// Program Entry Point
class CampusProgram
{
    static void Main()
    {
        // Create object of derived class
        CampusStudent student = new CampusStudent
        {
            Name = "Divya"
        };

        // Call overridden methods
        student.DisplayRole();     // Overridden from base class
        student.ShowWelcome();     // Overridden from base class
    }
}
