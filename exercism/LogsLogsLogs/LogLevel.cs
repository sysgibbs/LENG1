using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Short format INFO: " + LogsLogsLogs.ToShortFormat(LogLevel.Info));
        Console.WriteLine("Short format WARNING: " + LogsLogsLogs.ToShortFormat(LogLevel.Warning));
        Console.WriteLine("Short format ERROR: " + LogsLogsLogs.ToShortFormat(LogLevel.Error));
    }
}
