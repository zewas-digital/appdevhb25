namespace Appdevhb25.SheilaMayJaro.Aufgabe72Bonus
{
    public class Aufgabe72Bonus
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 72)");
            /* 
            Erweitere das vorhergehende Beispiel um die Klassen Objektiv und Speicherkarte. 
            Die Brennweite der Kamera fällt demnach weg. Das Objektiv und die Speicherkarte sollen getauscht werden können. 
            Erstelle Methoden um zu erfragen wieviele Fotos bereits aufgenommen wurden und wieviel Speicher noch frei ist. 
            Für die Berechnung Speicherplatz pro Bild, kann ein Wert von 0.3MB pro Megapixel angenommen werden.
            */

            Camera camera = new Camera();
            camera.Model = "Canon";
            camera.Megapixel = 50;
            camera.Manufacturer = "GepettoAndSon";
            camera.memoryCard.MaxStorageSpace = 8000; 
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto(); 
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();
            camera.TakeFoto();

            Console.WriteLine(camera.HowManyFotosTaken());
            System.Console.WriteLine($"Speicherplatz verbraucht: {camera.memoryCard.StorageSpaceUsed}");
            System.Console.WriteLine($"Speicherplatz noch verfügbar: {camera.memoryCard.HowMuchStorageSpace()}");
        }
    }
}