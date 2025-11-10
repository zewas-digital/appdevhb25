namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe68
{
    public class Kameras
    {
        public static void Start()
        {
            Fotoapparat[] fotoapparate =
            [
                new Fotoapparat(24, 120, "D850", "Nikon", 45.7),
                new Fotoapparat(24, 70, "Vlog-Kamera ZV-1", "Sony", 20.1),
                new Fotoapparat(18, 55, "EOS 250D Kit", "Canon", 24.1),
            ];

            for (int i = 0; i < fotoapparate.Length; i++)
            {
                fotoapparate[i].TakePhoto();
            }
        }
    }
}