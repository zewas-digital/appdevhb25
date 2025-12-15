using System;
namespace Appdevhb25.KatjaHaemmerli.Widerholungsaufgabe96
{
    public class Rechteck : Figur, ISkalieren
    {
        public double Umfang { get; private set; }
        public double Flaeche { get; private set; }
        public double Breite { get; private set; }
        public double Laenge { get; private set; }
        public static int AnzahlRechtecke { get; private set; } // Klasse speichert den Wert von AnzahlRechtecke, weil static 
        public Rechteck(double breite, double laenge)
        {
            Breite = breite;
            Laenge = laenge;
            AnzahlRechtecke++;
        }
        public override double FlaecheBerechnen()
        {
            Flaeche = Breite * Laenge;
            System.Console.WriteLine($"Fläche Rechteck: {Flaeche}");
            return Flaeche;
        }

        public override double UmfangBerechnen()
        {
            Umfang = 2 * Breite + 2 * Laenge;
            // System.Console.WriteLine($"Umfang Rechteck: {summeUmfang}");
            return Umfang;
        }
        public static void SchreibeAnzahl()
        {
            Console.WriteLine($"Anzahl Rechtecke: {AnzahlRechtecke}");
        }
        public double Skalieren(double faktor)
        {
            if (faktor > 0)
            {
                Laenge = Laenge * faktor;
            }
            else
            {
                System.Console.WriteLine("Skalierung nicht möglich. Bitte eine positive Zahl eingeben.");
            }

            return Laenge;
        }

        public override string ToString()
        {
            return $"Rechteck: Tolles Rechteck\nTyp: Rechteck\nLänge: {Laenge}\nBreite: {Breite}\nUmfang: {Umfang}\nFläche: {Flaeche}";            
        }
    }
}