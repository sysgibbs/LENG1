using System;

class Program
{
    static void Main()
    {
        var warrior = new Warrior();
        var wizard = new Wizard();

        Console.WriteLine("Warrior: " + warrior.ToString() + ", damage: " + warrior.Damage);
        Console.WriteLine("Wizard: " + wizard.ToString() + ", damage: " + wizard.Damage);
    }
}
