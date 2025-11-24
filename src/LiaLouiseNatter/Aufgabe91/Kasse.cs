namespace Appdevhb25.LiaLouiseNatter.Aufgabe91
{
    public class Kasse
    {
        private double tagesUmsatz = 0;

        public void Bezahlen()
        {
            Produkt produkt = new Produkt();
            foreach(KeyValuePair<string, double> artikel in produkt.produkte)
            {
                tagesUmsatz += artikel.Value;
            }
            System.Console.WriteLine($"TagesUmsatz der Kassa: {tagesUmsatz}");
        }


    }
}
