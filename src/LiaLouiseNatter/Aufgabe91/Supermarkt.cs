namespace Appdevhb25.LiaLouiseNatter.Aufgabe91
{
    public class Supermarkt
    {
        public static void Start()
        {
            Warenkorb warenkorb = new Warenkorb();
            Produkt produkt = new Produkt();
            Kasse kasse = new Kasse();
            
            produkt.PrintProdukte();
            System.Console.WriteLine("____________Artikel Adden__________");
            warenkorb.ArtikelHinzufuegen("Apfel", 5);
            warenkorb.ArtikelHinzufuegen("Bananen", 3);
            warenkorb.ArtikelHinzufuegen("Tomaten", 1);
            warenkorb.ArtikelHinzufuegen("Orangensaft", 2);
            warenkorb.ArtikelHinzufuegen("Hafermilch", 10);
            System.Console.WriteLine("____________Artikel Ändern__________");
            warenkorb.ArtikelAendern("Apfel", 50);
            System.Console.WriteLine("____________Artikel Löschen__________");
            warenkorb.ArtikelLoeschen("Orangensaft");
        }
    }
}