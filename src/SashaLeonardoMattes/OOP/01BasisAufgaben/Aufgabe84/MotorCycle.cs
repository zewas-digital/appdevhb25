using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe84
{

    public class MotorCycle : IObject
    {

         public string InventoryNumber { get; set; }

        public MotorCycle(string inventoryNumber)
        {
            InventoryNumber = inventoryNumber;
        }

        public string GetObjectInfo()
        {
            return $"Das ist ein Motorrad:\nInventarnummer: {InventoryNumber}\nKilometerstand: {Mileage}";
        }

        public static int amountProduced = 0;
        public static double revenue;

        private double _mileage;
        private int _horsePower;

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

        public int HorsePower
        {
            get
            {
                return _horsePower;
            }
            set
            {
                if (value > 0)
                {
                    _horsePower = value;
                }
                else
                {
                    System.Console.WriteLine("Die Leistung muss größer als 0 sein!");
                }
            }
        }
        public string? Color;

        public double Price;
        public string? LicensePlate;

        public static double GetAverageRevenue()
        {
            return revenue / amountProduced;
        }
    }
}
