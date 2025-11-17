using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe70
{

    public class Vehicles
    {
        private double _mileage;

        public static int amountProducedVehicles;
        public string? Color;
        
        public double Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (value > _mileage)
                {
                    _mileage = value;
                }
                else
                {
                    System.Console.WriteLine("Kilometerstand darf nicht verringert werden! Aktueller Kilometerstand: " + _mileage);
                }
            }
        }
        public string? LicensePlate;


        public Vehicles(string color, string licensePlate, double mileage)
        {
            Color = color;
            LicensePlate = licensePlate;
            Mileage = mileage;

            amountProducedVehicles++;
        }


        public virtual void PrintVehicle()
        {
            System.Console.WriteLine($"Farbe: {Color}\n Kilometerstand: {Mileage}\n Kennzeichen: {LicensePlate}");
        }
       
        
    }
}
