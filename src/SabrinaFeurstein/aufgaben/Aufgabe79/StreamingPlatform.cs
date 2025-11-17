namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe79
{
    public class StreamingPlatform
    {
        private readonly Dictionary<Serie, double> SerienBewertungen = new Dictionary<Serie, double>();

        public void StreamingPlatformBefuellen(params (Serie name, double bewertung)[] serienListe)
        {
            foreach (var serie in serienListe)
            {
                SerienBewertungen[serie.name] = serie.bewertung;
            }
        }

        public void BewertungErgaenzen(Serie serie, double bewertung)
        {
            SerienBewertungen[serie] = bewertung;
        }

        public Serie NutzerBewertung(string nutzerSuche)
        {
            Serie gesuchteSerie = new Serie(0, "");
            bool serieGefunden = false;
            while (!serieGefunden)
            {
                foreach (var serie in SerienBewertungen)
                {
                    if (serie.Key.SerienName.Equals(nutzerSuche, StringComparison.OrdinalIgnoreCase))
                    {
                        gesuchteSerie = serie.Key;
                        serieGefunden = true;
                        break;
                    }
                }
                if (!serieGefunden)
                {
                    Console.Write("Serie ist nicht in der Liste! Bitte erneut eingeben: ");
                    nutzerSuche = Console.ReadLine()!;
                }
            }

            if (serieGefunden)
            {
                Console.Write($"Gib eine Bewertung für die gewählte Sendung ({gesuchteSerie.SerienName}) ab: ");
                string? nutzerEingabe = Console.ReadLine();
                double nutzerBewertung;

                do
                {
                    if (double.TryParse(nutzerEingabe, out nutzerBewertung))
                        break;
                    else
                    {
                        Console.Write("Falsche Eingabe! Bitte gib eine Zahl ein: ");
                        nutzerEingabe = Console.ReadLine();
                    }

                } while (true);

                SerienBewertungen[gesuchteSerie] = nutzerBewertung;
            }
            return gesuchteSerie;
        }


        public void TopDrei()
        {
            var serienBewertungenSortiert = SerienBewertungen.OrderByDescending(s => s.Value);
            int i = 0;

            Console.WriteLine("---------\nTop 3\n---------");
            foreach (var serie in serienBewertungenSortiert)
            {
                Console.WriteLine($"{i + 1}. {serie.Key.SerienName} (ID: {serie.Key.SerienID}) - {serie.Value}");
                i++;
                if (i == 3)
                    break;
            }
        }

        public void SerienListeAusgeben()
        {
            Console.WriteLine("Serien auf der Streaming Plattfrom " + ":");
            foreach (var serie in SerienBewertungen)
            {
                Console.WriteLine(serie.Key.SerienName);
            }
        }

        public void DictionaryAusgeben()
        {
            Console.WriteLine();
            foreach (var serie in SerienBewertungen)
            {
                Console.WriteLine($"{serie.Key} {serie.Value}");
            }
        }
    }
}