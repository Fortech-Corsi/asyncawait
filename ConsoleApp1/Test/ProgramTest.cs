// public class Program
// {
//     static void Main(string[] args)
//     {
//         Addizione a1 = new Addizione(5, 5);
//         System.Console.Write($"Addizione: {a1.X} + {a1.Y} = ");
//         calculate(a1);

//         Sottrazione s1 = new Sottrazione(5, 5);
//         System.Console.Write($"Sottrazione: {s1.X} - {s1.Y} = ");
//         calculate(s1);
        

//         Console.ReadLine();
//     }
//     public static void calculate(AOperazione operzione)
//     {
//         var risultato = operzione.DOoperation();
//         Console.WriteLine(risultato);
//     }

// }

// // DEFINIRE CLASSE ASTRATTA AOPERAZIONE
// // DEVE AVERE 2 PROPERTY DI TIPO INT 
// // METODO PUBLIC abstract INT DOOPERATION() Oppure PUBLIC ABSTRACT INT DOOPERATION()

// public abstract class AOperazione
// {
//     public int X {get; set;}
//     public int Y {get; set;}
//     public AOperazione(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
//     public abstract int DOoperation();
// }


// // CREARE CLASSE ADDIZIONE che ESTENDA AOPERAZIONE
// // DEVE AVERE UN COSTRUTTORE CHE PRENDA DUE VALORI INT
// // EFFETTUARE OVERRIDE DEL DOOPERATION

// public class Addizione : AOperazione{
//     public Addizione(int x, int y) : base(x, y)
//     {

//     }

//     public override int DOoperation()
//     {
//         return X + Y;
//     }
// }

// // CREARE CLASSE SOTTRAZIONE che ESTENDA AOPERAZIONE
// // DEVE AVERE UN COSTRUTTORE CHE PRENDA DUE VALORI INT
// // EFFETTUARE OVERRIDE DEL DOOPERATION 

// public class Sottrazione : AOperazione{
//     public Sottrazione(int x, int y) : base(x, y)
//     {

//     }

//     public override int DOoperation()
//     {
//         return X - Y;
//     }
// }

// // CREARE METODO STATICO GLOBALE CALCULATE(AOPERAZIONE operazione)



// // ISTANZIARE DIVERSE OPERAZIONI CHIAMARE PER CIASCUNA IL CALCULATE
