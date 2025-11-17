namespace Appdevhb25.NoahHois.Aufgabe68
{
    public class ProgramFotoapparat
    {
        public static void Start()
        {
            Fotoapparat[] cameras = new Fotoapparat[4];
            Fotoapparat firstCamera = new Fotoapparat(16, 2000, "Sony Alpha 9 II.", "Sony", 50);
            Fotoapparat secondCamera = new Fotoapparat(20, 1500, "Canon Ultra II.", "Canon", 30);
            Fotoapparat thirdCamera = new Fotoapparat(26, 200, "Sony Mini 3", "Sony", 24);
            Fotoapparat fourthCamera = new Fotoapparat(12, 540, "Canon Beta III.", "Canon", 42);
            cameras[0] = firstCamera;
            cameras[1] = secondCamera;
            cameras[2] = thirdCamera;
            cameras[3] = fourthCamera;

            foreach (Fotoapparat f in cameras)
            {
                f.Print();
                Console.WriteLine();
            }
        }
    }
}