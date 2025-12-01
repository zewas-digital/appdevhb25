namespace Appdevhb25.JonaSchnell.Aufgabe68
{
    public class AufgabeFotoapparat
    {
        public static void StartFotoapparat()
        {
            // Standard Kamera
            Console.WriteLine("=== Test 1: Standard Kamera ===");
            var kamera1 = new Fotoapparat();
            kamera1.ZeigeDaten();
            kamera1.TakePhoto();

            // Kamera mit allen Details
            Console.WriteLine("=== Test 2: Vollständige Kamera ===");
            var kamera2 = new Fotoapparat("Canon", "EOS 2000D", 18, 55, 24);
            kamera2.ZeigeDaten();
            kamera2.TakePhoto();

            // Test der Validierung
            Console.WriteLine("=== Test 3: Validierung ===");
            var testKamera = new Fotoapparat();
            testKamera.Megapixel = -5;        // Sollte Fehler ausgeben
            testKamera.Model = "";            // Sollte Fehler ausgeben
            testKamera.BrennweiteMax = 10;    // Sollte Fehler ausgeben (kleiner als Min)
        }
    }
}
