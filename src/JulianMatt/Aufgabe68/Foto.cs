using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe68
{
    public class Foto
    {
        private double focalLengthMin;

        private double focalLengthMax;

        private double megaPixels;
            
        public string Manufacturer { get; set; }

        public string Model { get; set; }
            

        public double FocalLengthMin
        {
            get { return focalLengthMin; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Minimum Brennweite muss über 0 sein");
                }
                else if (focalLengthMax != 0 && value > focalLengthMax)
                {
                    Console.WriteLine("Minimum Brennweite darf nicht größer sein als Max Brenweite");
                }
                else
                {
                    focalLengthMin = value;
                }
            }
        }


        public double FocalLengthMax
        {
            get { return focalLengthMax; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Max Brennweite muss über 0 sein");
                }
                else if (focalLengthMin != 0 && value < focalLengthMin)
                {
                    Console.WriteLine("Max Darf nicht kleiner als Min Brennweite sein");
                }
                else
                {
                    focalLengthMax = value;
                }
            }
        }

        public double MegaPixels
        {
            get { return megaPixels; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Megapixel müsssen mehr als 0 sein");
                }
                else
                {
                    megaPixels = value;
                }
            }
        }

        public void TakeAPhoto()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Du hast ein Foto mit deiner " + Model + " geschossen");
        }
        
        public void DataSheet()
        {
            System.Console.WriteLine("----------- Datenblat -----------");
            System.Console.WriteLine($"Die Brennweite beträgt {FocalLengthMin} - {focalLengthMax} mm");
            System.Console.WriteLine($"Model: {Model}");
            System.Console.WriteLine($"Manufacturer: {Manufacturer}");
            System.Console.WriteLine($"Es sind {MegaPixels} Megapixel");
        }
    }
}