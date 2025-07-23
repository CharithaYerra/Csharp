using System;
using System.Collections;

class ArrayListExample
{
    // Method 1: Add items to an ArrayList
    public static ArrayList CreateRobotPartsList()
    {
        ArrayList robotParts = new ArrayList();
        robotParts.Add("Sensor");
        robotParts.Add("Motor");
        robotParts.Add("Battery");
        robotParts.Add(123);  // Mixing types (not recommended in practice)
        return robotParts;
    }

    // Method 2: Print ArrayList
    public static void PrintParts(ArrayList parts)
    {
        Console.WriteLine("Robot Parts:");
        foreach (var part in parts)
        {
            Console.WriteLine(part);
        }
    }

    // Method 3: Modify the ArrayList
    public static void ModifyParts(ArrayList parts)
    {
        parts.Insert(1, "Camera");       // Insert at position 1
        parts.Remove("Motor");           // Remove "Motor"
        parts.Add("AI Module");          // Add new part at end
    }

    static void Main(string[] args)
    {
        ArrayList robotParts = CreateRobotPartsList();

        PrintParts(robotParts);

        Console.WriteLine("\n-- After Modifications of Array List --");
        ModifyParts(robotParts);
        PrintParts(robotParts);
    }
}
