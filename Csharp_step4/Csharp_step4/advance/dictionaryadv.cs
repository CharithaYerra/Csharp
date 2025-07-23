using System;
using System.Collections.Generic;

class RobotDictionaryExample
{
    // Method 1: Create and return a dictionary of robot commands
    public static Dictionary<string, string> GetRobotCommands()
    {
        Dictionary<string, string> commands = new Dictionary<string, string>();
        commands.Add("start", "Robot is starting up.");
        commands.Add("move", "Robot is moving forward.");
        commands.Add("stop", "Robot has stopped.");
        return commands;
    }

    // Method 2: Print all commands
    public static void PrintCommands(Dictionary<string, string> commands)
    {
        Console.WriteLine("Robot Command List:");
        foreach (var pair in commands)
        {
            Console.WriteLine($"Command: {pair.Key} => Action: {pair.Value}");
        }
    }

    // Method 3: Update or add a command
    public static void UpdateCommand(Dictionary<string, string> commands, string key, string newAction)
    {
        commands[key] = newAction; // Adds new if key doesn't exist, updates if it does
    }

    // Method 4: Remove a command if it exists
    public static void RemoveCommand(Dictionary<string, string> commands, string key)
    {
        if (commands.ContainsKey(key))
        {
            commands.Remove(key);
            Console.WriteLine($"Command '{key}' removed.");
        }
        else
        {
            Console.WriteLine($"Command '{key}' not found.");
        }
    }

    static void Main(string[] args)
    {
        var robotCommands = GetRobotCommands();
        PrintCommands(robotCommands);

        Console.WriteLine("\n-- Updating 'move' and adding 'shutdown' --");
        UpdateCommand(robotCommands, "move", "Robot is running fast.");
        UpdateCommand(robotCommands, "shutdown", "Robot is shutting down.");
        PrintCommands(robotCommands);

        Console.WriteLine("\n-- Removing 'start' command --");
        RemoveCommand(robotCommands, "start");
        PrintCommands(robotCommands);
    }
}
