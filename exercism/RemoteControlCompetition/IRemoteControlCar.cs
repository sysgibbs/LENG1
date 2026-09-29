using System;

class Program
{
    static void Main()
    {
        var car = new RemoteControlCar();
        car.Drive();
        Console.WriteLine("Distance: " + car.DistanceDriven());
        Console.WriteLine("Battery drained: " + car.BatteryDrained());
    }
}
