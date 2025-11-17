using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe71
{

    public class MotorCycle : Vehicles
    {
        public static int motorCyclesProduced = 0;
        public static double revenue;
        private int _horsePower;

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

        public double Price;

        public MotorCycle(int hp, string color, double price, string licensePlate, double mileage) :base(color, licensePlate, mileage)
        {
            HorsePower = hp;
            Price = price;

            motorCyclesProduced++;
            revenue += price;
        }

        public static double GetAverageRevenue()
        {
            return revenue / motorCyclesProduced;
        }

        public override void PrintVehicle()
        {
            base.PrintVehicle();
            System.Console.WriteLine($"Preis: {Price} Leistung: {HorsePower}");
        }

        public override void Fahren(double distance)
        {
            Mileage += distance;
        }

        public override string ToString()
        {
            return "Das ist ein Motorrad";
        }
    }
}
