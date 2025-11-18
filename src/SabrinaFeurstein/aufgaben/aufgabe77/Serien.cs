namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe77
{
    public class Serien
    {
        public Dictionary<string, double> serien = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);

        public void SerienHinzufuegen(params (string name, double bewertung)[] serienListe)
        {
            foreach (var serie in serienListe)
            {
                serien[serie.name] = serie.bewertung;
            }
        }

        public IEnumerable<KeyValuePair<string, double>> SerienSortiertNachNamen()
        {
            return serien.OrderBy(s => s.Key);
        }

        public IEnumerable<KeyValuePair<string, double>> SerienMitBewertungUeberAcht()
        {
            return serien.Where(s => s.Value > 8);
        }

        // Alternative

        // public IEnumerable<KeyValuePair<string, double>> SerieMitBesterBewertung()
        // {
        //     return serien.Where(s => s.Value == serien.Values.Max());
        // }

        public KeyValuePair<string, double> SerieMitBesterBewertung()
        {
            return serien.Aggregate((l, r) => l.Value > r.Value ? l : r);
        }

        public IEnumerable<KeyValuePair<string, double>> SerieSuchen()
        {
            Console.Write("Serie eingeben: ");
            string suche = Console.ReadLine()!;

            if (serien.ContainsKey(suche))
            {
                return serien.Where(s => s.Key.Equals(suche, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                Console.WriteLine("Serie nicht gefunden!");
                return new Dictionary<string, double>();
            }
        }
    }
}