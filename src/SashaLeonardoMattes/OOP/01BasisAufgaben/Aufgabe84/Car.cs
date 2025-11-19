using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe84
{

    public class Car : IObject
    {
        public string? Color;
        public double Mileage;
        public string? LicensePlate;
        public double Consumption;

        public Car(string inventoryNumber)
        {
            InventoryNumber = inventoryNumber;
        }

       public string InventoryNumber { get; set; }

        public string GetObjectInfo()
        {
            return $"Das ist ein Auto:\nInventarnummer: {InventoryNumber}\nKilometerstand: {Mileage}";
        }

        public void PrintCar()
        {
            System.Console.WriteLine($"Farbe: {Color} Kilometerstand: {Mileage} Kennzeichen: {LicensePlate} Verbrauch: {Consumption}");
        }

       
        
    }
}
