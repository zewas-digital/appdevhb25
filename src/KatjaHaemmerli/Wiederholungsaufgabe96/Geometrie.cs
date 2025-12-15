// using System;
// namespace Appdevhb25.KatjaHaemmerli.Widerholungsaufgabe96
// {
//     public  class GeometrieAufgabe
//     {
//         public static void Start()
//         {            
//             List<Figur> figurenListe = new List<Figur>();
//             Rechteck rechteck = new Rechteck(10,10);
//             Dreieck dreieck = new Dreieck(10);
//             Kreis kreis = new Kreis(40);
//             rechteck.UmfangBerechnen();
//             rechteck.FlaecheBerechnen();
//             dreieck.UmfangBerechnen();
//             dreieck.FlaecheBerechnen();
//             kreis.UmfangBerechnen();
//             kreis.FlaecheBerechnen();                        
//             Rechteck.SchreibeAnzahl();            
//             Dreieck.SchreibeAnzahl();
//             Kreis.SchreibeAnzahl();
           
//             rechteck.Skalieren(2);
//             System.Console.WriteLine($"Rechteck skaliert: {rechteck.Skalieren(0.5)}");     

//             System.Console.WriteLine(rechteck);   
//             System.Console.WriteLine(rechteck.ToString());  
//         }
//     }
// }