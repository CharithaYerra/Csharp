//Fields


// Class is in c# is a building block which groups the related members.

using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

class FileDetails
{

    //Fields: Fields are variables that belong to a class.
    // They represent the data that an object of the class can hold.

    string fileName = "Ram_Resume.docx";
    string fileLocation = @"D:\Students\Resumes";
    string fileSize = "2kb";
    string createdDate = "Mar-01-2025";

    DateTime createdDateTime = DateTime.Now;


    void ShowMessage(string filename, string filelocation)
    {
        //filename 
        Console.WriteLine($"Hello, File name is {this.fileName} and file location is {filelocation}");
        //Keep in mind this.filename means filename from File class . here this refers to the class Scope
    }

    static void ShowPDFFileHistory(string name, string createddate)
    {
        Console.WriteLine($"Hello, File name is {name} and created date is {createddate}");
    }

    static void ShowWordFileSize(string name, string filesize)
    {
        Console.WriteLine($"Hello, File name is {name} and file size is {filesize}");
    }


    static void ShowDetailsMessage(FileDetails file)
    {
        Console.WriteLine($"Hello,  name is {file.fileName} , size is {file.fileSize}  , location {file.fileLocation} and created DAte {file.createdDate}");
    }


    static void Main()
    {


        FileDetails file2 = new FileDetails();
        file2.fileName = "VisualStudioCodeInstallationDocument.docx";
        file2.fileSize = "10kb";
        ShowWordFileSize(file2.fileName, file2.fileSize);


        FileDetails fileInstance = new FileDetails();
        fileInstance.fileName = "Employee1_Salary.pdf";
        fileInstance.fileLocation = @"C:\Employees\Salaries";
        fileInstance.fileSize = "1Kb";
        fileInstance.createdDate = "Jan-01-2025";
        ShowDetailsMessage(fileInstance);


        //single statement;

        FileDetails file4 = new FileDetails()
        {
            fileName = "CreditCardStatemtn.pdf",
            fileLocation = @"c:/Downloads",
            fileSize = "5Kb",
            createdDate = "April-01-2025"
        };
        ShowDetailsMessage(file4);






        string fileCreatedDate = fileInstance.createdDate; //"Jan-01-2025";
        Console.WriteLine(fileCreatedDate);

        Console.WriteLine($"Print the instance of class i.e. {fileInstance}");

        fileInstance.ShowMessage(fileInstance.fileName, fileInstance.fileLocation);
        ShowPDFFileHistory("HDFC Credit Card Statement.pdf", "May-10-2024");











        //Console.WriteLine($"filename: {fileInstance.fileName}");
        //Console.WriteLine($"filelocation: {fileInstance.fileLocation}");
        //Console.WriteLine($"fileSize: {fileInstance.fileSize}");
        //Console.WriteLine($"createdDate: {fileInstance.createdDate}");



    }


}