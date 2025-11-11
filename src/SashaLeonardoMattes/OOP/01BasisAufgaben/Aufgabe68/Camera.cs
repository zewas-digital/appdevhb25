using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe68
{

    public class Camera
    {
        //x.foLe = 9;
        private int _focalLength;
        private int _megaPixel;
        public int FocalLength
        {
            get
            {
                return _focalLength;
            }
            set
            {
                if (value > 8 && value < 2000)
                {
                    _focalLength = value;
                }
                else
                {
                    System.Console.WriteLine(value + " ist keine gültige Brennweite");
                }
            }
        }

        public string? Model { get; set; }

        public string? Manufacturer { get; set; }
        public int MegaPixel
        {
            get
            {
                return _megaPixel;
            }
            set
            {
                if (value > 9 && value < 50)
                {
                    _megaPixel = value;
                }
                else
                {
                    System.Console.WriteLine(value + " ist keine gültige Anzahl an Megapixeln");
                }
            }
        }


        public void TakePhoto()
        {
            System.Console.WriteLine($"Kamera: {Model}\n Von Hersteller: {Manufacturer}\n Mit Megapixeln: {MegaPixel}\n Brennweite: {FocalLength}\n hat ein Foto gemacht - Foto: ⌐■_■");
        }
        
    }


}
