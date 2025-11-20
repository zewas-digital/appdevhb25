namespace Appdevhb25.LiaLouiseNatter.Aufgabe91
{
    public class Warenkorb
    {
        private Dictionary<string, WarenkorbItem> einkauf = new Dictionary<string, WarenkorbItem>();
        private int menge;
        public int Menge
        {
            get
            {
                return menge;
            }
            set
            {
                menge = value;
            }
        }
        public Produkt produkt = new Produkt();
        

        public void ArtikelHinzufuegen(string artikel, int menge)
        {
            if (produkt.produkte.ContainsKey(artikel))
            {
                double preis = produkt.produkte[artikel];
                einkauf.Add(artikel, new WarenkorbItem
                {
                    Preis = preis,
                    Menge = menge
                });
            }
            if (!produkt.produkte.ContainsKey(artikel))
            {
                System.Console.WriteLine("Artikel nicht verfügbar");
            }  
            PrintWarenkorb();
        }

        public void ArtikelAendern(string artikel, int menge)
        {
            if (!produkt.produkte.ContainsKey(artikel))
            {
                System.Console.WriteLine("Artikel nicht verfügbar");
            }
            if (einkauf.ContainsKey(artikel))
            {
                einkauf[artikel].Menge = menge;
            }
            else
            {
                System.Console.WriteLine("Artikel nicht verfügbar");
            }
            
            PrintWarenkorb();
            
        }

        public void ArtikelLoeschen(string artikel)
        {
            if (einkauf.ContainsKey(artikel))
            {
                einkauf.Remove(artikel);
            }
            else
            {
                System.Console.WriteLine("Artikel nicht verfügbar");
            }
            PrintWarenkorb();
        }

        public void PrintWarenkorb()
        {
            int counter = 0;
            System.Console.WriteLine($"Wilkommen im Spar");
            foreach(KeyValuePair<string, WarenkorbItem> produkt in einkauf)
            {
                counter++;
                System.Console.WriteLine($"{counter}. Artikel: {produkt.Key} Preis: {produkt.Value.GetGesamtpreis()} Menge: {produkt.Value.Menge}");
            }
        }
    }
    
}