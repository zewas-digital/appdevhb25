using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe73
{

    public class Camera: Hardware
    {
        public int AmountPhotos;
        public Lens? lens;
        public MemoryCard? memoryCard;

        public Camera(Lens lens, MemoryCard mC, string model, string serialNumber) : base(model, serialNumber)
        {
            ChangeLense(lens);
            ChangeMemoryCard(mC);
        }

        public void TakePhoto()
        {
            System.Console.WriteLine($"Kamera: {Model} hat ein Foto gemacht - Foto: ⌐■_■");
            memoryCard!.Size -= 5;
            AmountPhotos++;
        }

        public void ChangeLense(Lens newLens)
        {
            lens = newLens;
        }

        public void ChangeMemoryCard(MemoryCard memoryCard)
        {
            this.memoryCard = memoryCard;
        }

        public int AmountPhotosLeft()
        {
            return memoryCard!.Size / 5;
        }
        

    }
}