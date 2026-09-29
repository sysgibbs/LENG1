class Program
{
    static void Main()
    {
        var character = new Character
        {
            Class = "Wizard",
            Level = 4,
            HitPoints = 28
        };

        var destination = new Destination
        {
            Name = "Mordor",
            Inhabitants = 1234567
        };

        Console.WriteLine(GameMaster.Describe(character));
        Console.WriteLine(GameMaster.Describe(destination));
        Console.WriteLine(GameMaster.Describe(TravelMethod.Walking));
        Console.WriteLine(GameMaster.Describe(TravelMethod.Horseback));
        Console.WriteLine(GameMaster.Describe(character, destination));
        Console.WriteLine(GameMaster.Describe(character, destination, TravelMethod.Horseback));
    }
}
