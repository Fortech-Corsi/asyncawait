
// These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
using System.Diagnostics;

internal class HttpCall { }
internal class BigData { }
internal class Print { }

class Program
{
    public static async Task Main(string[] args)
    {
        Stopwatch s = new Stopwatch();
        s.Start();

        Console.WriteLine($"START {s.ElapsedMilliseconds}");

        Task<HttpCall> httpData = DoHttpCall();
        BigData bigData = RetrieveBigData();
        Print print = PrintData();        

        Console.WriteLine($"END {s.ElapsedMilliseconds}");
    }


    private static BigData RetrieveBigData()
    {
        Console.WriteLine("RetrieveBigData START");
        Task.Delay(3000).Wait();
        Console.WriteLine("RetrieveBigData END");

        return new BigData();
    }

    private async static Task<HttpCall> DoHttpCall()
    {
        Console.WriteLine("DoHttpCall START");
        await Task.Delay(3000);
        Console.WriteLine("DoHttpCall END");

        return new HttpCall();
    }

    private static Print PrintData()
    {
        Console.WriteLine("PrintData START");
        Task.Delay(1000).Wait();
        Console.WriteLine("PrintData END");

        return new Print();
    }

}
