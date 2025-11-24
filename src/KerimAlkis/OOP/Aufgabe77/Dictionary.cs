using Appdevhb25.KerimAlkis.Aufgabe04;

namespace Appdevhb25.KerimAlkis.Aufgabe77
{
    public class Dictionary
    {
        public static void Start()
        {
            Serien serien = new Serien();
            serien.serienBewertung.Add("Stranger Things", 9.6);
            serien.serienBewertung.Add("Breaking Bad", 8.5);
            serien.serienBewertung.Add("Rick and Morty", 9.0);
            serien.serienBewertung.Add("Prison Break", 8.7);
            serien.serienBewertung.Add("Riverdale", 6.1);

            System.Console.WriteLine("Serien sortiert nach Name:");
            foreach (var serie in serien.SortName())
            {
                System.Console.WriteLine(serie);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Berwertung über 8.0:");
            foreach (var serie in serien.UeberAchtBewertung())
            {
                System.Console.WriteLine(serie);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Beste Serie(n)");
            foreach (var serie in serien.BesteSerie())
            {
                System.Console.WriteLine(serie);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Gib Name der Serie ein um die Bewertung zu sehen");
            Console.WriteLine(serien.SucheBewertung(Console.ReadLine()));


        }
    }
    public class Serien
    {
        public Dictionary<string, double> serienBewertung;
        public Serien()
        {
            serienBewertung = new Dictionary<string, double>();
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
            if(serienBewertung[nameDerSerie] == null)
            {
                Console.WriteLine("Fehler");
                return 0;
            }
            return serienBewertung[nameDerSerie];
        }

    }
}