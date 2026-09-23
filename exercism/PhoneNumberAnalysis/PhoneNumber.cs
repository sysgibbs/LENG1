using System;

class Program
{
    static void Main()
    {
        var resultado = PhoneNumber.Analyze("212-555-1234");

        Console.WriteLine($"¿Es de New York? {resultado.IsNewYork}");
        Console.WriteLine($"¿Es falso? {resultado.IsFake}");
        Console.WriteLine($"Número local: {resultado.LocalNumber}");

        bool falso = PhoneNumber.IsFake(resultado);

        Console.WriteLine($"IsFake(): {falso}");
    }
}
