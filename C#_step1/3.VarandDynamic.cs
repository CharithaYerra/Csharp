using System;

    class VarandDynamic
    {
     static void Main()
    {
        //var and dynamic keywords usage

        //var number; should assign when declaring and can change

        int age = 20;
        age = 30;
        Console.WriteLine("age type:" + age.GetType());

        string name = "john";
        Console.WriteLine("name type:" + name.GetType());

        //string also can be reassigned but only to string type

        name = "sindhu";
        Console.WriteLine("name is after reassignment:" + name);

        //var keyword

        var city = "Kadapa";
        Console.WriteLine("city type:" + city.GetType());

        city = "Hyderabad";
        Console.WriteLine("city :" + city);

        //city = 20; conpile time error var is string cannot store int 

        var streetNo= 5;
        Console.WriteLine("streetno type: " + streetNo.GetType());

        streetNo = 5435583;
        Console.WriteLine("streetno type: " + streetNo.GetType());


        //Dynamic keyword

        //can declare without assigning the numbers and also can reassign

        dynamic number;
        number = 10;

        dynamic pack = 500;
        Console.WriteLine("pack  : " + pack);

        Console.WriteLine("pack type : " + pack.GetType());

        pack = 3;
        Console.WriteLine("pack type : " + pack.GetType());
        




        //we can assign string when reassigning but it leads to another errors

        pack = "2GB";
        Console.WriteLine("pack type : " + pack.GetType());
        //we cannot use MaxValue for string type 
        //Console.WriteLine("pack type : " + pack.length);



        












    }
}

