using System.Reflection.Metadata;
using Appdevhb25.SheilaMayJaro.Aufgabe64and65;

namespace Appdevhb25.SheilaMayJaro.Aufgabe73
{
public class Camera : Hardware
    {
        //AnzahlFotos, Objektiv und Speicherkarte
        public int NumberOfPictures;
        public MemoryCard MemoryCard;
        public CameraLens CameraLens; 
        public Camera(string SerialNumber, string Model) : base(SerialNumber, Model)
        {

        }
        
        public void TakePicture()
        {
            Console.WriteLine("'KLICK!' Uff etwas verwackelt. Lass gleich noch ein Bild machen.");
            NumberOfPictures++;
            MemoryCard.StorageSpace -= 5;
        }
        public void ChangeCameraLens(CameraLens cameraLens)
        {
            CameraLens = cameraLens; 
            System.Console.WriteLine($"Objektiv: \n{cameraLens}");
        }
        public void ChangeMemoryCard(MemoryCard memoryCard)
        {
            MemoryCard = memoryCard; 
           System.Console.WriteLine($"Speicherkarte: {memoryCard}");
        }
        public int NumberOfAvailablePictures()
        {
            return MemoryCard.StorageSpace/5 - NumberOfPictures;
        }
        public override string ToString()
        {
            return
            $"Modell: {Model,10}\nSeriennummer: {SerialNumber,5}";
        }
    }
}