using System;

namespace Appdevhb25.JulianMatt.Aufgabe71
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
                if (value <= 0 || value > 10)
                    Console.WriteLine("Ungültige Türanzahl");
                else
                    _countOfDoors = value;
            }
        }

        public Auto(string color, string licensePlate, double kilometers, int countOfDoors)
            : base(color, licensePlate, kilometers)
        {
            CountOfDoors = countOfDoors;
            CountOfProducedCars++;
        }

        public override void PrintVehicleInfo()
        {
            base.PrintVehicleInfo();
            Console.WriteLine($"Anzahl Türen: {CountOfDoors}");
        }

        public override void Fahren()
        {
            Console.WriteLine($"Das Auto mit dem Kennzeichen {LicensePlate} fährt los");
        }

        public override string ToString()
        {
            return $"Das ist ein Auto";
        }
    }
}