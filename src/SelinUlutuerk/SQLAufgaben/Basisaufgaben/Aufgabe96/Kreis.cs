using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe96
{
    class Kreis : Figur, ISkalierbar
    {
        public double Radius { get; private set; }
        public static int AnzahlKreis { get; private set; }


        public Kreis(double radius, string name, string elementtyp) : base(name, elementtyp)
        {
            Radius = radius;
            AnzahlKreis++;
        }

        public override double Umfang()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Flaeche()
        {
            return Math.PI * Radius * Radius;
        }

        public static void PrintAnzahl()
        {
            Console.WriteLine($"Es wurden bisher {AnzahlKreis} Kreise erstellt.");
        }

        public void Skalieren(double faktor)
        {
            Radius *= faktor;
        }

        public override string ToString()
        {
            return $"Name des Elements: {Name}\nTyp:\t\t{Elementtyp}\nRadius:\t\t{Radius:F2}\nUmfang:\t\t{Umfang():F2}\t\nFläche:\t\t{Flaeche():F2}";
        }
    }
}