namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe91
{
    // Liste aller Produkte und der jeweilligen Menge im Warenkorb
    public class Warenkorb
    {
        public List<WarenkorbProdukt> Produkte { get; set; } = new List<WarenkorbProdukt>();

        // Gibt den derzeitigen Inhalt des Warenkorbes aus (Produktname, Menge, Preis)
        // dieser wird nach jeder Veraenderung des Warenkorbes (Verwendung einer der unteren Methoden) nochmals ausgegeben
        public void InhaltAusgeben()
        {
            Console.WriteLine("-----------------------------");
            foreach (var produkt in Produkte)
            {
                Console.WriteLine(produkt);
            }
            Console.WriteLine("-----------------------------\n");
        }

        // Fügt die angegebene Menge eines Produktes in den Warenkorb hinzu; überprüft erst ob das Produkt schon im Warenkorb enthalten ist
        // Wenn das Produkt schon vorhanden ist wird die Menge des vorhandenen Produktes um die angegebene Menge erhöht
        // Wenn das Produkt noch nicht vorhanden ist wird es als neuer Eintrag in der Liste hinzugefügt
        public void ProduktHinzufuegen(Produkt produkt, int menge)
        {
            bool produktSchonImWarenKorb = false;
            foreach (var item in Produkte)
            {
                if (item.Produkt.Nummer.Equals(produkt.Nummer, StringComparison.OrdinalIgnoreCase))
                {
                    item.Menge += menge;

                    produktSchonImWarenKorb = true;
                    break;
                }
            }
            if (!produktSchonImWarenKorb)
                Produkte.Add(new WarenkorbProdukt(produkt, menge));

            InhaltAusgeben();
        }

        // Eingabe wird mit dem Namen und der Nummer der Produkte im Warenkorb verglichen 
        // Wenn einer der Werte übereinstimmt, wird der Eintrag gelöscht
        // Wenn kein übereinstimmendes Produkt gefunden wurde, wird eine 'Fehlermeldung' ausgegeben
        public void ProduktLoeschen(string produktSuche)
        {
            bool produktGeloescht = false;
            foreach (var item in Produkte)
            {
                if (item.Produkt.Name.Equals(produktSuche, StringComparison.OrdinalIgnoreCase) || item.Produkt.Nummer.Equals(produktSuche, StringComparison.OrdinalIgnoreCase))
                {
                    Produkte.Remove(item);
                    produktGeloescht = true;
                    break;
                }
            }
            if (!produktGeloescht)
                Console.WriteLine("Produkt nicht im Warenkorb!\n");
            InhaltAusgeben();
        }

        // Eingabe wird mit dem Namen und der Nummer der Produkte im Warenkorb verglichen
        // Wenn einer der Werte übereinstimmt, wird die Menge dieses Produktes mit dem neuen Mengenwert ersetzt
        // Wenn kein übereinstimmendes Produkt gefunden wurde, wird eine 'Fehlermeldung' ausgegeben
        public void ProduktMengeAendern(string produktSuche, int neueMenge)
        {
            bool produktVeraendert = false;
            foreach (var item in Produkte)
            {
                if (item.Produkt.Name.Equals(produktSuche, StringComparison.OrdinalIgnoreCase) || item.Produkt.Nummer.Equals(produktSuche, StringComparison.OrdinalIgnoreCase))
                {
                    item.Menge = neueMenge;
                    produktVeraendert = true;
                    break;
                }
            }
            if (!produktVeraendert)
                Console.WriteLine("Produkt nicht im Warenkorb!\n");
            InhaltAusgeben();
        }
    }
}