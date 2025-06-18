using System;
using System.Diagnostics.Eventing.Reader;

class String
{
    static void Main()

    {

        //String types to use

        string sentence = "This is a sample sentence.";
        string useOfVariable = $"The sentence is : {sentence}";

        string specialChars = "This is  a \"special\" string with 'quotes' and \\backslashes\\";
        Console.WriteLine("Special Characters String: " + specialChars);
        //after usage of \ we need special chars 

        //string myProjectPath = @"D:\Csharp - Training\CSharp\CSharp_Step1";
        string myProjectPath = @"D:\Csharp - Training\\CSharp\\CSharp_Step1\";
        Console.WriteLine(myProjectPath);

        string FirstName = "divya";
        string LastName = "siri";
        Console.WriteLine("the full name is {0} and lastname is {1}", FirstName, LastName);
        string fullName = string.Format("the full name is {0} and lastname is {1}", FirstName, LastName);
        Console.WriteLine(fullName);


        //string method usage


        string name = "divya";
        Console.WriteLine(name.ToLower());
        Console.WriteLine(name.ToUpper());

        //trim usage 

        string space = "   sentence     ";
        Console.WriteLine( space);

        Console.WriteLine("the usage if trim :"+space.Trim());
        Console.WriteLine("the usage if trimEnd :"+space.TrimEnd());
        Console.WriteLine("the usage if trimStart :" + space.TrimStart());


        //we can specify the character which should be trimmed

        string trimChar = "############Hellow World############";

        Console.WriteLine(trimChar);
        Console.WriteLine("the usage of trim with char :" + trimChar.Trim('#'));
        Console.WriteLine("the usage of trimEnd with char :" + trimChar.TrimEnd('#'));
        Console.WriteLine("the usage of trimStart with char :" + trimChar.TrimStart('#'));

        //usage of pad to add spaces to the string

        string padString = "Hello";

        Console.WriteLine(padString);
        Console.WriteLine("the usage of padLeft :" + padString.PadLeft(7));
        Console.WriteLine("the usage of padRight: " + padString.PadRight(7));


        //to compare

        string str1 = "hello";
        string str2 = "Hello";
        Console.WriteLine("Comparing two strings: " + str1.Equals(str2));


        //To get the substring from a string

        string subStingEx = "This is a string to get a substring from it.";

        Console.WriteLine(subStingEx);
        Console.WriteLine("Substring from index 10 to 15 is :" + subStingEx.Substring(10, 5));


        //usage of split 

        string sentenceToSplit = "This is a sample sentence to split";
        string[] splitted = sentenceToSplit.Split(' ');
        Console.WriteLine(splitted);
        foreach(string word in splitted)
        {
            Console.WriteLine(word);
        }

        string originalString = "Hello World";
        Console.WriteLine("the origina string is :" + originalString);

        string replacedString = originalString.Replace("World", "Siri");




        Console.WriteLine("Let us check the duplicate characters in the string");
        Console.WriteLine("Enter a word :");
        string wordtoCheck = Console.ReadLine();

        for (int i= 0; i < wordtoCheck.Length; i++)
        {
            for (int j = i + 1; j < wordtoCheck.Length; j++)
            {
                if (wordtoCheck[i] == wordtoCheck[j])
                {
                    Console.WriteLine("Duplicate character found: " + wordtoCheck[i]);
                    break;
                }
            }
        }



        Console.WriteLine("Count no of words in sentence");
        Console.WriteLine("Enter a sentence :");
        string CountWords = Console.ReadLine();
        string[] splittedWords = CountWords.Split(' ');
        int wordCount = splittedWords.Length;
        Console.WriteLine("Number of words in the sentence:" + wordCount);





    }
}

