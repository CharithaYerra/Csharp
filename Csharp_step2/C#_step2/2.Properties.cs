using System;

class StudentResume
{
    string filename;
    string filelocation = @"D:\Students\Resumes";
    string filesize = "2Kb";
    string createdDate = "Mar-01-2025";
    DateTime createdDateTime = DateTime.Now;



    //Attributes
    string FileName { get; set; }
    string FileLocation { get; set; }
    string FileSize { get; set; }
    string CreatedDate { get; set; }

    static void Main()
    {

        StudentResume studentResume = new StudentResume();

        //studentResume.filename = "Employee1_Salary.pdf";
        studentResume.FileName = "Employee1_Resume.pdf";
        studentResume.FileLocation = "C:\\Employees\\Resumes";
        studentResume.FileSize = "2kb";
        studentResume.CreatedDate = "Mar-01-2025";

        Console.WriteLine($"FileName is {studentResume.FileName} and fileSize is {studentResume.FileSize}");

    }
}