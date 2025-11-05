using System.Drawing;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe67
{
    public class Inventur2
    {
        public static void Start()
        {
            List<Article> articles = new List<Article>();
            Article a1 = new Article("Apfel", 0.5f, 20);
            Article a2 = new Article("Banane", 0.30f, 15);
            Article a3 = new Article("Karotten", 0.40f, 10);
            Article a4 = new Article("Kartoffeln", 0.40f, 30);
            articles.Add(a1);
            articles.Add(a2);
            articles.Add(a3);
            articles.Add(a4);
            berechnungen(articles);
        }

        public static void berechnungen(List<Article> articles)
        {
            string teuersterArtikel = "";
            float preisHolder = 0;

            string billigsterArtikel = "";
            float preisHolderBillig = articles[0].Preis;

            float allePreiseAddiert = 0;
            float gesWertArtUndMeng = 0;

            foreach (Article article in articles)
            {
                if (article.Preis >= preisHolder)
                {
                    preisHolder = article.Preis;
                    teuersterArtikel = article.Name;
                }

                if (article.Preis <= preisHolderBillig)
                {
                    preisHolderBillig = article.Preis;
                    billigsterArtikel = article.Name;
                }

                allePreiseAddiert += article.Preis;

                gesWertArtUndMeng += article.Preis * article.Menge;
            }
            allePreiseAddiert /= articles.Count;
            System.Console.WriteLine($"Teuerster Artikel: {teuersterArtikel}\nBilligster Artikel: {billigsterArtikel}\nDurchschnittspreis aller Artikel: {allePreiseAddiert}\nGesamtwert aller Artikel und Mengen: {gesWertArtUndMeng}");

        }
       
    }
    

}
