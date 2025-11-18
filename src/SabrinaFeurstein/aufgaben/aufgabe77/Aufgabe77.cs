namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe77
{
    public class Aufgabe77
    {
        public static void Start()
        {
            var serien = new Serien();
            serien.SerienHinzufuegen(
                ("Stranger Things", 9.9),
                ("Modern Family", 8),
                ("Riverdale", 2),
                ("Jujutsu Kaisen", 8.7),
                ("South Park", 7.5)
                );

            foreach (var serie in serien.SerienSortiertNachNamen())
                Console.WriteLine($"{serie.Key}: {serie.Value:F1}");

            Console.WriteLine();

            foreach (var serie in serien.SerienMitBewertungUeberAcht())
                Console.WriteLine($"{serie.Key}: {serie.Value:F1}");

            Console.WriteLine();

            // foreach (var serie in serien.SerieMitBesterBewertung())
            //     Console.WriteLine($"{serie.Key:F1}: {serie.Value:F1}");

            var beste = serien.SerieMitBesterBewertung();
            Console.WriteLine($"{beste.Key}: {beste.Value:F1}");

            Console.WriteLine();

            foreach (var serie in serien.SerieSuchen())
                Console.WriteLine($"Bewertung: {serie.Value:F1}");
        }
    }
}