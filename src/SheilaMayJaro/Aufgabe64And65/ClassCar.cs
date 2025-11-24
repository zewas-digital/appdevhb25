using System;
using System.Globalization;
namespace Appdevhb25.SheilaMayJaro.Aufgabe64and65
{
    public class Car
    {
        public string Colour;
        public int Kilometrage;
        public string LicensePlate;
        public double FuelConsumption; //z.B. 6,8l pro 100 km Dieselmotor / 7,7l pro 100 km Benzinmotor
        public void PrintCar()
        {
            System.Console.WriteLine($"Farbe: {Colour}");
            System.Console.WriteLine($"Kilometerstand: {Kilometrage:N0} km");
            System.Console.WriteLine($"Kennzeichen: {LicensePlate}");
            System.Console.WriteLine($"Verbrauch: {FuelConsumption} l");
        }
        public void Driving(int distance)
        {
            System.Console.WriteLine($"Aktueller Kilometerstand: {Kilometrage:N0}");
            System.Console.WriteLine($"Distanz: {distance} km");
            Kilometrage += distance;
            Kilometrage = Kilometrage + distance;
            Console.WriteLine($"Neuer Kilometerstand: {Kilometrage:N0} km"); 
        }   
    }
} 