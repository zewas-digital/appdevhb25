using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe64
{
    public class Car
    {
        public string Colour;
        public double Kilometers;
        public string LicensePlateLetter;
        public int LicensePlateNumbers;
        public double Usage;

        public Car()
        {

        }

        public void PrintColour(string choosenRegion)
        {
            System.Console.WriteLine(choosenRegion);
        }
        public void PrintKilometers(double choosenRegion)
        {
            System.Console.WriteLine(choosenRegion);
        }
        public void PrintLicensePlate(string choosenRegion, int choosenRegion2)
        {
            System.Console.WriteLine(choosenRegion+" "+choosenRegion2);
        }
         public void PrintUsage(double choosenRegion)
        {
            System.Console.WriteLine(choosenRegion);
        }




    }
}