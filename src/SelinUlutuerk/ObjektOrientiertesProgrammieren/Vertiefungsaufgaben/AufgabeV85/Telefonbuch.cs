using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeV85
{
    public class Telefonbuch
    {
        private static List<Kontakte> kontakte = new List<Kontakte>();
        public static void Start()
        {
            Hinzufuegen();
            Veraendern();
            Loeschen();
            NachnamenSuche();
        }

        // Methode hinzufügen
        private static void Hinzufuegen()
        {
            System.Console.WriteLine("Bitte gib nun folgende Daten ein:");
            System.Console.WriteLine("Nachname: ");
            string nachname = Console.ReadLine() ?? string.Empty;

            System.Console.WriteLine("Ort: ");
            string ort = Console.ReadLine() ?? string.Empty;

            System.Console.WriteLine("Telefonnummer: ");
            string tel = Console.ReadLine() ?? string.Empty;

            Kontakte neu = new Kontakte(nachname,ort,tel);
            kontakte.Add(neu);

            System.Console.WriteLine("Kontakt wurde hinzugefügt!");
            System.Console.WriteLine(new string('-',20));
        }

        // Methode verändern
        private static void Veraendern()
        {
            System.Console.WriteLine("Welcher Kontakt soll verändert werden? (Eingabe Nachname)");
            string sucheNachname = Console.ReadLine() ?? string.Empty;

            Kontakte? gefundenerKontakt = null;

            // suche nach Kontakt
            foreach (var k in kontakte)
            {
                if (k.Nachname.Equals(sucheNachname, StringComparison.OrdinalIgnoreCase))
                {
                    gefundenerKontakt = k;
                    break;
                }
            }

            // kein Kontakt gefunden
            if (gefundenerKontakt == null)
            {
                Console.WriteLine("Kein Kontakt mit diesem Nachnamen gefunden.");
                return;
            }

            // wenn Kontakt gefunden:
            System.Console.WriteLine("Gefundener Kontakt:");
            System.Console.WriteLine(gefundenerKontakt);

            // neuer Nachname
            System.Console.WriteLine("Neuer Nachname (leer lassen, um alten zu behalten): ");
            string neuerNachname = Console.ReadLine()?? string.Empty;
            if(!string.IsNullOrWhiteSpace(neuerNachname))
            {
                gefundenerKontakt.Nachname = neuerNachname;
            }

             // neuer Ort
            System.Console.WriteLine("Neuer Nachname (leer lassen, um alten zu behalten): ");
            string neuerOrt = Console.ReadLine()?? string.Empty;
            if(!string.IsNullOrWhiteSpace(neuerOrt))
            {
                gefundenerKontakt.Ort = neuerOrt;
            }

             // neue Tel
            System.Console.WriteLine("Neue Tel (leer lassen, um alten zu behalten): ");
            string neueTel = Console.ReadLine()?? string.Empty;
            if(!string.IsNullOrWhiteSpace(neueTel))
            {
                gefundenerKontakt.Telefonnummer = neueTel;
            }

            System.Console.WriteLine("Kontakt wurde erfolgreich angepasst!");
            System.Console.WriteLine(gefundenerKontakt);
            System.Console.WriteLine(new string('-',20));
        }


        // Methode gelöscht
        private static void Loeschen()
        {
            System.Console.WriteLine("Welcher Kontakt soll entfernt werden? (Eingabe Nachname)");
            string sucheNachname = Console.ReadLine() ?? string.Empty;

            Kontakte? gefundenerKontakt = null;

            // suche nach Kontakt
            foreach (var k in kontakte)
            {
                if (k.Nachname.Equals(sucheNachname, StringComparison.OrdinalIgnoreCase))
                {
                    gefundenerKontakt = k;
                    break;
                }
            }

            // kein Kontakt gefunden
            if (gefundenerKontakt == null)
            {
                Console.WriteLine("Kein Kontakt mit diesem Nachnamen gefunden.");
                return;
            }

            Console.WriteLine("Gefundener Kontakt:");
            Console.WriteLine(gefundenerKontakt);
            System.Console.WriteLine(new string('-',20));

            Console.Write("Wirklich löschen? (j/n): ");
            string bestaetigung = Console.ReadLine() ?? string.Empty;

            if (bestaetigung.Equals("j", StringComparison.OrdinalIgnoreCase))
            {
                kontakte.Remove(gefundenerKontakt);
                Console.WriteLine("Kontakt wurde gelöscht.");
            }
            else
            {
                Console.WriteLine("Löschen abgebrochen.");
            }
        }
        

        // Methode nach Nachnamen suchen
        public static void NachnamenSuche()
        {
            System.Console.WriteLine(new string('-',20));

            System.Console.WriteLine("Nach welchem Nachnamen möchtest du suchen?");
            string eingabe = Console.ReadLine() ?? string.Empty;

            bool etwasGefunden = false;

            foreach(var k in kontakte)
            {
                if(k.Nachname.Contains(eingabe,StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine(k);
                    etwasGefunden = true;
                }

                if (!etwasGefunden)
                {
                    System.Console.WriteLine("Kein Kontakt mit diesem Nachnamen gefunden!");
                }
            }

        }
    }
}