namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe84
{
    public class Inventarliste
    {
        public static void Start()
        {
            List<IGegenstand> inventarliste =
            [
                new Auto("534", "gelb", 10489, "B-PL345", 7.3),
                new Motorrad("322", 255903, "schwarz", 20, 2200, "B-45WL"),
                new Fotoapparat("435", 120, "D850", "Nikon", 45.7),
            ];

            foreach (IGegenstand gegenstand in inventarliste)
            {
                Console.WriteLine(gegenstand.GetGegenstandInfo());
            }
        }
    }
}