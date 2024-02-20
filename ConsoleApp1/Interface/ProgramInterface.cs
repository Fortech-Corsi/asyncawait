// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("START");

//         Cane baldo = new Cane();
//         GiocaConLui(baldo);

//         Gatto pucci = new Gatto();
//         GiocaConLui(pucci);

//         Uomo mario = new Uomo();
//         GiocaConLui(mario);  
//         CantaConLui(mario);

//         Bird polly = new Bird();
//         CantaConLui(polly);  

//         IAnimaleTerreste g = AcquistaUnAnimale();
//         g.DoVerso();
//         g.Run();      

//         Console.WriteLine("END");
//     }

//     public static IAnimaleTerreste AcquistaUnAnimale()
//     {
//         return new Gatto();
//     }

//     public static void CantaConLui(IEssereVivente c)
//     {
//         c.DoVerso();
//     }

//     public static void GiocaConLui(IAnimaleTerreste c)
//     {
//         c.DoVerso();
//         c.Run();
//     }

   
// }

// // Essere vivente 
// public interface IEssereVivente
// {
//     void DoVerso();
// }

// public interface IAnimaleTerreste : IEssereVivente
// {
//     void Run();
// }

// public class Bird : IEssereVivente
// {
//     public void DoVerso()
//     {
//         throw new NotImplementedException();
//     }

// }

// // Uomo
// public class Uomo : IAnimaleTerreste
// {
//     public void DoVerso()
//     {
//         Console.WriteLine("Ciao");
//     }

//     public void Run()
//     {
//         Console.WriteLine("mi faccio una maratona");
//     }

// }

// // Gatto
// public class Gatto : IAnimaleTerreste
// {
//     public void DoVerso()
//     {
//         Console.WriteLine("Miao");
//     }

//     public void Run()
//     {
//         Console.WriteLine("Corro agile");
//     }

// }

// // Cane
// public class Cane : IAnimaleTerreste
// {
//     public void DoVerso()
//     {
//         Console.WriteLine("Bau");
//     }

//     public void Run()
//     {
//         Console.WriteLine("Corro sbavando");
//     }
// }
