using System;

class AssignmentFile
{
    // Properties  with set and get 
    string FileName { get; set; }
    string FileLocation { get; set; }
    string FileSize { get; set; }
    string CreatedDate { get; set; }

    DateTime CreatedDateTime { get; set; } = DateTime.Now;
    //main method where the program starts the execution
    static void Main()
    {
        AssignmentFile file = new AssignmentFile();

        file.FileName = "MathAssignment.pdf";
        file.FileLocation = @"E:\College\Assignments";
        file.FileSize = "3Mb";
        file.CreatedDate = "July-01-2025";

        Console.WriteLine($"File Name: {file.FileName}");
        Console.WriteLine($"Location: {file.FileLocation}");
        Console.WriteLine($"Size: {file.FileSize}");
        Console.WriteLine($"Created Date: {file.CreatedDate}");
        Console.WriteLine($"System Created Time: {file.CreatedDateTime}");
    }
}
