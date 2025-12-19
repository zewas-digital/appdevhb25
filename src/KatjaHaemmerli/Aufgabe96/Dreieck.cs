using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe96
{
    public class Dreieck : Figur
    {
        public double Hoehe;
        public double Breite;
        public double SeitenlaengeC;
        public int anzahlDreiecke = 0;
        public Dreieck(string name, double hoehe, double breite, double seitenlaengeC): base(name)
        {
            Elementtyp = "Dreieck";
            Hoehe = hoehe;
            Breite = breite;
            SeitenlaengeC = seitenlaengeC;
            anzahlDreiecke++;
            Name = name;            
        }

        public override double Flaechenberechnung()
        {
            System.Console.WriteLine("Dreieck:");
            double flaeche = SeitenlaengeC * Hoehe / 2;
            return flaeche;
        }

        public override double UmfangBerechnung()
        {
            System.Console.WriteLine("Dreieck:");
            double umfang = Hoehe + Hoehe + SeitenlaengeC;
            return umfang;
        }
        public void AusgabeAnzahlDreiecke()
        {
            System.Console.WriteLine($"Dreiecke: {anzahlDreiecke}");
        }
    }
}