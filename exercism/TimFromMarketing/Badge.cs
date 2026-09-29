class Program
{
    static void Main()
    {
        Console.WriteLine(Badge.Print(123, "Juan", "sales"));
        Console.WriteLine(Badge.Print(null, "Juan", null));
        Console.WriteLine(Badge.Print(42, "Maria", "engineering"));
    }
}
