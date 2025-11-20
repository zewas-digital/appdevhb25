namespace Appdevhb25.KerimAlkis.Aufgabe91
{
    public class Supermarkt
    {
        public static void Start()
        {
            Console.Clear();
            SupermarketObjekt supermarkt = new SupermarketObjekt();
            supermarkt.produkte = new List<Produkt>();
            supermarkt.kassen = new List<Kasse>();
            supermarkt.warenkoerbe = new List<Warenkorb>();

            Produkt apfel = new Produkt("P01", "Apfel", 120, 0.5);
            Produkt brot = new Produkt("P02", "Brot", 40, 3);
            Produkt cola = new Produkt("P03", "Cola 1L", 80, 1.5);
            Produkt nudeln = new Produkt("P04", "Nudeln 500g", 60, 0.9);
            Produkt kaese = new Produkt("P05", "Käse", 30, 3.5);

            supermarkt.produkte.Add(apfel);
            supermarkt.produkte.Add(brot);
            supermarkt.produkte.Add(cola);
            supermarkt.produkte.Add(nudeln);
            supermarkt.produkte.Add(kaese);

            Kasse k1 = new Kasse("1");
            Kasse k2 = new Kasse("2");
            Kasse k3 = new Kasse("3");

            supermarkt.kassen.Add(k1);
            supermarkt.kassen.Add(k2);
            supermarkt.kassen.Add(k3);

            Warenkorb wk1 = new Warenkorb("W01", "Hans Peter");
            Warenkorb wk2 = new Warenkorb("W02", "Anna Müller");

            Console.WriteLine();
            Console.WriteLine("==== Kassenstatus nach Öffnen ====");
            supermarkt.GetInfoKassen();

            k1.KasseOeffnen();
            k2.KasseOeffnen();


            Console.WriteLine();
            wk1.GetWarenkorb();
            Console.WriteLine(wk1.ProduktHinzufuegen(apfel, 5));
            Console.WriteLine(wk1.ProduktHinzufuegen(brot, 3));
            Console.WriteLine(wk1.ProduktHinzufuegen(cola, 4));

            Console.WriteLine();
            wk2.GetWarenkorb();
            Console.WriteLine(wk2.ProduktHinzufuegen(kaese, 8));
            Console.WriteLine(wk2.ProduktHinzufuegen(nudeln, 4));
            Console.WriteLine(wk2.ProduktHinzufuegen(cola, 10));



            Console.WriteLine();
            Console.WriteLine("=== Zahlung: Max an Kasse 1 ===");
            Console.WriteLine(k1.Zahlen(wk1));

            Console.WriteLine();
            Console.WriteLine("=== Zahlung: Anna an Kasse 2 ===");
            Console.WriteLine(k2.Zahlen(wk2));

            Console.WriteLine();
            Console.WriteLine("==== Kassenstatus nach Zahlungen ====");
            supermarkt.GetInfoKassen();

            Console.WriteLine();
            Console.WriteLine("==== Lagerbestand nach Verkäufen ====");
            supermarkt.GetInfoLager();

        }
    }

    public class SupermarketObjekt
    {
        public List<Warenkorb> warenkoerbe;
        public List<Produkt> produkte;
        public List<Kasse> kassen;
        public SupermarketObjekt()
        {
            warenkoerbe = new();
            produkte = new();
            kassen = new();
        }
        public void GetInfoKassen()
        {
            foreach (var kasse in kassen)
            {
                Console.WriteLine(kasse.InfoKasse());
            }
        }
        public void GetInfoLager()
        {
            foreach (Produkt produkt in produkte)
            {
                Console.WriteLine(produkt.InfoProdukt());
            }
        }
    }

    public class Warenkorb
    {
        public string Warennummer;
        public double GesamtPreis;
        public string Kunde;
        public List<WarenkorbItem> items;

        public Warenkorb(string warennummer, string kunde)
        {
            Warennummer = warennummer;
            Kunde = kunde;
            items = new();
        }
        public string ProduktHinzufuegen(Produkt produkt, int anzahl)
        {
            items.Add(new(produkt, anzahl));
            produkt.LagerAnzahl -= anzahl;
            GesamtPreis += produkt.Preis * anzahl;

            return $"{Kunde} hat sich {anzahl} {produkt.Name} genommen";
        }
        public void GetWarenkorb()
        {
            System.Console.WriteLine("Warenkorb " + Warennummer);
            foreach (WarenkorbItem produkte in items)
            {
                System.Console.WriteLine(produkte.GetItemInfo());
            }
            System.Console.WriteLine();
            System.Console.WriteLine("gesamtPreis: " + GesamtPreis);
        }
        public void ProduktLoeschenBearbeiten(WarenkorbItem warenkorbItem)
        {
            warenkorbItem.item.LagerAnzahl += warenkorbItem.menge;
            items.Remove(warenkorbItem);
        }
        public void ProduktLoeschenBearbeiten(Produkt produkt, int anzahl)
        {
            items.Find(i => i.item == produkt).menge += anzahl;
            produkt.LagerAnzahl -= anzahl;
        }
    }

    public class Produkt
    {
        public string Produktnummer;
        public string Name;
        public int LagerAnzahl;
        public double Preis;

        public Produkt(string produktnummer, string name, int lagerAnzahl, double preis)
        {
            Produktnummer = produktnummer;
            Name = name;
            LagerAnzahl = lagerAnzahl;
            Preis = preis;
        }

        public void Hinzufuegen(int anzahl)
        {
            LagerAnzahl += anzahl;
        }
        public void Loeschen(int anzahl)
        {
            LagerAnzahl -= anzahl;
        }
        public string InfoProdukt()
        {
            return $"{Name}: {LagerAnzahl} Stück";
        }

    }
    public class Kasse
    {
        public string Kassennummer;
        public double TagesUmsatz;
        public bool OFFON;

        public Kasse(string kassennummer)
        {
            Kassennummer = kassennummer;
            TagesUmsatz = 0;
            OFFON = false;
        }
        public void KasseOeffnen()
        {
            OFFON = true;
            System.Console.WriteLine("Kasse " + Kassennummer + " ist offen");
        }
        public void KasseSchliessen()
        {
            OFFON = false;
            System.Console.WriteLine("Kasse " + Kassennummer + " ist zu");
        }
        public string Zahlen(Warenkorb warenkorb)
        {
            TagesUmsatz += warenkorb.GesamtPreis;
            return $"{warenkorb.Kunde} hat {warenkorb.GesamtPreis}$ bezahlt";
        }
        public string InfoKasse()
        {
            string AnAus = OFFON ? "offen" : "geschlossen";
            return $"Kasse {Kassennummer} ist {AnAus}, sein Tagesumsatz ist {TagesUmsatz}$";
        }
    }
    public class WarenkorbItem
    {
        public Produkt item;
        public int menge;

        public WarenkorbItem(Produkt produkt, int _menge)
        {
            item = produkt;
            menge = _menge;
        }
        public string GetItemInfo()
        {
            return $"{item.Name} {menge}x{item.Preis}";
        }
    }

}