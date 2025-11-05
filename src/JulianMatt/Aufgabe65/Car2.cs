using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe65
{
    public class Car2
    {
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
        public double Usage;

        public Car2()
        {

        }

        public void PrintColour()
        {
            System.Console.WriteLine(Colour);
        }
        public void PrintKilometers()
        {
            System.Console.WriteLine(Kilometers);
        }
        public void PrintLicensePlate()
        {
            System.Console.WriteLine(LicensePlateLetter + " " + LicensePlateNumbers);
        }
        public void PrintUsage()
        {
            System.Console.WriteLine(Usage);
        }

        public void KilometersUpcounter(Car2[] Cars, int i)
        {
            Console.WriteLine("Alte Kilometer: " + Cars[i].Kilometers);

            Console.WriteLine("Wie viel mehr gefahren?");
            double extraKilometers = Convert.ToDouble(Console.ReadLine());

            Cars[i].Kilometers += extraKilometers;
            Console.WriteLine("Neue Gesamtkilometer: " + Cars[i].Kilometers);
        }



    }
}