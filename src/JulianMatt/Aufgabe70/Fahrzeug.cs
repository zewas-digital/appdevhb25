using System.Drawing;
using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe70
{
    public class Fahrzeug
    {

        public static int CountOfProducedVehicles = 0;
        public string Colour;

        public string LicensePlate;
        
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

        public Fahrzeug(string colour, string licensePlate, double kilometers)
        {
            Colour = colour;
            LicensePlate = licensePlate;
            Kilometers = kilometers;

            CountOfProducedVehicles++;
        }
        
        public virtual void PrintDatePaper()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Farbe: " + Colour);
            System.Console.WriteLine($"Kennzeichen: {LicensePlate}");
            System.Console.WriteLine($"Kilometerstand: {Kilometers}");
        }
    }
}