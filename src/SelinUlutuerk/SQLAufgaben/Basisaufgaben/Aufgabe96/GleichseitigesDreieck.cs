using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe96
{
    class GleichseitigesDreieck : Figur
    {
        public double Seite {get; private set;}
        public static int AnzahlDreieck;


        public GleichseitigesDreieck(double seite, string name, string elementtyp) : base(name,elementtyp)
        {
            Seite = seite;
            AnzahlDreieck++;
        }

        public override double Umfang()
        {
            return 3*Seite;
        }

        public override double Flaeche()
        {
            return Seite*Seite * Math.Sqrt(3)/4;
        }

        public static void PrintAnzahl()
        {
            Console.WriteLine($"Es wurden bisher {AnzahlDreieck} Gleichseitige Dreiecke erstellt.");
        }

        public override string ToString()
        {
            return $"Name des Elements: {Name}\nTyp:\t\t{Elementtyp}\nSeitenlänge:\t{Seite:F2}\nUmfang:\t\t{Umfang():F2}\nFläche:\t\t{Flaeche():F2}";
        }
        
    }
}