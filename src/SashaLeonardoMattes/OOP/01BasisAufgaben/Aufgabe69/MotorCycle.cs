using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe69
{

    public class MotorCycle
    {
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

        public MotorCycle(int hp, string color, double price, string licensePlate)
        {
            HorsePower = hp;
            Color = color;
            Price = price;
            LicensePlate = licensePlate;

            amountProduced++;
            revenue += price;
        }
        
        public MotorCycle(double mileage, int hp, string color, double price, string licensePlate)
        {
            Mileage = mileage;
            HorsePower = hp;
            Color = color;
            Price = price;
            LicensePlate = licensePlate;

            amountProduced++;
            revenue += price;
        }

        public static double GetAverageRevenue()
        {
            return revenue / amountProduced;
        }
    }
}
