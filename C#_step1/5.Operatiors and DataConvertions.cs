using System;
 class OperatorsAndDataConversions


    {
    static void Main()
    {
        // byte sum = (5 + 3);

        // int differnce = (10 - 4);

        // int productsLength = (3 * 4) + 5;   //17

        // double result = (10.9 / 3.7);

        // double remainder = (10 % 3);

        // //string test = $"{sum}"

        //string ouput =  string.Format("Sum is {0} difference {1} productsLength {2} result {3} remainder {4}", 
        //     sum, differnce, productsLength,result ,  remainder);

        // Console.WriteLine(ouput);


        //Console.WriteLine(5 == 5);

        //--------------------------------------------------------------------------------------

        //bool isEquals = (5 == 5);   //true

        //bool isNotEqual = (5 != 3);  //true

        //bool isGreatr = (8 > 5);   //true

        //bool isLess = (3 < 7); //true

        //bool isGreatarOrEqual = (8 >= 8); //true

        //bool isLessOrEqual  =  (3 <= 7);  //true


        //Console.WriteLine("****Compare operators are useful for Compare the values****");

        //string SI = $"isEqual {isEquals} , isNotEqual {isNotEqual} , isGreatr {isGreatr} , " +
        //    $"isLess{isLess} , isGreatarOrEqual {isGreatarOrEqual} , isLessOrEqual {isLessOrEqual}";

        //Console.WriteLine(SI);



        string userName = "John";
        int lenthOfUserName = 4;

        bool isUserNameLengthCorrect = (userName.Length == lenthOfUserName);
        //Console.WriteLine(isUserNameLengthCorrect);


        //string[] currencyItems = { "10$", "20$", "30$" };
        string[] currencyItems = new string[] { "10$", "20$", "30$" };
        int noOfCurrencyItems = 8;


        //string[3] currecnyItems = []

        bool isCurrnceyNotesEqaual = (currencyItems.Length == noOfCurrencyItems);
        //Console.WriteLine(isCurrnceyNotesEqaual);




        //-----------------------------------------------------------------------------------------

        // Logical Operators  && ||  !

        Console.WriteLine("***************** && (And) operator****************");
        //bool checkResult1 = true && true;         //true
        //Console.WriteLine(checkResult1);

        //bool checkResult2 = (5 == 5) && (5 != 3); //true
        //Console.WriteLine(checkResult2);
        ////                      T           F
        //bool checkResult3 = (5 == 5) && (5 == 3); //false
        //Console.WriteLine(checkResult3);

        //bool checkResult4 = (5 == 3) && (5 == 5); //false
        //Console.WriteLine(checkResult4);

        //bool checkResult5 = (5 == 3) && (5 == 3); //false
        //Console.WriteLine(checkResult5);


        Console.WriteLine("***************** && (Or) operator****************");
        bool checkResult1 = true || true;         //true
        Console.WriteLine(checkResult1);

        bool checkResult6 = false || false;       //false
        Console.WriteLine(checkResult6);

        bool checkResult2 = (5 == 5) || (5 != 3); //true
        Console.WriteLine(checkResult2);
        //                      T           F
        bool checkResult3 = (5 == 5) || (5 == 3); //true
        Console.WriteLine(checkResult3);

        bool checkResult4 = (5 == 3) || (5 == 5); //true
        Console.WriteLine(checkResult4);

        bool checkResult5 = (5 == 3) || (5 == 3); //false
        Console.WriteLine(checkResult5);


        bool oppTrue = !true;  //false
        Console.WriteLine(oppTrue);

        bool oppFalse = !false; //true
        Console.WriteLine(oppFalse);



        //null -> No value   1, 23


        //int age = 30;  //Value type

        //int? age = null;

        //int id 

        int? age = 30;

        Console.WriteLine("Age is ", age);

        bool? nullbaleBool = null;
        Console.WriteLine("nullbaleBool is ", nullbaleBool);

        bool? nullbaleBool1 = false;
        Console.WriteLine(nullbaleBool1);

        /*
       Implicit Type Conversion (Type Promotion)
       It occurs when you convert a smaller data type into a larger data type without the risk of losing data.

       Datatype    Maximum value  
       Integral Types (Whole Numbers Only)
       byte        0 to 255
       int         ±2,147,483,648 or -2,147,483,648 to +2,147,483,647
       uint        0 to 4,294,967,295  
       long        -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  
       ulong       0 to 18,446,744,073,709,551,615  

       Floating-Point Types (Fractional Values Allowed)
       decimal     ±79,228,162,514,264,337,593,543,950,335  
       float       ±3.40282347E+38F  
       double      ±1.7976931348623157E+308 
       */


        byte smallNumber = 5;
        int largeNumber = smallNumber;  //Implicitconversation from byto to Int
        Console.WriteLine(largeNumber);


        int NoOfEmployees = 400;
        byte ConvertingNoOfEmployees = (byte)NoOfEmployees;
        Console.WriteLine(ConvertingNoOfEmployees);  // correct result set ????


        double PetrolPrice = 80.45;
        int intVAlue = (int)PetrolPrice;
        Console.WriteLine(intVAlue);


        int number = 42;
        string strNumber = number.ToString();
        Console.WriteLine(strNumber.GetType());



        string strnumber1 = "42";
        int parsedNumber = int.Parse(strnumber1);
        //string strNumber = number.ToString();
        Console.WriteLine(parsedNumber);
        Console.WriteLine(parsedNumber.GetType());


        string strnumber2 = "42";
        int convertNumber = Convert.ToInt32(strnumber2);
        //string strNumber = number.ToString();
        Console.WriteLine(convertNumber);
        Console.WriteLine(convertNumber.GetType());


        //value type numeric types       //ref
        string nullbaleString = null;
        //int output1 = int.Parse(nullbaleString);
        int output1 = Convert.ToInt32(nullbaleString);  //0
        Console.WriteLine(output1);


        
    }
}

