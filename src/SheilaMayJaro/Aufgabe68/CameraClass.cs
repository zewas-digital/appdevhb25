using System.Xml;

namespace Appdevhb25.SheilaMayJaro.Aufgabe68
{
    public class Camera
    {
        private int _focalLengthmin = 14; //Brennweite Minimum in mm
        public int FocalLengthMin
        {
            get
            {
                return _focalLengthmin;
            }
            set
            {
                if (value > _focalLengthmin)
                {
                    _focalLengthmin = value;
                }
                else
                {
                    System.Console.WriteLine("Brennweite kann nicht kleiner eingestellt werden.");
                }
            }
        }
        private int _focalLengthmax = 200; //Brennweite Maximum in mm
        public int FocalLengthMax
        {
            get
            {
                return _focalLengthmax;
            }
            set
            {
                if (value < _focalLengthmax)
                {
                    _focalLengthmax = value;
                }
                else
                {
                    System.Console.WriteLine("Brennweite kann nicht größer eingestellt werden.");
                }
            }
        }
        public string? Model; 
        public string? Manufacturer; //Hersteller
        public double Megapixel;
        public static void TakeFoto()
        {
            Console.WriteLine("'KLICK' Wundervoll! Noch ein Foto bitte!");
        }
        public void OutputCameraProperties()
        {
            System.Console.WriteLine($"Maximale Brennweite: { FocalLengthMax, 4} mm");
            System.Console.WriteLine($"Minimale Brennweite: {FocalLengthMin,3} mm");
            System.Console.WriteLine($"Modell: {Model,27}");
            System.Console.WriteLine($"Hersteller: {Manufacturer,50}");
            System.Console.WriteLine($"Megapixel: {Megapixel,15} MP");
        }
    }
}