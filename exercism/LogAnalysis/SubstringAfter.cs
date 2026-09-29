using System;

class Program
{
    static void Main()
    {
        string log = "[INFO]: Hello world";

        Console.WriteLine("Message: " + log.Message());
        Console.WriteLine("Log level: " + log.LogLevel());
        Console.WriteLine("Reformatted: " + log.Reformat());
    }
}
