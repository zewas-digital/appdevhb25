using System;

namespace Appdevhb25.JulianMatt.Aufgabe71
{
    public class Motorrad : Fahrzeug
    {
        public static int CountOfProducedBikes = 0;

        private int _performance;
        public int Performance
        {
            get { return _performance; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Ungültige Leistung");
                else
                    _performance = value;
            }
        }

        public static double Price;
        public static double Revenue;

        public Motorrad(string color, string licensePlate, double kilometers, int performance, double price) : base(color, licensePlate, kilometers)
        {
            Performance = performance;
            Price = price;
            CountOfProducedBikes++;
        }

        public override void PrintVehicleInfo()
        {
            base.PrintVehicleInfo();
            Console.WriteLine($"Leistung: {Performance} PS");
            Console.WriteLine($"Preis: {Price} €");
        }

        public static double CalculateTheMoneyMadePerVehicle()
        {
            Revenue = Price * CountOfProducedBikes;
            return Revenue;
        }

        public override void Fahren()
        {
            Console.WriteLine($"Das Motorrad mit dem Kennzeichen {LicensePlate} fährt los");
        }

        public override string ToString()
        {
            return $"Motorrad: Farbe= {Colour}, Kennzeichen= {LicensePlate}, km= {Kilometers}, Leistung= {Performance} PS";
        }
    }
}
