using System;
 class Task
    {
    static void Main()
    {
        string[] Empnames = { "John", "Robert", "Chandra", "Peter"};

        Console.WriteLine("Third Employee: " + Empnames[2]);
        Console.WriteLine("Enter the employee data to get:");
        int index = int.Parse(Console.ReadLine())-1;
        Console.WriteLine("Employee data at index " + index + ":" + Empnames[index]);

        bool isEqual = Empnames[1] == Empnames[2];
        Console.WriteLine("Is second employee equal to the third employee " + (isEqual? "is True" : "is False"));


        foreach(string name in Empnames)
        {
            if (name[0] == 'J')
            {
                Console.WriteLine("Emplyee name that start with 'J' is " + name);

            }
        }

        foreach (string name in Empnames)
        {
            if (name.StartsWith("J"))
            {
                Console.WriteLine("Emplyee name that start with 'J' is " + name);

            }
        }

        string allEmployeeNames = string.Join(",", Empnames);
        Console.WriteLine("All employee names: " + allEmployeeNames);

        string updatedallEmployee = allEmployeeNames.Replace("Robert", "Peter");

        Console.WriteLine("Updated all employee names" + updatedallEmployee);
        Console.WriteLine("Getting the names with foreach");
        foreach(string name in Empnames)
        {
            if (name.Length > 4)
            {
                Console.WriteLine("The employee names whose length is >4 : " + name);
            }
        }


        Console.WriteLine("Getting the names with for");
        for (int i= 0;i < Empnames.Length;i++)
        {
            if (Empnames[i].Length > 4)
            {
                Console.WriteLine("The employee names whose length is >4 : " + Empnames[i]);
            }
        }

        /*To get the emplyee names in the array
        we need to give the writeline statement for each employee name
        instead we can use the loop until the condition is false
        */
        /*
         Floating data types are float ,decimal,double
        They are used to store the decimal values
         */

        float[] Empsalary = { 1555.5f, 20000.23f, 45454.22f,5555.5f };

        Console.WriteLine("float values");
        for (int i= 0;i < Empsalary.Length;i++)
        {
            Console.WriteLine(Empnames[i] + " : " + Empsalary[i]);

        }
        double[] updatedEmpsalary = { 2000.5, 20500.23, 47254.22,5825.5 };
        Console.WriteLine("double values");

        for (int i = 0; i < updatedEmpsalary.Length; i++)
        {
            Console.WriteLine(Empnames[i] + " : " + updatedEmpsalary[i]);

        }
        decimal[] reducedEmpsalary = { 555.5m, 200.23m, 554.22m,55.5m };
        Console.WriteLine("decimal values");

        for (int i = 0; i < reducedEmpsalary.Length; i++)
        {
            Console.WriteLine(Empnames[i] + " : " + reducedEmpsalary[i]);

        }


        /*
         Logical operators are used to perform logical operations on boolean values
        They are &&,||,!

        Usage given below 
         */

        foreach(string name in Empnames)
        {
            if(name.Length>4 && name.StartsWith("J"))
            {
                Console.WriteLine("Employee name starts with j and length is >4 :" + name);
            }

            if (name.Length > 4 || name.StartsWith("J"))
            {
                Console.WriteLine("Employee name starts with j or length is >4 :" + name);
            }

            if (!name.StartsWith("J"))
            {
                Console.WriteLine("Employee names that are not starting with 'j' are :" + name);
            }

        }

        /*
         * The data types cannot have null values by default
         * so we use nullable data types to assign null values to it
         * int? age=null;
         * This is how we assign the null values
         */

        int? age = null;
      
        float? marks = 88.5f;
        bool? isVerified = null;
        DateTime? dob = new DateTime(2000, 1, 1);

       // Console.WriteLine("int studentRoll number is :" + studentRoll);
        if (age.HasValue)
        {
            Console.WriteLine("Age: " + age.Value);
        }
        else
        {
            Console.WriteLine("Age is not set.");
        }

        // Set value and print again
        age = 30;

        Console.WriteLine("Updated Age: " + age);







    }
}

