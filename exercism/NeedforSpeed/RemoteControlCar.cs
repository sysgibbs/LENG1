using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Remote Control Car ===");

        RemoteControlCar car = new RemoteControlCar(20, 2);

        Console.WriteLine($"Distancia inicial: {car.DistanceDriven()}");
        Console.WriteLine($"¿Batería agotada?: {car.BatteryDrained()}");

        car.Drive();
        car.Drive();
        car.Drive();

        Console.WriteLine($"Distancia después de conducir: {car.DistanceDriven()}");
        Console.WriteLine($"¿Batería agotada?: {car.BatteryDrained()}");

        RaceTrack track = new RaceTrack(100);

        bool canFinish = track.TryFinishTrack(car);

        Console.WriteLine($"¿Puede terminar la pista?: {canFinish}");

        Console.WriteLine("\n=== Nitro Car ===");

        RemoteControlCar nitro = RemoteControlCar.Nitro();

        Console.WriteLine($"Distancia inicial: {nitro.DistanceDriven()}");

        nitro.Drive();

        Console.WriteLine($"Distancia después de conducir: {nitro.DistanceDriven()}");

        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine();
    }


}
