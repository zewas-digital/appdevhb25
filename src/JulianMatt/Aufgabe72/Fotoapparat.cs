using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe72
{
    public class FotoApparat 
    {
        private double _megaPixels;
            
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public double MegaPixels
        {
            get { return _megaPixels; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Megapixel müsssen mehr als 0 sein");
                }
                else
                {
                    _megaPixels = value;
                }
            }
        }

        public FotoApparat(double megapixel, string manufacturer, string model)
        {
            MegaPixels = megapixel;
            Manufacturer = manufacturer;
            Model = model;
        }

        
        public void DataSheet()
        {
            System.Console.WriteLine("----------- Datenblat -----------");
            System.Console.WriteLine($"Model: {Model}");
            System.Console.WriteLine($"Manufacturer: {Manufacturer}");
            System.Console.WriteLine($"Es sind {MegaPixels} Megapixel");
        }
    }
}