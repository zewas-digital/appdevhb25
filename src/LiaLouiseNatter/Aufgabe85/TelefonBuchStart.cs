namespace Appdevhb25.LiaLouiseNatter.Aufgabe85
{
    public class TelefonBuchStart
    {
        public static void Start()
        {
            Kontakt kontakt = new Kontakt("Natter", "06704061043", "6900");
            Kontakt kontakt2 = new Kontakt("Lia", "06704061043", "6900");
            Kontakt kontakt3 = new Kontakt("Emma", "067365061043", "6850");
            Telefonbuch telefonbuch = new Telefonbuch();
            System.Console.WriteLine("_________erster kontakt hinzugefuegt________");
            telefonbuch.Hinzufuegen(kontakt);
            System.Console.WriteLine("_________zweiter kontakt hinzugefuegt________");
            telefonbuch.Hinzufuegen(kontakt3);
            System.Console.WriteLine("_________kontakt veraendert________");
            telefonbuch.Veraendern(kontakt, kontakt2);
            System.Console.WriteLine("_________zweiter kontakt hinzugefuegt________");
            telefonbuch.Hinzufuegen(kontakt);
            System.Console.WriteLine("_________kontakt geloescht________");
            telefonbuch.Geloescht(kontakt2);
            System.Console.WriteLine("_________suche kontakt________");
            telefonbuch.Suchen("Emma");
            
        }
    }
}