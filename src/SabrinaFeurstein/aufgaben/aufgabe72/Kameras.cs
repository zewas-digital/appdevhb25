namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe72
{
    public class Kameras
    {
        public static void Start()
        {
            Speicherkarte speicherkarte1 = new Speicherkarte(32);
            Speicherkarte speicherkarte2 = new Speicherkarte(64);

            Objektiv objektiv1 = new Objektiv(55);
            Objektiv objektiv2 = new Objektiv(70);

            Fotoapparat[] fotoapparate =
            [
                new Fotoapparat(objektiv1, "D850", "Nikon", 45.7, speicherkarte2),
                new Fotoapparat(objektiv2, "Vlog-Kamera ZV-1", "Sony", 20.1, speicherkarte1),
                new Fotoapparat(objektiv1, "EOS 250D Kit", "Canon", 24.1, speicherkarte2),
            ];

            for (int i = 0; i < fotoapparate.Length; i++)
            {
                fotoapparate[i].TakePhoto();
            }

            fotoapparate[0].TakePhoto();
            fotoapparate[0].Speicher();
        }
    }
}