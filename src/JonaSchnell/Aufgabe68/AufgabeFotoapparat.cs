namespace Appdevhb25.JonaSchnell.Aufgabe68
{
    public class AufgabeFotoapparat
    {
        public static void StartFotoapparat()
        {
            Kamera kamera1 = new Kamera("Canon", "EOS 2000D", 18, 55, 24);
            kamera1.Verkäufe();
            kamera1.TakePhoto();

            Kamera kamera2 = new Kamera("Nikon", "D3500", 18, 55, 24);
            kamera2.Verkäufe();
            kamera2.TakePhoto();
        }
    }
}
