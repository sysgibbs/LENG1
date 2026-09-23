using System;

class Program
{
    static void Main()
    {
        // Creamos un BirdCount con los datos de esta semana
        int[] birds = { 0, 2, 5, 3, 7, 8, 4 };
        BirdCount birdCount = new BirdCount(birds);

        Console.WriteLine("Pájaros de hoy: " + birdCount.Today());

        birdCount.IncrementTodaysCount();
        Console.WriteLine("Después de incrementar: " + birdCount.Today());

        Console.WriteLine("¿Hay algún día sin pájaros?: " + birdCount.HasDayWithoutBirds());

        Console.WriteLine("Pájaros en los primeros 3 días: " +
                          birdCount.CountForFirstDays(3));

        Console.WriteLine("Días ocupados: " + birdCount.BusyDays());

        Console.WriteLine("Semana pasada:");
        int[] lastWeek = BirdCount.LastWeek();

        foreach (int birdsInDay in lastWeek)
        {
            Console.Write(birdsInDay + " ");
        }
    }
}
