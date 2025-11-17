namespace Appdevhb25.SheilaMayJaro.Aufgabe73
{
    public class Aufgabe73
    {
        public static void Start()
        {
            // System.Console.WriteLine("Aufgabe 73)");
            // Camera camera = new Camera();
            // camera.SerialNumber = "1565104LO542";
            // camera.MemoryCard.StorageSpace = 8000; 
            // camera.TakePicture();
            // camera.TakePicture();
            // camera.TakePicture();
            // camera.TakePicture();
            // camera.TakePicture(); 
            // camera.TakePicture();
            // camera.TakePicture();
            // Console.WriteLine($"Speicherplatz übrig: {camera.MemoryCard.StorageSpace} MB");
        
            Console.WriteLine("---\n\nAufgabe 73 - Kamera mit Hardware");
            // Instanzierung der Klassen und Demonstration der Funktionalität
            Camera camera1 = new Camera("FA123456", "Nikon D3500");
            CameraLens cameraLens55 = new CameraLens("OB654321", "Nikon AF-P DX 18-55mm", 55);
            CameraLens cameraLens200 = new CameraLens("OB987654", "Nikon AF-S DX 55-200mm", 200);
            MemoryCard memoryCardM = new MemoryCard("SK112233", "SanDisk Ultra", 1024 * 32);
            MemoryCard memoryCardL = new MemoryCard("SK445566", "Lexar Professional", 1024 * 64);

            // Nutzung der Methoden
            Console.WriteLine("Unser Fotoapparat:\n" + camera1);
            camera1.ChangeCameraLens(cameraLens55);
            camera1.ChangeMemoryCard(memoryCardM);
            Console.WriteLine("\n1/\nAktuelles Objektiv: " + camera1.CameraLens);
            Console.WriteLine("Aktuelle Speicherkarte: " + camera1.MemoryCard);
            camera1.TakePicture();
            camera1.TakePicture();
            camera1.TakePicture();
            camera1.TakePicture();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + camera1.NumberOfPictures);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + camera1.NumberOfAvailablePictures());

            // Wechsel des Objektivs und der Speicherkarte
            camera1.ChangeCameraLens(cameraLens200);
            camera1.ChangeMemoryCard(memoryCardL);
            Console.WriteLine("\n2/\nGewechseltes Objektiv: " + camera1.CameraLens);
            Console.WriteLine("Gewechselte Speicherkarte: " + camera1.MemoryCard);
            camera1.TakePicture();
            camera1.TakePicture();
            Console.WriteLine("-\nAnzahl aufgenommener Fotos: " + camera1.NumberOfPictures);
            Console.WriteLine("Anzahl verfügbarer Fotos auf der Speicherkarte: " + camera1.NumberOfAvailablePictures());
            Console.WriteLine("---");
        }
    }
}