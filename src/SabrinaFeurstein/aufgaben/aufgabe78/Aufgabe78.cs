namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe78
{
    public class Aufgabe78
    {
        public static void Start()
        {
            var serien = new Serien();
            Queue<string> topSerienDesNutzers = new Queue<string>();
            Queue<double> interneBewertungenTemp = new Queue<double>();
            Dictionary<string, double> serienListeDesNutzers = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);

            serien.SerienHinzufuegen(
                ("Stranger Things", 9.9),
                ("Modern Family", 8),
                ("Riverdale", 2),
                ("Jujutsu Kaisen", 8.7),
                ("South Park", 7.5)
                );

            // Ausgabe der Seriennamen
            foreach (var serie in serien.serien)
                Console.WriteLine($"{serie.Key}");

            // Nutzerabfrage der 3 liebsten Serien mit Prüfung ob die Eingabe in der Liste ist - Speichern der 3 Serien in einer Queue
            Console.WriteLine("\nGib deine 3 liebsten Serien aus der Liste an.");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Serie {i + 1}: ");
                string? name = Console.ReadLine();
                while (!serien.serien.ContainsKey(name!))
                {
                    if (true)
                    {
                        Console.Write("Serie ist nicht in der Liste! Bitte erneut eingeben: ");
                        name = Console.ReadLine();
                    }
                }

                topSerienDesNutzers.Enqueue(name!);
            }

            // fragt Nutzer nach Bewertungen für die Serien - speichert die drei Seriennamen mit den Bewertungen in einem Dictionary
            Console.WriteLine("Gib deine Bewertungen für die gewählten Serien ab.");
            foreach (var serie in topSerienDesNutzers)
            {
                Console.Write(serie + ": ");
                double bewertung = Convert.ToDouble(Console.ReadLine());
                serienListeDesNutzers.Add(serie, bewertung);
            }

            // temporäre Queue zum Speichern der internen Bewertungen für die des Nutzers gewählten Serien
            foreach (var serie in serien.serien)
            {
                if (serienListeDesNutzers.ContainsKey(serie.Key))
                    interneBewertungenTemp.Enqueue(serie.Value);
            }

            // Ausgabe des Seriennamens und der beiden Bewertungen
            Console.WriteLine("\nSerienname: Internen Bewertungen - Benutzerbewertungen");
            foreach (var serie in serienListeDesNutzers)
            {
                Console.WriteLine($"{serie.Key}: {interneBewertungenTemp.Peek()} - {serie.Value}");
                interneBewertungenTemp.Dequeue();
            }


            // Eingaben von Aufgabe 77

            // foreach (var serie in serien.SerienSortiertNachNamen())
            //     Console.WriteLine($"{serie.Key}: {serie.Value:F1}");

            // Console.WriteLine();

            // foreach (var serie in serien.SerienMitBewertungUeberAcht())
            //     Console.WriteLine($"{serie.Key}: {serie.Value:F1}");

            // Console.WriteLine();

            // // foreach (var serie in serien.SerieMitBesterBewertung())
            // //     Console.WriteLine($"{serie.Key:F1}: {serie.Value:F1}");

            // var beste = serien.SerieMitBesterBewertung();
            // Console.WriteLine($"{beste.Key}: {beste.Value:F1}");

            // Console.WriteLine();

            // foreach (var serie in serien.SerieSuchen())
            //     Console.WriteLine($"Bewertung: {serie.Value:F1}");
        }
    }
}