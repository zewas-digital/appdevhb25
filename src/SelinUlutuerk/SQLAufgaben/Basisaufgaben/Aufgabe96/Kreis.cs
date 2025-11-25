using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe96
{
    class Kreis : Figur, ISkalierbar
    {
        private double _radius;
        private static int _anzahlKreis;

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    System.Console.WriteLine("Der Radius darf nicht negativ sein");
                }
            }
        }
        public static int AnzahlKreis
        {
             get
            {
                return _anzahlKreis;
            }
            set
            {
                if (value > _anzahlKreis)
                {
                    _anzahlKreis = value;
                }
                else
                {
                    System.Console.WriteLine("Anzahl der Kreise kann nicht verkleinert werden");
                }
            }
        }


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