using System;

class Program
{
    static void Main()
    {
        var scale = new WeighingMachine(0.5m);

        scale.Weight = 75.5m;
        Console.WriteLine("Weight in kg: " + scale.Weight);
        Console.WriteLine("Weight in lbs: " + scale.WeightInPounds);
    }
}
