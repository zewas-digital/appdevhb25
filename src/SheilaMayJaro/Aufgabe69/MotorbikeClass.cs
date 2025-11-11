using System.Globalization;
using System.Text;
using System.Windows.Markup;
using Appdevhb25.SheilaMayJaro.Aufgabe68;

namespace Appdevhb25.SheilaMayJaro.Aufgabe69
{
    public class Motorbike
    {
        public static int NumberOfMotorbikesProduced = 0;
        public static int sales = 0; 
        private int _kilometrage;
        public int Kilometrage
        {
            get
            {
                return _kilometrage;
            }
            set
            {
                if (value > _kilometrage)
                {
                    _kilometrage = value;
                }
                else
                {
                    Console.WriteLine("Der Kilometerstand darf nicht kleiner sein.");
                }
            }
        }
        private string? _colour;
        public string? Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                //verschiedene Farbmöglichkeiten 
                _colour = value; 
            }
        }
        private double _performance = 80;
        public double Performance
        {
            get
            {
                return _performance;
            }
            set
            {
                if (value < _performance)
                {
                    _performance = value;
                }
                else
                {
                    System.Console.WriteLine("Die Leistung kann nicht erhöht werden.");
                }
            }
        }
        private int _purchasePrice;

        public int PurchasePrice
        {
            get
            {
                return _purchasePrice;
            }
            set
            {
                if (value >= 2000)
                {
                    _purchasePrice = value;
                }
                else
                {
                    System.Console.WriteLine("Der Kaufpreis kann nicht niedriger werden.");
                }
            }
        }
        private string? _licensePlate;
        public string? LicensePlate
        {
            get
            {
                return _licensePlate;
            }
            set
            {
                if (LicensePlate.Length == value.Length && LicensePlate != string.Empty)
                {
                    _licensePlate = value;
                }
                else
                {
                    System.Console.WriteLine("Das Kennzeichen ist ungültig");
                }
            }
        }
        //neues Motorrad 
        public Motorbike(string colour, double performance, int price) //Überladung zum Objekt 'Motorbike'
        {
            Colour = colour;
            Performance = performance;
            PurchasePrice = price;
            NumberOfMotorbikesProduced++;
            sales += PurchasePrice; 
        }
        //gebrauchtes Motorrad
        public Motorbike(string colour, double performance, int price, int kilometrage) //Überladung zum Objekt 'Motorbike'
        {
            Colour = colour;
            Performance = performance;
            PurchasePrice = price;
            Kilometrage = kilometrage;
            NumberOfMotorbikesProduced++;
            sales += PurchasePrice; 
        }
        public void PrintDataSheet()
        {
            System.Console.WriteLine($"Farbe: {Colour,22}");
            System.Console.WriteLine($"Kilometerstand: {Kilometrage.ToString("N0"),10} km");
            System.Console.WriteLine($"Leistung: {Performance,19}");
            System.Console.WriteLine($"Kaufpreis: {PurchasePrice.ToString("N"),18}");
            System.Console.WriteLine($"Kennzeichen: {LicensePlate,13}");
        }
    
        public static double CalculateAverageSalesPerMotorbike()
        {
            return sales / NumberOfMotorbikesProduced;
        }
    }
}