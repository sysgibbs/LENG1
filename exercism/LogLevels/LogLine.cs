class Program
{
    static void Main()
    {
        string log = "[WARNING]: Disk almost full";

        Console.WriteLine(LogLine.Message(log));
        Console.WriteLine(LogLine.LogLevel(log));
        Console.WriteLine(LogLine.Reformat(log));
    }
}
