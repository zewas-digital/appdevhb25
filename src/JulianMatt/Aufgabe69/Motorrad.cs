using System.Drawing;
using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe69
{
    public class Motorrad
    {
        public static int CountOfProducedCars = 0;
        public string Colour;
        private double _kilometers;
        public double Kilometers
        {
            get { return _kilometers; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Das geht nicht");
                }
                else
                {
                    _kilometers = value;
                }
            }

        }
        public string LicensePlateLetter;
        public int LicensePlateNumbers;

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

        public void KilometersUpcounter()
        {
            Console.WriteLine("Alte Kilometer: " + Kilometers);

            Console.WriteLine("Wie viel mehr gefahren?");
            double extraKilometers = Convert.ToDouble(Console.ReadLine());

            Kilometers += extraKilometers;
            Console.WriteLine("Neue Gesamtkilometer: " + Kilometers);
        }

        public Motorrad(string color, double kilometers, string licensePlateLetter, int licensePlateNumbers, int performance)
        {
            Colour = color;
            Kilometers = kilometers;
            LicensePlateLetter = licensePlateLetter;
            LicensePlateNumbers = licensePlateNumbers;
            Performance = performance;
            CountOfProducedCars++;
        }

        public Motorrad(double kilometers, string licensePlateLetter, int licensePlateNumbers, int performance)
        {
            Colour = "Red";
            Kilometers = kilometers;
            LicensePlateLetter = licensePlateLetter;
            LicensePlateNumbers = licensePlateNumbers;
            Performance = performance;
            CountOfProducedCars++;
        }

        public static void RevenueCounter()
        {
            int PricerPerBike = 10000;
            System.Console.WriteLine("Wir haben "+ PricerPerBike * CountOfProducedCars+" Euro Gemacht");
        }

    }
}