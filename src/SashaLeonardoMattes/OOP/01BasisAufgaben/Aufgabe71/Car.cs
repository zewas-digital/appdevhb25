using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe71
{

    public class Car : Vehicles
    {
        public static int amountProducedCars;
        public int AmountDoors;
        public Car(string color, string licensePlate, double mileage, int amountDoors) : base(color, licensePlate, mileage)
        {
            AmountDoors = amountDoors;

            amountProducedCars++;
        }

        public void Drive(double distance)
        {
            System.Console.WriteLine("Alter Kilometerstand: " + Mileage);
            Mileage += distance;
            System.Console.WriteLine("Gefahrene Distanz: " + distance);
            System.Console.WriteLine("Neuer Kilometerstand: " + Mileage);
        }

        public static void PrintAmountProducedCars()
        {
            System.Console.WriteLine("Anzahl der produzeirten Autos: " + amountProducedCars);
        }

        public override void PrintVehicle()
        {
            base.PrintVehicle();
            System.Console.WriteLine("Anzahl Türen: " + AmountDoors);
        }

        public override void Fahren(double distance)
        {
            Mileage += distance;
        }

        public override string ToString()
        {
            return "Das ist ein Auto";
        }
       
        
    }
}
