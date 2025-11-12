namespace Appdevhb25.NoahHois.Aufgabe77
{
    public class Dictionary
    {
        private Dictionary<string, double> serie = new Dictionary<string, double> { { "One Piece", 10 }, { "Bleach", 9.3 }, { "Naruto", 3.8 }, { "Digimon", 8.9 }, { "Cyberpunk", 7.90 } };
        public void Sotieren()
        {
            foreach (var d in serie.OrderBy(b => b.Key))
            {
                System.Console.WriteLine($"Serie: {d.Key} Bewertung: {d.Value}");
            }
        }
        public void BewertungUeber8()
        {
            foreach (var d in serie)
            {
                if (d.Value > 8.0)
                {
                    System.Console.WriteLine($"Serie: {d.Key} Bewertung: {d.Value}");
                }
            }
        }
        public void HoechsteBewertung()
        {
            var hoechsteBewertung = serie.MaxBy(b => b.Value);
            System.Console.WriteLine($"Serie: {hoechsteBewertung.Key} Bewertung: {hoechsteBewertung.Value}");
        }
        public void SucheSerie(string suche)
        {
            foreach (var d in serie)
            {
                if (d.Key == suche)
                {
                    System.Console.WriteLine($"Serie: {d.Key} Bewertung: {d.Value}");
                }
            }
        }
    }
}