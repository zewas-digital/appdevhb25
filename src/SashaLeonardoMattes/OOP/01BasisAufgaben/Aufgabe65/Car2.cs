using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe65
{

    public class Car2
    {
        public string? Color;
        public double Mileage;
        public string? LicensePlate;
        public double Consumption;

        public void PrintCar()
        {
            System.Console.WriteLine($"Farbe: {Color} Kilometerstand: {Mileage} Kennzeichen: {LicensePlate} Verbrauch: {Consumption}");
        }

        public void Drive(double distance)
        {
            System.Console.WriteLine("Alter Kilometerstand: " + Mileage);
            Mileage += distance;
            System.Console.WriteLine("Gefahrene Distanz: " + distance);
            System.Console.WriteLine("Neuer Kilometerstand: " + Mileage);
        }

       
        
    }
}
