using System;
using System.Xml.Schema;
class TaskMethods
{
    static void Main()
    {
        Console.WriteLine("Information of student");
        Console.WriteLine("Enter the details of student");
        string[] studentDetails = new string[3];
        Console.WriteLine("Enter name of studet:");
        studentDetails[0] = Console.ReadLine();
        Console.WriteLine("Enter name of RollNum:");
        studentDetails[1] = Console.ReadLine();

        Console.WriteLine("Enter name of gender (f/m):");
        studentDetails[2] = Console.ReadLine();
        //The implict conversion is to convert the data types without losing any data

        int noOfstds = Details(studentDetails);
        int[] marks = { 20, 56, 64, 43, 34 };
        Grade(studentDetails[0],marks);
        bool isPassed = Passed(marks, 10);
        Console.WriteLine((isPassed ? "Student can go to next class" : "Failed"));

    }
    static byte Details(string[] student)
    {
        foreach(string detail in student)
        {
            Console.WriteLine(detail);
        }
        return 1;//impicit coversion
    }

    static void Grade(string studentName, int[] marks)
    {
        if (marks.Length == 0)
        {
            Console.WriteLine("No marks available");
        }
        else
        {
            foreach(int mark in marks)
            {
                if (mark >= 50)
                {
                    Console.WriteLine($"{mark} is A Grade");

                }
                else if(mark>=35 && mark < 50)
                {
                    Console.WriteLine($"{mark} is of B grade");
                }
                else
                {
                    Console.WriteLine($"{mark} is fail Grade");

                }

            }
        }
    }


    static bool Passed(int[] marks,int classno)
    {
        float total = 0;
        foreach(int mark in marks)
        {
          total+= mark;
        }
        switch (classno)
        {
            case 8:
                if (total / marks.Length >= 40)
                {
                    return true;
                }
                else
                {
                     return false; 
                }
            case 9:
                if (total / marks.Length >= 60)
                {
                    return true;
                }
                else
                {
                    { return false; }
                }
            case 10:
                if (total / marks.Length >= 80)
                {
                    return true;
                }
                else
                {
                    { return false; }
                }

        }
        return false;//it returns if the switch case does not match

    }

}