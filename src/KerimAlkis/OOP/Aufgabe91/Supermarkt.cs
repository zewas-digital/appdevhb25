namespace Appdevhb25.KerimAlkis.Aufgabe91
{
    public class Supermarkt
    {
        public static void Start()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SupermarketObjekt supermarkt = new SupermarketObjekt();
            supermarkt.produkte = new List<Produkt>();
            supermarkt.kassen = new List<Kasse>();
            supermarkt.warenkoerbe = new List<Warenkorb>();

            Produkt apfel = new Produkt("P01", "Apfel", 120, 0.5);
            Produkt brot = new Produkt("P02", "Brot", 40, 3);
            Produkt cola = new Produkt("P03", "Cola 1L", 80, 1.5);
            Produkt nudeln = new Produkt("P04", "Nudeln 500g", 60, 0.9);
            Produkt kaese = new Produkt("P05", "Käse", 30, 3.5);
            Produkt milch = new Produkt("P06", "Milch 1L", 50, 1.1);
            Produkt ei = new Produkt("P07", "Ei 10er", 20, 2.9);

            supermarkt.produkte.AddRange(new[] { apfel, brot, cola, nudeln, kaese, milch, ei });

            Kasse k1 = new Kasse("1");
            Kasse k2 = new Kasse("2");
            Kasse k3 = new Kasse("3");
            supermarkt.kassen.Add(k1);
            supermarkt.kassen.Add(k2);
            supermarkt.kassen.Add(k3);

            Dictionary<string, int> verkaufteMengen = new();
            Dictionary<string, double> umsaetze = new();
            foreach (var p in supermarkt.produkte) { verkaufteMengen[p.Produktnummer] = 0; umsaetze[p.Produktnummer] = 0; }

            double gesamterUmsatz = 0;
            int kundenBedient = 0;
            Random rnd = new();

            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║   Willkommen zur Supermarkt-Simulation ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine();

            k1.KasseOeffnen();
            if (rnd.NextDouble() > 0.3) k2.KasseOeffnen();

            Console.WriteLine();
            Console.WriteLine("Heute im Angebot: 10% Rabatt auf Käse (zufällige Aktion)");
            bool kaeseRabatt = true;

            void TryAddSale(Produkt p, int menge)
            {
                if (menge <= 0) return;
                verkaufteMengen[p.Produktnummer] += menge;
                double preis = p.Preis * menge;
                if (kaeseRabatt && p == kaese)
                    preis *= 0.9;
                umsaetze[p.Produktnummer] += preis;
                gesamterUmsatz += preis;
            }

            Produkt GetProduktById(string id) => supermarkt.produkte.Find(x => x.Produktnummer == id);

            string[] namen = new[] {
            "Max Mustermann", "Anna Müller", "Hans Peter", "Lena Klein",
            "Omar Yildiz", "Yuki Tanaka", "Sofia Rossi", "Lukas Meier",
            "Miriam Bauer", "Jonas Schmidt"
            };

            int kundenAnzahl = 20;
            for (int i = 0; i < kundenAnzahl; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"--- Kunde {i + 1} betritt den Laden ---");
                Thread.Sleep(120); 

                string kundeName = namen[rnd.Next(namen.Length)];
                Warenkorb wk = new Warenkorb($"W{100 + i}", kundeName);
                supermarkt.warenkoerbe.Add(wk);

                int produkteZumNehmen = rnd.Next(1, 6);
                for (int pcount = 0; pcount < produkteZumNehmen; pcount++)
                {
                    Produkt produkt = supermarkt.produkte[rnd.Next(supermarkt.produkte.Count)];
                    int menge = rnd.Next(1, 6); 

                    if (produkt.LagerAnzahl <= 0)
                    {
                        Console.WriteLine($"  {produkt.Name} ist ausverkauft. {kundeName} überspringt das Produkt.");
                        continue;
                    }

                    int tatsMenge = Math.Min(menge, produkt.LagerAnzahl);
                    wk.ProduktHinzufuegen(produkt, tatsMenge);

                    if (produkt == kaese && kaeseRabatt)
                        Console.WriteLine($"  (Rabatt angewendet: 10% auf {produkt.Name})");

                    TryAddSale(produkt, tatsMenge);
                    Thread.Sleep(40);
                }

                if (wk.items.Count > 0 && rnd.NextDouble() < 0.12)
                {
                    var retour = wk.items[rnd.Next(wk.items.Count)];
                    int retourMenge = Math.Max(1, retour.menge / 2);
                    retour.menge -= retourMenge;
                    retour.item.LagerAnzahl += retourMenge;
                    double retourBetrag = retour.item.Preis * retourMenge;
                    if (kaeseRabatt && retour.item == kaese) retourBetrag *= 0.9;
                    wk.GesamtPreis -= retourBetrag;
                    verkaufteMengen[retour.item.Produktnummer] -= retourMenge;
                    umsaetze[retour.item.Produktnummer] -= retourBetrag;
                    gesamterUmsatz -= retourBetrag;
                    Console.WriteLine($"  {kundeName} gibt {retourMenge}x {retour.item.Name} zurück (Teilrückgabe).");
                }

                Kasse bedienKasse = supermarkt.kassen.FirstOrDefault(k => k.OFFON);
                if (bedienKasse == null)
                {
                    var zufKasse = supermarkt.kassen[rnd.Next(supermarkt.kassen.Count)];
                    zufKasse.KasseOeffnen();
                    bedienKasse = zufKasse;
                }

                Console.WriteLine();
                Console.WriteLine($"--> {kundeName} zahlt an Kasse {bedienKasse.Kassennummer}: {wk.GesamtPreis:0.00}€");
                string quittung = bedienKasse.Zahlen(wk);
                Console.WriteLine("   Quittung: " + quittung);

                kundenBedient++;
                Thread.Sleep(80);

                foreach (var prod in supermarkt.produkte)
                {
                    if (prod.LagerAnzahl > 0 && prod.LagerAnzahl < 5 && rnd.NextDouble() < 0.3)
                    {
                        int bestell = 20 + rnd.Next(0, 31); // 20-50
                        prod.Hinzufuegen(bestell);
                        Console.WriteLine($"  Nachbestellung: {bestell}x {prod.Name} wurde ins Lager gelegt.");
                        Thread.Sleep(40);
                    }
                }

                Thread.Sleep(200);
            }

            if (rnd.NextDouble() > 0.5) k2.KasseSchliessen();

            Console.WriteLine();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║          Tagesabschluss Bericht       ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine($"Kunden bedient: {kundenBedient}");
            Console.WriteLine($"Gesamtumsatz: {gesamterUmsatz:0.00}€");
            Console.WriteLine();

            var topMengen = verkaufteMengen.OrderByDescending(kv => kv.Value).Take(3);
            Console.WriteLine("Top 3 verkaufte Produkte (nach Menge):");
            foreach (var kv in topMengen)
            {
                var prod = supermarkt.produkte.Find(p => p.Produktnummer == kv.Key);
                Console.WriteLine($" - {prod?.Name ?? kv.Key}: {kv.Value} Stk, Umsatz: {umsaetze[kv.Key]:0.00}€");
            }

            Console.WriteLine();
            Console.WriteLine("Produkte mit niedrigem Lagerbestand (<6):");
            foreach (var p in supermarkt.produkte)
            {
                if (p.LagerAnzahl < 6) Console.WriteLine($" - {p.Name}: {p.LagerAnzahl} Stück");
            }

            Console.WriteLine();
            Console.WriteLine("Endbestand aller Produkte:");
            supermarkt.GetInfoLager();

            Console.WriteLine();
            Console.WriteLine("Kassenstatus:");
            supermarkt.GetInfoKassen();

            Console.WriteLine();
            Console.WriteLine("Simulation beendet. Drücke eine Taste zum Beenden...");
            Console.ReadKey();
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
            private static int AnzahlProdukte;

            public Produkt(string produktnummer, string name, int lagerAnzahl, double preis)
            {
                Produktnummer = produktnummer;
                Name = name;
                LagerAnzahl = lagerAnzahl;
                Preis = preis;
                AnzahlProdukte++;
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
            public static int GetAnzahl()
            {
                return AnzahlProdukte;
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