
// // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
// using System.Diagnostics;

// internal class HttpCall { }
// internal class BigData { }
// internal class Print { }

// class Program
// {
//     public static async Task Main(string[] args)
//     {
//         Stopwatch s = new Stopwatch();
//         s.Start();

//         Console.WriteLine($"START {s.ElapsedMilliseconds}");

//         // 10s
//         Task<HttpCall> httpData = DoHttpCall();
//         // 5s
//         Task<BigData> bigData = RetrieveBigData();
        
//         await Task.WhenAll(httpData, bigData);

//         Print print = await PrintData();        

//         Console.WriteLine($"END {s.ElapsedMilliseconds}");
//     }


//     private async static Task<BigData> RetrieveBigData()
//     {
//         Console.WriteLine("RetrieveBigData START");
//         await Task.Delay(5000);
//         Console.WriteLine("RetrieveBigData END");

//         return new BigData();
//     }

//     private async static Task<HttpCall> DoHttpCall()
//     {
//         Console.WriteLine("DoHttpCall START");
//         await Task.Delay(100000);
//         Console.WriteLine("DoHttpCall END");

//         return new HttpCall();
//     }

//     private async static Task<Print> PrintData()
//     {
//         Console.WriteLine("PrintData START");
//         await Task.Delay(1000);
//         Console.WriteLine("PrintData END");

//         return new Print();
//     }

// }
