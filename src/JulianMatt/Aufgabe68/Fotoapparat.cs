using System.Globalization;
using System.Xml.Serialization;

namespace Appdevhb25.JulianMatt.Aufgabe68
{
    public class FotoApparat
    {
        private double _focalLengthMin;

        private double _focalLengthMax;

        private double _megaPixels;
            
        public string Manufacturer { get; set; }

        public string Model { get; set; }
            

        public double FocalLengthMin
        {
            get { return _focalLengthMin; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Minimum Brennweite muss über 0 sein");
                }
                else if (_focalLengthMax != 0 && value > _focalLengthMax)
                {
                    Console.WriteLine("Minimum Brennweite darf nicht größer sein als Max Brenweite");
                }
                else
                {
                    _focalLengthMin = value;
                }
            }
        }


        public double FocalLengthMax
        {
            get { return _focalLengthMax; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Max Brennweite muss über 0 sein");
                }
                else if (_focalLengthMin != 0 && value < _focalLengthMin)
                {
                    Console.WriteLine("Max Darf nicht kleiner als Min Brennweite sein");
                }
                else
                {
                    _focalLengthMax = value;
                }
            }
        }

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

        public void TakeAPhoto()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Du hast ein Foto mit deiner " + Model + " geschossen");
        }
        
        public void DataSheet()
        {
            System.Console.WriteLine("----------- Datenblat -----------");
            System.Console.WriteLine($"Die Brennweite beträgt {FocalLengthMin} - {FocalLengthMax} mm");
            System.Console.WriteLine($"Model: {Model}");
            System.Console.WriteLine($"Manufacturer: {Manufacturer}");
            System.Console.WriteLine($"Es sind {MegaPixels} Megapixel");
        }
    }
}