using System;


class MessagingApp
{
    

    static void Main()
    {
        string[] messages = new string[100];
        int messageCount = 0;
        Console.WriteLine("Simple Message");
        Console.WriteLine("Type 'exit' to stop.\n");

        bool running = true;
        string currentUser = "User1";

        while (running)
        {
            Console.Write($"{currentUser}: ");
            string message = Console.ReadLine();

            if (message.ToLower() == "exit")
            {
                running = false;
                break;
            }

            messages[messageCount++]=($"{currentUser}: {message}");

            // Switch users
            currentUser = (currentUser == "User1") ? "User2" : "User1";
        }

     
        Console.WriteLine("\nConversation:");
        for (int i = 0; i < messageCount; i++)
        {
            Console.WriteLine(messages[i]);
        }
    }
}
