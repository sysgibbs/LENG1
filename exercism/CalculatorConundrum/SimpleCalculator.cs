using System;

class Program
{
    static void Main()
    {
        var calc = new CalculatorConundrum();

        Console.WriteLine(calc.Calculate(2, 3, "add"));       // 5
        Console.WriteLine(calc.Calculate(10, 2, "divide"));   // 5
        Console.WriteLine(calc.Calculate(5, 0, "divide"));    // error message
        Console.WriteLine(calc.Calculate(2, 3, "multiply"));  // error message
    }
}
