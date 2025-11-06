using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe68
{
    public class Intro
    {
        public static void Start()
        {
            Fotoapparat[] kameras = new Fotoapparat[2];

            kameras[0] = new Fotoapparat("Sony", "Alpha 7 IV", 24.2, 28.0, 3.5);
            kameras[1] = new Fotoapparat("Nikon", "Z50", 20.9, 16.0, 3.2);

            kameras[0].TakePhoto();
        }
    }
}