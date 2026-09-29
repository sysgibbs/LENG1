using System;

class Program
{
    static void Main()
    {
        var tracks = new TracksOnTracksOnTracks(new List<string> { "C#" });

        Console.WriteLine("Languages: " + string.Join(", ", tracks.Languages));
        tracks.AddLanguage("F#");
        Console.WriteLine("After add: " + string.Join(", ", tracks.Languages));
        tracks.RemoveLanguage("C#");
        Console.WriteLine("After remove: " + string.Join(", ", tracks.Languages));
    }
}
