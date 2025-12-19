using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe96
{
    public class Rechteck : Figur
    {
        double Hoehe;
        double Breite;
        public int anzahlRechtecke = 0;
        public Rechteck(string name, double hoehe, double breite): base(name) 
        {
            Elementtyp = "Rechteck";
            Hoehe = hoehe;
            Breite = breite;
            anzahlRechtecke++;
        }

        public override double Flaechenberechnung()
        {
            System.Console.WriteLine("Rechteck:");
            double flaeche = Hoehe * Breite;
            return flaeche;
        }

        public override double UmfangBerechnung()
        {
            System.Console.WriteLine("Rechteck:");
            double umfang = 2 * Hoehe + 2 * Breite;
            return umfang;
        }
        public void AusgabeAnzahlRechtecke()
        {
            System.Console.WriteLine($"Rechtecke: {anzahlRechtecke}");
        }
    }
}