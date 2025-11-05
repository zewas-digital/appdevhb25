namespace Appdevhb25.LiaLouiseNatter.Aufgabe68
{
    public class Start
    {
        public static void FotoapparatStart()
        {
            Fotoapparat f1 = new Fotoapparat();
            f1.Modell = "Canon";
            f1.Brennweite = 18;
            f1.Megapixel = 8;

            Fotoapparat f2 = new Fotoapparat();
            f2.Modell = "Nikon";
            f2.Brennweite = 35;
            f2.Megapixel = 12;

            Fotoapparat f3 = new Fotoapparat();
            f3.Modell = "Sony";
            f3.Brennweite = 85;
            f3.Megapixel = 24;

            Fotoapparat f4 = new Fotoapparat();
            f4.Modell = "Fujifilm";
            f4.Brennweite = 200;
            f4.Megapixel = 50;

            f1.takePhoto();
            f2.takePhoto();
            f3.takePhoto();
            f4.takePhoto();

        }
    }
}