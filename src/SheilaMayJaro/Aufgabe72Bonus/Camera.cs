using System.Reflection.Metadata.Ecma335;

namespace Appdevhb25.SheilaMayJaro.Aufgabe72Bonus
{
    public class Camera
    {
        //Modell, Manufacturer, Megapixel
        public string? Model;
        public string? Manufacturer; //Hersteller
        public double Megapixel;
        public static int FotoTaken;
        public MemoryCard memoryCard = new MemoryCard();
        public CameraLens cameraLens = new CameraLens(); 
        public void TakeFoto()
        {
            Console.WriteLine("'KLICK' Wundervoll! Noch ein Foto bitte!");
            FotoTaken++;
            memoryCard.StorageSpaceUsed += 0.3 * Megapixel; 
        }
        public int HowManyFotosTaken()
        {
            return FotoTaken;
        }
        public void OutputCameraProperties()
        {
            System.Console.WriteLine($"Modell: {Model,27}");
            System.Console.WriteLine($"Hersteller: {Manufacturer,50}");
            System.Console.WriteLine($"Megapixel: {Megapixel,15} MP");
            System.Console.WriteLine($"Speicherplatz: {memoryCard}");
            System.Console.WriteLine($"Maximale Brennweite: {cameraLens.FocalLengthMax,4} mm");
            System.Console.WriteLine($"Minimale Brennweite: {cameraLens.FocalLengthMin,3} mm");
        }
    }   
}