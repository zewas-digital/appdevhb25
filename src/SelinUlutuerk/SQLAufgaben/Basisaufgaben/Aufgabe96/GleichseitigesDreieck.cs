using System;
using System.Dynamic;

namespace Appdevhb25.SelinUlutuerk.Aufgabe96
{
    class GleichseitigesDreieck : Figur
    {
        private double _seite;
        private static int _anzahlDreieck;

        public double Seite
        {
            get
            {
                return _seite;
            }
            set
            {
                if (value >= 0)
                {
                    _seite = value;
                }
                else
                {
                    System.Console.WriteLine("Die Seitenlänge darf nicht negativ sein");
                }
            }
        }
        public static int AnzahlDreieck
        {
             get
            {
                return _anzahlDreieck;
            }
            set
            {
                if (value > _anzahlDreieck)
                {
                    _anzahlDreieck = value;
                }
                else
                {
                    System.Console.WriteLine("Anzahl der Dreiecke kann nicht verkleinert werden");
                }
            }
        }


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
            return Math.Pow(Seite,2) * Math.Sqrt(3)/4;
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