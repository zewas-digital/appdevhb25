using Appdevhb25.KerimAlkis.Aufgabe04;
using Appdevhb25.KerimAlkis.Vertiefungsaufgabe78;

namespace Appdevhb25.KerimAlkis.Bonusaufgabe79
{
    public class SerienTop3
    {
        public static void Start()
        {
            Serie s1 = new Serie(1, "Stranger Things", 9.1);
            Serie s2 = new Serie(2, "Breaking Bad", 8.6);
            Serie s3 = new Serie(3, "Rick and Morty", 9.5);
            Serie s4 = new Serie(4, "Prison Break", 9);

            StreamingPlattform netflix = new StreamingPlattform("Netflix");
            netflix.SerieHinzufuegen(s1);
            netflix.SerieHinzufuegen(s2);
            netflix.SerieHinzufuegen(s3);
            netflix.SerieHinzufuegen(s4);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Serienliste: ");
                foreach (var serie in netflix.Serien.Keys)
                {
                    Console.WriteLine($"-{serie.Name, -20} {serie.Bewertungen.Average(), -10}");
                }

                Console.WriteLine("\nWähle eine Serie (Name):");
                string eingabe = Console.ReadLine();

                Serie ausgewaehlteSerie = null;
                if (netflix.Serien.Keys.Any(s => s.Name == eingabe))
                {
                    ausgewaehlteSerie = netflix.Serien.Keys.First(s => s.Name == eingabe);
                }
                else
                {
                    Console.WriteLine("Serie nicht gefunden");
                    Thread.Sleep(1000); continue;
                }

                Console.WriteLine($"Gib eine Bewertung für {ausgewaehlteSerie.Name} ein (0-10):");

                if (!double.TryParse(Console.ReadLine(), out double bewertung) || bewertung < 0 || bewertung > 10)
                {
                    Console.WriteLine("Falsche Bewertung");
                    Thread.Sleep(1000); continue;
                }

                netflix.BewertungHinzu(ausgewaehlteSerie, bewertung);

                Console.WriteLine("\nTop 3 Serien:");

                List<Serie> top3 = netflix.Serien.Keys.OrderByDescending(s => s.Bewertungen.Average()).ToList();

                int platz = 0;
                foreach (Serie t in top3)
                {
                    platz++;
                    Console.WriteLine($"{platz}. {t.Name, -20} {t.Bewertungen.Average(), -10}");
                    if (platz >= 3)
                    {
                        break;
                    }
                }
                System.Console.WriteLine("Druecke Taste zum Fortsetzen");
                Console.ReadKey();
            }
        }
    }
    public class Serie
    {
        public int SerienID;
        public string Name;
        public List<string> Cast = new List<string>();
        public List<double> Bewertungen = new List<double>();

        public Serie(int serienID, string name, double bewertung)
        {
            SerienID = serienID;
            Name = name;
            Bewertungen.Add(bewertung);
        }
        /*public void BewertungHizufuegen(double benutzerbewertung)
        {
            Bewertungen.Add(benutzerbewertung);
        }*/
        public void CastHinzufuegen(string schauspieler)
        {
            Cast.Add(schauspieler);
        }
    }
    public class StreamingPlattform
    {
        public string Name;
        public Dictionary<Serie, List<double>> Serien;

        public StreamingPlattform(string name)
        {
            Name = name;
            Serien = new Dictionary<Serie, List<double>>();
        }
        public void SerieHinzufuegen(Serie serie)
        {
            Serien.Add(serie, serie.Bewertungen);
        }
        public void BewertungHinzu(Serie serie, double benutzerbewertung)
        {
            Serien[serie].Add(benutzerbewertung);
        }
    }
}