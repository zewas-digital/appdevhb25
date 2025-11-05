using System.Drawing;
using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe70
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
                if (-value >= _performance)
                {
                    System.Console.WriteLine("Ungültige Eingabe");
                }
                else
                {
                    _performance = value;
                }
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

        public override void PrintDatePaper()
        {
            base.PrintDatePaper();
            System.Console.WriteLine($"Leistung: {Performance}");
            System.Console.WriteLine($"Preis: {Price}");
        }
        public static double CalculateTheMoneyMadePerVehicle()
        {
            Revenue = Price * CountOfProducedBikes;
            return Revenue;
        }

    }
}