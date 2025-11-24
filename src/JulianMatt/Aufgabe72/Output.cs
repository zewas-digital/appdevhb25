using System;

namespace Appdevhb25.JulianMatt.Aufgabe72
{
    public class Output
    {
        public static void Start72()
        {
            FotoApparat[] fotoapparat = new FotoApparat[1];
            fotoapparat[0] = new FotoApparat(1440, "Sony", "Sony X1 B1 Mega Timer");

            fotoapparat[0].DataSheet();

            Speicherkarte[] speicherkarte = new Speicherkarte[1];
            speicherkarte[0] = new Speicherkarte(4);

            TakePhoto(speicherkarte);
        }
        
        public static void TakePhoto( Speicherkarte[] speicherkarte)
        {
            System.Console.WriteLine("Wollen sie ein Foto nehmen Ja/Nein");
            string yesNo = Console.ReadLine();
            if (yesNo == "Ja")
            {
                speicherkarte[0].TakeAPhoto();
            }
            
        }    
    }   
}
