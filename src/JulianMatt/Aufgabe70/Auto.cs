using System.Drawing;
using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe70
{
    public class Auto : Fahrzeug
    {
        public static int CountOfProducedCars = 0;

        private int _countOfDoors;

        public int CountOfDoors
        {
            get { return _countOfDoors; }
            set
            {
                if (value <= 0 || value >= 30)
                {
                    System.Console.WriteLine("Ungültige Eingabe");
                }
                else
                {
                    _countOfDoors = value;
                }
            }
        }

        public Auto(string color, string licensePlate, double kilometers, int countOfDoors) : base(color, licensePlate, kilometers)
        {
            CountOfDoors = countOfDoors;
            CountOfProducedCars++;
        }

        public override void PrintDatePaper()
        {
            base.PrintDatePaper();
            System.Console.WriteLine($"Anzahl der Tühren: {CountOfDoors}");
        }

    }
}