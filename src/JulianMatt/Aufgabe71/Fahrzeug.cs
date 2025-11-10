using System;

namespace Appdevhb25.JulianMatt.Aufgabe71
{
    public abstract class Fahrzeug
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
                if (value < 0)
                    Console.WriteLine("Ungültiger Kilometerstand");
                else
                    _kilometers = value;
            }
        }

        public Fahrzeug(string colour, string licensePlate, double kilometers)
        {
            Colour = colour;
            LicensePlate = licensePlate;
            Kilometers = kilometers;
            CountOfProducedVehicles++;
        }

        public virtual void PrintVehicleInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Farbe: {Colour}");
            Console.WriteLine($"Kennzeichen: {LicensePlate}");
            Console.WriteLine($"Kilometerstand: {Kilometers}");
        }

        public abstract void Fahren();
    }
}
