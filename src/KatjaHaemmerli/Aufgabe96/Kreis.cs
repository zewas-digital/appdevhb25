using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe96
{
    public class Kreis : Figur
    {
        double Radius;
        internal static int anzahlKreise = 0;

        public Kreis(string name, double radius): base(name) 
        {
            Elementtyp = "Kreis";
            Radius = radius;
            anzahlKreise++;
        }

        public override double Flaechenberechnung()
        {
            System.Console.WriteLine("Kreis:");
            double flaeche = Radius * Radius * 3.14;
            return flaeche;            
        }

        public override double UmfangBerechnung()
        {
            System.Console.WriteLine("Kreis:");
            double umfang = 2 * 3.14 * Radius;
            return umfang;
        }
        public void AusgabeAnzahlKreise()
        {
            System.Console.WriteLine($"Kreise: {anzahlKreise}");
        }
    }
}