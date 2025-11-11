using System;
using System.Runtime.InteropServices;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe73
{
    public class CameraHardwareCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Lens l1 = new Lens("lens1", "l123");
            l1.FocalLength = 20;

            MemoryCard m1 = new MemoryCard(100, "mCard1", "m456");


            Camera c1 = new Camera(l1, m1, "kamera1", "k1");

            c1.TakePhoto();
            c1.TakePhoto();
            System.Console.WriteLine($"Kamera 1\n Brennweite: {c1.lens?.FocalLength}\n Speicherkarte: {c1.memoryCard!.Size}\n gemachte Photos: {c1.AmountPhotos} übrige Fotos bis Speicher voll: {c1.AmountPhotosLeft()}\n------------------------------------");

            Lens l2 = new Lens("lens2", "l4w59");
            MemoryCard m2 = new MemoryCard(200, "mCard2", "m453526");
            
            c1.ChangeLense(l2);
            c1.ChangeMemoryCard(m2);

            c1.TakePhoto();
            c1.TakePhoto();
            System.Console.WriteLine($"Kamera 1\n Brennweite: {c1.lens?.FocalLength}\n Speicherkarte: {c1.memoryCard!.Size}\n gemachte Photos: {c1.AmountPhotos} übrige Fotos bis Speicher voll: {c1.AmountPhotosLeft()}");
            
        }
    }
}
