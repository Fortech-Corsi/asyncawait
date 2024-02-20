
// These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.





using System.Diagnostics;
internal class PreparaCaffe;
internal class TostaPane;
internal class ImburraPane;
internal class SpremiLeArance;
internal class ConsumaLaColazione;

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

        Task<PreparaCaffe> preparaCaffe = PreparaCaffe();
        Task<TostaPane> tostaPane = TostaPane();
        Task<SpremiLeArance> spremiLeArance = SpremiLeArance();
        Task t = Task.WhenAll(preparaCaffe, tostaPane, spremiLeArance);


        ImburraPane imburraPane = await ImburraPane();
        ConsumaLaColazione consumaLaColazione = await ConsumaLaColazione();

        await Task.WhenAll(t);

        Console.WriteLine($"END {s.ElapsedMilliseconds}");
    }

    private static async Task<ConsumaLaColazione> ConsumaLaColazione()
    {
        await Task.Delay(6000);
        return new ConsumaLaColazione();
    }


    private static async Task<SpremiLeArance> SpremiLeArance()
    {
        await Task.Delay(5000);
        return new SpremiLeArance();
    }


    private static async Task<ImburraPane> ImburraPane()
    {
        await Task.Delay(4000);
        return new ImburraPane();
    }


    private static async Task<TostaPane> TostaPane()
    {
        await Task.Delay(4000);
        return new TostaPane();
    }


    private static async Task<PreparaCaffe> PreparaCaffe()
    {
        await Task.Delay(3000);
        return new PreparaCaffe();
    }

}
