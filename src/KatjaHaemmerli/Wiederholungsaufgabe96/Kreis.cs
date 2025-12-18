// using System;
// namespace Appdevhb25.KatjaHaemmerli.Widerholungsaufgabe96
// {
//     public  class Kreis : Figur, ISkalieren
//     {
//         public double Umfang { get; private set; }
//         public double Flaeche { get; private set; }
//         public double Radius { get; private set; }        
//         public static int AnzahlKreise { get; private set; }
//         public Kreis(double radius)
//         {
//             Radius = radius;
//             AnzahlKreise++;
//         }
//         public override double FlaecheBerechnen()
//         {
//             double summeflaeche = Radius * Radius * 3.14;
//             System.Console.WriteLine($"Fläche Kreis: {summeflaeche}");
//             return summeflaeche;
//         }

//         public override double UmfangBerechnen()
//         {
//             double summeUmfang = 2 * 3.14 * Radius;
//             System.Console.WriteLine($"Umfang Kreis: {summeUmfang}");
//             return summeUmfang;
//         }
//         public static void SchreibeAnzahl()
//         {              
//             System.Console.WriteLine($"Anzahl Kreise: {AnzahlKreise}");
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