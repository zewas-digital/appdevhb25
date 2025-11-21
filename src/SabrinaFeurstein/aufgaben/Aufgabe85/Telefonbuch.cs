namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe85
{
    public class Telefonbuch
    {
        public List<Kontakt> TelefonbuchListe = new List<Kontakt>();

        public void EintragHinzufuegen(string nachname, string ort, string telefonnummer)
        {
            TelefonbuchListe.Add(new Kontakt(nachname, ort, telefonnummer));
        }

        public void EintragVeraendern(string suche, string neuerNachname, string neuerOrt, string neueTelefonnummer)
        {
            bool kontaktVeraendert = false;

            foreach (var eintrag in TelefonbuchListe)
            {
                if (eintrag.Nachname.Equals(suche, StringComparison.OrdinalIgnoreCase) || eintrag.Ort.Equals(suche, StringComparison.OrdinalIgnoreCase) || eintrag.Telefonnummer.Equals(suche, StringComparison.OrdinalIgnoreCase))
                {
                    eintrag.Nachname = neuerNachname;
                    eintrag.Ort = neuerOrt;
                    eintrag.Telefonnummer = neueTelefonnummer;
                    kontaktVeraendert = true;
                    break;
                }
            }

            if (!kontaktVeraendert)
                Console.WriteLine("Eintrag nicht gefunden!");
        }

        public void EintragLoeschen(string suche)
        {
            bool kontaktGeloescht = false;

            foreach (var eintrag in TelefonbuchListe)
            {
                if (eintrag.Nachname.Equals(suche, StringComparison.OrdinalIgnoreCase) || eintrag.Ort.Equals(suche, StringComparison.OrdinalIgnoreCase) || eintrag.Telefonnummer.Equals(suche, StringComparison.OrdinalIgnoreCase))
                {
                    TelefonbuchListe.Remove(eintrag);
                    kontaktGeloescht = true;
                    break;
                }
            }

            if (!kontaktGeloescht)
                Console.WriteLine("Eintrag nicht gefunden!");
        }

        public Kontakt NachnameSuchen(string nachname)
        {
            Kontakt gesuchterKontakt = new Kontakt("", "", "");
            bool kontaktGefunden = false;

            foreach (var eintrag in TelefonbuchListe)
            {
                if (eintrag.Nachname.Equals(nachname, StringComparison.OrdinalIgnoreCase))
                {
                    gesuchterKontakt = eintrag;
                    kontaktGefunden = true;
                }
            }

            if (!kontaktGefunden)
                Console.WriteLine("Nachname nicht gefunden!");

            return gesuchterKontakt;
        }
    }
}