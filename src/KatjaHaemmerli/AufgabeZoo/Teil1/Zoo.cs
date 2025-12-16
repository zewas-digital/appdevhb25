using System;
namespace Appdevhb25.KatjaHaemmerli.AufgabeZoo
{
    public class Zoo
    {
        public string ZooName { get; }
        public string Gruendungsjahr { get; }
        public List<Gehege> ListeVonGehegen = new List<Gehege>();
        List<Pfleger> pflegerListe = new List<Pfleger>();
        public Dictionary<Futter, double> FutterbedarfAllerTiere = new Dictionary<Futter, double>(); //Futter und Menge gesamt
        public Zoo(string zooName, string gruendungsjahr)
        {
            ZooName = zooName;
            Gruendungsjahr = gruendungsjahr;
        }
        public void GehegeHinzufuegen(Gehege gehege)
        {
            ListeVonGehegen.Add(gehege);
        }
        public void GehegeEntfernen(Gehege gehegeName)
        {
            ListeVonGehegen.Remove(gehegeName);
        }
        public void PflegerHinzufügen(Pfleger pfleger, Pfleger pfleger2, Pfleger pfleger3)
        {
            pflegerListe.Add(pfleger);
            pflegerListe.Add(pfleger2);
            pflegerListe.Add(pfleger3);
        }
        public void AusgabeGanzeStruktur()
        {
            System.Console.WriteLine($"├── Zoo:{ZooName}, gegründet {Gruendungsjahr}");

            foreach (Gehege alleGehegeZoo in ListeVonGehegen)
            {
                foreach(Pfleger pfleger in pflegerListe)
                {
                    foreach(Gehege gehegePfleger in pfleger.gehegeListePfleger)
                    {
                        if( alleGehegeZoo == gehegePfleger)
                        {
                            Console.WriteLine($"|  ├── Pfleger: {pfleger.PflegerName}"); 
                        }
                    }
                                       
                }
                System.Console.WriteLine($"|     ├── Gehege: {alleGehegeZoo.GehegeName}");

                if (alleGehegeZoo.tierListe.Count() < 1)
                {
                    System.Console.WriteLine($"|          ├── (Leer))");
                    continue; // überspringt rest der Schleife foreach wird übersprungen. trifft zu wenn Leer                  
                }
                foreach (Tier tier in alleGehegeZoo.tierListe)
                {
                    tier.AusgabeTierNamen();
                    foreach(KeyValuePair<Futter, double> futter in tier.Futterbedarf)
                    {
                        System.Console.WriteLine($"|          ├── Futter: {futter.Key.FutterName}");
                    }
                }

            }

        }
        public void FutterbedarfZusammenzaehlen()
        {
            foreach (Gehege gehege in ListeVonGehegen)
            {
                foreach (Tier tier in gehege.tierListe)
                {
                    foreach (KeyValuePair<Futter, double> futter in tier.Futterbedarf)
                    {
                        if (FutterbedarfAllerTiere.ContainsKey(futter.Key))
                        {
                            // Wert(Menge) dem bestehendem Schlüssel(FutterName) hinzufügen
                            FutterbedarfAllerTiere[futter.Key] += futter.Value;
                        }
                        else
                        {
                            // Schlüssel(FutterName) mit Wert(Menge) wird Liste Futterbedarf hinzugefügt
                            FutterbedarfAllerTiere.Add(futter.Key, futter.Value);
                        }

                    }
                }
            }

        }
        public void FutterbedarfAusgeben()
        {
            // Tabellenkopf
            Console.WriteLine("Futterbedarf:");
            System.Console.WriteLine(new string('-', 29));

            // Tabellendaten
            foreach (KeyValuePair<Futter, double> futter in FutterbedarfAllerTiere)
            {
                System.Console.WriteLine($"{futter.Key.FutterName} {futter.Value} {futter.Key.Einheit} {futter.Key.Einheitspreis} {futter.Key.Waehrung}");
            }
            System.Console.WriteLine(new string('-', 29));

            System.Console.WriteLine($"Summe:           {SummePreis(),9:N0} €"); //N0 für den Punkt in der Zahl 2.000
        }
        public double SummePreis()
        {
            double summe = 0;// Eiheitspreis * Menge
            foreach (var item in FutterbedarfAllerTiere)
            {
                summe = item.Value * item.Key.Einheitspreis;
            }
            return summe;
        }        
       
    }
}