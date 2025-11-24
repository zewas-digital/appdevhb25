namespace Appdevhb25.NoahHois.Aufgabe91
{
    public class Supermarkt
    {
        public static void Start()
        {
            Produkt apfel = new Produkt(1.20, "Äpfel");
            Produkt birne = new Produkt(2.50, "Birnen");
            Produkt banane = new Produkt(1.40, "Bananen");
            Warenkorb firstWarenkorb = new Warenkorb("Sasha");
            Kasse firstKasse = new Kasse();
            firstWarenkorb.Add(apfel, 5);
            firstWarenkorb.PrintOutput();

            firstWarenkorb.Add(birne, 10);
            firstWarenkorb.PrintOutput();

            firstWarenkorb.Add(banane, 3);
            firstWarenkorb.PrintOutput();

            firstWarenkorb.Delete(apfel);
            firstWarenkorb.PrintOutput();


            firstWarenkorb.PrintOutput();

            firstWarenkorb.Change(banane, 2);
            firstWarenkorb.Change(birne, -1);
            firstWarenkorb.PrintOutput();

            System.Console.WriteLine("Bezahlen...");
            firstKasse.Pay(firstWarenkorb);
            firstWarenkorb.PrintOutput();

        }
    }
}