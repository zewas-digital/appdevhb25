using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe64
{

    public class Car
    {
        public string? Color;
        public double Mileage;
        public string? LicensePlate;
        public double Consumption;

        public void PrintCar()
        {
            System.Console.WriteLine($"Farbe: {Color} Kilometerstand: {Mileage} Kennzeichen: {LicensePlate} Verbrauch: {Consumption}");
        }

       
        
    }
}
