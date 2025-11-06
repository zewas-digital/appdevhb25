using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe68
{
    public class FotoApparatA68
    {
        public static void Start68()
        {
            FotoApparat[] Kamara = new FotoApparat[2];

            Kamara[0] = new FotoApparat();
            
            Kamara[0].FocalLengthMin = 20;
            Kamara[0].FocalLengthMax = 300;
            Kamara[0].Manufacturer = "Sony";
            Kamara[0].MegaPixels = 1080;
            Kamara[0].Model = "Sony Cybershot DSC-RX 100 Mark VII";

            Kamara[0].TakeAPhoto();
            Kamara[0].DataSheet();

            Kamara[1] = new FotoApparat();

            Kamara[1].FocalLengthMin = 10;
            Kamara[1].FocalLengthMax = 50;
            Kamara[1].Manufacturer = "Canon";
            Kamara[1].MegaPixels = 720;
            Kamara[1].Model = "Canon Powershot G7X Mark III Silber";

            Kamara[1].TakeAPhoto();
            Kamara[1].DataSheet();

            


        }
    }
}