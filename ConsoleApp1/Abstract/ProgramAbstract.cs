// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("START");

//         Gatto pucci = new Gatto();
//         CantaConLui(pucci);

//         Cane baldo = new Cane();
//         CantaConLui(baldo);

//         Console.WriteLine("END");
//     }

//     public static void CantaConLui(AEssereVivente essere)
//     {
//         essere.DoVerso();
//     }

//     // public static IAnimaleTerreste AcquistaUnAnimale()
//     // {
//     //     return new Gatto();
//     // }

//     // public static void CantaConLui(IEssereVivente c)
//     // {
//     //     c.DoVerso();
//     // }

//     // public static void GiocaConLui(IAnimaleTerreste c)
//     // {
//     //     c.DoVerso();
//     //     c.Run();
//     // }


// }

// // Essere vivente 
// public abstract class AEssereVivente
// {
//     public virtual void DoVerso()
//     {
//         Console.WriteLine("....");
//     }
// }

// // Gatto
// public class Gatto : AEssereVivente
// {
//     public override void DoVerso()
//     {
//         Console.WriteLine("Miao");
//     }

//     public void Run()
//     {
//         Console.WriteLine("Miao");
//     }
// }

// // Cane
// public class Cane : AEssereVivente
// {

// }




// // // Gatto
// // public class Gatto : IAnimaleTerreste
// // {
// //     public void DoVerso()
// //     {
// //         Console.WriteLine("Miao");
// //     }

// //     public void Run()
// //     {
// //         Console.WriteLine("Corro agile");
// //     }

// // }








// // public interface IAnimaleTerreste : IEssereVivente
// // {
// //     void Run();
// // }

// // public class Bird : IEssereVivente
// // {
// //     public void DoVerso()
// //     {
// //         throw new NotImplementedException();
// //     }

// // }

// // // Uomo
// // public class Uomo : IAnimaleTerreste
// // {
// //     public void DoVerso()
// //     {
// //         Console.WriteLine("Ciao");
// //     }

// //     public void Run()
// //     {
// //         Console.WriteLine("mi faccio una maratona");
// //     }

// // }

// // // Gatto
// // public class Gatto : IAnimaleTerreste
// // {
// //     public void DoVerso()
// //     {
// //         Console.WriteLine("Miao");
// //     }

// //     public void Run()
// //     {
// //         Console.WriteLine("Corro agile");
// //     }

// // }

// // // Cane
// // public class Cane : IAnimaleTerreste
// // {
// //     public void DoVerso()
// //     {
// //         Console.WriteLine("Bau");
// //     }

// //     public void Run()
// //     {
// //         Console.WriteLine("Corro sbavando");
// //     }
// // }
