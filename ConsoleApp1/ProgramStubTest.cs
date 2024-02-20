
// These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
using System.Diagnostics;

// CREARE METODI:
// PreparaCaffe -> 3s
// TostaPane -> 4s
// ImburraPane -> 4s
// SpremiLeArance -> 5s
// ConsumaLaColazione ->6s

class Program
{
    public static async Task Main(string[] args)
    {
        Stopwatch s = new Stopwatch();
        s.Start();

        Console.WriteLine($"START {s.ElapsedMilliseconds}");

        

        Console.WriteLine($"END {s.ElapsedMilliseconds}");
    }


}
