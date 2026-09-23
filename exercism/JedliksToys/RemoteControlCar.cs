using System;
class Program
{
    static void Main(string[] args)
    {
        RemoteControlCar car = RemoteControlCar.Buy();

        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());

        car.Drive();
        car.Drive();
        car.Drive();

        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());

        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine();
    }

}
