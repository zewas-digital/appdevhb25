namespace Appdevhb25.KerimAlkis.Aufgabe67
{
    public class Inventur2
    {
        public static void Start()
        {
            string path = @"C:\Users\ALKIKER\Documents\appdevhb25\src\KerimAlkis\Vertiefungsaufgaben\Aufgabe67\articleInput.txt";
            string[] articels = File.ReadAllLines(path);


            List<Article> articleList = new List<Article>();

            for (int i = 0; i < articels.Length - 1; i++)
            {
                string[] parts = articels[i].Split("  ");

                string name = parts[0];
                int menge = int.Parse(parts[1]);
                double preis = double.Parse(parts[2]);

                articleList.Add(new Article(name, preis, menge));
            }
            Berechnung(articleList);
        }
        public static void Berechnung(List<Article> articles)
        {
            double teuerPreis = 0;
            double billigPreis = articles[0].Preis;
            double mengeGesamt = 0;
            double gesamtWertAllerArticle = 0;


            string teuerArtikel = "";
            string billigArtikel = "";


            foreach (Article a in articles)
            {
                if (a.Preis > teuerPreis) { teuerPreis = a.Preis; teuerArtikel = a.Name; }
                if (a.Preis < billigPreis) { billigPreis = a.Preis; billigArtikel = a.Name; }

                mengeGesamt += a.Preis;
                gesamtWertAllerArticle += (a.Preis * a.Menge);
            }

            System.Console.WriteLine("teuerster Artikel: " + teuerArtikel);
            System.Console.WriteLine("billigster Artikel: " + billigArtikel);
            System.Console.WriteLine("Durchschnittspreis aller Artikel: " + (mengeGesamt / articles.Count).ToString("F2"));
            System.Console.WriteLine("Gesamtwert aller Artikel und Mengen: " + gesamtWertAllerArticle.ToString("F2"));
        }
    }

    public class Article
    {
        public string Name;
        public double Preis;
        public int Menge;

        public Article(string name, double preis, int menge)
        {
            Name = name;
            Preis = preis;
            Menge = menge;
        }
    }
}