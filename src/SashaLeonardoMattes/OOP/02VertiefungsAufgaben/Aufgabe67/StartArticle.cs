using System;
using System.Runtime.InteropServices;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe67
{
    public class ArticleCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Article[] articles = new Article[3];

            Article a1 = new Article();
            a1.Name = "Apfel";
            a1.Price = 0.5m;
            a1.Amount = 20;
            articles[0] = a1;

            Article a2 = new Article();
            a2.Name = "Banane";
            a2.Price = 0.3m;
            a2.Amount = 15;
            articles[1] = a2;


            Article a3 = new Article();
            a3.Name = "Karotte";
            a3.Price = 1.0m;
            a3.Amount = 10;
            articles[2] = a3;

            WriteCalculations(articles);

        }
        
        public static void WriteCalculations(Article[] articles)
        {
            decimal mostExpensive = articles[0].Price;
            decimal leastExpensive = articles[0].Price;
            decimal totalPrice = 0;
            decimal averagePrice = 0;

            foreach (Article article in articles)
            {
                if (article.Price > mostExpensive)
                {
                    mostExpensive = article.Price;
                }
                if (article.Price < leastExpensive)
                {
                    leastExpensive = article.Price;
                }

                totalPrice += article.Price * article.Amount;
                averagePrice += article.Price;
            }
            averagePrice /= articles.Length;

            System.Console.WriteLine($"Teuerster Artikel: {mostExpensive}\n Billigster Artikel: {leastExpensive}\n Durchschnittspreis: {averagePrice}\n Gesamtwert: {totalPrice}");
        }
    }
}
