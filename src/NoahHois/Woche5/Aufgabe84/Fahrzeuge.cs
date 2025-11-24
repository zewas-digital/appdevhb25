using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Appdevhb25.NoahHois.Aufgabe84
{
    public abstract class Fahrzeuge //: IGegenstand
    {

        public string Color;
        public string Mark;
        private double _mileage;
        public double Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (value >= _mileage)
                {
                    _mileage = value;
                }
                else
                {
                    System.Console.WriteLine("Man kann den Kilometerstand nicht zurücksetzen.");
                }
            }
        }

        public static int AnzahlDerProduziertenFahrzeuge;

        public Fahrzeuge(string color, string mark, double mileage)
        {
            Color = color;
            Mark = mark;
            Mileage = mileage;
            AnzahlDerProduziertenFahrzeuge++;
        }

        public virtual void PrintDataSheet()
        {
            System.Console.WriteLine("Farbe " + Color);
            System.Console.WriteLine("Kennzeichen " + Mark);
            System.Console.WriteLine("Kilometerstand " + Mileage);
        }

        public abstract void Drive(double distanz);
    }
}