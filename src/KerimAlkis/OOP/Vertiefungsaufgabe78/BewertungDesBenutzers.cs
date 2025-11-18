using Appdevhb25.KerimAlkis.Aufgabe04;

namespace Appdevhb25.KerimAlkis.Vertiefungsaufgabe78
{
    public class BewertungDesBenutzers
    {
        public static void Start()
        {
            Serien serien = new Serien();
            serien.serienBewertung.Add("Stranger Things", 9.6);
            serien.serienBewertung.Add("Breaking Bad", 8.5);
            serien.serienBewertung.Add("Rick and Morty", 9.0);
            serien.serienBewertung.Add("Prison Break", 8.7);
            serien.serienBewertung.Add("Riverdale", 6.1);


            Queue<string> lieblingsSerien = new Queue<string>();
            do
            {
                Console.Clear();
                Console.WriteLine("Serienliste:");
                int index = 1;
                foreach (var serie in serien.serienBewertung)
                {
                    Console.WriteLine($"{index}. {serie.Key} ({serie.Value}/10)");
                    index++;
                }

                Console.WriteLine("\nAusgewählte Serien:");
                foreach (var serie in lieblingsSerien)
                {
                    Console.WriteLine("- " + serie);
                }

                Console.WriteLine("\nWähle 3 Serie (Name) aus:");
                string eingabe = Console.ReadLine();

                string ausgewaehlteSerie = null;
                if (serien.serienBewertung.ContainsKey(eingabe))
                {
                    ausgewaehlteSerie = eingabe;
                }
                if (ausgewaehlteSerie != null)
                {
                    if (!lieblingsSerien.Contains(ausgewaehlteSerie))
                    {
                        lieblingsSerien.Enqueue(ausgewaehlteSerie);
                        Console.WriteLine($"'{ausgewaehlteSerie}' wurde hinzugefügt!");
                    }
                    else { Console.WriteLine("Diese Serie wurde bereits ausgewählt."); }
                }
                else { Console.WriteLine("Fehler: Serie nicht gefunden."); }

                Thread.Sleep(1200);

            } while (lieblingsSerien.Count < 3);
            Console.Clear();
            Dictionary<string, double> Benutzerbewertung = new Dictionary<string, double>();
            foreach (var serie in lieblingsSerien)
            {
                System.Console.WriteLine("Bewerte " + serie + " von 1-10");
                double bewertungSerie;
                do
                {
                    string inputBewertung = Console.ReadLine();
                    if (double.TryParse(inputBewertung, out double bewertungOK))
                    {
                        bewertungSerie = bewertungOK; break;
                    }
                } while (true);
                Benutzerbewertung[serie] = bewertungSerie;
            }

            serien.LieblingsSerien = Benutzerbewertung;

            Console.Clear();
            Console.WriteLine("Vergleich der internen Bewertungen mit den Benutzerbewertungen:\n");
            Console.WriteLine($"{"Serie",-20} {"Intern",-10} {"Benutzer",-10}");
            Console.WriteLine(new string('-', 45));

            foreach (var serie in Benutzerbewertung)
            {
                double interneBewertung = serien.serienBewertung[serie.Key];
                double benutzerBewertung = serie.Value;
                double differenz = Math.Round(benutzerBewertung - interneBewertung, 2);

                Console.WriteLine($"{serie.Key,-20} {interneBewertung,-10} {benutzerBewertung,-10}");
            }
        }
    }
    public class Serien
    {
        public Dictionary<string, double> serienBewertung;
        public Dictionary<string, double> LieblingsSerien;
        public Serien()
        {
            serienBewertung = new Dictionary<string, double>();
            LieblingsSerien = new Dictionary<string, double>();
        }
        public Dictionary<string, double> SortName()
        {
            return serienBewertung.OrderBy(p => p.Key).ToDictionary();
        }
        public Dictionary<string, double> UeberAchtBewertung()
        {
            return serienBewertung.Where(p => p.Value >= 8).ToDictionary();
        }
        public Dictionary<string, double> BesteSerie()
        {
            return serienBewertung.Where(p => p.Value == serienBewertung.Max(p => p.Value)).ToDictionary();
        }
        public double SucheBewertung(string nameDerSerie)
        {
            if(serienBewertung[nameDerSerie] == 0)
            {
                Console.WriteLine("Fehler");
                return 0;
            }
            return serienBewertung[nameDerSerie];
        }

    }
}