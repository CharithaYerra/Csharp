using System;
using System.Collections;

namespace step4 { 
class ArrayListExample
{
    static void Main()
    {
        ArrayList mixedList = new ArrayList();
        mixedList.Add("Hello");
        mixedList.Add(100);
        mixedList.Add(45.6);

        Console.WriteLine("ArrayList contents:");
        foreach (var item in mixedList)
        {
            Console.WriteLine(item);
        }
    }
}
}