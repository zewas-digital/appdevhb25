using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe96
{
    class Rechteck : Figur, ISkalierbar
    {
        private double _laenge;
        private double _breite;
        private static int _anzahlRechteck ;

        public double Laenge
        {
            get
            {
                return _laenge;
            }
            set
            {
                if (value >= 0)
                {
                    _laenge = value;
                }
                else
                {
                    System.Console.WriteLine("Die Länge darf nicht negativ sein");
                }
            }
        }
        public double Breite
        {
            get
            {
                return _breite;
            }
            set
            {
                if (value >= 0)
                {
                    _breite = value;
                }
                else
                {
                    System.Console.WriteLine("Die Breite darf nicht negativ sein");
                }
            }
        }
        public static int AnzahlRechteck
        {
            get
            {
                return _anzahlRechteck;
            }
            set
            {
                if (value > _anzahlRechteck)
                {
                    _anzahlRechteck = value;
                }
                else
                {
                    System.Console.WriteLine("Anzahl der Rechtecke kann nicht verkleinert werden");
                }
            }
        }


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