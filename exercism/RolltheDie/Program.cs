class Program
{
    static void Main()
    {
        Player player = new Player();

        Console.WriteLine(player.RollDie());
        Console.WriteLine(player.GenerateSpellStrength());
    }
}
