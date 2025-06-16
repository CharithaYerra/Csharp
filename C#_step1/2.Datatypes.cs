using System;



class Datatypes
{
    static void Main()

    {
        Console.WriteLine("** Data Types and their usage is shown here **");

        /*
          Numeric Data Types: byte, short, ushort, int, uint, long, ulong, float, decimal, double
          ------------------
           byte    : Represents unsigned integers ranging from 0 to 255.

       */


        byte age = 20; // No floating, small positive number .
        Console.WriteLine("Byte Value:" + age);

        /*
         * Range: -32,768 to 32,767
           Purpose: Stores small signed integers
         */

        short temperature = -1500;
        Console.WriteLine("Short Value:" + temperature);


        /*ushort
         * Range: 0 to 65,535
         * Purpose: Stores small positive integers
         */
        ushort population = 50000;
        Console.WriteLine("Ushort Value:" + population);


        /*int
          Range: -2,147,483,648 to 2,147,483,647
          Purpose: Default data type for integers
        */

        int AreaLength = 21456778;
        Console.WriteLine("Int Value:" + AreaLength);



        /*unit
           Range: 0 to 4,294,967,295
           Purpose: Stores positive whole numbers only
         */
        uint distance = 3000000000U;
        Console.WriteLine("UInt Value:" + distance);

        /*
        * long
            Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Purpose: Used for very large or small integers
        */
        long worldPopulation = 7800000000L;
        Console.WriteLine("Long Value:" + worldPopulation);

        /*ulong
            Range: 0 to 18,446,744,073,709,551,615
            Purpose: Large positive integers
        */

        ulong bankBalance = 100000000000000UL;
        Console.WriteLine("Ulong Value:" + bankBalance);

        /*
               Floating - Point Types(Fractional Values Allowed)
               decimal : ±79,228,162,514,264,337,593,543,950,335
               float   : ±3.40282347E+38F
               double  : ±1.7976931348623157E+308
        */


        decimal price = 199.99m;
        Console.WriteLine("Price Value:" + price);

        float pi = 3.1415199999f;
        Console.WriteLine("Pi Value:" + pi);

        double stockPrice = 987.65d;
        Console.WriteLine("stockPrice Value:" + stockPrice);


        MaxAndMinValues();


    }

    static void MaxAndMinValues()
    {
        Console.WriteLine($"byte datatype MaxValue: {byte.MaxValue} and MinValue: {byte.MinValue}");
        Console.WriteLine($"short datatype MaxValue: {short.MaxValue} and MinValue: {short.MinValue}");
        Console.WriteLine($"ushort datatype MaxValue: {ushort.MaxValue} and MinValue: {ushort.MinValue}");
        Console.WriteLine($"uint datatype MaxValue: {uint.MaxValue} and MinValue: {uint.MinValue}");
        Console.WriteLine($"ulong datatype MaxValue: {ulong.MaxValue} and MinValue: {ulong.MinValue}");
        Console.WriteLine($"float datatype MaxValue: {float.MaxValue} and MinValue: {float.MinValue}"); 
        Console.WriteLine($"decimal datatype MaxValue: {decimal.MaxValue} and MinValue: {decimal.MinValue}");

        
        Console.WriteLine($"double datatype MaxValue: {double.MaxValue} and MinValue: {double.MinValue}"); 
        Console.WriteLine($"int datatype MaxValue: {int.MaxValue} and MinValue: {int.MinValue}");
        Console.WriteLine($"long datatype MaxValue: {long.MaxValue} and MinValue: {long.MinValue}");




        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------------------------");



        /* byte short ushort int uint long ulong float decimal double
         * These are the basic data types in increasing range*/

        bool boolValue = true;
       
        Console.WriteLine("Bool value " + boolValue);


        char charValue = 'A';
        Console.WriteLine("Charcter :" + charValue);

        string sentence = "Hello , World";
        Console.WriteLine("String :" + sentence);


    }
}

