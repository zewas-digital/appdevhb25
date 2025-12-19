using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe96
{
    public class VerwaltungGeometrischeFormen
    {
        public static void Start()
        {
          Dreieck dreieck = new Dreieck("DreieckEins",5.5, 5.5,7.5);          
          Kreis kreis = new Kreis("KreisEins",7.7);
          Rechteck rechteck = new Rechteck("Das Rechteck",10.5, 12.5);

          System.Console.WriteLine("Ausgabe Formennamen:");
          dreieck.AusgabeFormenNamen();
          rechteck.AusgabeFormenNamen();
          kreis.AusgabeFormenNamen();
          System.Console.WriteLine();

          System.Console.WriteLine();
          System.Console.WriteLine("Anzahl der Formen:");
          System.Console.WriteLine(new string('-', 18));
          dreieck.AusgabeAnzahlDreiecke();
          kreis.AusgabeAnzahlKreise();
          rechteck.AusgabeAnzahlRechtecke();
          System.Console.WriteLine();

          System.Console.WriteLine("Umfang der Formen:");
          System.Console.WriteLine(new string('-', 18));
          System.Console.WriteLine(dreieck.UmfangBerechnung());
          System.Console.WriteLine(kreis.UmfangBerechnung());          
          System.Console.WriteLine(rechteck.UmfangBerechnung());
          
          System.Console.WriteLine(); 

          System.Console.WriteLine("Flächen der Formen:");
          System.Console.WriteLine(new string('-', 19));          
          System.Console.WriteLine(dreieck.Flaechenberechnung());
          System.Console.WriteLine(kreis.Flaechenberechnung());
          System.Console.WriteLine(rechteck.Flaechenberechnung());                 
        }
    }
}