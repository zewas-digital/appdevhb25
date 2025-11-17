namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe79
{
    public class Aufgabe79
    {
        public static void Start()
        {
            Serie[] serie =
            [
                new Serie(1, "Stranger Things"),
                new Serie(2, "Modern Family"),
                new Serie(3, "Arcane"),
                new Serie(4, "Wednesday")
            ];

            serie[0].Cast.AddRange(new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Finn", "Wolfhard"),
                new Tuple<string, string>("Noah", "Schnapp"),
                new Tuple<string, string>("Caleb", "McLaughlin"),
                new Tuple<string, string>("Gaten", "Matarazzo"),
                new Tuple<string, string>("Sadie", "Sink"),
                new Tuple<string, string>("Millie Bobby", "Brown"),
            });

            serie[0].CastListeAusgeben();
            Console.WriteLine();

            StreamingPlatform netflix = new StreamingPlatform();
            netflix.StreamingPlatformBefuellen(
                (serie[0], 9.5),
                (serie[1], 8.2),
                (serie[2], 9.3),
                (serie[3], 6.9)
                );

            netflix.BewertungErgaenzen(serie[0], 9.0);
            netflix.SerienListeAusgeben();
            Console.WriteLine();

            while (true)
            {
                Console.Write(@"Wähle eine Serie aus der Liste oder gib ""quit"" ein um das Programm zu beenden: ");
                string? nutzerEingabe = Console.ReadLine();

                if (nutzerEingabe!.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.WriteLine(netflix.NutzerBewertung(nutzerEingabe!));
                netflix.TopDrei();
            }
        }
    }
}