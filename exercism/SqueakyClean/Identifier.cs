using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Identifier.Clean("hello world"));
        Console.WriteLine(Identifier.Clean("hello-world"));
        Console.WriteLine(Identifier.Clean("123hello"));
        Console.WriteLine(Identifier.Clean("hello\tworld"));
        Console.WriteLine(Identifier.Clean("hello-world-test"));

        Console.WriteLine();
        Console.WriteLine("Presiona Enter para salir...");
        Console.ReadLine();
    }
}
