namespace Appdevhb25.LiaLouiseNatter.Aufgabe85
{
    public class Telefonbuch
    {
        public List<Kontakt> Kontaktdaten = new List<Kontakt>();

        public void Hinzufuegen(Kontakt kontakt)
        {
            Kontaktdaten.Add(kontakt);
            KontaktdatenPrinter(Kontaktdaten);
        }

        public void Veraendern(Kontakt kontakt, Kontakt aenderung)
        {
            
            for(int i = 0; i < Kontaktdaten.Count; i++)
            {
                if(Kontaktdaten[i] == kontakt)
                {
                    Kontaktdaten[i] = aenderung;
                }
            }
            KontaktdatenPrinter(Kontaktdaten);
            
        }

        public void Geloescht(Kontakt kontakt)
        {
            for(int i = 0; i < Kontaktdaten.Count; i++)
            {
                if(Kontaktdaten[i] == kontakt)
                {
                    Kontaktdaten.Remove(kontakt);
                }
            }
            KontaktdatenPrinter(Kontaktdaten);
        }

        public void Suchen(string Nachname)
        {
            for(int i = 0; i < Kontaktdaten.Count; i++)
            {
                if (Kontaktdaten[i].nachName == Nachname)
                {
                    Kontakt kontakt = Kontaktdaten[i];
                    System.Console.WriteLine($"Name: {kontakt.nachName}, PLZ: {kontakt.ort}, Tel: {kontakt.telefonNummer}");
                }
            }
            
        }

        public void KontaktdatenPrinter(List<Kontakt> kontakte)
        {
            foreach(Kontakt person in Kontaktdaten)
            {
                System.Console.WriteLine($"Name: {person.nachName}, PLZ: {person.ort}, Tel: {person.telefonNummer}");
            }
        }
    }
}