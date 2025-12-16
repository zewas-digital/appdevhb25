// using System;
// namespace Appdevhb25.KatjaHaemmerli.Widerholungsaufgabe96
// {
//     public class Dreieck : Figur, ISkalieren
//     {
//         public double Umfang { get; private set; }
//         public double Flaeche { get; private set; }    
//         public double Seitenlaenge {get; private set;}
//         public static int AnzahlDreiecke { get; private set; }
//         public Dreieck(double seitenlaenge)
//         {
//             Seitenlaenge = seitenlaenge;
//             AnzahlDreiecke++;
//         }
//         public override double FlaecheBerechnen()
//         {
//             double summeflaeche = Seitenlaenge * Seitenlaenge / 2;
//             System.Console.WriteLine($"Fläche Dreieck: {summeflaeche}");
//             return summeflaeche;
//         }

//         public override double UmfangBerechnen()
//         {
//             double summeUmfang = Seitenlaenge * 3;
//             System.Console.WriteLine($"Umfang Dreieck: {summeUmfang}");
//             return summeUmfang;
//         }
//         public static void SchreibeAnzahl()
//         {               
//             System.Console.WriteLine($"Anzahl Dreiecke: {AnzahlDreiecke}");       
            
//         }
//         public double Skalieren(double faktor)
//         {
//             if (faktor > 0)
//             {
//                 Laenge = Laenge * faktor;
//             }
//             else
//             {
//                 System.Console.WriteLine("Skalierung nicht möglich. Bitte eine positive Zahl eingeben.");
//             }

//             return Laenge;
//         }

//         public override string ToString()
//         {
//             return $"Rechteck: Tolles Rechteck\nTyp: Rechteck\nLänge: {Laenge}\nBreite: {Breite}\nUmfang: {Umfang}\nFläche: {Flaeche}";            
//         }
    
//     }
// }