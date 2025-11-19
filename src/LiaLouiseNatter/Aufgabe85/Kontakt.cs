namespace Appdevhb25.LiaLouiseNatter.Aufgabe85
{
    public class Kontakt
    {
        public string nachName {get; set;}
        public string ort {get;set;}
        public string telefonNummer{get;set;}

        public Kontakt(string Nachname, string Ort, string Telefonnummer)
        {
            nachName = Nachname;
            ort = Ort;
            telefonNummer = Telefonnummer;
        }

    }
}