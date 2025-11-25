using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe96
{
    class Rechteck : Figur, ISkalierbar
    {
        public double Laenge { get; private set; }
        public double Breite { get; private set; }
        public static int AnzahlRechteck { get; private set; }

        public Rechteck(double laenge, double breite, string name, string elementtyp) : base(name, elementtyp)
        {
            Laenge = laenge;
            Breite = breite;
            AnzahlRechteck++;
        }

        public override double Umfang()
        {
            return 2 * Laenge + 2 * Breite;
        }

        public override double Flaeche()
        {
            return Laenge * Breite;
        }

        public static void PrintAnzahl()
        {
            Console.WriteLine($"Es wurden bisher {AnzahlRechteck} Rechtecke erstellt.");
        }

        public void Skalieren(double faktor)
        {
            Laenge *= faktor;
            Breite *= faktor;
        }

        public override string ToString()
        {
            return $"Name des Elements: {Name}\nTyp:\t\t{Elementtyp}\nLänge:\t\t{Laenge:F2}\nBreite:\t\t{Breite:F2}\nUmfang:\t\t{Umfang():F2}\nFläche:\t\t{Flaeche():F2}";
        }
    }
}