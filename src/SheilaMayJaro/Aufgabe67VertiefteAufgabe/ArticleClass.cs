using System;
namespace Appdevhb25.SheilaMayJaro.Aufgabe67
{
    public class Article
    {
        //Instanzattribute bzw. Objektattribute
        public string? Articlename;
        public int Amount;
        public double Price;

        //Konstruktor
        public Article(string articlename, double price, int amount)
        {
            // Die Argumente, welche beim Aufruf des Konstruktors übergeben werden, 
            // werden in die Instanzattribute des Objektes gespeichert.
            Articlename = articlename;
            Price = price;
            Amount = amount;
        }
        public Article()
        {
            
        }
    }

}